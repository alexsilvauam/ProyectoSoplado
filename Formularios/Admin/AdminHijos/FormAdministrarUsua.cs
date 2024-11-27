using ProyectoSoplado_1._0_.Modelo_de_datos.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoplado_1._0_.Formularios.Admin
{

    public partial class FormAdministrarUsua : Form
    {
        public static List<Miembro> Lmiembros = new List<Miembro>();

        public FormAdministrarUsua()
        {
            InitializeComponent();
            dgvUsuarios.CellFormatting += dgvUsuarios_CellFormatting;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void lblBUsuario_Click(object sender, EventArgs e)
        {

        }

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
     
            int id = int.Parse(txtID.Text);

            Random random = new Random();
            int codigoQR = random.Next(1, 1000); 
           

            Lmiembros.Add(new Miembro(id, rolUsuario, nombre, apellido,codigoQR, cifCed));

            actualizarGrid();
            LimpiarCampos();
            MessageBox.Show("Miembro agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public bool verificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo Apellido no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("El campo ID no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtID.Text, out _))
            {
                MessageBox.Show("El campo ID debe ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbRolUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un rol de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbCifCed.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una opción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCifCed.Text))
            {
                MessageBox.Show("El campo CIF/Cédula no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string selectedType = cmbCifCed.SelectedItem.ToString();
            int maxLength = selectedType == "CIF" ? 8 : 16;

            if (txtCifCed.Text.Length != maxLength)
            {
                MessageBox.Show($"El campo {selectedType} debe tener {maxLength} caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (Miembro e in Lmiembros)
            {
                if (Convert.ToInt16(txtID.Text) == e.IDusuario)
                {
                    MessageBox.Show("No puedes repetir un ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }


        public void actualizarGrid()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Lmiembros;
        }
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cmbRolUsuario.SelectedIndex = -1;
            cmbCifCed.SelectedIndex = -1;
            txtID.Clear();
        }

        public bool verificarBuscar()
        {
            if (string.IsNullOrEmpty(txtBusqueda.Text))
            {
                MessageBox.Show("El campo ID no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtBusqueda.Text, out _))
            {
                MessageBox.Show("El campo ID debe ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (verificarBuscar() == false)
            {
                return;
            }

            int BuscarId = int.Parse(txtBusqueda.Text);

            Miembro MiembroExistente = Lmiembros.FirstOrDefault(x => x.IDusuario == BuscarId);
            if (MiembroExistente != null)
            {
                Lmiembros.Remove(MiembroExistente);
                actualizarGrid();
                txtBusqueda.Clear();
                MessageBox.Show("Miembro eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show($"No se encontró ningún miembro con el ID {BuscarId}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (verificarBuscar() == false)
            {
                return;
            }

            int BuscarId = int.Parse(txtBusqueda.Text);

            Miembro MiembroExistente = Lmiembros.FirstOrDefault(x => x.IDusuario == BuscarId);
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
                MessageBox.Show($"No se encontró ningún miembro con el ID {BuscarId}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (verificarBuscar() == false)
            {
                return;
            }
            int searchText = int.Parse(txtBusqueda.Text);
            Miembro MiembroExistente = Lmiembros.FirstOrDefault(x => x.IDusuario == searchText);
            if (MiembroExistente != null)
            {
                MessageBox.Show($"Se encontró el miembro con el ID {searchText}", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBusqueda.Clear();
            }
            else
            {
                MessageBox.Show($"El usuario {searchText} no ha sido encontrado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAdministrarUsua_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void lblBUsuario_Click_1(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void gbRegistro_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCifCed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCifCed.Clear();

        }

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
    }
}
