using ProyectoSoplado_1._0_.Modelo_de_datos.Asistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSoplado_1._0_.Formularios.Admin;
using ProyectoSoplado_1._0_.Modelo_de_datos.Usuario;

namespace ProyectoSoplado_1._0_.Formularios
{
    public partial class FormPrincipal : Form
    {
        public static List<Asistencia> RegistroAsistencia = new List<Asistencia>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormIniciarAdmin formAdmin = new FormIniciarAdmin();
            formAdmin.Show();
           // this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioLogin.Text))
            {
                MessageBox.Show("El Campo Id o nombre de usuario no puede estar vacio.");
                return;
            }

            string usuario = txtUsuarioLogin.Text;
            //para el mensaje
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
            string horaActual = DateTime.Now.ToString("HH:mm");
            //para la lista
            DateTime Date_FechaActual = DateTime.Now.Date;
           
                  Miembro MiembroExistente = FormAdministrarUsua.Lmiembros.FirstOrDefault(x => x.NombreUsuario == usuario);
            if (MiembroExistente != null)
            {

                RegistroAsistencia.Add(new Asistencia(usuario, Date_FechaActual, horaActual));

                MessageBox.Show($"El usuario {usuario} inició sesión a las {horaActual} del {fechaActual}", "Registro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"El usuario '{usuario}' no ha sido encontrado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    

    private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Función no implementada", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
