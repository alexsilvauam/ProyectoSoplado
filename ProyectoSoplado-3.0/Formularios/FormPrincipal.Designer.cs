namespace ProyectoSoplado_1._0_.Formularios
{
    partial class FormPrincipal
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
            this.plLogo = new System.Windows.Forms.Panel();
            this.plAdmin = new System.Windows.Forms.Panel();
            this.plUsuario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblIngrese = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.plLogo.SuspendLayout();
            this.plAdmin.SuspendLayout();
            this.plUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // plLogo
            // 
            this.plLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.plLogo.Controls.Add(this.pictureBox2);
            this.plLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.plLogo.Location = new System.Drawing.Point(0, 0);
            this.plLogo.Name = "plLogo";
            this.plLogo.Size = new System.Drawing.Size(482, 113);
            this.plLogo.TabIndex = 0;
            // 
            // plAdmin
            // 
            this.plAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.plAdmin.Controls.Add(this.btnAdmin);
            this.plAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plAdmin.Location = new System.Drawing.Point(0, 511);
            this.plAdmin.Name = "plAdmin";
            this.plAdmin.Size = new System.Drawing.Size(482, 92);
            this.plAdmin.TabIndex = 1;
            this.plAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.plAdmin_Paint);
            // 
            // plUsuario
            // 
            this.plUsuario.BackColor = System.Drawing.Color.White;
            this.plUsuario.Controls.Add(this.button1);
            this.plUsuario.Controls.Add(this.btnMarcar);
            this.plUsuario.Controls.Add(this.txtUsuarioLogin);
            this.plUsuario.Controls.Add(this.lblIngrese);
            this.plUsuario.Controls.Add(this.panel1);
            this.plUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plUsuario.Location = new System.Drawing.Point(0, 113);
            this.plUsuario.Name = "plUsuario";
            this.plUsuario.Size = new System.Drawing.Size(482, 398);
            this.plUsuario.TabIndex = 2;
            this.plUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.plUsuario_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 398);
            this.panel1.TabIndex = 0;
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
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(482, 34);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Soy un administrador.";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.Location = new System.Drawing.Point(240, 101);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(119, 16);
            this.lblIngrese.TabIndex = 1;
            this.lblIngrese.Text = "Ingrese su Usuario";
            this.lblIngrese.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProyectoSoplado_1._0_.Properties.Resources.asistencia_icono1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(243, 133);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(210, 22);
            this.txtUsuarioLogin.TabIndex = 2;
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(243, 179);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(210, 23);
            this.btnMarcar.TabIndex = 3;
            this.btnMarcar.Text = "Marcar Asistencia";
            this.btnMarcar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Escanear codigo de Barras";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::ProyectoSoplado_1._0_.Properties.Resources._71732;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(482, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 603);
            this.Controls.Add(this.plUsuario);
            this.Controls.Add(this.plAdmin);
            this.Controls.Add(this.plLogo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 650);
            this.Name = "FormPrincipal";
            this.Text = "Sistema Jaguar";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.plLogo.ResumeLayout(false);
            this.plAdmin.ResumeLayout(false);
            this.plUsuario.ResumeLayout(false);
            this.plUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plLogo;
        private System.Windows.Forms.Panel plAdmin;
        private System.Windows.Forms.Panel plUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblIngrese;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMarcar;
    }
}