namespace ProyectoIntegrador4to.Formularios
{
    partial class FormPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.lblCaducidad = new System.Windows.Forms.Label();
            this.dtpCaducidad = new System.Windows.Forms.DateTimePicker();
            this.tbMedida = new System.Windows.Forms.TextBox();
            this.lblMedida = new System.Windows.Forms.Label();
            this.numExistencia = new System.Windows.Forms.NumericUpDown();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.numCosto = new System.Windows.Forms.NumericUpDown();
            this.lbCosto = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lbNombrePantalla = new System.Windows.Forms.Label();
            this.dgPacientes = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblCategoria);
            this.groupBox2.Controls.Add(this.cbCategorias);
            this.groupBox2.Controls.Add(this.lblProveedor);
            this.groupBox2.Controls.Add(this.cbProveedores);
            this.groupBox2.Controls.Add(this.lblCaducidad);
            this.groupBox2.Controls.Add(this.dtpCaducidad);
            this.groupBox2.Controls.Add(this.tbMedida);
            this.groupBox2.Controls.Add(this.lblMedida);
            this.groupBox2.Controls.Add(this.numExistencia);
            this.groupBox2.Controls.Add(this.lblExistencia);
            this.groupBox2.Controls.Add(this.numCosto);
            this.groupBox2.Controls.Add(this.lbCosto);
            this.groupBox2.Controls.Add(this.numPrecio);
            this.groupBox2.Controls.Add(this.btEliminar);
            this.groupBox2.Controls.Add(this.btEditar);
            this.groupBox2.Controls.Add(this.btAgregar);
            this.groupBox2.Controls.Add(this.lblPrecio);
            this.groupBox2.Controls.Add(this.tbNombre);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Controls.Add(this.tbDescripcion);
            this.groupBox2.Controls.Add(this.lblDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(12, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1411, 201);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCategoria.Location = new System.Drawing.Point(745, 113);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(116, 22);
            this.lblCategoria.TabIndex = 81;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // cbCategorias
            // 
            this.cbCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(876, 110);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(212, 28);
            this.cbCategorias.TabIndex = 80;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblProveedor.Location = new System.Drawing.Point(745, 81);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(125, 22);
            this.lblProveedor.TabIndex = 79;
            this.lblProveedor.Text = "PROVEEDOR";
            // 
            // cbProveedores
            // 
            this.cbProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(876, 78);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(212, 28);
            this.cbProveedores.TabIndex = 78;
            // 
            // lblCaducidad
            // 
            this.lblCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaducidad.AutoSize = true;
            this.lblCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCaducidad.Location = new System.Drawing.Point(754, 48);
            this.lblCaducidad.Name = "lblCaducidad";
            this.lblCaducidad.Size = new System.Drawing.Size(116, 22);
            this.lblCaducidad.TabIndex = 77;
            this.lblCaducidad.Text = "CADUCIDAD";
            // 
            // dtpCaducidad
            // 
            this.dtpCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtpCaducidad.Location = new System.Drawing.Point(876, 46);
            this.dtpCaducidad.Name = "dtpCaducidad";
            this.dtpCaducidad.Size = new System.Drawing.Size(212, 27);
            this.dtpCaducidad.TabIndex = 76;
            // 
            // tbMedida
            // 
            this.tbMedida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbMedida.Location = new System.Drawing.Point(492, 108);
            this.tbMedida.Name = "tbMedida";
            this.tbMedida.ShortcutsEnabled = false;
            this.tbMedida.Size = new System.Drawing.Size(176, 27);
            this.tbMedida.TabIndex = 75;
            // 
            // lblMedida
            // 
            this.lblMedida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMedida.AutoSize = true;
            this.lblMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblMedida.Location = new System.Drawing.Point(408, 110);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(78, 22);
            this.lblMedida.TabIndex = 74;
            this.lblMedida.Text = "MEDIDA";
            // 
            // numExistencia
            // 
            this.numExistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numExistencia.DecimalPlaces = 2;
            this.numExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.numExistencia.Location = new System.Drawing.Point(492, 76);
            this.numExistencia.Margin = new System.Windows.Forms.Padding(2);
            this.numExistencia.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numExistencia.Name = "numExistencia";
            this.numExistencia.Size = new System.Drawing.Size(176, 27);
            this.numExistencia.TabIndex = 73;
            // 
            // lblExistencia
            // 
            this.lblExistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblExistencia.Location = new System.Drawing.Point(371, 78);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(116, 22);
            this.lblExistencia.TabIndex = 72;
            this.lblExistencia.Text = "EXISTENCIA";
            // 
            // numCosto
            // 
            this.numCosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numCosto.DecimalPlaces = 2;
            this.numCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.numCosto.Location = new System.Drawing.Point(492, 45);
            this.numCosto.Margin = new System.Windows.Forms.Padding(2);
            this.numCosto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCosto.Name = "numCosto";
            this.numCosto.Size = new System.Drawing.Size(176, 27);
            this.numCosto.TabIndex = 71;
            // 
            // lbCosto
            // 
            this.lbCosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCosto.AutoSize = true;
            this.lbCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbCosto.Location = new System.Drawing.Point(409, 47);
            this.lbCosto.Name = "lbCosto";
            this.lbCosto.Size = new System.Drawing.Size(75, 22);
            this.lbCosto.TabIndex = 70;
            this.lbCosto.Text = "COSTO";
            // 
            // numPrecio
            // 
            this.numPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.numPrecio.Location = new System.Drawing.Point(166, 111);
            this.numPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.numPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(176, 27);
            this.numPrecio.TabIndex = 69;
            // 
            // btEliminar
            // 
            this.btEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEliminar.Location = new System.Drawing.Point(1216, 122);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(116, 35);
            this.btEliminar.TabIndex = 15;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = false;
            // 
            // btEditar
            // 
            this.btEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEditar.Location = new System.Drawing.Point(1216, 81);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(116, 35);
            this.btEditar.TabIndex = 14;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = false;
            // 
            // btAgregar
            // 
            this.btAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAgregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAgregar.Location = new System.Drawing.Point(1216, 40);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(116, 35);
            this.btAgregar.TabIndex = 13;
            this.btAgregar.Text = "AGREGAR";
            this.btAgregar.UseVisualStyleBackColor = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPrecio.Location = new System.Drawing.Point(83, 113);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(78, 22);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "PRECIO";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbNombre.Location = new System.Drawing.Point(166, 46);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(176, 27);
            this.tbNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblNombre.Location = new System.Drawing.Point(72, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(88, 22);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbDescripcion.Location = new System.Drawing.Point(166, 79);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(176, 27);
            this.tbDescripcion.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblDescripcion.Location = new System.Drawing.Point(27, 81);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(133, 22);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "DESCRIPCIÓN";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblBuscar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblFiltrar);
            this.groupBox1.Controls.Add(this.lbNombrePantalla);
            this.groupBox1.Controls.Add(this.dgPacientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1411, 430);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(785, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(728, 18);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(51, 13);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "BUSCAR";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alimentos",
            "Medicamentos",
            "Suplementos",
            "Accesorios",
            "Higiene/Cuidado",
            "Equipos/Suministros"});
            this.comboBox1.Location = new System.Drawing.Point(538, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(489, 18);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(52, 13);
            this.lblFiltrar.TabIndex = 2;
            this.lblFiltrar.Text = "FILTRAR";
            // 
            // lbNombrePantalla
            // 
            this.lbNombrePantalla.AutoSize = true;
            this.lbNombrePantalla.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePantalla.Location = new System.Drawing.Point(6, 16);
            this.lbNombrePantalla.Name = "lbNombrePantalla";
            this.lbNombrePantalla.Size = new System.Drawing.Size(122, 22);
            this.lbNombrePantalla.TabIndex = 1;
            this.lbNombrePantalla.Text = "PACIENTES";
            // 
            // dgPacientes
            // 
            this.dgPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacientes.Location = new System.Drawing.Point(6, 44);
            this.dgPacientes.Name = "dgPacientes";
            this.dgPacientes.Size = new System.Drawing.Size(1399, 380);
            this.dgPacientes.TabIndex = 0;
            // 
            // FormularioPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 663);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioPacientes";
            this.Text = "FormularioPacientes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.Label lblCaducidad;
        private System.Windows.Forms.DateTimePicker dtpCaducidad;
        private System.Windows.Forms.TextBox tbMedida;
        private System.Windows.Forms.Label lblMedida;
        public System.Windows.Forms.NumericUpDown numExistencia;
        private System.Windows.Forms.Label lblExistencia;
        public System.Windows.Forms.NumericUpDown numCosto;
        private System.Windows.Forms.Label lbCosto;
        public System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Label lbNombrePantalla;
        private System.Windows.Forms.DataGridView dgPacientes;
    }
}