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
    public partial class frmEditarAdmin : Form
    {
        public string EditUsuario { get; private set; }
        public string EditContraseña { get; private set; }

        public frmEditarAdmin(string usuarioActual, string contraseñaActual)
        {
            InitializeComponent();
            txtEditUsuario.Text = usuarioActual;
            txtEditContraseña.Text = contraseñaActual;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEditUsuario.Text) || string.IsNullOrWhiteSpace(txtEditContraseña.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditUsuario = txtEditUsuario.Text.Trim();
            EditContraseña = txtEditContraseña.Text.Trim();

            DialogResult = DialogResult.OK; 
            Close();
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
