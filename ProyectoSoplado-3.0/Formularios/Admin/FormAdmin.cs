using ProyectoSoplado_1._0_.Formularios;
using ProyectoSoplado_1._0_.Formularios.Admin;
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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            personalizarDiseño();
        }
        // Diseños del submenu
        public void personalizarDiseño() {
            panelReportes.Visible = false;

            panelUsuarios.Visible = false;
        }

        public void ocultarSubmenu()
        {
            if (panelUsuarios.Visible == true)
                panelUsuarios.Visible = false;            
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
        }
        public void mostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        //Termina.

        private void btnad_Click(object sender, EventArgs e)
        {

        }

        private void PlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirMinisForms(new FormAdministrarUsua());
            ocultarSubmenu();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirMinisForms(new FormRegistrarUsuario());
            ocultarSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirMinisForms(new FormVerificacionSolvencia());
            ocultarSubmenu();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPanelUsuarios_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelUsuarios);
        }

        private void btnRepAsistencia_Click(object sender, EventArgs e)
        {
            abrirMinisForms(new FormReporteAsistencia());

            ocultarSubmenu();

        }

        private void btnRepSolvencia_Click(object sender, EventArgs e)
        {
            abrirMinisForms(new FormReporteSolvencia());
            ocultarSubmenu();

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelReportes);
        }

        private void FormAdmin_Load_1(object sender, EventArgs e)
        {

        }

        private void lblAviso_Click(object sender, EventArgs e)
        {

        }
        public Form activeform = null;
        public void abrirMinisForms(Form hijo)
        {
            if (activeform != null)
                activeform.Close();
            activeform= hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelContenedorHijos.Controls.Add(hijo);
            panelContenedorHijos.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
