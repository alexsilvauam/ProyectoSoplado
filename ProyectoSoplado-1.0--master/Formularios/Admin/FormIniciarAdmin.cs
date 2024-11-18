using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoplado_1._0_
{
    public partial class FormIniciarAdmin : Form
    {
        public FormIniciarAdmin()
        {
            InitializeComponent();
        }

        private void lbl_InicioSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            FormIniciarAdmin formIniciarAdmin = this;

            formAdmin.FormClosed += (s, args) => formIniciarAdmin.Close(); 
            formAdmin.Show();
            this.Hide();
        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
