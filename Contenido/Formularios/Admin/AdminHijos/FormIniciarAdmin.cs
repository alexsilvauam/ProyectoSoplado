using ProyectoSoplado_1._0_.Formularios;
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
        // Lista estática de administradores
        static public List<(string Usuario, string Contraseña)> admins = new List<(string, string)>();
        // Ruta de la carpeta de archivos
        public string carpetaArchivos = Path.Combine(Directory.GetCurrentDirectory(), "ArchivosBIN");
        // Nombre del archivo de administradores
        public const string archivoAdmins = "admins.bin";

        // Constructor de la clase
        public FormIniciarAdmin()
        {
            InitializeComponent();
            CargarAdministradores(); // Cargar administradores desde el archivo
        }

        #region Botones con Metodo

        // Evento del botón Ingresar
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            string usuario = txtNombreUsuario.Text;
            string contraseña = txtcontraseña.Text;

            // Verificar que el campo de usuario no esté vacío
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("El usuario no puede estar vacio...", "Completa el campo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Verificar que el campo de contraseña no esté vacío
            if (string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("La contraseña no puede estar vacio...", "Completa el campo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Credenciales de administrador por defecto
            string usuarioCorrect = "1";
            string contraseñaCorrect = "admin";

            // Verificar si las credenciales son correctas
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

                // Verificar si las credenciales coinciden con algún administrador registrado
                foreach (var admin in admins)
                {
                    if (admin.Usuario == usuario && admin.Contraseña == contraseña)
                    {
                        esAdminValido = true;
                        break;
                    }
                }

                // Mostrar mensaje según el resultado de la verificación
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

        // Evento del botón Admin
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario
        }

        // Evento del botón Nuevo Admin
        private void btnNuevoAdmin_Click(object sender, EventArgs e)
        {
            btnIngresar.Visible = false;
            txtPIN.Visible = true;
            lblPIN.Visible = true;
            btnRegistrarAdm.Visible = true;
            btnVolver.Visible = true;
            lblNota.Visible = true;
        }

        // Evento del botón Registrar Admin
        private void btnRegistrarAdm_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = txtNombreUsuario.Text;
            string nuevaContraseña = txtcontraseña.Text;
            string pin = txtPIN.Text;

            // Verificar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(nuevoUsuario) || string.IsNullOrWhiteSpace(nuevaContraseña) || string.IsNullOrWhiteSpace(pin))
            {
                MessageBox.Show("Todos los campos deben ser completados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Verificar que el PIN sea correcto
            if (pin != "1309")
            {
                MessageBox.Show("PIN incorrecto. No se puede registrar el administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool existeUsuario = false;
            // Verificar si el nombre de usuario ya existe
            foreach (var admin in admins)
            {
                if (admin.Usuario == nuevoUsuario)
                {
                    existeUsuario = true;
                    break;
                }
            }

            // Registrar el nuevo administrador si el nombre de usuario no existe
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

            GuardarAdministradores(); // Guardar administradores en el archivo
        }

        // Evento del botón Volver
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

        // Método para cargar administradores desde el archivo
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

        // Método para guardar administradores en el archivo
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

        // Evento del label Inicio Sesion (sin método)
        private void lbl_InicioSesion_Click(object sender, EventArgs e)
        {

        }

        // Evento del botón Ingresar (sin método)
        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        // Evento del label Contraseña (sin método)
        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        // Evento del cambio de texto en txtcontraseña (sin método)
        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        // Evento del label Contraseña (sin método)
        private void lblContraseña_Click_1(object sender, EventArgs e)
        {

        }

        // Evento del cambio de texto en txtNombreUsuario (sin método)
        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        // Evento del label1 (sin método)
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Evento de carga del formulario (sin método)
        private void FormIniciarAdmin_Load_1(object sender, EventArgs e)
        {

        }

        // Evento del cambio de texto en txtPIN (sin método)
        private void txtPIN_TextChanged(object sender, EventArgs e)
        {

        }

        // Evento del label PIN (sin método)
        private void lblPIN_Click(object sender, EventArgs e)
        {

        }

        #endregion

        // Evento del botón Gestionar Admin (sin método)
        private void btnGestionarAdmin_Click(object sender, EventArgs e)
        {

        }

        // Evento del botón1 (sin método)
        private void button1_Click(object sender, EventArgs e)
        {
            frmGestionarAdmins frm = new frmGestionarAdmins();
            frm.Show();
        }
    }
}
