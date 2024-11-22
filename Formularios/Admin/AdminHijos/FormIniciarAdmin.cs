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
            
        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void FormIniciarAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            string usuario = txtNombreUsuario.Text;
            string contraseña = txtcontraseña.Text;

            string usuarioCorrect = "1";
            string contraseñaCorrect = "admin";

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("El usuario no puede estar vacio...", "Completa el campo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("La contraseña no puede estar vacio...", "Completa el campo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (usuario == usuarioCorrect && contraseña == contraseñaCorrect)
            {
                FormAdmin formAdmin = new FormAdmin();
                FormIniciarAdmin formIniciarAdmin = this;

                formAdmin.FormClosed += (s, args) => formIniciarAdmin.Close();
                formAdmin.Show();
               this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta...", ".", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
