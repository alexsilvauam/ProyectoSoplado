namespace ProyectoSoplado_1._0_
{
    partial class FormAdmin
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.panelReportes = new System.Windows.Forms.Panel();
            this.btnRepSolvencia = new System.Windows.Forms.Button();
            this.btnRepAsistencia = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.btnVerSolvencia = new System.Windows.Forms.Button();
            this.btnAdmUsuarios = new System.Windows.Forms.Button();
            this.btnRegUsuarios = new System.Windows.Forms.Button();
            this.btnPanelUsuarios = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.PbUAMLogo = new System.Windows.Forms.PictureBox();
            this.panelContenedorHijos = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelReportes.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUAMLogo)).BeginInit();
            this.panelContenedorHijos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.panelMenu.Controls.Add(this.lblAviso);
            this.panelMenu.Controls.Add(this.panelReportes);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.panelUsuarios);
            this.panelMenu.Controls.Add(this.btnPanelUsuarios);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(312, 761);
            this.panelMenu.TabIndex = 5;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAviso.Location = new System.Drawing.Point(0, 744);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(279, 17);
            this.lblAviso.TabIndex = 4;
            this.lblAviso.Text = "Actualmente estas en modo Administrador*";
            this.lblAviso.Click += new System.EventHandler(this.lblAviso_Click);
            // 
            // panelReportes
            // 
            this.panelReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelReportes.Controls.Add(this.btnRepSolvencia);
            this.panelReportes.Controls.Add(this.btnRepAsistencia);
            this.panelReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportes.Location = new System.Drawing.Point(0, 611);
            this.panelReportes.Name = "panelReportes";
            this.panelReportes.Size = new System.Drawing.Size(312, 111);
            this.panelReportes.TabIndex = 4;
            // 
            // btnRepSolvencia
            // 
            this.btnRepSolvencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRepSolvencia.FlatAppearance.BorderSize = 0;
            this.btnRepSolvencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepSolvencia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRepSolvencia.Location = new System.Drawing.Point(0, 50);
            this.btnRepSolvencia.Name = "btnRepSolvencia";
            this.btnRepSolvencia.Padding = new System.Windows.Forms.Padding(43, 0, 0, 0);
            this.btnRepSolvencia.Size = new System.Drawing.Size(312, 50);
            this.btnRepSolvencia.TabIndex = 1;
            this.btnRepSolvencia.Text = "Reportes de solvencia";
            this.btnRepSolvencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepSolvencia.UseVisualStyleBackColor = true;
            this.btnRepSolvencia.Click += new System.EventHandler(this.btnRepSolvencia_Click);
            // 
            // btnRepAsistencia
            // 
            this.btnRepAsistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRepAsistencia.FlatAppearance.BorderSize = 0;
            this.btnRepAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepAsistencia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRepAsistencia.Location = new System.Drawing.Point(0, 0);
            this.btnRepAsistencia.Name = "btnRepAsistencia";
            this.btnRepAsistencia.Padding = new System.Windows.Forms.Padding(43, 0, 0, 0);
            this.btnRepAsistencia.Size = new System.Drawing.Size(312, 50);
            this.btnRepAsistencia.TabIndex = 0;
            this.btnRepAsistencia.Text = "Reportes de asistencia";
            this.btnRepAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepAsistencia.UseVisualStyleBackColor = true;
            this.btnRepAsistencia.Click += new System.EventHandler(this.btnRepAsistencia_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportes.Location = new System.Drawing.Point(0, 554);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(312, 57);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelUsuarios.Controls.Add(this.btnVerSolvencia);
            this.panelUsuarios.Controls.Add(this.btnAdmUsuarios);
            this.panelUsuarios.Controls.Add(this.btnRegUsuarios);
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuarios.Location = new System.Drawing.Point(0, 394);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(312, 160);
            this.panelUsuarios.TabIndex = 2;
            this.panelUsuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnVerSolvencia
            // 
            this.btnVerSolvencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerSolvencia.FlatAppearance.BorderSize = 0;
            this.btnVerSolvencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSolvencia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerSolvencia.Location = new System.Drawing.Point(0, 100);
            this.btnVerSolvencia.Name = "btnVerSolvencia";
            this.btnVerSolvencia.Padding = new System.Windows.Forms.Padding(43, 0, 0, 0);
            this.btnVerSolvencia.Size = new System.Drawing.Size(312, 50);
            this.btnVerSolvencia.TabIndex = 2;
            this.btnVerSolvencia.Text = "Verificacion de solvencia";
            this.btnVerSolvencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerSolvencia.UseVisualStyleBackColor = true;
            this.btnVerSolvencia.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAdmUsuarios
            // 
            this.btnAdmUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmUsuarios.FlatAppearance.BorderSize = 0;
            this.btnAdmUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmUsuarios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdmUsuarios.Location = new System.Drawing.Point(0, 50);
            this.btnAdmUsuarios.Name = "btnAdmUsuarios";
            this.btnAdmUsuarios.Padding = new System.Windows.Forms.Padding(43, 0, 0, 0);
            this.btnAdmUsuarios.Size = new System.Drawing.Size(312, 50);
            this.btnAdmUsuarios.TabIndex = 1;
            this.btnAdmUsuarios.Text = "Administrar Usuarios";
            this.btnAdmUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmUsuarios.UseVisualStyleBackColor = true;
            this.btnAdmUsuarios.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRegUsuarios
            // 
            this.btnRegUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegUsuarios.FlatAppearance.BorderSize = 0;
            this.btnRegUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegUsuarios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnRegUsuarios.Name = "btnRegUsuarios";
            this.btnRegUsuarios.Padding = new System.Windows.Forms.Padding(43, 0, 0, 0);
            this.btnRegUsuarios.Size = new System.Drawing.Size(312, 50);
            this.btnRegUsuarios.TabIndex = 0;
            this.btnRegUsuarios.Text = "Registrar Usuarios";
            this.btnRegUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegUsuarios.UseVisualStyleBackColor = true;
            this.btnRegUsuarios.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPanelUsuarios
            // 
            this.btnPanelUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanelUsuarios.FlatAppearance.BorderSize = 0;
            this.btnPanelUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPanelUsuarios.Location = new System.Drawing.Point(0, 337);
            this.btnPanelUsuarios.Name = "btnPanelUsuarios";
            this.btnPanelUsuarios.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPanelUsuarios.Size = new System.Drawing.Size(312, 57);
            this.btnPanelUsuarios.TabIndex = 1;
            this.btnPanelUsuarios.Text = "Panel Usuarios";
            this.btnPanelUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelUsuarios.UseVisualStyleBackColor = true;
            this.btnPanelUsuarios.Click += new System.EventHandler(this.btnPanelUsuarios_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.panelLogo.Controls.Add(this.PbUAMLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(312, 337);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PlLogo_Paint);
            // 
            // PbUAMLogo
            // 
            this.PbUAMLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PbUAMLogo.Image = global::ProyectoSoplado_1._0_.Properties.Resources._71732;
            this.PbUAMLogo.Location = new System.Drawing.Point(18, 7);
            this.PbUAMLogo.Margin = new System.Windows.Forms.Padding(7);
            this.PbUAMLogo.Name = "PbUAMLogo";
            this.PbUAMLogo.Size = new System.Drawing.Size(280, 281);
            this.PbUAMLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbUAMLogo.TabIndex = 3;
            this.PbUAMLogo.TabStop = false;
            this.PbUAMLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelContenedorHijos
            // 
            this.panelContenedorHijos.AutoSize = true;
            this.panelContenedorHijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panelContenedorHijos.Controls.Add(this.pictureBox1);
            this.panelContenedorHijos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorHijos.Location = new System.Drawing.Point(312, 0);
            this.panelContenedorHijos.Name = "panelContenedorHijos";
            this.panelContenedorHijos.Size = new System.Drawing.Size(672, 761);
            this.panelContenedorHijos.TabIndex = 6;
            this.panelContenedorHijos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ProyectoSoplado_1._0_.Properties.Resources.universidad_americana_2020;
            this.pictureBox1.Location = new System.Drawing.Point(110, 295);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(480, 171);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(480, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(206)))), ((int)(((byte)(214)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(312, 661);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 100);
            this.panel1.TabIndex = 7;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedorHijos);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "FormAdmin";
            this.Text = "Modo Administrador";
            this.Load += new System.EventHandler(this.FormAdmin_Load_1);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelReportes.ResumeLayout(false);
            this.panelUsuarios.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbUAMLogo)).EndInit();
            this.panelContenedorHijos.ResumeLayout(false);
            this.panelContenedorHijos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox PbUAMLogo;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Button btnPanelUsuarios;
        private System.Windows.Forms.Button btnVerSolvencia;
        private System.Windows.Forms.Button btnAdmUsuarios;
        private System.Windows.Forms.Button btnRegUsuarios;
        private System.Windows.Forms.Panel panelReportes;
        private System.Windows.Forms.Button btnRepSolvencia;
        private System.Windows.Forms.Button btnRepAsistencia;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Panel panelContenedorHijos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}