namespace ProyectoSoplado_1._0_.Formularios.Admin
{
    partial class FormAdministrarUsua
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrarUsua));
            this.gbPanelControl = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBUsuario = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.txtCifCed = new System.Windows.Forms.TextBox();
            this.cmbCifCed = new System.Windows.Forms.ComboBox();
            this.lblCifCed = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.cmbRolUsuario = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRolUsua = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbPanelControl.SuspendLayout();
            this.gbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPanelControl
            // 
            this.gbPanelControl.Controls.Add(this.btnBuscar);
            this.gbPanelControl.Controls.Add(this.lblBUsuario);
            this.gbPanelControl.Controls.Add(this.txtBusqueda);
            this.gbPanelControl.Controls.Add(this.btnEliminar);
            this.gbPanelControl.Controls.Add(this.btnEditar);
            this.gbPanelControl.Location = new System.Drawing.Point(29, 45);
            this.gbPanelControl.Name = "gbPanelControl";
            this.gbPanelControl.Size = new System.Drawing.Size(199, 162);
            this.gbPanelControl.TabIndex = 25;
            this.gbPanelControl.TabStop = false;
            this.gbPanelControl.Text = "Panel de control";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnBuscar.Location = new System.Drawing.Point(34, 68);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(134, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lblBUsuario
            // 
            this.lblBUsuario.AutoSize = true;
            this.lblBUsuario.Location = new System.Drawing.Point(14, 32);
            this.lblBUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBUsuario.Name = "lblBUsuario";
            this.lblBUsuario.Size = new System.Drawing.Size(19, 13);
            this.lblBUsuario.TabIndex = 0;
            this.lblBUsuario.Text = "Id:";
            this.lblBUsuario.Click += new System.EventHandler(this.lblBUsuario_Click_1);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(34, 30);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(134, 20);
            this.txtBusqueda.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnEliminar.Location = new System.Drawing.Point(34, 101);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 28);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnEditar.Location = new System.Drawing.Point(106, 101);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(62, 28);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.txtCifCed);
            this.gbRegistro.Controls.Add(this.cmbCifCed);
            this.gbRegistro.Controls.Add(this.lblCifCed);
            this.gbRegistro.Controls.Add(this.lblApellido);
            this.gbRegistro.Controls.Add(this.cmbRolUsuario);
            this.gbRegistro.Controls.Add(this.lblNombre);
            this.gbRegistro.Controls.Add(this.lblRolUsua);
            this.gbRegistro.Controls.Add(this.txtNombre);
            this.gbRegistro.Controls.Add(this.btnRegistrar);
            this.gbRegistro.Controls.Add(this.txtApellido);
            this.gbRegistro.Controls.Add(this.txtID);
            this.gbRegistro.Controls.Add(this.lblID);
            this.gbRegistro.Location = new System.Drawing.Point(4, 228);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(251, 276);
            this.gbRegistro.TabIndex = 24;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registro";
            this.gbRegistro.Enter += new System.EventHandler(this.gbRegistro_Enter);
            // 
            // txtCifCed
            // 
            this.txtCifCed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCifCed.Location = new System.Drawing.Point(90, 164);
            this.txtCifCed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCifCed.Name = "txtCifCed";
            this.txtCifCed.Size = new System.Drawing.Size(148, 20);
            this.txtCifCed.TabIndex = 21;
            this.txtCifCed.TextChanged += new System.EventHandler(this.txtCifCed_TextChanged);
            // 
            // cmbCifCed
            // 
            this.cmbCifCed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCifCed.FormattingEnabled = true;
            this.cmbCifCed.Items.AddRange(new object[] {
            "CIF",
            "Cedula"});
            this.cmbCifCed.Location = new System.Drawing.Point(88, 127);
            this.cmbCifCed.Name = "cmbCifCed";
            this.cmbCifCed.Size = new System.Drawing.Size(150, 21);
            this.cmbCifCed.TabIndex = 19;
            this.cmbCifCed.SelectedIndexChanged += new System.EventHandler(this.cmbCifCed_SelectedIndexChanged);
            // 
            // lblCifCed
            // 
            this.lblCifCed.AutoSize = true;
            this.lblCifCed.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCifCed.Location = new System.Drawing.Point(6, 130);
            this.lblCifCed.Name = "lblCifCed";
            this.lblCifCed.Size = new System.Drawing.Size(68, 14);
            this.lblCifCed.TabIndex = 18;
            this.lblCifCed.Text = "CIF/Cedula:";
            this.lblCifCed.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblApellido.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(22, 93);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(55, 14);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido:";
            // 
            // cmbRolUsuario
            // 
            this.cmbRolUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRolUsuario.FormattingEnabled = true;
            this.cmbRolUsuario.Items.AddRange(new object[] {
            "Estudiante",
            "Colaborador",
            "Externo"});
            this.cmbRolUsuario.Location = new System.Drawing.Point(88, 189);
            this.cmbRolUsuario.Name = "cmbRolUsuario";
            this.cmbRolUsuario.Size = new System.Drawing.Size(150, 21);
            this.cmbRolUsuario.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(22, 59);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 14);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRolUsua
            // 
            this.lblRolUsua.AutoSize = true;
            this.lblRolUsua.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolUsua.Location = new System.Drawing.Point(4, 189);
            this.lblRolUsua.Name = "lblRolUsua";
            this.lblRolUsua.Size = new System.Drawing.Size(72, 14);
            this.lblRolUsua.TabIndex = 16;
            this.lblRolUsua.Text = "Rol Usuario:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(87, 57);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(26, 215);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(212, 31);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Location = new System.Drawing.Point(87, 90);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(150, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(87, 18);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 20);
            this.txtID.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(56, 20);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 14);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID:";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(278, 62);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(464, 355);
            this.dgvUsuarios.TabIndex = 23;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // FormAdministrarUsua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 516);
            this.Controls.Add(this.gbPanelControl);
            this.Controls.Add(this.gbRegistro);
            this.Controls.Add(this.dgvUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdministrarUsua";
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.FormAdministrarUsua_Load);
            this.gbPanelControl.ResumeLayout(false);
            this.gbPanelControl.PerformLayout();
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbPanelControl;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBUsuario;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ComboBox cmbRolUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRolUsua;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ComboBox cmbCifCed;
        private System.Windows.Forms.Label lblCifCed;
        private System.Windows.Forms.TextBox txtCifCed;
    }
}
