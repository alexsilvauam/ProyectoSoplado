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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.plLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(89, 144);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(95, 14);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "Introduzca su ID";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontraseña.Location = new System.Drawing.Point(92, 227);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(189, 20);
            this.txtcontraseña.TabIndex = 21;
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
            this.btnIngresar.Location = new System.Drawing.Point(92, 264);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(189, 34);
            this.btnIngresar.TabIndex = 19;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreUsuario.Location = new System.Drawing.Point(92, 169);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(189, 20);
            this.txtNombreUsuario.TabIndex = 18;
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 95);
            this.panel1.TabIndex = 25;
            // 
            // FormIniciarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plLogo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtNombreUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIniciarAdmin";
            this.Text = "Iniciar Admin";
            this.Load += new System.EventHandler(this.FormIniciarAdmin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.plLogo.ResumeLayout(false);
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
    }
}