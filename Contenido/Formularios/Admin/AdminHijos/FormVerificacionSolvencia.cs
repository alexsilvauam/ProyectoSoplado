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
        // Lista estática de pagos registrados
        public static List<Pago> RegistroPagos = new List<Pago>();
        Miembro MiembroExistente;

        // Constructor de la clase
        public FormVerificacionSolvencia()
        {
            InitializeComponent();
            txtIdpago.Enabled = false; // Deshabilitar el campo de texto de ID de pago
            InicializarIDPago(); // Inicializar el campo de ID de pago
        }

        // Método para inicializar el ID de pago
        private void InicializarIDPago()
        {
            int nextIdPago = RegistroPagos.Count > 0 ? RegistroPagos.Max(p => p.id_pago) + 1 : 1;
            txtIdpago.Text = nextIdPago.ToString();
        }

        #region Metodos

        // Método para buscar un miembro por CIF/CED o ID
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
                if (int.TryParse(txtBuscarMiembro.Text, out int id))
                {
                    Miembro Miembro = FormAdministrarUsua.Lmiembros.FirstOrDefault(x => x.IDusuario == id);
                    return Miembro;
                }
                else
                {
                    MessageBox.Show("El Id de Miembro tiene que ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
        }

        // Método para buscar y verificar un miembro por CIF/CED o ID
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

        // Método para verificar que los campos estén completos y correctos
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

        // Método para limpiar los campos del formulario
        public void limpiarCampos()
        {
            txtBuscarMiembro.Clear();
            txtmontopago.Clear();
            cmbModalidad.SelectedIndex = -1;
            txtFechaInicio.Clear();
            txtFechaVencimieto.Clear();

            // Calcular el próximo ID de pago disponible y mostrarlo en el campo de texto de ID de pago
            int nextIdPago = RegistroPagos.Count > 0 ? RegistroPagos.Max(p => p.id_pago) + 1 : 1;
            txtIdpago.Text = nextIdPago.ToString();
        }

        // Método para verificar que el campo de verificación esté completo y correcto
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

        // Método para asignar el monto de pago según el rol del usuario y la modalidad
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

        // Método para asignar la fecha de vencimiento según la modalidad
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

        // Evento del botón Agregar
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

                int idpago = int.Parse(txtIdpago.Text);
                DateTime fechaActual = DateTime.Now.Date;
                double montoPago = double.Parse(txtmontopago.Text);

                pago.id_pago = idpago;
                pago.fecha_pago = fechaActual;
                pago.Fecha_Vencimiento = AsignarFecha();
                pago.monto_pago = montoPago;

                RegistroPagos.Add(pago);

                MiembroExistente.Solvencia = true;

                // Actualizar los campos de fecha y monto de pago
                txtFechaInicio.Text = fechaActual.ToString("dd/MM/yyyy");
                txtFechaVencimieto.Text = pago.Fecha_Vencimiento.ToString("dd/MM/yyyy");
                txtmontopago.Text = montoPago.ToString("F2");

                limpiarCampos();
                MessageBox.Show("Pago registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Guardar los datos en el archivo binario
                try
                {
                    string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "ArchivosBIN");

                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    string filePath = Path.Combine(directoryPath, "Pagos.bin");

                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream stream = new FileStream(filePath, FileMode.Create))
                    {
                        formatter.Serialize(stream, RegistroPagos);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al guardar los pagos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        #endregion

        // Métodos y eventos adicionales (cuerpos eliminados para brevedad)
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!verificar())
            {
                return;
            }

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
                MessageBox.Show($"No existe un miembro con la búsqueda {txtverificar.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e) { }
        private void FormVerificacionSolvencia_Load(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void txtmontopago_TextChanged(object sender, EventArgs e) { }
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


        private void groupBox2_Enter(object sender, EventArgs e) { }

        private void txtFechaInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaVencimieto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
