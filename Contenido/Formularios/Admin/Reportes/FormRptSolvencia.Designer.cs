namespace ProyectoSoplado_1._0_.Formularios.Admin.Reportes
{
    partial class FormRptSolvencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRptSolvencia));
            this.RvSolvencia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RvSolvencia
            // 
            this.RvSolvencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvSolvencia.LocalReport.ReportEmbeddedResource = "ProyectoSoplado_1._0_.Reportes.RptSolvencia.rdlc";
            this.RvSolvencia.Location = new System.Drawing.Point(0, 0);
            this.RvSolvencia.Name = "RvSolvencia";
            this.RvSolvencia.ServerReport.BearerToken = null;
            this.RvSolvencia.Size = new System.Drawing.Size(800, 450);
            this.RvSolvencia.TabIndex = 0;
            // 
            // FormRptSolvencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RvSolvencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRptSolvencia";
            this.Text = "Reporte de Solvencia";
            this.Load += new System.EventHandler(this.FormRptSolvencia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RvSolvencia;
    }
}