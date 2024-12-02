using ProyectoSoplado_1._0_.Modelo_de_datos.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoplado_1._0_.Formularios.Admin
{
    public partial class FormAdministrarUsua : Form
    {
        // Lista estática de miembros
        public static List<Miembro> Lmiembros = new List<Miembro>();
        Miembro MiembroExistente;

        public FormAdministrarUsua()
        {
            InitializeComponent();
            dgvUsuarios.CellFormatting += dgvUsuarios_CellFormatting;
            txtID.Enabled = false;
            InicializarID();
        }

        // Inicializa el campo de texto de ID con el próximo ID disponible
        private void InicializarID()
        {
            int nextId = Lmiembros.Count > 0 ? Lmiembros.Max(m => m.IDusuario) + 1 : 1;
            txtID.Text = nextId.ToString();
        }

        #region Botones con Metodo

        // Evento del botón Buscar (vacío)
        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        // Evento del botón Registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (verificarCampos() == false)
            {
                return;
            }
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string rolUsuario = cmbRolUsuario.SelectedItem.ToString();
            string cifCed = txtCifCed.Text;
            int id = Lmiembros.Count > 0 ? Lmiembros.Max(m => m.IDusuario) + 1 : 1;

            id = int.Parse(txtID.Text);

            Random random = new Random();
            int codigoQR = random.Next(1, 1000);

            Lmiembros.Add(new Miembro(id, rolUsuario, nombre, apellido, codigoQR, cifCed));

            actualizarGrid();
            LimpiarCampos();
            MessageBox.Show("Miembro agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Guardar los datos en el archivo binario
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "ArchivosBIN");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string filePath = Path.Combine(directoryPath, "Usuarios.bin");
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(stream, Lmiembros);
            }
            MessageBox.Show("Los datos se han guardado correctamente en el archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Evento del botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (verificarBuscar() == false)
            {
                return;
            }
            MiembroExistente = buscarMiembro();

            string BuscarId = txtBusqueda.Text;

            if (MiembroExistente != null)
            {
                Lmiembros.Remove(MiembroExistente);
                actualizarGrid();
                txtBusqueda.Clear();
                MessageBox.Show("Miembro eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se encontró ningún miembro la busqueda {BuscarId}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento del botón Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (verificarBuscar() == false)
            {
                return;
            }

            MiembroExistente = buscarMiembro();

            string BuscarId = txtBusqueda.Text;

            if (MiembroExistente != null)
            {
                using (FormEditarMiembro formEditar = new FormEditarMiembro(MiembroExistente))
                {
                    if (formEditar.ShowDialog() == DialogResult.OK)
                    {
                        actualizarGrid();
                        txtBusqueda.Clear();
                        MessageBox.Show("El miembro ha sido editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show($"No se encontró ningún miembro con la busqueda {BuscarId}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento del botón Buscar (duplicado)
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (verificarBuscar() == false)
            {
                return;
            }
            string searchText = txtBusqueda.Text;

            MiembroExistente = buscarMiembro();
            if (MiembroExistente != null)
            {
                MessageBox.Show($"Se encontró el miembro con la busqueda {searchText}", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBusqueda.Clear();
            }
            else
            {
                MessageBox.Show($"No se encontro el miembro con la busqueda {searchText}.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento del botón Guardar Archivo
        private void btnGuardarArchivo_Click(object sender, EventArgs e)
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
                formatter.Serialize(stream, Lmiembros);
            }
            MessageBox.Show("Los datos se han guardado correctamente en el archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Evento del botón Leer Archivo (vacío)
        private void btnLeerArchivo_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region Metodos

        // Actualiza el DataGridView con la lista de miembros
        public void actualizarGrid()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Lmiembros;

            // Cambiar los nombres de las columnas
            dgvUsuarios.Columns["IDusuario"].HeaderText = "ID Usuario";
            dgvUsuarios.Columns["RolUsuario"].HeaderText = "Rol de Usuario";
            dgvUsuarios.Columns["CifCed"].HeaderText = "CIF/Cédula";
            dgvUsuarios.Columns["Nombre"].HeaderText = "Nombre";
            dgvUsuarios.Columns["Apellido"].HeaderText = "Apellido";
            dgvUsuarios.Columns["CodigoQR"].HeaderText = "Código QR";
            dgvUsuarios.Columns["Solvencia"].HeaderText = "Solvencia";
        }

        // Limpia los campos del formulario
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cmbRolUsuario.SelectedIndex = -1;
            cmbCifCed.SelectedIndex = -1;
            txtCifCed.Clear();

            // Calcular el próximo ID disponible y mostrarlo en el campo de texto de ID
            int nextId = Lmiembros.Count > 0 ? Lmiembros.Max(m => m.IDusuario) + 1 : 1;
            txtID.Text = nextId.ToString();
        }

        // Verifica que los campos de búsqueda no estén vacíos y que el ID sea un número entero
        public bool verificarBuscar()
        {
            if (string.IsNullOrEmpty(txtBusqueda.Text))
            {
                MessageBox.Show("El campo de busqueda no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (rbtnId.Checked)
            {
                if (!int.TryParse(txtBusqueda.Text, out _))
                {
                    MessageBox.Show("El ID debe ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        // Busca un miembro en la lista según el criterio seleccionado (ID o CIF/Cédula)
        public Miembro buscarMiembro()
        {
            if (rbtnCifCed.Checked)
            {
                string cifced = txtBusqueda.Text;
                Miembro Miembro = Lmiembros.FirstOrDefault(x => x.CifCed == cifced);
                return Miembro;
            }
            else
            {
                int id = int.Parse(txtBusqueda.Text);
                Miembro Miembro = Lmiembros.FirstOrDefault(x => x.IDusuario == id);
                return Miembro;
            }
        }

        // Evento de carga del formulario
        private void FormAdministrarUsua_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        // Evento de cambio de selección en el ComboBox de CIF/Cédula
        private void cmbCifCed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCifCed.Clear();
        }

        // Evento de cambio de texto en el campo de CIF/Cédula
        private void txtCifCed_TextChanged(object sender, EventArgs e)
        {
            if (cmbCifCed.SelectedItem == null)
            {
                return;
            }

            string selectedType = cmbCifCed.SelectedItem.ToString();
            int maxLength = selectedType == "CIF" ? 8 : 16;

            if (txtCifCed.Text.Length > maxLength)
            {
                txtCifCed.Text = txtCifCed.Text.Substring(0, maxLength);
                txtCifCed.SelectionStart = txtCifCed.Text.Length;
            }
        }

        // Formatea las celdas del DataGridView según el valor de la columna "Solvencia"
        private void dgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "Solvencia")
            {
                bool solvencia = (bool)e.Value;
                if (solvencia)
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        #endregion

        #region Botones sin Metodo

        // Evento de clic en el DataGridView (vacío)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Evento de cambio de texto en el campo de búsqueda (vacío)
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
        }

        // Evento de clic en el PictureBox (vacío)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        // Evento de clic en la etiqueta de búsqueda de usuario (vacío)
        private void lblBUsuario_Click(object sender, EventArgs e)
        {
        }

        // Evento de clic en la etiqueta de búsqueda de usuario (duplicado)
        private void lblBUsuario_Click_1(object sender, EventArgs e)
        {
        }

        // Evento de clic en la etiqueta de ID (vacío)
        private void lblID_Click(object sender, EventArgs e)
        {
        }

        // Evento de entrada en el grupo de registro (vacío)
        private void gbRegistro_Enter(object sender, EventArgs e)
        {
        }

        // Evento de clic en la etiqueta 1 (vacío)
        private void label1_Click(object sender, EventArgs e)
        {
        }
        #endregion
        // Verifica que los campos del formulario no estén vacíos
        public bool verificarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) ||
                cmbRolUsuario.SelectedIndex == -1 || string.IsNullOrEmpty(txtCifCed.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Evento de cambio de texto en el campo de ID (vacío)
        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
