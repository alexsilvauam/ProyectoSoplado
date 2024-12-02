using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoplado_1._0_.Formularios.Admin.Reportes
{
    public partial class FormRptSolvencia : Form
    {
        public FormRptSolvencia()
        {
            InitializeComponent();
        }

        private void FormRptSolvencia_Load(object sender, EventArgs e)
        {

            this.RvSolvencia.RefreshReport();
        }
    }
}
