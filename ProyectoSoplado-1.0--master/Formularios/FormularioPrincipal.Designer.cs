namespace ProyectoSoplado_1._0_
{
    partial class FormularioPrincipal
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContenedorHijos = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PbUAMLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            this.panelContenedorHijos.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUAMLogo)).BeginInit();
            this.SuspendLayout();
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
            // 
            // panelContenedorHijos
            // 
            this.panelContenedorHijos.AutoSize = true;
            this.panelContenedorHijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panelContenedorHijos.Controls.Add(this.pictureBox1);
            this.panelContenedorHijos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorHijos.Location = new System.Drawing.Point(312, 0);
            this.panelContenedorHijos.Name = "panelContenedorHijos";
            this.panelContenedorHijos.Size = new System.Drawing.Size(670, 753);
            this.panelContenedorHijos.TabIndex = 8;
            this.panelContenedorHijos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorHijos_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnUsuario);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(312, 753);
            this.panelMenu.TabIndex = 7;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuario.Location = new System.Drawing.Point(0, 337);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUsuario.Size = new System.Drawing.Size(312, 57);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "Ingresar Asistencia";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ProyectoSoplado_1._0_.Properties.Resources.universidad_americana_2020;
            this.pictureBox1.Location = new System.Drawing.Point(109, 250);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(480, 171);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(480, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 394);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(312, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Modo Administrador";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.panelContenedorHijos);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormularioPrincipal";
            this.ShowInTaskbar = false;
            this.Text = "Acceso al gimnasio";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelContenedorHijos.ResumeLayout(false);
            this.panelContenedorHijos.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUAMLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PbUAMLogo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContenedorHijos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button button1;
    }
}