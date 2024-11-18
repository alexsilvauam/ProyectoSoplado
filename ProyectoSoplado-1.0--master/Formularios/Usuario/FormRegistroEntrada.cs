using System;
using System.Windows.Forms;

namespace ProyectoSoplado_1._0_
{
    public partial class FormRegistroEntrada : Form
    {
        public FormRegistroEntrada()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioEntrada.Text;
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
            string horaActual = DateTime.Now.ToString("HH:mm");
            MessageBox.Show($"El usuario {usuario} inició sesión a las {horaActual} del {fechaActual}", "Registro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEscanear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aún no está implementado", "Escanear Código de Barras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}