namespace UI.Report
{
    partial class ReporteHidraulicoEspecifico
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteHidraulicoEspecifico));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DiseñoHidraulicoEspecificoReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LateralBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerA = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerD1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerD2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DiseñoHidraulicoEspecificoReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LateralBLBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiseñoHidraulicoEspecificoReportBindingSource
            // 
            this.DiseñoHidraulicoEspecificoReportBindingSource.DataMember = "HidraListing";
            this.DiseñoHidraulicoEspecificoReportBindingSource.DataSource = typeof(BL.DiseñoHidraulicoEspecificoReport);
            // 
            // LateralBLBindingSource
            // 
            this.LateralBLBindingSource.DataMember = "LateralListing";
            this.LateralBLBindingSource.DataSource = typeof(BL.LateralBL);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 40);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "REPORTE DISEÑO HIDRÁULICO";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(924, 13);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(16, 16);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewerD2);
            this.panel1.Controls.Add(this.reportViewerD1);
            this.panel1.Controls.Add(this.reportViewerA);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 671);
            this.panel1.TabIndex = 6;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource7.Name = "DiseñoHidraulicoEspecificoReport";
            reportDataSource7.Value = this.DiseñoHidraulicoEspecificoReportBindingSource;
            reportDataSource8.Name = "LateralReport";
            reportDataSource8.Value = this.LateralBLBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Report.ReportHidraulicoEspecifico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(954, 671);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Visible = false;
            // 
            // reportViewerA
            // 
            this.reportViewerA.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DiseñoHidraulicoEspecificoReport";
            reportDataSource5.Value = this.DiseñoHidraulicoEspecificoReportBindingSource;
            reportDataSource6.Name = "LateralReport";
            reportDataSource6.Value = this.LateralBLBindingSource;
            this.reportViewerA.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewerA.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewerA.LocalReport.ReportEmbeddedResource = "UI.Report.ReportHidraulicoEspecificoA.rdlc";
            this.reportViewerA.Location = new System.Drawing.Point(0, 0);
            this.reportViewerA.Name = "reportViewerA";
            this.reportViewerA.ServerReport.BearerToken = null;
            this.reportViewerA.Size = new System.Drawing.Size(954, 671);
            this.reportViewerA.TabIndex = 1;
            this.reportViewerA.Visible = false;
            // 
            // reportViewerD1
            // 
            this.reportViewerD1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DiseñoHidraulicoEspecificoReport";
            reportDataSource3.Value = this.DiseñoHidraulicoEspecificoReportBindingSource;
            reportDataSource4.Name = "LateralReport";
            reportDataSource4.Value = this.LateralBLBindingSource;
            this.reportViewerD1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerD1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewerD1.LocalReport.ReportEmbeddedResource = "UI.Report.ReportHidraulicoEspecificoD1.rdlc";
            this.reportViewerD1.Location = new System.Drawing.Point(0, 0);
            this.reportViewerD1.Name = "reportViewerD1";
            this.reportViewerD1.ServerReport.BearerToken = null;
            this.reportViewerD1.Size = new System.Drawing.Size(954, 671);
            this.reportViewerD1.TabIndex = 2;
            this.reportViewerD1.Visible = false;
            // 
            // reportViewerD2
            // 
            this.reportViewerD2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DiseñoHidraulicoEspecificoReport";
            reportDataSource1.Value = this.DiseñoHidraulicoEspecificoReportBindingSource;
            reportDataSource2.Name = "LateralReport";
            reportDataSource2.Value = this.LateralBLBindingSource;
            this.reportViewerD2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerD2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerD2.LocalReport.ReportEmbeddedResource = "UI.Report.ReportHidraulicoEspecificoD2.rdlc";
            this.reportViewerD2.Location = new System.Drawing.Point(0, 0);
            this.reportViewerD2.Name = "reportViewerD2";
            this.reportViewerD2.ServerReport.BearerToken = null;
            this.reportViewerD2.Size = new System.Drawing.Size(954, 671);
            this.reportViewerD2.TabIndex = 3;
            this.reportViewerD2.Visible = false;
            // 
            // ReporteHidraulicoEspecifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ReporteHidraulicoEspecifico";
            this.Text = "ReporteHidraulicoEspecifico";
            this.Load += new System.EventHandler(this.ReporteHidraulicoEspecifico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiseñoHidraulicoEspecificoReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LateralBLBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DiseñoHidraulicoEspecificoReportBindingSource;
        private System.Windows.Forms.BindingSource LateralBLBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerA;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerD1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerD2;
    }
}