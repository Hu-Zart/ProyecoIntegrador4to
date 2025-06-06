using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to.Formularios
{
    public partial class FormReporteHistoria: Form
    {
        public FormReporteHistoria()
        {
            InitializeComponent();
            Controladores.ControladorConsultas controladorConsultas = new Controladores.ControladorConsultas();
            controladorConsultas.consultarConsultas(dgvConsulta);
        }

        public void cargarReporteHistoria()
        {
            int idVenta = Convert.ToInt32(dgvConsulta.SelectedRows[0].Cells[0].Value);
            if (idVenta <= 0) return;

            try
            {
                DataSet dsReporte = new DataSet();
                Controladores.ControladorReporte controladorHistorial = new Controladores.ControladorReporte();

                controladorHistorial.reporteHojaHistoria(dsReporte, idVenta);

                // Modificar el ReportDataSource para usar la primera tabla
                ReportDataSource rds = new ReportDataSource("DataSet1", dsReporte.Tables[0]);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoIntegrador4to.Reportes.ReporteHistorialClinico.rdlc";
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}");
            }
        }


        private void dgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controladores.ControladorReporte controladorReporte = new Controladores.ControladorReporte();
            cargarReporteHistoria();
        }
    }
}
