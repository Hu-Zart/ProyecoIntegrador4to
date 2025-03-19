namespace ProyectoIntegrador4to
{
    partial class Form3RegistrarConsulta
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
            this.lbPrueba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPrueba
            // 
            this.lbPrueba.AutoSize = true;
            this.lbPrueba.Location = new System.Drawing.Point(341, 311);
            this.lbPrueba.Name = "lbPrueba";
            this.lbPrueba.Size = new System.Drawing.Size(60, 20);
            this.lbPrueba.TabIndex = 0;
            this.lbPrueba.Text = "Prueba";
            // 
            // Form3RegistrarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPrueba);
            this.Name = "Form3RegistrarConsulta";
            this.Text = "Form3RegistrarConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrueba;
    }
}