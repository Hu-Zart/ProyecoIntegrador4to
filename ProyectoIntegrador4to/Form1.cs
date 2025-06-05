using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to
{
    public partial class Form1: Form
    {
        public Modelos.ModeloUsuarios usuarioActual = new Modelos.ModeloUsuarios();
        public Modelos.ModeloUsuarios objetoUsuario = new Modelos.ModeloUsuarios();
        public Form1()
        {
            InitializeComponent();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string contraseña = tbContraseña.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña");
                return;
            }

            // Intentar autenticar al usuario
            if (AutenticarUsuario(usuario, contraseña))
            {
                // Usuario autenticado correctamente
                Form2 form2 = new Form2(usuarioActual);
                form2.FormClosed += (s, args) => this.Close();
                form2.Show();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                tbContraseña.Text = "";
                tbContraseña.Focus();
            }
        }

        private bool AutenticarUsuario(string nombreUsuario, string contrasena)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "SELECT id_usuario, nombre, fecha_ingreso, direccion, telefono, " +
                         "privilegio_inventario, privilegio_administrativo, " +
                         "privilegio_veterinario, privilegio_venta " +
                         "FROM usuarios " +
                         "WHERE nombre = @nombre AND contraseña = @contrasena";

            try
            {
                using (MySqlConnection conn = conexion.establecerConexion())
                {
                    if (conn != null)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@nombre", nombreUsuario);
                            cmd.Parameters.AddWithValue("@contrasena", contrasena);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Usuario encontrado, llenar el objeto usuarioActual
                                    usuarioActual.IdUsuario = reader.GetInt32("id_usuario");
                                    usuarioActual.Nombre = reader.GetString("nombre");
                                    usuarioActual.Contrasena = contrasena;

                                    // Campos opcionales (manejar nulos)
                                    if (!reader.IsDBNull(reader.GetOrdinal("fecha_ingreso")))
                                        usuarioActual.FechaRegistro = reader.GetDateTime("fecha_ingreso");

                                    if (!reader.IsDBNull(reader.GetOrdinal("direccion")))
                                        usuarioActual.Direccion = reader.GetString("direccion");

                                    if (!reader.IsDBNull(reader.GetOrdinal("telefono")))
                                        usuarioActual.Telefono = reader.GetString("telefono");

                                    // Privilegios
                                    usuarioActual.PermisoInventario = reader.GetBoolean("privilegio_inventario");
                                    usuarioActual.PermisoRegistro = reader.GetBoolean("privilegio_administrativo");
                                    usuarioActual.PermisoVeterinario = reader.GetBoolean("privilegio_veterinario");
                                    usuarioActual.PermisoVenta = reader.GetBoolean("privilegio_venta");

                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al autenticar: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }

            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
