using ProyectoSoplado_1._0_.Modelo_de_datos.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoplado_1._0_
{
    public partial class FormIniciarAdmin : Form
    {
        private List<(string Usuario, string Contraseña)> admins = new List<(string, string)>();
        public string carpetaArchivos = Path.Combine(Directory.GetCurrentDirectory(), "ArchivosBIN");
        public const string archivoAdmins = "admins.bin";

        public FormIniciarAdmin()
        {
            InitializeComponent();
            CargarAdministradores();
        }               
        #region Botones con Metodo
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            string usuario = txtNombreUsuario.Text;
            string contraseña = txtcontraseña.Text;

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

            string usuarioCorrect = "1";
            string contraseñaCorrect = "admin";

            if (usuario == usuarioCorrect && contraseña == contraseñaCorrect)
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.FormClosed += (s, args) => this.Close();
                formAdmin.Show();
                this.Hide();
            }
            else
            {
                bool esAdminValido = false;

                foreach (var admin in admins)
                {
                    if (admin.Usuario == usuario && admin.Contraseña == contraseña)
                    {
                        esAdminValido = true;
                        break;
                    }
                }

                if (esAdminValido)
                {
                    MessageBox.Show("Bienvenido, Administrador!", ".", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.FormClosed += (s, args) => this.Close();
                    formAdmin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta...", ".", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoAdmin_Click(object sender, EventArgs e)
        {
            btnIngresar.Visible = false;
            txtPIN.Visible = true;
            lblPIN.Visible = true;
            btnRegistrarAdm.Visible = true;
            btnVolver.Visible = true;
            lblNota.Visible = true;
        }

        private void btnRegistrarAdm_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = txtNombreUsuario.Text;
            string nuevaContraseña = txtcontraseña.Text;
            string pin = txtPIN.Text;

            if (string.IsNullOrWhiteSpace(nuevoUsuario) || string.IsNullOrWhiteSpace(nuevaContraseña) || string.IsNullOrWhiteSpace(pin))
            {
                MessageBox.Show("Todos los campos deben ser completados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (pin != "1309")
            {
                MessageBox.Show("PIN incorrecto. No se puede registrar el administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool existeUsuario = false;
            foreach (var admin in admins)
            {
                if (admin.Usuario == nuevoUsuario)
                {
                    existeUsuario = true;
                    break;
                }
            }

            if (!existeUsuario)
            {
                admins.Add((nuevoUsuario, nuevaContraseña));
                MessageBox.Show("Administrador registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreUsuario.Clear();
                txtcontraseña.Clear();
                txtPIN.Clear();
                btnVolver_Click(sender, e);
            }
            else
            {
                MessageBox.Show("El nombre de usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GuardarAdministradores();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            txtPIN.Visible = false;
            lblPIN.Visible = false;
            btnRegistrarAdm.Visible = false;
            btnVolver.Visible = false;
            btnIngresar.Visible = true;
            lblNota.Visible = false;
        }
        #endregion
        #region Metodos
        public void CargarAdministradores()
        {
            string rutaCompleta = Path.Combine(carpetaArchivos, archivoAdmins);

            if (File.Exists(rutaCompleta))
            {
                using (FileStream fs = new FileStream(rutaCompleta, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    admins = (List<(string, string)>)formatter.Deserialize(fs);
                }
            }
        }

        public void GuardarAdministradores()
        {
            string rutaCompleta = Path.Combine(carpetaArchivos, archivoAdmins);

            if (!Directory.Exists(carpetaArchivos))
            {
                Directory.CreateDirectory(carpetaArchivos);
            }

            using (FileStream fs = new FileStream(rutaCompleta, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, admins);
            }
        }
        #endregion
        #region Botones sin Metodo
        private void lbl_InicioSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

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

        private void FormIniciarAdmin_Load_1(object sender, EventArgs e)
        {

        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPIN_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

