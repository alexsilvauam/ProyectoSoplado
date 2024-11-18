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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedorHijos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            abrirMinisForms(new FormRegistroEntrada());
        }
        public Form activeform = null;
        public void abrirMinisForms(Form hijo)
        {
            if (activeform != null)
                activeform.Close();
            activeform = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelContenedorHijos.Controls.Add(hijo);
            panelContenedorHijos.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            abrirMinisForms(new FormIniciarAdmin());
        }
    }
}
