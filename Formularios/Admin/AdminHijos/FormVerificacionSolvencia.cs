﻿using ProyectoSoplado_1._0_.Modelo_de_datos.Pago;
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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProyectoSoplado_1._0_.Formularios.Admin;

namespace ProyectoSoplado_1._0_
{
    public partial class FormVerificacionSolvencia : Form
    {
        public static List<Pago> RegistroPagos = new List<Pago>();

        public FormVerificacionSolvencia()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!VerificarCampos())
            {
                return;
            }

            int Idmiembro = int.Parse(txtIdMiembro.Text);
            int idpago = int.Parse(txtIdpago.Text);
            DateTime Date_FechaActual = DateTime.Now.Date;
            double montoPago = double.Parse(txtmontopago.Text);




            Miembro MiembroExistente = FormAdministrarUsua.Lmiembros.FirstOrDefault(x => x.IDusuario == int.Parse(txtIdMiembro.Text));
            if (MiembroExistente == null)
            {
                MessageBox.Show($"No existe un miembro con el id {txtIdMiembro.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                Pago pago = new Pago();

                pago.idMiembro = Idmiembro;
                pago.id_pago = idpago;
                pago.fecha_pago = Date_FechaActual;
                pago.Fecha_Vencimiento = AsignarFecha();
                pago.monto_pago = montoPago;
               


                RegistroPagos.Add(pago);

                MiembroExistente.Solvencia = true;
                limpiarCampos();
                MessageBox.Show("Pago registrado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        public bool VerificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtIdMiembro.Text))
            {
                MessageBox.Show("El campo Id Miembro no puede estar vacío.", "Completa el campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIdpago.Text))
            {
                MessageBox.Show("El campo Id Pago no puede estar vacío.", "Completa el campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            if (cmbModalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una modalidad.", "Completa el campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtIdMiembro.Text, out int _))
            {
                MessageBox.Show("El campo Id Miembro tiene que ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtIdpago.Text, out int _))
            {
                MessageBox.Show("El campo Id Pago tiene que ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtmontopago.Text, out double _))
            {
                MessageBox.Show("El campo Monto Pago tiene que ser un número.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (Pago elem in RegistroPagos)
            {
                if (int.Parse(txtIdpago.Text) == elem.id_pago)
                {
                    MessageBox.Show("No puedes repetir el ID del pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }


        public void limpiarCampos()
        {
            txtIdMiembro.Clear();
            txtIdpago.Clear();
            txtmontopago.Clear();
            cmbModalidad.SelectedIndex = -1;
            txtFechaInicio.Clear();
            txtFechaVencimieto.Clear();

        }



        public bool verificarId()
        {
            if (string.IsNullOrWhiteSpace(txtIDverificar.Text))
            {
                MessageBox.Show("El campo Id Miembro no puede estar vacío.", "Completa el campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (!int.TryParse(txtIDverificar.Text, out int _))
            {
                MessageBox.Show("El campo Id tiene que ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Miembro MiembroExistente = FormAdministrarUsua.Lmiembros.FirstOrDefault(x => x.IDusuario == int.Parse(txtIDverificar.Text));
            if (MiembroExistente == null)
            {
                MessageBox.Show($"No existe un miembro con el id {txtIDverificar.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!verificarId())
            {
                return;
            }

            int ID = int.Parse(txtIDverificar.Text);
            Miembro miembroExistente = FormAdministrarUsua.Lmiembros.FirstOrDefault(x => x.IDusuario == ID);

            if (miembroExistente != null)
            {
                Pago pago = RegistroPagos.Find(item => item.idMiembro == ID);
                if (pago != null)
                {
                    MessageBox.Show($"El miembro {miembroExistente.Nombre} ya ha realizado el pago.", "Información de pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDverificar.Clear();
                }
                else
                {
                    MessageBox.Show($"El miembro {miembroExistente.Nombre} no ha realizado el pago.", "Información de pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"No existe un miembro con el id {ID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormVerificacionSolvencia_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtmontopago_TextChanged(object sender, EventArgs e)
        {

        }

        private void asignarMonto(string rolUsuario, string modalidad)
        {
            double monto = 0.0;

            if (modalidad == "Mes")
            {
                switch (rolUsuario)
                {
                    case "Estudiante":
                    case "Colaborador":
                        monto = 15.00;
                        break;
                    case "Externo":
                        monto = 25.00;
                        break;
                    default:
                        monto = 0.00;
                        break;
                }
            }
            else if (modalidad == "Dia")
            {
                monto = 3.00;
            }

            txtmontopago.Text = monto.ToString("F2");
        }
        private void txtIdMiembro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdMiembro.Text))
            {
                return;
            }

            if (!int.TryParse(txtIdMiembro.Text, out int id))
            {
                MessageBox.Show("El campo Id Miembro tiene que ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Miembro miembroExistente = FormAdministrarUsua.Lmiembros.FirstOrDefault(x => x.IDusuario == id);
            if (miembroExistente != null)
            {
                string rolUsuario = miembroExistente.RolUsuario;
                asignarMonto(rolUsuario, cmbModalidad.SelectedItem?.ToString());
            }
            else
            {
                txtmontopago.Clear();
            }
        }

        private void cmbModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdMiembro.Text) || !int.TryParse(txtIdMiembro.Text, out int id))
            {
                return;
            }

            Miembro miembroExistente = FormAdministrarUsua.Lmiembros.FirstOrDefault(x => x.IDusuario == id);
            if (miembroExistente != null)
            {
                string rolUsuario = miembroExistente.RolUsuario;
                asignarMonto(rolUsuario, cmbModalidad.SelectedItem?.ToString());



            }
            txtFechaInicio.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFechaVencimieto.Text = AsignarFecha().ToString("dd/MM/yyyy");

        }

        public DateTime AsignarFecha()
        {
            if (cmbModalidad.SelectedItem.ToString() == "Mes")
            {
                return DateTime.Now.AddMonths(1).Date;
            }
            else
            {
                return DateTime.Now.AddDays(1).Date;
            }
        }

    }
}

