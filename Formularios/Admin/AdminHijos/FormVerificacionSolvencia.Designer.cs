﻿namespace ProyectoSoplado_1._0_
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
            this.lblModalidad = new System.Windows.Forms.Label();
            this.cmbModalidad = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIdMiembro);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtIDverificar);
            this.groupBox1.Location = new System.Drawing.Point(31, 311);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(409, 188);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verificar Solvencia";
            // 
            // lblIdMiembro
            // 
            this.lblIdMiembro.AutoSize = true;
            this.lblIdMiembro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMiembro.Location = new System.Drawing.Point(37, 42);
            this.lblIdMiembro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdMiembro.Name = "lblIdMiembro";
            this.lblIdMiembro.Size = new System.Drawing.Size(112, 16);
            this.lblIdMiembro.TabIndex = 10;
            this.lblIdMiembro.Text = "ID de miembro:";
            this.lblIdMiembro.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.btnBuscar.Location = new System.Drawing.Point(172, 90);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(195, 37);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Verificar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIDverificar
            // 
            this.txtIDverificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDverificar.Location = new System.Drawing.Point(172, 39);
            this.txtIDverificar.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDverificar.Name = "txtIDverificar";
            this.txtIDverificar.Size = new System.Drawing.Size(194, 22);
            this.txtIDverificar.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Monto de pago:";
            // 
            // txtIdMiembro
            // 
            this.txtIdMiembro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdMiembro.Location = new System.Drawing.Point(172, 30);
            this.txtIdMiembro.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMiembro.Name = "txtIdMiembro";
            this.txtIdMiembro.Size = new System.Drawing.Size(202, 22);
            this.txtIdMiembro.TabIndex = 24;
            this.txtIdMiembro.TextChanged += new System.EventHandler(this.txtIdMiembro_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.btnAgregar.Location = new System.Drawing.Point(172, 183);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(203, 38);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Registrar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtmontopago
            // 
            this.txtmontopago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmontopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontopago.Location = new System.Drawing.Point(173, 153);
            this.txtmontopago.Margin = new System.Windows.Forms.Padding(4);
            this.txtmontopago.Name = "txtmontopago";
            this.txtmontopago.Size = new System.Drawing.Size(202, 23);
            this.txtmontopago.TabIndex = 22;
            this.txtmontopago.TextChanged += new System.EventHandler(this.txtmontopago_TextChanged);
            // 
            // txtIdpago
            // 
            this.txtIdpago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdpago.Location = new System.Drawing.Point(172, 76);
            this.txtIdpago.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdpago.Name = "txtIdpago";
            this.txtIdpago.Size = new System.Drawing.Size(202, 22);
            this.txtIdpago.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID de pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID  de miembro:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblModalidad);
            this.groupBox2.Controls.Add(this.cmbModalidad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIdpago);
            this.groupBox2.Controls.Add(this.txtmontopago);
            this.groupBox2.Controls.Add(this.txtIdMiembro);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(31, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(409, 239);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar Pago";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidad.Location = new System.Drawing.Point(63, 121);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(84, 16);
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
            this.cmbModalidad.Location = new System.Drawing.Point(172, 114);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(202, 24);
            this.cmbModalidad.TabIndex = 27;
            this.cmbModalidad.SelectedIndexChanged += new System.EventHandler(this.cmbModalidad_SelectedIndexChanged);
            // 
            // FormVerificacionSolvencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}