using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSoplado_1._0_.Modelo_de_datos.Usuario;

namespace ProyectoSoplado_1._0_.Formularios.Admin
{
    public partial class FormEditarMiembro : Form
    {
        private Miembro MiembroActual;

        public FormEditarMiembro(Miembro miembro)
        {
            InitializeComponent();
            MiembroActual = miembro;

            txtNombre.Text = miembro.NombreUsuario;
            txtApellido.Text = miembro.ApellidoUsuario;
            txtID.Text = miembro.IdentificacionUsuario.ToString();
            txtCifCed.Text = miembro.CifCed;
            cmbRolUsuario.SelectedItem = miembro.RolUsuario;

            txtID.Enabled = false;
        }

        private void FormEditarMiembro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MiembroActual.NombreUsuario = txtNombre.Text;
            MiembroActual.ApellidoUsuario = txtApellido.Text;
            MiembroActual.RolUsuario = cmbRolUsuario.SelectedItem?.ToString();
            MiembroActual.CifCed = txtCifCed.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmbRolUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCifCed_TextChanged(object sender, EventArgs e)
        {
            if (cmbCifCed.SelectedItem == null)
            {
                return;
            }

            string selectedType = cmbCifCed.SelectedItem.ToString();
            int maxLength = selectedType == "CIF" ? 8 : 16;

            if (txtCifCed.Text.Length > maxLength)
            {
                txtCifCed.Text = txtCifCed.Text.Substring(0, maxLength);
                txtCifCed.SelectionStart = txtCifCed.Text.Length;
            }
        }

        private void cmbCifCed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
