namespace ProyectoIntegrador4to
{
    partial class Form2
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
            this.btDirigirReg = new System.Windows.Forms.Button();
            this.btDirigirInv = new System.Windows.Forms.Button();
            this.btRedirigirHis = new System.Windows.Forms.Button();
            this.lbHola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDirigirReg
            // 
            this.btDirigirReg.Location = new System.Drawing.Point(146, 66);
            this.btDirigirReg.Name = "btDirigirReg";
            this.btDirigirReg.Size = new System.Drawing.Size(127, 46);
            this.btDirigirReg.TabIndex = 0;
            this.btDirigirReg.Text = "REGISTRAR CONSULTA";
            this.btDirigirReg.UseVisualStyleBackColor = true;
            this.btDirigirReg.Click += new System.EventHandler(this.btDirigirReg_Click);
            // 
            // btDirigirInv
            // 
            this.btDirigirInv.Location = new System.Drawing.Point(146, 137);
            this.btDirigirInv.Name = "btDirigirInv";
            this.btDirigirInv.Size = new System.Drawing.Size(127, 46);
            this.btDirigirInv.TabIndex = 1;
            this.btDirigirInv.Text = "INVENTARIO";
            this.btDirigirInv.UseVisualStyleBackColor = true;
            this.btDirigirInv.Click += new System.EventHandler(this.btDirigirInv_Click);
            // 
            // btRedirigirHis
            // 
            this.btRedirigirHis.Location = new System.Drawing.Point(146, 207);
            this.btRedirigirHis.Name = "btRedirigirHis";
            this.btRedirigirHis.Size = new System.Drawing.Size(127, 46);
            this.btRedirigirHis.TabIndex = 2;
            this.btRedirigirHis.Text = "HISTORIAL";
            this.btRedirigirHis.UseVisualStyleBackColor = true;
            this.btRedirigirHis.Click += new System.EventHandler(this.btRedirigirHis_Click);
            // 
            // lbHola
            // 
            this.lbHola.AutoSize = true;
            this.lbHola.Location = new System.Drawing.Point(193, 296);
            this.lbHola.Name = "lbHola";
            this.lbHola.Size = new System.Drawing.Size(48, 13);
            this.lbHola.TabIndex = 3;
            this.lbHola.Text = "HOLAaa";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 391);
            this.Controls.Add(this.lbHola);
            this.Controls.Add(this.btRedirigirHis);
            this.Controls.Add(this.btDirigirInv);
            this.Controls.Add(this.btDirigirReg);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDirigirReg;
        private System.Windows.Forms.Button btDirigirInv;
        private System.Windows.Forms.Button btRedirigirHis;
        private System.Windows.Forms.Label lbHola;
    }
}