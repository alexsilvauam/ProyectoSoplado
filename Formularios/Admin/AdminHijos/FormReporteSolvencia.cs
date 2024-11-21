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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoSoplado_1._0_.Formularios.Admin
{
    public partial class FormReporteSolvencia : Form
    {
        public static List<Pago> RegistroPagos = new List<Pago>();

        public FormReporteSolvencia()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int miembro = int.Parse(txtIdMiembro.Text);
            int idpago = int.Parse(txtIdpago.Text);
            DateTime Date_FechaActual = DateTime.Now.Date;
            double montoPago = double.Parse(txtmontopago.Text);

            Pago pago = new Pago();

            pago.idMiembro = miembro;
            pago.id_pago = idpago;
            pago.fecha_pago = Date_FechaActual;
            pago.monto_pago = montoPago;
            RegistroPagos.Add(pago);

            dataGridView1.DataSource = RegistroPagos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pago pago = new Pago();
            pago = RegistroPagos.Find(item => item.idMiembro == int.Parse(txtValor.Text));
            if (pago != null)
            {
                MessageBox.Show("Este miembro ya ha realizado el pago", ".");
            }
            else
            {
                MessageBox.Show("Este miebro no ha realizado el pago", ".");

            }
        }
    }
}
