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
    public partial class GestionarAdmins : Form
    {
        public GestionarAdmins()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!verificar())
            {
                return;
            }
            string usuario = txtUsuario.Text;
            bool encontrado =FormIniciarAdmin.admins.Any(admin => admin.Usuario == usuario);

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

        
        public bool verificar()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, ingresa el usuario del admin.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        
     public void actualizargrid()
        {
            dgvAdmins.DataSource = null;
            dgvAdmins.DataSource = dgvAdmins.DataSource = FormIniciarAdmin.admins.Select(admin => new { Usuario = admin.Usuario, Contraseña = admin.Contraseña }).ToList();

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GestionarAdmins_Load(object sender, EventArgs e)
        {
            actualizargrid();
        }

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
                using (frmEditarAdmin formEditar = new frmEditarAdmin(adminExistente.Usuario, adminExistente.Contraseña))
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


    }
}



