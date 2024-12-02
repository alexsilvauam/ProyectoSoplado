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
    public partial class FormEditarAdmin : Form
    {
        // Propiedades para obtener el usuario y la contraseña editados
        public string EditUsuario { get; private set; }
        public string EditContraseña { get; private set; }

        // Constructor del formulario
        public FormEditarAdmin(string usuarioActual, string contraseñaActual)
        {
            InitializeComponent();
            txtEditUsuario.Text = usuarioActual;
            txtEditContraseña.Text = contraseñaActual;
        }

        #region Eventos de Botones

        // Evento del botón Editar
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

        #endregion

        #region Eventos de Controles

        // Evento del label1 (actualmente no utilizado)
        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Evento del lblContraseña (actualmente no utilizado)
        private void lblContraseña_Click(object sender, EventArgs e)
        {
        }

        // Evento del textBox2 (actualmente no utilizado)
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        // Evento del textBox1 (actualmente no utilizado)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        #region Eventos del Formulario

        // Evento de carga del formulario (actualmente no utilizado)
        private void FormEditarAdmin_Load(object sender, EventArgs e)
        {
        }

        #endregion
    }
}
