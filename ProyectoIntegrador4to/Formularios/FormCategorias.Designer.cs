namespace ProyectoIntegrador4to.Formularios
{
    partial class FormCategorias
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
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lbNombrePantalla = new System.Windows.Forms.Label();
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbDescripcion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btEliminar);
            this.groupBox2.Controls.Add(this.btEditar);
            this.groupBox2.Controls.Add(this.btAgregar);
            this.groupBox2.Controls.Add(this.tbNombre);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Location = new System.Drawing.Point(12, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 201);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbDescripcion.Location = new System.Drawing.Point(150, 59);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescripcion.MaxLength = 150;
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(704, 98);
            this.tbDescripcion.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(13, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 22);
            this.label8.TabIndex = 68;
            this.label8.Text = "DESCRIPCIÓN";
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
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
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
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
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
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbNombre.Location = new System.Drawing.Point(150, 27);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(176, 27);
            this.tbNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblNombre.Location = new System.Drawing.Point(56, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(88, 22);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE";
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
            this.groupBox1.Controls.Add(this.dgCategorias);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 430);
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
            this.lbNombrePantalla.Size = new System.Drawing.Size(140, 22);
            this.lbNombrePantalla.TabIndex = 1;
            this.lbNombrePantalla.Text = "CATEGORIAS";
            // 
            // dgCategorias
            // 
            this.dgCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.Location = new System.Drawing.Point(6, 44);
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.Size = new System.Drawing.Size(1025, 380);
            this.dgCategorias.TabIndex = 0;
            this.dgCategorias.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCategorias_RowHeaderMouseClick);
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 663);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Label lbNombrePantalla;
        private System.Windows.Forms.DataGridView dgCategorias;
        public System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label8;
    }
}