namespace ProyectoSoplado_1._0_.Formularios
{
    partial class FormReporteAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteAsistencia));
            this.dgvReporteAsistencias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarReporte = new System.Windows.Forms.Button();
            this.btnOcultarReporte = new System.Windows.Forms.Button();
            this.rprtAsistencia = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporteAsistencias
            // 
            this.dgvReporteAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteAsistencias.Location = new System.Drawing.Point(220, 83);
            this.dgvReporteAsistencias.Name = "dgvReporteAsistencias";
            this.dgvReporteAsistencias.RowHeadersWidth = 51;
            this.dgvReporteAsistencias.Size = new System.Drawing.Size(272, 377);
            this.dgvReporteAsistencias.TabIndex = 0;
            this.dgvReporteAsistencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro De Asistencias";
            // 
            // btnMostrarReporte
            // 
            this.btnMostrarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnMostrarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMostrarReporte.ForeColor = System.Drawing.Color.White;
            this.btnMostrarReporte.Location = new System.Drawing.Point(58, 83);
            this.btnMostrarReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarReporte.Name = "btnMostrarReporte";
            this.btnMostrarReporte.Size = new System.Drawing.Size(157, 34);
            this.btnMostrarReporte.TabIndex = 25;
            this.btnMostrarReporte.Text = "Mostrar Reporte";
            this.btnMostrarReporte.UseVisualStyleBackColor = false;
            this.btnMostrarReporte.Click += new System.EventHandler(this.btnMostrarReporte_Click);
            // 
            // btnOcultarReporte
            // 
            this.btnOcultarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnOcultarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOcultarReporte.ForeColor = System.Drawing.Color.White;
            this.btnOcultarReporte.Location = new System.Drawing.Point(58, 121);
            this.btnOcultarReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnOcultarReporte.Name = "btnOcultarReporte";
            this.btnOcultarReporte.Size = new System.Drawing.Size(157, 34);
            this.btnOcultarReporte.TabIndex = 26;
            this.btnOcultarReporte.Text = "Ocultar Reporte";
            this.btnOcultarReporte.UseVisualStyleBackColor = false;
            this.btnOcultarReporte.Click += new System.EventHandler(this.btnOcultarReporte_Click);
            // 
            // rprtAsistencia
            // 
            this.rprtAsistencia.Location = new System.Drawing.Point(220, 83);
            this.rprtAsistencia.Name = "rprtAsistencia";
            this.rprtAsistencia.ServerReport.BearerToken = null;
            this.rprtAsistencia.Size = new System.Drawing.Size(396, 246);
            this.rprtAsistencia.TabIndex = 27;
            // 
            // FormReporteAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 472);
            this.Controls.Add(this.rprtAsistencia);
            this.Controls.Add(this.btnOcultarReporte);
            this.Controls.Add(this.btnMostrarReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReporteAsistencias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormReporteAsistencia";
            this.Text = "Reporte Asistencia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAsistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporteAsistencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarReporte;
        private System.Windows.Forms.Button btnOcultarReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rprtAsistencia;
    }
}