namespace TicariOtomasyon
{
    partial class frmRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporlar));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TicariOtomasyonDataSet1 = new TicariOtomasyon.TicariOtomasyonDataSet1();
            this.COMPANIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TicariOtomasyonDataSet = new TicariOtomasyon.TicariOtomasyonDataSet();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.COMPANIESTableAdapter = new TicariOtomasyon.TicariOtomasyonDataSetTableAdapters.COMPANIESTableAdapter();
            this.CUSTOMERSTableAdapter = new TicariOtomasyon.TicariOtomasyonDataSet1TableAdapters.CUSTOMERSTableAdapter();
            this.TicariOtomasyonDataSet2 = new TicariOtomasyon.TicariOtomasyonDataSet2();
            this.EXPENSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EXPENSESTableAdapter = new TicariOtomasyon.TicariOtomasyonDataSet2TableAdapters.EXPENSESTableAdapter();
            this.TicariOtomasyonDataSet3 = new TicariOtomasyon.TicariOtomasyonDataSet3();
            this.PRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRODUCTSTableAdapter = new TicariOtomasyon.TicariOtomasyonDataSet3TableAdapters.PRODUCTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMPANIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXPENSESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CUSTOMERSBindingSource
            // 
            this.CUSTOMERSBindingSource.DataMember = "CUSTOMERS";
            this.CUSTOMERSBindingSource.DataSource = this.TicariOtomasyonDataSet1;
            // 
            // TicariOtomasyonDataSet1
            // 
            this.TicariOtomasyonDataSet1.DataSetName = "TicariOtomasyonDataSet1";
            this.TicariOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // COMPANIESBindingSource
            // 
            this.COMPANIESBindingSource.DataMember = "COMPANIES";
            this.COMPANIESBindingSource.DataSource = this.TicariOtomasyonDataSet;
            // 
            // TicariOtomasyonDataSet
            // 
            this.TicariOtomasyonDataSet.DataSetName = "TicariOtomasyonDataSet";
            this.TicariOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.reportViewer5);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.ImageOptions.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(958, 464);
            this.xtraTabPage1.Text = "MÜŞTEERİ  RAPORLARI";
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CUSTOMERSBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "TicariOtomasyon.Report2.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(0, 0);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.Size = new System.Drawing.Size(958, 464);
            this.reportViewer5.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.reportViewer1);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.ImageOptions.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(958, 464);
            this.xtraTabPage2.Text = "FİRMA  RAPORLARI";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.COMPANIESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TicariOtomasyon.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(958, 464);
            this.reportViewer1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(964, 511);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.reportViewer2);
            this.xtraTabPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.ImageOptions.Image")));
            this.xtraTabPage3.ImageOptions.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(958, 464);
            this.xtraTabPage3.Text = "KASA RAPORLARI";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(958, 464);
            this.reportViewer2.TabIndex = 1;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.reportViewer3);
            this.xtraTabPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage4.ImageOptions.Image")));
            this.xtraTabPage4.ImageOptions.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(958, 464);
            this.xtraTabPage4.Text = "GİDER  RAPORLARI";
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.EXPENSESBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "TicariOtomasyon.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(958, 464);
            this.reportViewer3.TabIndex = 1;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.reportViewer4);
            this.xtraTabPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage5.ImageOptions.Image")));
            this.xtraTabPage5.ImageOptions.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(958, 464);
            this.xtraTabPage5.Text = "PERSONEL  RAPORLARI";
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.PRODUCTSBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "TicariOtomasyon.Report4.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(958, 464);
            this.reportViewer4.TabIndex = 1;
            // 
            // COMPANIESTableAdapter
            // 
            this.COMPANIESTableAdapter.ClearBeforeFill = true;
            // 
            // CUSTOMERSTableAdapter
            // 
            this.CUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // TicariOtomasyonDataSet2
            // 
            this.TicariOtomasyonDataSet2.DataSetName = "TicariOtomasyonDataSet2";
            this.TicariOtomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EXPENSESBindingSource
            // 
            this.EXPENSESBindingSource.DataMember = "EXPENSES";
            this.EXPENSESBindingSource.DataSource = this.TicariOtomasyonDataSet2;
            // 
            // EXPENSESTableAdapter
            // 
            this.EXPENSESTableAdapter.ClearBeforeFill = true;
            // 
            // TicariOtomasyonDataSet3
            // 
            this.TicariOtomasyonDataSet3.DataSetName = "TicariOtomasyonDataSet3";
            this.TicariOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PRODUCTSBindingSource
            // 
            this.PRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.PRODUCTSBindingSource.DataSource = this.TicariOtomasyonDataSet3;
            // 
            // PRODUCTSTableAdapter
            // 
            this.PRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 511);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmRaporlar";
            this.Text = "RAPORLAR";
            this.Load += new System.EventHandler(this.frmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMPANIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXPENSESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource COMPANIESBindingSource;
        private TicariOtomasyonDataSet TicariOtomasyonDataSet;
        private TicariOtomasyonDataSetTableAdapters.COMPANIESTableAdapter COMPANIESTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CUSTOMERSBindingSource;
        private TicariOtomasyonDataSet1 TicariOtomasyonDataSet1;
        private TicariOtomasyonDataSet1TableAdapters.CUSTOMERSTableAdapter CUSTOMERSTableAdapter;
        private System.Windows.Forms.BindingSource EXPENSESBindingSource;
        private TicariOtomasyonDataSet2 TicariOtomasyonDataSet2;
        private TicariOtomasyonDataSet2TableAdapters.EXPENSESTableAdapter EXPENSESTableAdapter;
        private System.Windows.Forms.BindingSource PRODUCTSBindingSource;
        private TicariOtomasyonDataSet3 TicariOtomasyonDataSet3;
        private TicariOtomasyonDataSet3TableAdapters.PRODUCTSTableAdapter PRODUCTSTableAdapter;
    }
}