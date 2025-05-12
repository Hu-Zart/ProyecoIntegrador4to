namespace ProyectoIntegrador4to
{
    partial class Form5Historial
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gbConsultas = new System.Windows.Forms.GroupBox();
            this.cbOrdenar = new System.Windows.Forms.ComboBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMascotas = new System.Windows.Forms.ListBox();
            this.lblMascotas = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDesarrolladora = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.gbDatos.SuspendLayout();
            this.gbConsultas.SuspendLayout();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.gbConsultas);
            this.gbDatos.Controls.Add(this.lbMascotas);
            this.gbDatos.Controls.Add(this.lblMascotas);
            this.gbDatos.Controls.Add(this.lblPrecio);
            this.gbDatos.Controls.Add(this.lblCategoria);
            this.gbDatos.Controls.Add(this.lblDesarrolladora);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Location = new System.Drawing.Point(218, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(570, 426);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            // 
            // gbConsultas
            // 
            this.gbConsultas.Controls.Add(this.cbOrdenar);
            this.gbConsultas.Controls.Add(this.lblOrdenar);
            this.gbConsultas.Controls.Add(this.listBox1);
            this.gbConsultas.Controls.Add(this.label1);
            this.gbConsultas.Location = new System.Drawing.Point(6, 201);
            this.gbConsultas.Name = "gbConsultas";
            this.gbConsultas.Size = new System.Drawing.Size(176, 219);
            this.gbConsultas.TabIndex = 12;
            this.gbConsultas.TabStop = false;
            this.gbConsultas.Text = "Consultas";
            // 
            // cbOrdenar
            // 
            this.cbOrdenar.FormattingEnabled = true;
            this.cbOrdenar.Items.AddRange(new object[] {
            "DES",
            "ASC"});
            this.cbOrdenar.Location = new System.Drawing.Point(79, 190);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Size = new System.Drawing.Size(61, 21);
            this.cbOrdenar.TabIndex = 14;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Location = new System.Drawing.Point(12, 193);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(61, 13);
            this.lblOrdenar.TabIndex = 13;
            this.lblOrdenar.Text = "ORDENAR";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "2019-03-15",
            "",
            "2020-07-28",
            "",
            "2018-01-03",
            "",
            "2021-09-19",
            "",
            "2022-11-07",
            "",
            "2017-05-22",
            "",
            "2023-12-10",
            "",
            "2020-02-14",
            "",
            "2018-08-06",
            "",
            "2021-04-30"});
            this.listBox1.Location = new System.Drawing.Point(15, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(114, 134);
            this.listBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fechas";
            // 
            // lbMascotas
            // 
            this.lbMascotas.FormattingEnabled = true;
            this.lbMascotas.Items.AddRange(new object[] {
            "Luna",
            "",
            "Max",
            "",
            "Bella",
            "",
            "Rocky",
            "",
            "Coco",
            "",
            "Milo",
            "",
            "Daisy",
            "",
            "Charlie",
            "",
            "Lola",
            "",
            "Simba",
            "",
            "Toby",
            "",
            "Nala",
            "",
            "Zeus",
            "",
            "Molly",
            "",
            "Bruno",
            "",
            "Chloe",
            "",
            "Leo",
            "",
            "Ruby",
            "",
            "Oreo",
            "",
            "Lucky"});
            this.lbMascotas.Location = new System.Drawing.Point(9, 42);
            this.lbMascotas.Name = "lbMascotas";
            this.lbMascotas.Size = new System.Drawing.Size(173, 147);
            this.lbMascotas.TabIndex = 11;
            // 
            // lblMascotas
            // 
            this.lblMascotas.AutoSize = true;
            this.lblMascotas.Location = new System.Drawing.Point(6, 26);
            this.lblMascotas.Name = "lblMascotas";
            this.lblMascotas.Size = new System.Drawing.Size(66, 13);
            this.lblMascotas.TabIndex = 8;
            this.lblMascotas.Text = "MASCOTAS";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrecio.Location = new System.Drawing.Point(206, 387);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(70, 20);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "PRECIO";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategoria.Location = new System.Drawing.Point(206, 201);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(110, 20);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Procedimiento";
            // 
            // lblDesarrolladora
            // 
            this.lblDesarrolladora.AutoSize = true;
            this.lblDesarrolladora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesarrolladora.Location = new System.Drawing.Point(206, 71);
            this.lblDesarrolladora.Name = "lblDesarrolladora";
            this.lblDesarrolladora.Size = new System.Drawing.Size(93, 20);
            this.lblDesarrolladora.TabIndex = 2;
            this.lblDesarrolladora.Text = "Diagnostico";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNombre.Location = new System.Drawing.Point(188, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(174, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE DUEÑO";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btBuscar);
            this.gb1.Controls.Add(this.tbTelefono);
            this.gb1.Controls.Add(this.lblTelefono);
            this.gb1.Controls.Add(this.lbNombres);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(200, 426);
            this.gb1.TabIndex = 5;
            this.gb1.TabStop = false;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(50, 42);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 7;
            this.btBuscar.Text = "BUSCAR";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // tbTelefono
            // 
            this.tbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelefono.Location = new System.Drawing.Point(76, 13);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 16);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 13);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "TELEFONO:";
            // 
            // lbNombres
            // 
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.Items.AddRange(new object[] {
            "+1 (555) 123-4567",
            "",
            "+34 912 345 678",
            "",
            "+52 55 1234 5678",
            "",
            "+44 20 7946 0958",
            "",
            "+49 30 12345678",
            "",
            "+33 1 23 45 67 89",
            "",
            "+39 06 1234 5678",
            "",
            "+81 3 1234 5678",
            "",
            "+86 10 1234 5678",
            "",
            "+61 2 1234 5678"});
            this.lbNombres.Location = new System.Drawing.Point(0, 71);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(200, 355);
            this.lbNombres.TabIndex = 0;
            // 
            // Form5Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gb1);
            this.Name = "Form5Historial";
            this.Text = "Form5Historial";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbConsultas.ResumeLayout(false);
            this.gbConsultas.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.GroupBox gbConsultas;
        private System.Windows.Forms.ComboBox cbOrdenar;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMascotas;
        private System.Windows.Forms.Label lblMascotas;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDesarrolladora;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lblTelefono;
        public System.Windows.Forms.ListBox lbNombres;
    }
}