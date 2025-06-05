namespace ProyectoIntegrador4to.Formularios
{
    partial class FormVentas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgbClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscarProductos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnDesabilitar = new System.Windows.Forms.Button();
            this.txtPrecioVentaFinal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnElimnarSeleccionProducto = new System.Windows.Forms.Button();
            this.dtgResumenVenta = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCompletarVenta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResumenVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgbClientes);
            this.groupBox1.Controls.Add(this.txtBuscarCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1032, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTES/TUTORES";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(873, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Click para Seleccionar";
            // 
            // dgbClientes
            // 
            this.dgbClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbClientes.Location = new System.Drawing.Point(8, 48);
            this.dgbClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgbClientes.Name = "dgbClientes";
            this.dgbClientes.RowHeadersWidth = 51;
            this.dgbClientes.Size = new System.Drawing.Size(1016, 177);
            this.dgbClientes.TabIndex = 1;
            this.dgbClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbClientes_CellClick);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCliente.Location = new System.Drawing.Point(69, 16);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(302, 22);
            this.txtBuscarCliente.TabIndex = 2;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtgProductos);
            this.groupBox2.Controls.Add(this.txtBuscarProductos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(384, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1052, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCTOS";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(892, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Click para Seleccionar";
            // 
            // dtgProductos
            // 
            this.dtgProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(12, 48);
            this.dtgProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.RowHeadersWidth = 51;
            this.dtgProductos.Size = new System.Drawing.Size(1032, 177);
            this.dtgProductos.TabIndex = 1;
            this.dtgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellClick);
            // 
            // txtBuscarProductos
            // 
            this.txtBuscarProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProductos.Location = new System.Drawing.Point(69, 16);
            this.txtBuscarProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarProductos.Name = "txtBuscarProductos";
            this.txtBuscarProductos.Size = new System.Drawing.Size(302, 22);
            this.txtBuscarProductos.TabIndex = 2;
            this.txtBuscarProductos.TextChanged += new System.EventHandler(this.txtBuscarProductos_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Buscar";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(16, 255);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1419, 367);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reusmen de Selección";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.btnAgregarProducto);
            this.groupBox6.Controls.Add(this.txtCantidadVenta);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.btnHabilitar);
            this.groupBox6.Controls.Add(this.btnDesabilitar);
            this.groupBox6.Controls.Add(this.txtPrecioVentaFinal);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(15, 146);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(1396, 186);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Precio y Cantidad de Venta";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(12, 78);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(1376, 95);
            this.btnAgregarProducto.TabIndex = 18;
            this.btnAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtCantidadVenta.Location = new System.Drawing.Point(709, 37);
            this.txtCantidadVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Size = new System.Drawing.Size(165, 32);
            this.txtCantidadVenta.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label12.Location = new System.Drawing.Point(565, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 26);
            this.label12.TabIndex = 17;
            this.label12.Text = "CANTIDAD";
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.BackColor = System.Drawing.Color.White;
            this.btnHabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHabilitar.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnHabilitar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHabilitar.Location = new System.Drawing.Point(323, 36);
            this.btnHabilitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(100, 28);
            this.btnHabilitar.TabIndex = 15;
            this.btnHabilitar.Text = "HABILITAR";
            this.btnHabilitar.UseVisualStyleBackColor = false;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnDesabilitar
            // 
            this.btnDesabilitar.BackColor = System.Drawing.Color.White;
            this.btnDesabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDesabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDesabilitar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDesabilitar.Location = new System.Drawing.Point(431, 36);
            this.btnDesabilitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDesabilitar.Name = "btnDesabilitar";
            this.btnDesabilitar.Size = new System.Drawing.Size(127, 28);
            this.btnDesabilitar.TabIndex = 14;
            this.btnDesabilitar.Text = "DESABILITAR";
            this.btnDesabilitar.UseVisualStyleBackColor = false;
            this.btnDesabilitar.Click += new System.EventHandler(this.btnDesabilitar_Click);
            // 
            // txtPrecioVentaFinal
            // 
            this.txtPrecioVentaFinal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrecioVentaFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVentaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtPrecioVentaFinal.Location = new System.Drawing.Point(152, 33);
            this.txtPrecioVentaFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioVentaFinal.Name = "txtPrecioVentaFinal";
            this.txtPrecioVentaFinal.ReadOnly = true;
            this.txtPrecioVentaFinal.Size = new System.Drawing.Size(165, 32);
            this.txtPrecioVentaFinal.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label15.Location = new System.Drawing.Point(40, 36);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 26);
            this.label15.TabIndex = 1;
            this.label15.Text = "PRECIO";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtStockProducto);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtPrecioProducto);
            this.groupBox5.Controls.Add(this.txtIdProducto);
            this.groupBox5.Controls.Add(this.txtNombreProducto);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(379, 23);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(1029, 116);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos del Producto";
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtStockProducto.Location = new System.Drawing.Point(671, 60);
            this.txtStockProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockProducto.Multiline = true;
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.ReadOnly = true;
            this.txtStockProducto.Size = new System.Drawing.Size(346, 33);
            this.txtStockProducto.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.Location = new System.Drawing.Point(565, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 26);
            this.label11.TabIndex = 7;
            this.label11.Text = "STOCK";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtPrecioProducto.Location = new System.Drawing.Point(671, 20);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioProducto.Multiline = true;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.ReadOnly = true;
            this.txtPrecioProducto.Size = new System.Drawing.Size(346, 33);
            this.txtPrecioProducto.TabIndex = 4;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtIdProducto.Location = new System.Drawing.Point(203, 21);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(307, 32);
            this.txtIdProducto.TabIndex = 1;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNombreProducto.Location = new System.Drawing.Point(203, 62);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProducto.Multiline = true;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(307, 33);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(559, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 26);
            this.label10.TabIndex = 5;
            this.label10.Text = "PRECIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(77, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "NOMBRE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(13, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "ID PRODUCTO";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.groupBox4.Controls.Add(this.txtTelefono);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtDireccion);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtNombreCliente);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtIdCliente);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 23);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(1032, 116);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del Tutor";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtTelefono.Location = new System.Drawing.Point(672, 62);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(347, 32);
            this.txtTelefono.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label17.Location = new System.Drawing.Point(520, 62);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 26);
            this.label17.TabIndex = 7;
            this.label17.Text = "TELEFONO";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtDireccion.Location = new System.Drawing.Point(672, 21);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(347, 32);
            this.txtDireccion.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label16.Location = new System.Drawing.Point(520, 21);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 26);
            this.label16.TabIndex = 5;
            this.label16.Text = "DIRECCIÓN";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNombreCliente.Location = new System.Drawing.Point(160, 62);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCliente.Multiline = true;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(347, 33);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(25, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "NOMBRE";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtIdCliente.Location = new System.Drawing.Point(160, 21);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(347, 32);
            this.txtIdCliente.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(8, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID CLIENTE";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.btnElimnarSeleccionProducto);
            this.groupBox7.Controls.Add(this.dtgResumenVenta);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Location = new System.Drawing.Point(21, 629);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(1413, 395);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resumen de Venta";
            // 
            // btnElimnarSeleccionProducto
            // 
            this.btnElimnarSeleccionProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElimnarSeleccionProducto.BackColor = System.Drawing.Color.White;
            this.btnElimnarSeleccionProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnElimnarSeleccionProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimnarSeleccionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnElimnarSeleccionProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnElimnarSeleccionProducto.Location = new System.Drawing.Point(1292, 15);
            this.btnElimnarSeleccionProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnElimnarSeleccionProducto.Name = "btnElimnarSeleccionProducto";
            this.btnElimnarSeleccionProducto.Size = new System.Drawing.Size(100, 28);
            this.btnElimnarSeleccionProducto.TabIndex = 19;
            this.btnElimnarSeleccionProducto.Text = "ELIMINAR";
            this.btnElimnarSeleccionProducto.UseVisualStyleBackColor = false;
            this.btnElimnarSeleccionProducto.Click += new System.EventHandler(this.btnElimnarSeleccionProducto_Click);
            // 
            // dtgResumenVenta
            // 
            this.dtgResumenVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgResumenVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgResumenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResumenVenta.Location = new System.Drawing.Point(9, 49);
            this.dtgResumenVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgResumenVenta.Name = "dtgResumenVenta";
            this.dtgResumenVenta.ReadOnly = true;
            this.dtgResumenVenta.RowHeadersWidth = 51;
            this.dtgResumenVenta.Size = new System.Drawing.Size(1397, 338);
            this.dtgResumenVenta.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1115, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Seleccionar Para Eliminar";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14.Location = new System.Drawing.Point(1188, 1122);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 24);
            this.label14.TabIndex = 5;
            this.label14.Text = "IVA 16%";
            // 
            // lblIva
            // 
            this.lblIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(1279, 1129);
            this.lblIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(16, 16);
            this.lblIva.TabIndex = 6;
            this.lblIva.Text = "...";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(1279, 1158);
            this.lblTotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(16, 16);
            this.lblTotalPagar.TabIndex = 8;
            this.lblTotalPagar.Text = "...";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label19.Location = new System.Drawing.Point(1004, 1143);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(255, 36);
            this.label19.TabIndex = 7;
            this.label19.Text = "TOTAL A PAGAR";
            // 
            // btnCompletarVenta
            // 
            this.btnCompletarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompletarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnCompletarVenta.Location = new System.Drawing.Point(16, 1196);
            this.btnCompletarVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompletarVenta.Name = "btnCompletarVenta";
            this.btnCompletarVenta.Size = new System.Drawing.Size(1419, 68);
            this.btnCompletarVenta.TabIndex = 19;
            this.btnCompletarVenta.Text = "COMPLETAR VENTA";
            this.btnCompletarVenta.UseVisualStyleBackColor = true;
            this.btnCompletarVenta.Click += new System.EventHandler(this.btnCompletarVenta_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 1055);
            this.Controls.Add(this.btnCompletarVenta);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResumenVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgbClientes;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.TextBox txtBuscarProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtStockProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPrecioVentaFinal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDesabilitar;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dtgResumenVenta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnElimnarSeleccionProducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCompletarVenta;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label16;
    }
}