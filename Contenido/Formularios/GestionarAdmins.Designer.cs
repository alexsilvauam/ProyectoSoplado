﻿namespace ProyectoSoplado_1._0_.Formularios
{
    partial class frmGestionarAdmins
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarAdmins));
            this.gbPanelControl = new System.Windows.Forms.GroupBox();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpLogin = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblCifCed = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.gbPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPanelControl
            // 
            this.gbPanelControl.Controls.Add(this.btnGuardarArchivo);
            this.gbPanelControl.Controls.Add(this.label1);
            this.gbPanelControl.Controls.Add(this.btnBuscar);
            this.gbPanelControl.Controls.Add(this.txtUsuario);
            this.gbPanelControl.Controls.Add(this.btnEliminar);
            this.gbPanelControl.Controls.Add(this.btnEditar);
            this.gbPanelControl.Location = new System.Drawing.Point(24, 39);
            this.gbPanelControl.Name = "gbPanelControl";
            this.gbPanelControl.Size = new System.Drawing.Size(219, 236);
            this.gbPanelControl.TabIndex = 28;
            this.gbPanelControl.TabStop = false;
            this.gbPanelControl.Text = "Panel de control";
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnGuardarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnGuardarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarArchivo.Location = new System.Drawing.Point(5, 173);
            this.btnGuardarArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(201, 31);
            this.btnGuardarArchivo.TabIndex = 5;
            this.btnGuardarArchivo.Text = "Guardar";
            this.btnGuardarArchivo.UseVisualStyleBackColor = false;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingrese Administrador:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Location = new System.Drawing.Point(39, 96);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(134, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Location = new System.Drawing.Point(39, 59);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(134, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Location = new System.Drawing.Point(39, 129);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 28);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnEditar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditar.Location = new System.Drawing.Point(111, 129);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(62, 28);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvAdmins
            // 
            this.dgvAdmins.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvAdmins.AllowUserToAddRows = false;
            this.dgvAdmins.AllowUserToDeleteRows = false;
            this.dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmins.Enabled = false;
            this.dgvAdmins.Location = new System.Drawing.Point(264, 30);
            this.dgvAdmins.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.RowHeadersWidth = 51;
            this.dgvAdmins.RowTemplate.Height = 24;
            this.dgvAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAdmins.Size = new System.Drawing.Size(402, 355);
            this.dgvAdmins.TabIndex = 26;
            this.dgvAdmins.TabStop = false;
            this.dgvAdmins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoSoplado_1._0_.Properties.Resources.administracion;
            this.pictureBox1.Location = new System.Drawing.Point(52, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // gpLogin
            // 
            this.gpLogin.Controls.Add(this.txtLogin);
            this.gpLogin.Controls.Add(this.btnLogin);
            this.gpLogin.Controls.Add(this.lblCifCed);
            this.gpLogin.Location = new System.Drawing.Point(249, 130);
            this.gpLogin.Name = "gpLogin";
            this.gpLogin.Size = new System.Drawing.Size(338, 145);
            this.gpLogin.TabIndex = 30;
            this.gpLogin.TabStop = false;
            this.gpLogin.Text = "Login";
            // 
            // lblCifCed
            // 
            this.lblCifCed.AutoSize = true;
            this.lblCifCed.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCifCed.Location = new System.Drawing.Point(65, 16);
            this.lblCifCed.Name = "lblCifCed";
            this.lblCifCed.Size = new System.Drawing.Size(74, 14);
            this.lblCifCed.TabIndex = 19;
            this.lblCifCed.Text = "Contraseña:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(68, 86);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(174, 33);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Desbloquear";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(68, 46);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '*';
            this.txtLogin.Size = new System.Drawing.Size(174, 20);
            this.txtLogin.TabIndex = 21;
            // 
            // frmGestionarAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 431);
            this.Controls.Add(this.gpLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbPanelControl);
            this.Controls.Add(this.dgvAdmins);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionarAdmins";
            this.Text = "Gestionar Admins";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionarAdmins_Load);
            this.gbPanelControl.ResumeLayout(false);
            this.gbPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpLogin.ResumeLayout(false);
            this.gpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPanelControl;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvAdmins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarArchivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblCifCed;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnLogin;
    }
}