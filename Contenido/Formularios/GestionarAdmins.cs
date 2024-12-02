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
using Microsoft.ReportingServices.Diagnostics.Internal;
using ProyectoSoplado_1._0_;
using ProyectoSoplado_1._0_.Modelo_de_datos.Usuario;

namespace ProyectoSoplado_1._0_.Formularios
{
    public partial class frmGestionarAdmins : Form
    {
        // Constructor del formulario
        public frmGestionarAdmins()
        {
            InitializeComponent();
        }

        #region Eventos de Botones

        // Evento del botón Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!verificar())
            {
                return;
            }
            string usuario = txtUsuario.Text;
            bool encontrado = FormIniciarAdmin.admins.Any(admin => admin.Usuario == usuario);

            if (encontrado)
            {
                MessageBox.Show($"Admin {usuario} encontrado.", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Clear();
            }
            else
            {
                MessageBox.Show($"Admin {usuario} no encontrado.", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Evento del botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!verificar())
            {
                return;
            }
            string usuario = txtUsuario.Text;

            var admin = FormIniciarAdmin.admins.FirstOrDefault(a => a.Usuario == usuario);

            if (admin.Usuario != null)
            {
                FormIniciarAdmin.admins.Remove(admin);
                actualizargrid();
                txtUsuario.Clear();
                MessageBox.Show($"Usuario '{usuario}' eliminado con éxito.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Usuario '{usuario}' no encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Evento del botón Guardar Archivo
        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            string carpetaArchivos = Path.Combine(Directory.GetCurrentDirectory(), "ArchivosBIN");
            const string archivoAdmins = "admins.bin";
            string rutaCompleta = Path.Combine(carpetaArchivos, archivoAdmins);

            if (!Directory.Exists(carpetaArchivos))
            {
                Directory.CreateDirectory(carpetaArchivos);
            }

            using (FileStream fs = new FileStream(rutaCompleta, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, FormIniciarAdmin.admins);
            }
        }

        // Evento del botón Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!verificar())
            {
                return;
            }

            string usuario = txtUsuario.Text;

            var adminExistente = FormIniciarAdmin.admins.FirstOrDefault(a => a.Usuario == usuario);

            if (adminExistente.Usuario != null)
            {
                using (FormEditarAdmin formEditar = new FormEditarAdmin(adminExistente.Usuario, adminExistente.Contraseña))
                {
                    if (formEditar.ShowDialog() == DialogResult.OK)
                    {
                        int index = FormIniciarAdmin.admins.IndexOf(adminExistente);
                        FormIniciarAdmin.admins[index] = (formEditar.EditUsuario, formEditar.EditContraseña);

                        actualizargrid();
                        txtUsuario.Clear();
                        MessageBox.Show($"El admin '{usuario}' ha sido editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Admin '{usuario}' no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Métodos

        // Método para verificar si el campo de usuario está vacío
        public bool verificar()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, ingresa el usuario del admin.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Método para actualizar el DataGridView
        public void actualizargrid()
        {
            dgvAdmins.DataSource = null;
            dgvAdmins.DataSource = FormIniciarAdmin.admins.Select(admin => new { Usuario = admin.Usuario, Contraseña = admin.Contraseña }).ToList();
        }

        public void ocultar()
        {
            gbPanelControl.Hide();
            pictureBox1.Hide();
            dgvAdmins.Hide();
            gpLogin.Show();
        }
        public void iniciar()
        {
            gbPanelControl.Show();
            pictureBox1.Show();
            dgvAdmins.Show();
            gpLogin.Hide();
        }

        #endregion

        #region Eventos del DataGridView

        // Evento del DataGridView (actualmente no utilizado)
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        #endregion

        #region Eventos del Formulario

        // Evento de carga del formulario
        private void GestionarAdmins_Load(object sender, EventArgs e)
        {
            ocultar();
            actualizargrid();
        }

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string contraseña = txtLogin.Text;
            string contraseñaCorrecta = "1234abcd";
            if(contraseñaCorrecta == contraseña)
            {
                iniciar();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Por favor, inténtelo de nuevo.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
