using ProyectoSoplado_1._0_.Modelo_de_datos.Asistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarAsistencia();
        }
        private void FormReporteAsistencia_Load(object sender, EventArgs e)
        {
            ActualizarAsistencia();
        }

        private void lbl_InicioSesion_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ActualizarAsistencia()
        {
            dgvReporteAsistencias.DataSource = null;
            dgvReporteAsistencias.DataSource = FormPrincipal.RegistroAsistencia;

        }

    }
}
