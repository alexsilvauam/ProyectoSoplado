namespace ProyectoSoplado_1._0_
{
    partial class FormRegistroEntrada
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

        private void InitializeComponent()
        {
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnScanCodigoBarra = new System.Windows.Forms.Button();
            this.txtUsuarioEntrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(18, 28);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(121, 13);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "ID o Nombre de Usuario";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(20, 68);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(172, 34);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar Entrada";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // btnScanCodigoBarra
            // 
            this.btnScanCodigoBarra.Location = new System.Drawing.Point(20, 107);
            this.btnScanCodigoBarra.Name = "btnScanCodigoBarra";
            this.btnScanCodigoBarra.Size = new System.Drawing.Size(171, 33);
            this.btnScanCodigoBarra.TabIndex = 6;
            this.btnScanCodigoBarra.Text = "Escanear con código de barra";
            this.btnScanCodigoBarra.UseVisualStyleBackColor = true;
            this.btnScanCodigoBarra.Click += new System.EventHandler(this.buttonEscanear_Click);
            // 
            // txtUsuarioEntrada
            // 
            this.txtUsuarioEntrada.Location = new System.Drawing.Point(20, 44);
            this.txtUsuarioEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioEntrada.Name = "txtUsuarioEntrada";
            this.txtUsuarioEntrada.Size = new System.Drawing.Size(173, 20);
            this.txtUsuarioEntrada.TabIndex = 3;
            // 
            // FormRegistroEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 165);
            this.Controls.Add(this.btnScanCodigoBarra);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtUsuarioEntrada);
            this.Controls.Add(this.lblUserID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRegistroEntrada";
            this.Text = "FormRegistroEntrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnScanCodigoBarra;
        private System.Windows.Forms.TextBox txtUsuarioEntrada;
    }
}