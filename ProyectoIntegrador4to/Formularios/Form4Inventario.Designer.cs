namespace ProyectoIntegrador4to
{
    partial class Form4Inventario
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lbNombrePantalla = new System.Windows.Forms.Label();
            this.dgwProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Informacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.tbInformacion = new System.Windows.Forms.TextBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.dgwProductos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 430);
            this.groupBox1.TabIndex = 0;
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
            this.lbNombrePantalla.Size = new System.Drawing.Size(134, 22);
            this.lbNombrePantalla.TabIndex = 1;
            this.lbNombrePantalla.Text = "PRODUCTOS";
            // 
            // dgwProductos
            // 
            this.dgwProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Categoria,
            this.Precio,
            this.Cantidad,
            this.Informacion});
            this.dgwProductos.Location = new System.Drawing.Point(6, 44);
            this.dgwProductos.Name = "dgwProductos";
            this.dgwProductos.Size = new System.Drawing.Size(1025, 380);
            this.dgwProductos.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "CODIGO";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "CATEGORIA";
            this.Categoria.Name = "Categoria";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "PRECIO";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "CANTIDAD";
            this.Cantidad.Name = "Cantidad";
            // 
            // Informacion
            // 
            this.Informacion.HeaderText = "INFORMACIÓN";
            this.Informacion.Name = "Informacion";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.numCantidad);
            this.groupBox2.Controls.Add(this.numPrecio);
            this.groupBox2.Controls.Add(this.btEliminar);
            this.groupBox2.Controls.Add(this.btEditar);
            this.groupBox2.Controls.Add(this.btAgregar);
            this.groupBox2.Controls.Add(this.tbInformacion);
            this.groupBox2.Controls.Add(this.lblInformacion);
            this.groupBox2.Controls.Add(this.cbCategoria);
            this.groupBox2.Controls.Add(this.lblCantidad);
            this.groupBox2.Controls.Add(this.lblPrecio);
            this.groupBox2.Controls.Add(this.lblCategoria);
            this.groupBox2.Controls.Add(this.tbNombre);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Controls.Add(this.tbCodigo);
            this.groupBox2.Controls.Add(this.lblCodigo);
            this.groupBox2.Location = new System.Drawing.Point(12, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // numCantidad
            // 
            this.numCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.numCantidad.Location = new System.Drawing.Point(567, 117);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(171, 27);
            this.numCantidad.TabIndex = 17;
            // 
            // numPrecio
            // 
            this.numPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.numPrecio.Location = new System.Drawing.Point(567, 84);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(171, 27);
            this.numPrecio.TabIndex = 16;
            // 
            // btEliminar
            // 
            this.btEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEliminar.Location = new System.Drawing.Point(874, 122);
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
            this.btEditar.Location = new System.Drawing.Point(874, 81);
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
            this.btAgregar.Location = new System.Drawing.Point(874, 40);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(116, 35);
            this.btAgregar.TabIndex = 13;
            this.btAgregar.Text = "AGREGAR";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // tbInformacion
            // 
            this.tbInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbInformacion.Location = new System.Drawing.Point(567, 48);
            this.tbInformacion.Name = "tbInformacion";
            this.tbInformacion.Size = new System.Drawing.Size(171, 27);
            this.tbInformacion.TabIndex = 12;
            // 
            // lblInformacion
            // 
            this.lblInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblInformacion.Location = new System.Drawing.Point(422, 53);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(135, 22);
            this.lblInformacion.TabIndex = 11;
            this.lblInformacion.Text = "INFORMACIÓN";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Alimentos",
            "Medicamentos",
            "Suplementos",
            "Accesorios",
            "Higiene/Cuidado",
            "Equipos/Suministros"});
            this.cbCategoria.Location = new System.Drawing.Point(140, 119);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(176, 26);
            this.cbCategoria.TabIndex = 10;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCantidad.Location = new System.Drawing.Point(455, 119);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(102, 22);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "CANTIDAD";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPrecio.Location = new System.Drawing.Point(479, 86);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(78, 22);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "PRECIO";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCategoria.Location = new System.Drawing.Point(18, 119);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(116, 22);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbNombre.Location = new System.Drawing.Point(140, 81);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(176, 27);
            this.tbNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblNombre.Location = new System.Drawing.Point(46, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(88, 22);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbCodigo.Location = new System.Drawing.Point(140, 50);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(176, 27);
            this.tbCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCodigo.Location = new System.Drawing.Point(52, 53);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(82, 22);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CODIGO";
            // 
            // Form4Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 663);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4Inventario";
            this.Text = "Form4Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4Inventario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNombrePantalla;
        private System.Windows.Forms.DataGridView dgwProductos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox tbInformacion;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Informacion;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}