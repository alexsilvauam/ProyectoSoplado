namespace ProyectoSoplado_1._0_.Formularios.Admin.Reportes
{
    partial class FormRptAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRptAsistencias));
            this.RvAsistencias = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RvAsistencias
            // 
            this.RvAsistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvAsistencias.LocalReport.ReportEmbeddedResource = "ProyectoSoplado_1._0_.Reportes.RptAsistencia.rdlc";
            this.RvAsistencias.Location = new System.Drawing.Point(0, 0);
            this.RvAsistencias.Name = "RvAsistencias";
            this.RvAsistencias.ServerReport.BearerToken = null;
            this.RvAsistencias.Size = new System.Drawing.Size(800, 450);
            this.RvAsistencias.TabIndex = 0;
            this.RvAsistencias.Load += new System.EventHandler(this.RvAsistencias_Load);
            // 
            // FormRptAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RvAsistencias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRptAsistencias";
            this.Text = "Reporte de Asistencias";
            this.Load += new System.EventHandler(this.FormRptAsistencias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RvAsistencias;
    }
}