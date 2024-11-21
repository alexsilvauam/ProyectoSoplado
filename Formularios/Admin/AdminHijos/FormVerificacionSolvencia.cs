using ProyectoSoplado_1._0_.Modelo_de_datos.Pago;
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

            limpiarCampos();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RegistroPagos;
        }
        public bool VerificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtIdMiembro.Text))
            {
                MessageBox.Show("El campo Id Miembro no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIdpago.Text))
            {
                MessageBox.Show("El campo Id Pago no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtmontopago.Text))
            {
                MessageBox.Show("El campo Monto Pago no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            {
                if (!int.TryParse(txtIdMiembro.Text, out int _))
                {
                    MessageBox.Show("El campo Id Miembro tiene que ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!int.TryParse(txtIdpago.Text, out int _))
                {
                    MessageBox.Show("El campo Id Pago tiene que ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!double.TryParse(txtmontopago.Text, out double _))
                {
                    MessageBox.Show("El campo Monto Pago tiene que ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
        }

        public void limpiarCampos()
        {
            txtIdMiembro.Clear();
            txtIdpago.Clear();
            txtmontopago.Clear();
        }



        public bool verificarId()
        {
            if (string.IsNullOrWhiteSpace(txtValor.Text))
             {
                MessageBox.Show("El campo Id Miembro no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (!int.TryParse(txtValor.Text, out int _))
            {
                MessageBox.Show("El campo Id tiene que ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                 int ID = int.Parse(txtValor.Text);
                Pago pago = new Pago();
                pago = RegistroPagos.Find(item => item.idMiembro == int.Parse(txtValor.Text));
                if (pago != null)
                {
                    MessageBox.Show("Este cliente ya ha realizado el pago", ".");
                }
                else
                {
                    MessageBox.Show("Este cliente no ha realizado el pago", ".");

                }
            }
        }
} 

