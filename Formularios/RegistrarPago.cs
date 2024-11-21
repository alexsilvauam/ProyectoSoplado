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

namespace ProyectoSoplado_1._0_.Formularios
{
    public partial class RegistrarPago : Form
    {
        List<Pago> pagos = new List<Pago>();
        public RegistrarPago()
        {
            InitializeComponent();
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
            pagos.Add(pago);

            dataGridView1.DataSource = pagos;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pago pago = new Pago();
            pago = pagos.Find(item => item.idMiembro == int.Parse(txtValor.Text));
            if(pago != null)
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
