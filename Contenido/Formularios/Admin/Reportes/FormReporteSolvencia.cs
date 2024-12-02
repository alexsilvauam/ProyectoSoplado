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
using ProyectoSoplado_1._0_.Modelo_de_datos.Asistencia;

namespace ProyectoSoplado_1._0_.Formularios.Admin
{
    public partial class FormReporteSolvencia : Form
    {
        // Constructor del formulario
        public FormReporteSolvencia()
        {
            InitializeComponent();
            // Agregar opciones al ComboBox de filtros
            CbFiltros.Items.Add("Diario");
            CbFiltros.Items.Add("Semanal");
            CbFiltros.Items.Add("Mensual");
            CbFiltros.SelectedIndexChanged += CbFiltros_SelectedIndexChanged;
        }

        // Evento del botón Ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Código para el evento del botón Ingresar
        }

        // Evento del botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Código para el evento del botón Agregar
        }

        // Evento del botón Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Código para el evento del botón Buscar
        }

        // Evento del DataGridView al hacer clic en una celda
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Código para el evento de clic en una celda del DataGridView
        }

        // Evento de carga del formulario
        private void FormReporteSolvencia_Load(object sender, EventArgs e)
        {
            // Configurar el DataGridView con los datos de pagos
            dgvRegistroPagos.DataSource = null;
            dgvRegistroPagos.DataSource = FormVerificacionSolvencia.RegistroPagos;
            dgvRegistroPagos.Columns["id_pago"].HeaderText = "ID del Pago";
            dgvRegistroPagos.Columns["fecha_pago"].HeaderText = "Fecha del Pago";
            dgvRegistroPagos.Columns["Fecha_Vencimiento"].HeaderText = "Fecha de vencimiento";
            dgvRegistroPagos.Columns["monto_pago"].HeaderText = "Monto de Pago";

            // Configurar el ComboBox de filtros
            CbFiltros.SelectedIndexChanged += CbFiltros_SelectedIndexChanged;
            if (CbFiltros.Items.Count > 0)
            {
                CbFiltros.SelectedIndex = 0; // Seleccionar el primer elemento por defecto
            }
            FiltrarPagos();
        }

        // Evento del botón Reporte
        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                // Generar el informe de solvencia
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
                // Mostrar mensaje de error en caso de fallo
                MessageBox.Show($"Error al generar el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para exportar el informe a PDF
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
                // Mostrar mensaje de error en caso de fallo
                MessageBox.Show($"Error al generar el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para exportar el informe a Excel
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
                // Mostrar mensaje de error en caso de fallo
                MessageBox.Show($"Error al generar el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para crear un DataTable con encabezados
        private DataTable CrearDataTableConEncabezados()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id_pago", typeof(int));
            dt.Columns.Add("fecha_pago", typeof(DateTime));
            dt.Columns.Add("Fecha_Vencimiento", typeof(DateTime));
            dt.Columns.Add("monto_pago", typeof(double));

            // Agregar datos al DataTable
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

        // Evento del botón Exportar a Excel
        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarAExcel();
        }

        // Evento del botón Exportar a PDF
        private void btnPDF_Click(object sender, EventArgs e)
        {
            ExportarAPdf();
        }

        // Evento del botón Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Mostrar cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea limpiar los registros de pagos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                try
                {
                    // Ruta del directorio del proyecto
                    string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "ArchivosBIN");
                    string filePath = Path.Combine(directoryPath, "Pagos.bin");

                    // Eliminar el archivo Pagos.bin
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                        MessageBox.Show("Archivo 'Pagos.bin' eliminado correctamente.", "Limpieza completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El archivo 'Pagos.bin' no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error en caso de fallo
                    MessageBox.Show($"Error al eliminar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        // Método para filtrar los pagos según el filtro seleccionado
        private void FiltrarPagos()
        {
            if (CbFiltros.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un filtro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedFilter = CbFiltros.SelectedItem.ToString();
            DateTime now = DateTime.Now;
            List<Pago> filteredList = new List<Pago>();

            switch (selectedFilter)
            {
                case "Diario":
                    filteredList = FormVerificacionSolvencia.RegistroPagos.Where(p => p.fecha_pago.Date == now.Date).ToList();
                    break;
                case "Semanal":
                    // Ajustar el cálculo del inicio de la semana para incluir el día actual
                    DateTime startOfWeek = now.AddDays(-(int)now.DayOfWeek + (int)DayOfWeek.Monday);
                    if (startOfWeek > now)
                    {
                        startOfWeek = startOfWeek.AddDays(-7);
                    }
                    filteredList = FormVerificacionSolvencia.RegistroPagos.Where(p => p.fecha_pago.Date >= startOfWeek.Date && p.fecha_pago.Date <= now.Date).ToList();
                    break;
                case "Mensual":
                    DateTime startOfMonth = new DateTime(now.Year, now.Month, 1);
                    filteredList = FormVerificacionSolvencia.RegistroPagos.Where(p => p.fecha_pago.Date >= startOfMonth.Date && p.fecha_pago.Date <= now.Date).ToList();
                    break;
            }

            dgvRegistroPagos.DataSource = null;
            dgvRegistroPagos.DataSource = filteredList;

            // Cambiar los nombres de las columnas
            dgvRegistroPagos.Columns["id_pago"].HeaderText = "ID del Pago";
            dgvRegistroPagos.Columns["fecha_pago"].HeaderText = "Fecha del Pago";
            dgvRegistroPagos.Columns["Fecha_Vencimiento"].HeaderText = "Fecha de vencimiento";
            dgvRegistroPagos.Columns["monto_pago"].HeaderText = "Monto de Pago";
        }

        // Evento del ComboBox de filtros al cambiar la selección
        private void CbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPagos();
        }
    }
}
