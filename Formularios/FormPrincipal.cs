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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormIniciarAdmin formAdmin = new FormIniciarAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Se ha marcado la entrada a las {DateTime.Now:HH:mm:ss} del {DateTime.Now:dd/MM/yyyy}", "Entrada marcada exitosamente");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Función no implementada", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
