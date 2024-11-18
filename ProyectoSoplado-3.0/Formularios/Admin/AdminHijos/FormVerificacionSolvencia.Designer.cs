namespace ProyectoSoplado_1._0_
{
    partial class FormVerificacionSolvencia
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(29, 19);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(152, 16);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "ID o Nombre de Usuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(32, 78);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(229, 23);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar Solvencia";
            this.btnVerificar.UseVisualStyleBackColor = true;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(32, 123);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(229, 29);
            this.btnCargarDatos.TabIndex = 3;
            this.btnCargarDatos.Text = "Cargar Datos de Pago";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            // 
            // FormVerificacionSolvencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 187);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUserID);
            this.Name = "FormVerificacionSolvencia";
            this.Text = "FormVerificacionSolvencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnCargarDatos;
    }
}