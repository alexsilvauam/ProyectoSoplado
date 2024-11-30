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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerificacionSolvencia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIdMiembro = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIDverificar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdMiembro = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtmontopago = new System.Windows.Forms.TextBox();
            this.txtIdpago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtFechaVencimieto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.cmbModalidad = new System.Windows.Forms.ComboBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIdMiembro);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtIDverificar);
            this.groupBox1.Location = new System.Drawing.Point(23, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 153);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verificar Solvencia";
            // 
            // lblIdMiembro
            // 
            this.lblIdMiembro.AutoSize = true;
            this.lblIdMiembro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMiembro.Location = new System.Drawing.Point(28, 34);
            this.lblIdMiembro.Name = "lblIdMiembro";
            this.lblIdMiembro.Size = new System.Drawing.Size(91, 14);
            this.lblIdMiembro.TabIndex = 10;
            this.lblIdMiembro.Text = "ID de miembro:";
            this.lblIdMiembro.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(129, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(146, 30);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Verificar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIDverificar
            // 
            this.txtIDverificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDverificar.Location = new System.Drawing.Point(129, 32);
            this.txtIDverificar.Name = "txtIDverificar";
            this.txtIDverificar.Size = new System.Drawing.Size(146, 20);
            this.txtIDverificar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "Monto de pago:";
            // 
            // txtIdMiembro
            // 
            this.txtIdMiembro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdMiembro.Location = new System.Drawing.Point(154, 22);
            this.txtIdMiembro.Name = "txtIdMiembro";
            this.txtIdMiembro.Size = new System.Drawing.Size(152, 20);
            this.txtIdMiembro.TabIndex = 1;
            this.txtIdMiembro.TextChanged += new System.EventHandler(this.txtIdMiembro_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(155, 213);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 31);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Registrar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtmontopago
            // 
            this.txtmontopago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmontopago.Enabled = false;
            this.txtmontopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontopago.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtmontopago.Location = new System.Drawing.Point(155, 187);
            this.txtmontopago.Name = "txtmontopago";
            this.txtmontopago.ReadOnly = true;
            this.txtmontopago.Size = new System.Drawing.Size(152, 20);
            this.txtmontopago.TabIndex = 4;
            this.txtmontopago.TextChanged += new System.EventHandler(this.txtmontopago_TextChanged);
            // 
            // txtIdpago
            // 
            this.txtIdpago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdpago.Location = new System.Drawing.Point(154, 60);
            this.txtIdpago.Name = "txtIdpago";
            this.txtIdpago.Size = new System.Drawing.Size(152, 20);
            this.txtIdpago.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID de pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID  de miembro:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFechaInicio);
            this.groupBox2.Controls.Add(this.txtFechaVencimieto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblModalidad);
            this.groupBox2.Controls.Add(this.cmbModalidad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIdpago);
            this.groupBox2.Controls.Add(this.txtmontopago);
            this.groupBox2.Controls.Add(this.txtIdMiembro);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(23, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 290);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar Pago";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaInicio.Enabled = false;
            this.txtFechaInicio.Location = new System.Drawing.Point(155, 122);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = true;
            this.txtFechaInicio.Size = new System.Drawing.Size(152, 20);
            this.txtFechaInicio.TabIndex = 37;
            // 
            // txtFechaVencimieto
            // 
            this.txtFechaVencimieto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaVencimieto.Enabled = false;
            this.txtFechaVencimieto.Location = new System.Drawing.Point(155, 155);
            this.txtFechaVencimieto.Name = "txtFechaVencimieto";
            this.txtFechaVencimieto.ReadOnly = true;
            this.txtFechaVencimieto.Size = new System.Drawing.Size(152, 20);
            this.txtFechaVencimieto.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 14);
            this.label6.TabIndex = 34;
            this.label6.Text = "Fecha de vencimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fecha de inicio:";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidad.Location = new System.Drawing.Point(69, 94);
            this.lblModalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(66, 14);
            this.lblModalidad.TabIndex = 28;
            this.lblModalidad.Text = "Modalidad:";
            // 
            // cmbModalidad
            // 
            this.cmbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModalidad.FormattingEnabled = true;
            this.cmbModalidad.Items.AddRange(new object[] {
            "Mes",
            "Dia"});
            this.cmbModalidad.Location = new System.Drawing.Point(154, 91);
            this.cmbModalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(152, 21);
            this.cmbModalidad.TabIndex = 3;
            this.cmbModalidad.SelectedIndexChanged += new System.EventHandler(this.cmbModalidad_SelectedIndexChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(408, 396);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(146, 30);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // FormVerificacionSolvencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 477);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVerificacionSolvencia";
            this.Text = "Verificacion Solvencia";
            this.Load += new System.EventHandler(this.FormVerificacionSolvencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIdMiembro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIDverificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdMiembro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtmontopago;
        private System.Windows.Forms.TextBox txtIdpago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.ComboBox cmbModalidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaVencimieto;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.Button btnguardar;
    }
}