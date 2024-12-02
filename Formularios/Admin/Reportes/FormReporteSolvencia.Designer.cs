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
            this.GbReportes = new System.Windows.Forms.GroupBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.gBFiltrado = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.CbFiltros = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPagos)).BeginInit();
            this.GbReportes.SuspendLayout();
            this.gBFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistroPagos
            // 
            this.dgvRegistroPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroPagos.Location = new System.Drawing.Point(220, 83);
            this.dgvRegistroPagos.Name = "dgvRegistroPagos";
            this.dgvRegistroPagos.RowHeadersWidth = 51;
            this.dgvRegistroPagos.Size = new System.Drawing.Size(513, 377);
            this.dgvRegistroPagos.TabIndex = 16;
            this.dgvRegistroPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registro de Pagos";
            // 
            // GbReportes
            // 
            this.GbReportes.Controls.Add(this.pictureBox2);
            this.GbReportes.Controls.Add(this.pictureBox1);
            this.GbReportes.Controls.Add(this.btnPDF);
            this.GbReportes.Controls.Add(this.btnReporte);
            this.GbReportes.Controls.Add(this.btnExcel);
            this.GbReportes.Location = new System.Drawing.Point(14, 83);
            this.GbReportes.Name = "GbReportes";
            this.GbReportes.Size = new System.Drawing.Size(200, 170);
            this.GbReportes.TabIndex = 18;
            this.GbReportes.TabStop = false;
            this.GbReportes.Text = "Reportes";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Location = new System.Drawing.Point(9, 109);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(129, 34);
            this.btnPDF.TabIndex = 25;
            this.btnPDF.Text = "Exportar en PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
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
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(9, 71);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(129, 34);
            this.btnExcel.TabIndex = 24;
            this.btnExcel.Text = "Exportar en Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // gBFiltrado
            // 
            this.gBFiltrado.Controls.Add(this.btnFiltrar);
            this.gBFiltrado.Controls.Add(this.CbFiltros);
            this.gBFiltrado.Location = new System.Drawing.Point(14, 360);
            this.gBFiltrado.Name = "gBFiltrado";
            this.gBFiltrado.Size = new System.Drawing.Size(192, 100);
            this.gBFiltrado.TabIndex = 26;
            this.gBFiltrado.TabStop = false;
            this.gBFiltrado.Text = "Filtrado";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(20, 61);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(152, 34);
            this.btnFiltrar.TabIndex = 24;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // CbFiltros
            // 
            this.CbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFiltros.FormattingEnabled = true;
            this.CbFiltros.Location = new System.Drawing.Point(20, 31);
            this.CbFiltros.Name = "CbFiltros";
            this.CbFiltros.Size = new System.Drawing.Size(152, 21);
            this.CbFiltros.TabIndex = 0;
            this.CbFiltros.SelectedIndexChanged += new System.EventHandler(this.CbFiltros_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoSoplado_1._0_.Properties.Resources.archivo_excel;
            this.pictureBox1.Location = new System.Drawing.Point(143, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoSoplado_1._0_.Properties.Resources.archivo_pdf;
            this.pictureBox2.Location = new System.Drawing.Point(143, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // FormReporteSolvencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 472);
            this.Controls.Add(this.gBFiltrado);
            this.Controls.Add(this.GbReportes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRegistroPagos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReporteSolvencia";
            this.Text = "Reporte Solvencia";
            this.Load += new System.EventHandler(this.FormReporteSolvencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPagos)).EndInit();
            this.GbReportes.ResumeLayout(false);
            this.gBFiltrado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRegistroPagos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbReportes;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox gBFiltrado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox CbFiltros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}