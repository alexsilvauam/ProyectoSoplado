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
using ProyectoSoplado_1._0_.Modelo_de_datos.Usuario;

namespace ProyectoSoplado_1._0_.Formularios.Admin
{
    public partial class FormEditarMiembro : Form
    {
        // Miembro actual que se está editando
        private Miembro MiembroActual;

        // Constructor que inicializa el formulario con los datos del miembro a editar
        public FormEditarMiembro(Miembro miembro)
        {
            InitializeComponent();
            MiembroActual = miembro;

            // Asignar los valores del miembro a los campos del formulario
            txtNombre.Text = miembro.Nombre;
            txtApellido.Text = miembro.Apellido;
            txtID.Text = miembro.IDusuario.ToString();
            txtCifCed.Text = miembro.CifCed;
            cmbRolUsuario.SelectedItem = miembro.RolUsuario;
            if (miembro.CifCed.Length == 8)
            {
                cmbCifCed.SelectedItem = "CIF";
            }
            else if (miembro.CifCed.Length == 16)
            {
                cmbCifCed.SelectedItem = "Cédula";
            }

            // Deshabilitar el campo de ID para que no se pueda editar
            txtID.Enabled = false;
        }

        #region Botones con Metodo

        // Evento del botón Registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar los datos del miembro actual
            MiembroActual.Nombre = txtNombre.Text;
            MiembroActual.Apellido = txtApellido.Text;
            MiembroActual.RolUsuario = cmbRolUsuario.SelectedItem?.ToString();
            MiembroActual.CifCed = txtCifCed.Text;

            // Guardar los datos en el archivo binario
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "ArchivosBIN");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string filePath = Path.Combine(directoryPath, "Usuarios.bin");
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(stream, FormAdministrarUsua.Lmiembros);
            }
            MessageBox.Show("Los datos se han guardado correctamente en el archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar el formulario y devolver el resultado OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Evento del botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario sin guardar cambios
            this.Close();
        }

        #endregion

        #region Metodos

        // Evento de cambio de texto en el campo de CIF/Cédula
        private void txtCifCed_TextChanged(object sender, EventArgs e)
        {
            if (cmbCifCed.SelectedItem == null)
            {
                return;
            }

            // Limitar la longitud del texto según el tipo seleccionado (CIF o Cédula)
            string selectedType = cmbCifCed.SelectedItem.ToString();
            int maxLength = selectedType == "CIF" ? 8 : 16;

            if (txtCifCed.Text.Length > maxLength)
            {
                txtCifCed.Text = txtCifCed.Text.Substring(0, maxLength);
                txtCifCed.SelectionStart = txtCifCed.Text.Length;
            }
        }

        #endregion

        #region Botones sin Metodo

        // Evento de carga del formulario (vacío)
        private void FormEditarMiembro_Load(object sender, EventArgs e)
        {
        }

        // Evento de cambio de selección en el ComboBox de Rol de Usuario (vacío)
        private void cmbRolUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Evento de cambio de selección en el ComboBox de CIF/Cédula (vacío)
        private void cmbCifCed_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        #endregion
    }
}
