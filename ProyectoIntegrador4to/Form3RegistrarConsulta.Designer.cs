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
            this.components = new System.ComponentModel.Container();
            this.lbPrueba = new System.Windows.Forms.Label();
            this.tbPrueba = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lbPrueba
            // 
            this.lbPrueba.AutoSize = true;
            this.lbPrueba.Location = new System.Drawing.Point(227, 202);
            this.lbPrueba.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrueba.Name = "lbPrueba";
            this.lbPrueba.Size = new System.Drawing.Size(41, 13);
            this.lbPrueba.TabIndex = 0;
            this.lbPrueba.Text = "Prueba";
            // 
            // tbPrueba
            // 
            this.tbPrueba.Location = new System.Drawing.Point(230, 218);
            this.tbPrueba.Name = "tbPrueba";
            this.tbPrueba.Size = new System.Drawing.Size(100, 20);
            this.tbPrueba.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form3RegistrarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.tbPrueba);
            this.Controls.Add(this.lbPrueba);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3RegistrarConsulta";
            this.Text = "Form3RegistrarConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrueba;
        private System.Windows.Forms.TextBox tbPrueba;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}