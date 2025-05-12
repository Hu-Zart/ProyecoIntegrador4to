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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDirigirReg
            // 
            this.btDirigirReg.Location = new System.Drawing.Point(18, 149);
            this.btDirigirReg.Name = "btDirigirReg";
            this.btDirigirReg.Size = new System.Drawing.Size(127, 46);
            this.btDirigirReg.TabIndex = 0;
            this.btDirigirReg.Text = "REGISTRAR CONSULTA";
            this.btDirigirReg.UseVisualStyleBackColor = true;
            this.btDirigirReg.Click += new System.EventHandler(this.btDirigirReg_Click);
            // 
            // btDirigirInv
            // 
            this.btDirigirInv.Location = new System.Drawing.Point(18, 384);
            this.btDirigirInv.Name = "btDirigirInv";
            this.btDirigirInv.Size = new System.Drawing.Size(127, 46);
            this.btDirigirInv.TabIndex = 1;
            this.btDirigirInv.Text = "INVENTARIO";
            this.btDirigirInv.UseVisualStyleBackColor = true;
            this.btDirigirInv.Click += new System.EventHandler(this.btDirigirInv_Click);
            // 
            // btRedirigirHis
            // 
            this.btRedirigirHis.Location = new System.Drawing.Point(18, 640);
            this.btRedirigirHis.Name = "btRedirigirHis";
            this.btRedirigirHis.Size = new System.Drawing.Size(127, 46);
            this.btRedirigirHis.TabIndex = 2;
            this.btRedirigirHis.Text = "HISTORIAL";
            this.btRedirigirHis.UseVisualStyleBackColor = true;
            this.btRedirigirHis.Click += new System.EventHandler(this.btRedirigirHis_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btDirigirReg);
            this.panel1.Controls.Add(this.btRedirigirHis);
            this.panel1.Controls.Add(this.btDirigirInv);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 794);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(181, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1314, 794);
            this.panel2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 818);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDirigirReg;
        private System.Windows.Forms.Button btDirigirInv;
        private System.Windows.Forms.Button btRedirigirHis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}