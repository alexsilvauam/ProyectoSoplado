﻿using ProyectoSoplado_1._0_.Modelo_de_datos.Asistencia;
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
using ProyectoSoplado_1._0_;
using ProyectoSoplado_1._0_.Modelo_de_datos.Pago;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
            cargarMiembros();
            cargarpagos();
            cargarAsistencia();
            verificarSolvencia(FormVerificacionSolvencia.RegistroPagos);
        }

        #region Metodos

        public void GuardarAsistencia()
        {
            try
            {
                string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "ArchivosBIN");
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                string filePath = Path.Combine(directoryPath, "Asistencia.bin");

                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    formatter.Serialize(stream, RegistroAsistencia);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarAsistencia()
        {
            try
            {
                string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "ArchivosBIN");
                string filePath = Path.Combine(directoryPath, "Asistencia.bin");

                if (File.Exists(filePath))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream stream = new FileStream(filePath, FileMode.Open))
                    {
                        RegistroAsistencia = (List<Asistencia>)formatter.Deserialize(stream);
                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarMiembros()
        {
            try
            {
                string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "ArchivosBIN");
                string filePath = Path.Combine(directoryPath, "Usuarios.bin");

                if (File.Exists(filePath))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream stream = new FileStream(filePath, FileMode.Open))
                    {
                        FormAdministrarUsua.Lmiembros = (List<Miembro>)formatter.Deserialize(stream);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarpagos()
        {
            try
            {
                string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "ArchivosBIN");
                string filePath = Path.Combine(directoryPath, "Pagos.bin");

                if (File.Exists(filePath))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream stream = new FileStream(filePath, FileMode.Open))
                    {
                        FormVerificacionSolvencia.RegistroPagos = (List<Pago>)formatter.Deserialize(stream);
                    }

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void verificarSolvencia(List<Pago> pagos)
        {
            foreach (Pago pago in pagos)
            {
                if (pago.Fecha_Vencimiento <= DateTime.Now)
                {
                    Miembro miembro = FormAdministrarUsua.Lmiembros.FirstOrDefault(m => m.IDusuario == pago.id_miembro);
                    if (miembro != null)
                    {
                        miembro.Solvencia = false;

                        try
                        {
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
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ocurrió un error al guardar la información: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        #endregion

        #region Botones con Metodo

        private void button2_Click(object sender, EventArgs e)
        {
            FormIniciarAdmin formAdmin = new FormIniciarAdmin();
            formAdmin.Show();
            // this.Hide();
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioLogin.Text))
            {
                MessageBox.Show("El Nombre de usuario no puede estar vacio.", "Complete el campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuario = txtUsuarioLogin.Text;

            //para el mensaje
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
            string horaActual = DateTime.Now.ToString("HH:mm");
            //para la lista
            DateTime Date_FechaActual = DateTime.Now.Date;

            Miembro MiembroExistente = FormAdministrarUsua.Lmiembros.FirstOrDefault(x => x.CifCed == usuario);
            if (MiembroExistente != null)
            {
                string Nombreusuario = MiembroExistente.Nombre + " " + MiembroExistente.Apellido;

                if (MiembroExistente.Solvencia)
                {
                    RegistroAsistencia.Add(new Asistencia(Nombreusuario, Date_FechaActual, horaActual));
                    MessageBox.Show($"El miembro {Nombreusuario} inició sesión a las {horaActual} del {fechaActual}", "Registro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GuardarAsistencia();
                    txtUsuarioLogin.Clear();
                }
                else
                {
                    MessageBox.Show($"El miembro {Nombreusuario} no esta solvente", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show($"El miembro no ha sido encontrado", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnMarcar.Hide();
            lblIngrese.Hide();
            txtUsuarioLogin.Hide();
            button1.Hide();
            txtQR.Show();
            lblQR.Show();
            btncodigoQr.Show();
            btnIngresarconusuario.Show();
        }

        private void btncodigoQr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQR.Text))
            {
                MessageBox.Show("El QR no puede estar vacio.", "Complete el campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtQR.Text, out _))
            {
                MessageBox.Show("El QR debe ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int QR = int.Parse(txtQR.Text);
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
            string horaActual = DateTime.Now.ToString("HH:mm");
            //para la lista
            DateTime Date_FechaActual = DateTime.Now.Date;

            Miembro MiembroExistente = FormAdministrarUsua.Lmiembros.FirstOrDefault(x => x.CodigoQR == QR);
            if (MiembroExistente != null)
            {
                string usuario = MiembroExistente.Nombre + " " + MiembroExistente.Apellido;

                if (MiembroExistente.Solvencia)
                {
                    RegistroAsistencia.Add(new Asistencia(usuario, Date_FechaActual, horaActual));
                    MessageBox.Show($"El miembro {usuario} inició sesión a las {horaActual} del {fechaActual}", "Registro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GuardarAsistencia();
                    txtQR.Clear();
                }
                else
                {
                    MessageBox.Show($"El miembro {usuario} {MiembroExistente.Apellido} no esta solvente", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show($"No hay un miembro con ese codigo QR.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresarconusuario_Click(object sender, EventArgs e)
        {
            btnMarcar.Show();
            lblIngrese.Show();
            txtUsuarioLogin.Show();
            button1.Show();
            btnIngresarconusuario.Hide();
            txtQR.Hide();
            lblQR.Hide();
            btncodigoQr.Hide();
        }

        #endregion
        #region Botones sin Metodo

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
