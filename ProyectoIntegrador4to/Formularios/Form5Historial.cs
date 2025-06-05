using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to
{
    public partial class Form5Historial: Form
    {
        public Form5Historial()
        {
            InitializeComponent();
            cargarReporteHistoria();
            Controladores.ControladorVentas controladorVentas = new Controladores.ControladorVentas();
            controladorVentas.consultarVentas(dgvConsulta);
        }

        public void cargarReporteHistoria()
        {
            try
            {
                DataSet dsReporte = new DataSet();
                Controladores.ControladorReporte controladorHistorial = new Controladores.ControladorReporte();

                controladorHistorial.reporteDetallesVenta(dsReporte, 14);

                // Modificar el ReportDataSource para usar la primera tabla
                ReportDataSource rds = new ReportDataSource("DataSet1", dsReporte.Tables[0]);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoIntegrador4to.Reportes.ReporteVenta.rdlc";
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}");
            }
        }

        private void dgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
