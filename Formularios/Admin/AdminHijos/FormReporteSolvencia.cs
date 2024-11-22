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

        }
    }
}
