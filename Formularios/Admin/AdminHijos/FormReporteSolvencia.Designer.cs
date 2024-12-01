namespace ProyectoSoplado_1._0_.Formularios.Admin
{
    partial class FormReporteSolvencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteSolvencia));
            this.dgvRegistroPagos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistroPagos
            // 
            this.dgvRegistroPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroPagos.Location = new System.Drawing.Point(151, 64);
            this.dgvRegistroPagos.Name = "dgvRegistroPagos";
            this.dgvRegistroPagos.RowHeadersWidth = 51;
            this.dgvRegistroPagos.Size = new System.Drawing.Size(429, 384);
            this.dgvRegistroPagos.TabIndex = 16;
            this.dgvRegistroPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registro de Pagos";
            // 
            // FormReporteSolvencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRegistroPagos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReporteSolvencia";
            this.Text = "Reporte Solvencia";
            this.Load += new System.EventHandler(this.FormReporteSolvencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRegistroPagos;
        private System.Windows.Forms.Label label1;
    }
}