using System.Windows.Forms;

namespace ProyectoIntegrador4to
{
    public class FormBaseHijo : Form
    {
        public FormBaseHijo()
        {
            // Configuración básica para redimensionamiento
            this.AutoScaleMode = AutoScaleMode.Font;
            this.DoubleBuffered = true; // Para evitar parpadeo al redimensionar
            this.StartPosition = FormStartPosition.Manual;
        }

        protected void ConfigurarControlesParaRedimension()
        {
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                                  | AnchorStyles.Left | AnchorStyles.Right;
                }
                else if (!(control is Button)) // Los botones generalmente no se estiran
                {
                    control.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    control.Width = this.ClientSize.Width - control.Left - 20;
                }
            }
        }
    }
}