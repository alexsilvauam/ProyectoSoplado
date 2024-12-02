using Microsoft.Reporting.WinForms;
using ProyectoSoplado_1._0_.DataSets;
using ProyectoSoplado_1._0_.Formularios.Admin.Reportes;
using ProyectoSoplado_1._0_.Modelo_de_datos.Asistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoplado_1._0_.Formularios
{
    public partial class FormReporteAsistencia : Form
    {
        public FormReporteAsistencia()
        {
            InitializeComponent();
            // Agregar opciones al ComboBox de filtros
            CbFiltros.Items.Add("Diario");
            CbFiltros.Items.Add("Semanal");
            CbFiltros.Items.Add("Mensual");
            // Asignar evento al cambiar la selección del ComboBox
            CbFiltros.SelectedIndexChanged += CbFiltros_SelectedIndexChanged;
        }

        #region Metodos

        /// <summary>
        /// Actualiza el DataGridView con los datos de asistencia.
        /// </summary>
        public void ActualizarAsistencia()
        {
            dgvReporteAsistencias.DataSource = null;
            dgvReporteAsistencias.DataSource = FormPrincipal.RegistroAsistencia;
            dgvReporteAsistencias.Columns["nombreUsuario"].HeaderText = "Nombre de Usuario";
            dgvReporteAsistencias.Columns["FechaAcceso"].HeaderText = "Fecha de Acceso";
            dgvReporteAsistencias.Columns["HoraAcceso"].HeaderText = "Hora de Acceso";
        }

        /// <summary>
        /// Exporta el informe de asistencia a un archivo Excel.
        /// </summary>
        private void ExportarAExcel()
        {
            try
            {
                // Crear DataTable con encabezados y datos
                DataTable dt = CrearDataTableConEncabezados();

                // Configurar el ReportViewer
                ReportDataSource dataSource = new ReportDataSource("DsAsistencias", dt);
                LocalReport report = new LocalReport();
                report.ReportEmbeddedResource = "ProyectoSoplado_1._0_.Reportes.RptAsistencia.rdlc"; // Asegúrate de que la ruta sea correcta
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
                    saveFileDialog.FileName = "InformeAsistencia.xlsx";

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

        /// <summary>
        /// Exporta el informe de asistencia a un archivo PDF.
        /// </summary>
        private void ExportarAPdf()
        {
            try
            {
                // Configurar el ReportViewer
                ReportDataSource dataSource = new ReportDataSource("DsAsistencias", FormPrincipal.RegistroAsistencia);
                LocalReport report = new LocalReport();
                report.ReportEmbeddedResource = "ProyectoSoplado_1._0_.Reportes.RptAsistencia.rdlc"; // Asegúrate de que la ruta sea correcta
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
                    saveFileDialog.FileName = "InformeAsistencia.pdf";

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

        /// <summary>
        /// Crea un DataTable con los encabezados y datos de asistencia.
        /// </summary>
        /// <returns>DataTable con los datos de asistencia.</returns>
        private DataTable CrearDataTableConEncabezados()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NombreUsuario", typeof(string));
            dt.Columns.Add("FechaAcceso", typeof(DateTime));
            dt.Columns.Add("HoraAcceso", typeof(TimeSpan));

            foreach (var registro in FormPrincipal.RegistroAsistencia)
            {
                DataRow row = dt.NewRow();
                row["NombreUsuario"] = registro.NombreUsuario;
                row["FechaAcceso"] = registro.FechaAcceso;
                row["HoraAcceso"] = registro.HoraAcceso;
                dt.Rows.Add(row);
            }

            return dt;
        }

        /// <summary>
        /// Filtra la lista de asistencias según el filtro seleccionado en el ComboBox.
        /// </summary>
        private void FiltrarAsistencia()
        {
            string selectedFilter = CbFiltros.SelectedItem.ToString();
            DateTime now = DateTime.Now;
            List<Asistencia> filteredList = new List<Asistencia>();

            switch (selectedFilter)
            {
                case "Diario":
                    filteredList = FormPrincipal.RegistroAsistencia.Where(a => a.FechaAcceso.Date == now.Date).ToList();
                    break;
                case "Semanal":
                    // Ajustar el cálculo del inicio de la semana
                    DateTime startOfWeek = now.AddDays(-(int)now.DayOfWeek + (int)DayOfWeek.Monday);
                    if (startOfWeek > now)
                    {
                        startOfWeek = startOfWeek.AddDays(-7);
                    }
                    filteredList = FormPrincipal.RegistroAsistencia.Where(a => a.FechaAcceso >= startOfWeek && a.FechaAcceso <= now).ToList();
                    break;
                case "Mensual":
                    DateTime startOfMonth = new DateTime(now.Year, now.Month, 1);
                    filteredList = FormPrincipal.RegistroAsistencia.Where(a => a.FechaAcceso >= startOfMonth && a.FechaAcceso <= now).ToList();
                    break;
            }

            dgvReporteAsistencias.DataSource = null;
            dgvReporteAsistencias.DataSource = filteredList;

            // Cambiar los nombres de las columnas
            dgvReporteAsistencias.Columns["NombreUsuario"].HeaderText = "Nombre de Usuario";
            dgvReporteAsistencias.Columns["FechaAcceso"].HeaderText = "Fecha de Acceso";
            dgvReporteAsistencias.Columns["HoraAcceso"].HeaderText = "Hora de Acceso";
        }

        #endregion

        #region Botones con metodo

        /// <summary>
        /// Genera y muestra el informe de asistencia en un formulario.
        /// </summary>
        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDataSource dataSource = new ReportDataSource("DsAsistencias", FormPrincipal.RegistroAsistencia);
                FormRptAsistencias reporte = new FormRptAsistencias();

                reporte.RvAsistencias.LocalReport.DataSources.Clear();
                reporte.RvAsistencias.LocalReport.DataSources.Add(dataSource);
                reporte.RvAsistencias.LocalReport.ReportEmbeddedResource = "ProyectoSoplado_1._0_.Reportes.RptAsistencia.rdlc";
                reporte.RvAsistencias.RefreshReport();
                reporte.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Llama al método para exportar el informe a Excel.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            ExportarAExcel();
        }

        /// <summary>
        /// Llama al método para exportar el informe a PDF.
        /// </summary>
        private void btnPDF_Click(object sender, EventArgs e)
        {
            ExportarAPdf();
        }

        #endregion

        #region Botones sin metodo

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarAsistencia();
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario de reporte de asistencia.
        /// </summary>
        private void FormReporteAsistencia_Load(object sender, EventArgs e)
        {
            ActualizarAsistencia();
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el label de inicio de sesión.
        /// </summary>
        private void lbl_InicioSesion_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en una celda del DataGridView.
        /// </summary>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        /// <summary>
        /// Evento que se ejecuta al cambiar la selección del ComboBox de filtros.
        /// </summary>
        private void CbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarAsistencia();
        }
    }
}
