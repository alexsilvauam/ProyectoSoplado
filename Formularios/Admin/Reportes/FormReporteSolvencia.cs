using ProyectoSoplado_1._0_.Modelo_de_datos.Pago;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSoplado_1._0_;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Reporting.WinForms;
using ProyectoSoplado_1._0_.Formularios.Admin.Reportes;
using System.IO;
using Microsoft.Win32;

namespace ProyectoSoplado_1._0_.Formularios.Admin
{
    public partial class FormReporteSolvencia : Form
    {

        public FormReporteSolvencia()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormReporteSolvencia_Load(object sender, EventArgs e)
        {
            dgvRegistroPagos.DataSource = null;
            dgvRegistroPagos.DataSource = FormVerificacionSolvencia.RegistroPagos;
            dgvRegistroPagos.Columns["id_pago"].HeaderText = "ID del Pago";
            dgvRegistroPagos.Columns["fecha_pago"].HeaderText = "Fecha del Pago";
            dgvRegistroPagos.Columns["Fecha_Vencimiento"].HeaderText = "Fecha de vencimiento";
            dgvRegistroPagos.Columns["monto_pago"].HeaderText = "Monto de Pago";

    

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDataSource dataSource = new ReportDataSource("DsSolvencia", FormVerificacionSolvencia.RegistroPagos);
                FormRptSolvencia reporte = new FormRptSolvencia();

                reporte.RvSolvencia.LocalReport.DataSources.Clear();
                reporte.RvSolvencia.LocalReport.DataSources.Add(dataSource);
                reporte.RvSolvencia.LocalReport.ReportEmbeddedResource = "ProyectoSoplado_1._0_.Reportes.RptSolvencia.rdlc";
                reporte.RvSolvencia.RefreshReport();
                reporte.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportarAPdf()
        {
            try
            {
                // Configurar el ReportViewer
                ReportDataSource dataSource = new ReportDataSource("DsSolvencia", FormVerificacionSolvencia.RegistroPagos);
                LocalReport report = new LocalReport();
                report.ReportEmbeddedResource = "ProyectoSoplado_1._0_.Reportes.RptSolvencia.rdlc"; // Asegúrate de que la ruta sea correcta
                report.DataSources.Clear();
                report.DataSources.Add(dataSource);

                // Renderizar el informe a formato PDF
                Warning[] warnings;
                string[] streamIds;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = report.Render(
                    "PDF", null, out mimeType, out encoding, out extension,
                    out streamIds, out warnings);

                // Usar SaveFileDialog para seleccionar la ruta del archivo
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar informe como PDF";
                    saveFileDialog.FileName = "InformeSolvencia.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        using (FileStream fs = new FileStream(filePath, FileMode.Create))
                        {
                            fs.Write(bytes, 0, bytes.Length);
                        }

                        // Mostrar mensaje de éxito
                        MessageBox.Show("El archivo PDF ha sido generado exitosamente en: " + filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarAExcel()
        {
            try
            {
                // Crear DataTable con encabezados y datos
                DataTable dt = CrearDataTableConEncabezados();

                // Configurar el ReportViewer
                ReportDataSource dataSource = new ReportDataSource("DsSolvencia", dt);
                LocalReport report = new LocalReport();
                report.ReportEmbeddedResource = "ProyectoSoplado_1._0_.Reportes.RptSolvencia.rdlc"; // Asegúrate de que la ruta sea correcta
                report.DataSources.Clear();
                report.DataSources.Add(dataSource);

                // Renderizar el informe a formato Excel
                Warning[] warnings;
                string[] streamIds;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = report.Render(
                    "EXCELOPENXML", null, out mimeType, out encoding, out extension,
                    out streamIds, out warnings);

                // Usar SaveFileDialog para seleccionar la ruta del archivo
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Guardar informe como Excel";
                    saveFileDialog.FileName = "InformeSolvencia.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        using (FileStream fs = new FileStream(filePath, FileMode.Create))
                        {
                            fs.Write(bytes, 0, bytes.Length);
                        }

                        // Mostrar mensaje de éxito
                        MessageBox.Show("El archivo Excel ha sido generado exitosamente en: " + filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable CrearDataTableConEncabezados()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id_pago", typeof(int));
            dt.Columns.Add("fecha_pago", typeof(DateTime));
            dt.Columns.Add("Fecha_Vencimiento", typeof(DateTime));
            dt.Columns.Add("monto_pago", typeof(double));

            foreach (var registro in FormVerificacionSolvencia.RegistroPagos)
            {
                DataRow row = dt.NewRow();
                row["id_pago"] = registro.id_pago;
                row["fecha_pago"] = registro.fecha_pago;
                row["Fecha_Vencimiento"] = registro.Fecha_Vencimiento;
                row["monto_pago"] = registro.monto_pago;
                dt.Rows.Add(row);
            }

            return dt;
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarAExcel();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ExportarAPdf();
        }
    }
}
