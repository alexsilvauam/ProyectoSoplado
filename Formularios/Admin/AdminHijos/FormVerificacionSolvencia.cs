using ProyectoSoplado_1._0_.Modelo_de_datos.Pago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProyectoSoplado_1._0_.Modelo_de_datos.Usuario;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ProyectoSoplado_1._0_.Formularios.Admin;

namespace ProyectoSoplado_1._0_
{
    public partial class FormVerificacionSolvencia : Form
    {
        public static List<Pago> RegistroPagos = new List<Pago>();
        Miembro MiembroExistente;

        public FormVerificacionSolvencia()
        {
            InitializeComponent();
        }

        #region Metodos

        public Miembro buscarMiembro()
        {
            if (rbtnCifCed.Checked)
            {
                string cifced = txtBuscarMiembro.Text;
                Miembro Miembro = FormAdministrarUsua.Lmiembros.FirstOrDefault(x => x.CifCed == cifced);
                return Miembro;
            }
            else
            {
                int id = int.Parse(txtBuscarMiembro.Text);
                Miembro Miembro = FormAdministrarUsua.Lmiembros.FirstOrDefault(x => x.IDusuario == id);
                return Miembro;
            }
        }

        public Miembro buscarVerificarMiembro()
        {
            if (rbtnVerificarCifCed.Checked)
            {
                string cifced = txtverificar.Text;
                Miembro Miembro = FormAdministrarUsua.Lmiembros.FirstOrDefault(x => x.CifCed == cifced);
                return Miembro;
            }
            else
            {
                int id = int.Parse(txtverificar.Text);
                Miembro Miembro = FormAdministrarUsua.Lmiembros.FirstOrDefault(x => x.IDusuario == id);
                return Miembro;
            }
        }

        public bool VerificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtBuscarMiembro.Text))
            {
                MessageBox.Show("El campo Buscar Miembro no puede estar vacío.", "Completa el campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (rbtnID.Checked)
            {
                if (!int.TryParse(txtBuscarMiembro.Text, out int _))
                {
                    MessageBox.Show("El Id de Miembro tiene que ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
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
            txtBuscarMiembro.Clear();
            txtIdpago.Clear();
            txtmontopago.Clear();
            cmbModalidad.SelectedIndex = -1;
            txtFechaInicio.Clear();
            txtFechaVencimieto.Clear();
        }

        public bool verificar()
        {
            if (string.IsNullOrWhiteSpace(txtverificar.Text))
            {
                MessageBox.Show("El campo de buscar miembro no puede estar vacío.", "Completa el campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (rbtnVerificarID.Checked)
            {
                if (!int.TryParse(txtverificar.Text, out int _))
                {
                    MessageBox.Show("El  Id tiene que ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
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

        #endregion

        #region Botones con metodo

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!VerificarCampos())
            {
                return;
            }

            MiembroExistente = buscarMiembro();
            if (MiembroExistente == null)
            {
                MessageBox.Show($"No existe un miembro con el id {txtBuscarMiembro.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Pago pago = new Pago();

                int Idmiembro = int.Parse(txtBuscarMiembro.Text);
                int idpago = int.Parse(txtIdpago.Text);
                DateTime Date_FechaActual = DateTime.Now.Date;
                double montoPago = double.Parse(txtmontopago.Text);

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!verificar())
            {
                return;
            }

            int ID = int.Parse(txtverificar.Text);
            MiembroExistente = buscarVerificarMiembro();

            if (MiembroExistente != null)
            {
                if (MiembroExistente.Solvencia)
                {
                    MessageBox.Show($"El miembro {MiembroExistente.Nombre} {MiembroExistente.Apellido} ya ha realizado el pago.", "Información de pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtverificar.Clear();
                }
                else
                {
                    MessageBox.Show($"El miembro {MiembroExistente.Nombre} {MiembroExistente.Apellido} no ha realizado el pago.", "Información de pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"No existe un miembro con la busqueda {ID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta del directorio
                string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "ArchivosBIN");

                // Verificar o crear el directorio
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Ruta del archivo
                string filePath = Path.Combine(directoryPath, "Pagos.bin");

                // Serializar la lista de pagos
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    formatter.Serialize(stream, RegistroPagos);
                }

                // Notificar éxito al usuario
                MessageBox.Show("Los pagos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show($"Ocurrió un error al guardar los pagos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones sin metodo

        private void FormVerificacionSolvencia_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtmontopago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdMiembro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarMiembro.Text))
            {
                return;
            }

            MiembroExistente = buscarMiembro();
            if (MiembroExistente != null)
            {
                string rolUsuario = MiembroExistente.RolUsuario;
                asignarMonto(rolUsuario, cmbModalidad.SelectedItem?.ToString());
            }
            else
            {
                txtmontopago.Clear();
            }
        }

        private void cmbModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarMiembro.Text))
            {
                return;
            }

            if (MiembroExistente != null)
            {
                string rolUsuario = MiembroExistente.RolUsuario;
                asignarMonto(rolUsuario, cmbModalidad.SelectedItem?.ToString());
            }
            txtFechaInicio.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFechaVencimieto.Text = AsignarFecha().ToString("dd/MM/yyyy");
        }

        #endregion
    }
}
