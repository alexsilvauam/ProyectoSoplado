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
        // Constructor del formulario
        public FormAdmin()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        #region Metodos

        // Método para personalizar el diseño del formulario
        public void personalizarDiseño()
        {
            panelReportes.Visible = false;
            panelUsuarios.Visible = false;
        }

        // Método para ocultar los submenús
        public void ocultarSubmenu()
        {
            if (panelUsuarios.Visible == true)
                panelUsuarios.Visible = false;
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
        }

        // Método para mostrar un submenú
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

        // Método para abrir formularios hijos dentro del panel contenedor
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

        #endregion

        #region Botones con metodo

        // Evento del botón para abrir el formulario de administrar usuarios
        private void button3_Click(object sender, EventArgs e)
        {
            abrirMinisForms(new FormAdministrarUsua());
            ocultarSubmenu();
        }

        // Evento del botón para abrir el formulario de verificación de solvencia
        private void button4_Click(object sender, EventArgs e)
        {
            abrirMinisForms(new FormVerificacionSolvencia());
            ocultarSubmenu();
        }

        // Evento del botón para mostrar el submenú de usuarios
        private void btnPanelUsuarios_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelUsuarios);
        }

        // Evento del botón para abrir el formulario de reporte de asistencia
        private void btnRepAsistencia_Click(object sender, EventArgs e)
        {
            abrirMinisForms(new FormReporteAsistencia());
            ocultarSubmenu();
        }

        // Evento del botón para abrir el formulario de reporte de solvencia
        private void btnRepSolvencia_Click(object sender, EventArgs e)
        {
            abrirMinisForms(new FormReporteSolvencia());
            ocultarSubmenu();
        }

        // Evento del botón para mostrar el submenú de reportes
        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelReportes);
        }

        // Evento del botón para cerrar el formulario
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Botones sin metodo

        // Evento del botón (actualmente no utilizado)
        private void btnad_Click(object sender, EventArgs e) { }

        // Evento del panel de logo (actualmente no utilizado)
        private void PlLogo_Paint(object sender, PaintEventArgs e) { }

        // Evento del pictureBox (actualmente no utilizado)
        private void pictureBox1_Click(object sender, EventArgs e) { }

        // Evento del botón (actualmente no utilizado)
        private void button5_Click(object sender, EventArgs e) { }

        // Evento del panel (actualmente no utilizado)
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        // Evento de carga del formulario (actualmente no utilizado)
        private void FormAdmin_Load(object sender, EventArgs e) { }

        // Evento del panel de menú (actualmente no utilizado)
        private void panelMenu_Paint(object sender, PaintEventArgs e) { }

        // Evento de carga del formulario (actualmente no utilizado)
        private void FormAdmin_Load_1(object sender, EventArgs e) { }

        // Evento del label de aviso (actualmente no utilizado)
        private void lblAviso_Click(object sender, EventArgs e) { }

        // Evento del panel (actualmente no utilizado)
        private void panel1_Paint_1(object sender, PaintEventArgs e) { }

        // Evento del botón (actualmente no utilizado)
        private void button1_Click(object sender, EventArgs e) { }

        #endregion

        // Variable para almacenar el formulario activo
        public Form activeform = null;

        // Evento del botón para abrir el formulario de gestionar admins
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            abrirMinisForms(new frmGestionarAdmins());
            ocultarSubmenu();
        }
    }
}

