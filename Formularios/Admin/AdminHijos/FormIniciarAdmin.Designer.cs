namespace ProyectoSoplado_1._0_
{
   partial class FormIniciarAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIniciarAdmin));
            this.lblID = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.plLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnNuevoAdmin = new System.Windows.Forms.Button();
            this.lblPIN = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnRegistrarAdm = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.plLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(89, 144);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(191, 14);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "Introduzca su nombre de usuario";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontraseña.Location = new System.Drawing.Point(92, 227);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(189, 20);
            this.txtcontraseña.TabIndex = 2;
            this.txtcontraseña.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(89, 206);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(71, 14);
            this.lblContraseña.TabIndex = 20;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click_1);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnIngresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Transparent;
            this.btnIngresar.Location = new System.Drawing.Point(92, 251);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(189, 34);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreUsuario.Location = new System.Drawing.Point(92, 169);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(189, 20);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreUsuario_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoSoplado_1._0_.Properties.Resources._71732;
            this.pictureBox2.Location = new System.Drawing.Point(113, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // plLogo
            // 
            this.plLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.plLogo.Controls.Add(this.pictureBox2);
            this.plLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.plLogo.Location = new System.Drawing.Point(0, 0);
            this.plLogo.Margin = new System.Windows.Forms.Padding(2);
            this.plLogo.Name = "plLogo";
            this.plLogo.Size = new System.Drawing.Size(364, 92);
            this.plLogo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 86);
            this.panel1.TabIndex = 25;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(364, 28);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Cancelar";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnNuevoAdmin
            // 
            this.btnNuevoAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.btnNuevoAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoAdmin.FlatAppearance.BorderSize = 0;
            this.btnNuevoAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAdmin.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNuevoAdmin.Location = new System.Drawing.Point(0, 92);
            this.btnNuevoAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoAdmin.Name = "btnNuevoAdmin";
            this.btnNuevoAdmin.Size = new System.Drawing.Size(364, 28);
            this.btnNuevoAdmin.TabIndex = 26;
            this.btnNuevoAdmin.Text = "¿Nuevo administrador?";
            this.btnNuevoAdmin.UseVisualStyleBackColor = false;
            this.btnNuevoAdmin.Click += new System.EventHandler(this.btnNuevoAdmin_Click);
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIN.Location = new System.Drawing.Point(89, 260);
            this.lblPIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(147, 14);
            this.lblPIN.TabIndex = 27;
            this.lblPIN.Text = "Digite el PIN de seguridad";
            this.lblPIN.Visible = false;
            this.lblPIN.Click += new System.EventHandler(this.lblPIN_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPIN.Location = new System.Drawing.Point(91, 276);
            this.txtPIN.Margin = new System.Windows.Forms.Padding(2);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.PasswordChar = '*';
            this.txtPIN.Size = new System.Drawing.Size(189, 20);
            this.txtPIN.TabIndex = 28;
            this.txtPIN.Visible = false;
            this.txtPIN.TextChanged += new System.EventHandler(this.txtPIN_TextChanged);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(11, 391);
            this.lblNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(326, 14);
            this.lblNota.TabIndex = 29;
            this.lblNota.Text = "Nota: Puede solicitar el PIN en la coordinación de deportes";
            this.lblNota.Visible = false;
            // 
            // btnRegistrarAdm
            // 
            this.btnRegistrarAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnRegistrarAdm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAdm.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrarAdm.Location = new System.Drawing.Point(91, 300);
            this.btnRegistrarAdm.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarAdm.Name = "btnRegistrarAdm";
            this.btnRegistrarAdm.Size = new System.Drawing.Size(189, 34);
            this.btnRegistrarAdm.TabIndex = 30;
            this.btnRegistrarAdm.Text = "Registrar";
            this.btnRegistrarAdm.UseVisualStyleBackColor = false;
            this.btnRegistrarAdm.Visible = false;
            this.btnRegistrarAdm.Click += new System.EventHandler(this.btnRegistrarAdm_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnVolver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolver.Location = new System.Drawing.Point(91, 338);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(189, 34);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormIniciarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 493);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistrarAdm);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.lblPIN);
            this.Controls.Add(this.btnNuevoAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plLogo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIniciarAdmin";
            this.Text = "Iniciar Admin";
            this.Load += new System.EventHandler(this.FormIniciarAdmin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.plLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel plLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnNuevoAdmin;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnRegistrarAdm;
        private System.Windows.Forms.Button btnVolver;
    }
}