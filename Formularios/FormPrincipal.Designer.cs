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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.plAdmin = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.plUsuario = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.lblIngrese = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQR = new System.Windows.Forms.Label();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.btncodigoQr = new System.Windows.Forms.Button();
            this.btnIngresarconusuario = new System.Windows.Forms.Button();
            this.plLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.plAdmin.SuspendLayout();
            this.plUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plLogo
            // 
            this.plLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.plLogo.Controls.Add(this.pictureBox2);
            this.plLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.plLogo.Location = new System.Drawing.Point(0, 0);
            this.plLogo.Margin = new System.Windows.Forms.Padding(2);
            this.plLogo.Name = "plLogo";
            this.plLogo.Size = new System.Drawing.Size(363, 92);
            this.plLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::ProyectoSoplado_1._0_.Properties.Resources._71732;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(363, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // plAdmin
            // 
            this.plAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.plAdmin.Controls.Add(this.btnAdmin);
            this.plAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plAdmin.Location = new System.Drawing.Point(0, 421);
            this.plAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.plAdmin.Name = "plAdmin";
            this.plAdmin.Size = new System.Drawing.Size(363, 75);
            this.plAdmin.TabIndex = 1;
            this.plAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.plAdmin_Paint);
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
            this.btnAdmin.Size = new System.Drawing.Size(363, 28);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Soy un administrador.";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // plUsuario
            // 
            this.plUsuario.BackColor = System.Drawing.Color.White;
            this.plUsuario.Controls.Add(this.btnIngresarconusuario);
            this.plUsuario.Controls.Add(this.btncodigoQr);
            this.plUsuario.Controls.Add(this.txtQR);
            this.plUsuario.Controls.Add(this.lblQR);
            this.plUsuario.Controls.Add(this.button1);
            this.plUsuario.Controls.Add(this.btnMarcar);
            this.plUsuario.Controls.Add(this.txtUsuarioLogin);
            this.plUsuario.Controls.Add(this.lblIngrese);
            this.plUsuario.Controls.Add(this.panel1);
            this.plUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plUsuario.Location = new System.Drawing.Point(0, 92);
            this.plUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.plUsuario.Name = "plUsuario";
            this.plUsuario.Size = new System.Drawing.Size(363, 329);
            this.plUsuario.TabIndex = 2;
            this.plUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.plUsuario_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.button1.Location = new System.Drawing.Point(182, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Escanear codigo de Barras";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnMarcar
            // 
            this.btnMarcar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnMarcar.Location = new System.Drawing.Point(182, 145);
            this.btnMarcar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(158, 29);
            this.btnMarcar.TabIndex = 3;
            this.btnMarcar.Text = "Marcar Asistencia";
            this.btnMarcar.UseVisualStyleBackColor = false;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioLogin.Location = new System.Drawing.Point(181, 111);
            this.txtUsuarioLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(158, 20);
            this.txtUsuarioLogin.TabIndex = 2;
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrese.Location = new System.Drawing.Point(180, 82);
            this.lblIngrese.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(97, 15);
            this.lblIngrese.TabIndex = 1;
            this.lblIngrese.Text = "Ingrese su nombre.";
            this.lblIngrese.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 329);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProyectoSoplado_1._0_.Properties.Resources.asistencia_icono1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblQR
            // 
            this.lblQR.AutoSize = true;
            this.lblQR.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQR.Location = new System.Drawing.Point(180, 84);
            this.lblQR.Name = "lblQR";
            this.lblQR.Size = new System.Drawing.Size(73, 15);
            this.lblQR.TabIndex = 5;
            this.lblQR.Text = "Ingresa tu QR:";
            this.lblQR.Visible = false;
            // 
            // txtQR
            // 
            this.txtQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQR.Location = new System.Drawing.Point(182, 102);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(157, 20);
            this.txtQR.TabIndex = 6;
            this.txtQR.Visible = false;
            // 
            // btncodigoQr
            // 
            this.btncodigoQr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btncodigoQr.Location = new System.Drawing.Point(184, 145);
            this.btncodigoQr.Name = "btncodigoQr";
            this.btncodigoQr.Size = new System.Drawing.Size(156, 31);
            this.btncodigoQr.TabIndex = 7;
            this.btncodigoQr.Text = "Ingresar";
            this.btncodigoQr.UseVisualStyleBackColor = false;
            this.btncodigoQr.Visible = false;
            this.btncodigoQr.Click += new System.EventHandler(this.btncodigoQr_Click);
            // 
            // btnIngresarconusuario
            // 
            this.btnIngresarconusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnIngresarconusuario.Location = new System.Drawing.Point(183, 197);
            this.btnIngresarconusuario.Name = "btnIngresarconusuario";
            this.btnIngresarconusuario.Size = new System.Drawing.Size(157, 31);
            this.btnIngresarconusuario.TabIndex = 8;
            this.btnIngresarconusuario.Text = "Ingresar con nombre";
            this.btnIngresarconusuario.UseVisualStyleBackColor = false;
            this.btnIngresarconusuario.Visible = false;
            this.btnIngresarconusuario.Click += new System.EventHandler(this.btnIngresarconusuario_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 496);
            this.Controls.Add(this.plUsuario);
            this.Controls.Add(this.plAdmin);
            this.Controls.Add(this.plLogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(379, 535);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(379, 535);
            this.Name = "FormPrincipal";
            this.Text = "Sistema Jaguar";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.plLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.plAdmin.ResumeLayout(false);
            this.plUsuario.ResumeLayout(false);
            this.plUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btncodigoQr;
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.Label lblQR;
        private System.Windows.Forms.Button btnIngresarconusuario;
    }
}