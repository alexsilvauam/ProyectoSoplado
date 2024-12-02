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
            this.GbReportes = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAsistencias)).BeginInit();
            this.GbReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReporteAsistencias
            // 
            this.dgvReporteAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteAsistencias.Location = new System.Drawing.Point(220, 83);
            this.dgvReporteAsistencias.Name = "dgvReporteAsistencias";
            this.dgvReporteAsistencias.RowHeadersWidth = 51;
            this.dgvReporteAsistencias.Size = new System.Drawing.Size(513, 377);
            this.dgvReporteAsistencias.TabIndex = 0;
            this.dgvReporteAsistencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Asistencias";
            // 
            // GbReportes
            // 
            this.GbReportes.Controls.Add(this.btnPDF);
            this.GbReportes.Controls.Add(this.btnExcel);
            this.GbReportes.Controls.Add(this.btnReporte);
            this.GbReportes.Location = new System.Drawing.Point(14, 83);
            this.GbReportes.Name = "GbReportes";
            this.GbReportes.Size = new System.Drawing.Size(200, 169);
            this.GbReportes.TabIndex = 2;
            this.GbReportes.TabStop = false;
            this.GbReportes.Text = "Reportes";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(9, 71);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(183, 34);
            this.btnExcel.TabIndex = 22;
            this.btnExcel.Text = "Exportar en Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(9, 33);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(183, 34);
            this.btnReporte.TabIndex = 21;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Location = new System.Drawing.Point(9, 109);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(183, 34);
            this.btnPDF.TabIndex = 23;
            this.btnPDF.Text = "Exportar en PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // FormReporteAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 472);
            this.Controls.Add(this.GbReportes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReporteAsistencias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReporteAsistencia";
            this.Text = "Reporte Asistencia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAsistencias)).EndInit();
            this.GbReportes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporteAsistencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbReportes;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPDF;
    }
}