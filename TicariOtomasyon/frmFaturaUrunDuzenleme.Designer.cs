namespace TicariOtomasyon
{
    partial class frmFaturaUrunDuzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaturaUrunDuzenleme));
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.txtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.txtTutar);
            this.groupControl5.Controls.Add(this.txtFiyat);
            this.groupControl5.Controls.Add(this.txtMiktar);
            this.groupControl5.Controls.Add(this.labelControl9);
            this.groupControl5.Controls.Add(this.labelControl6);
            this.groupControl5.Controls.Add(this.btnSil);
            this.groupControl5.Controls.Add(this.labelControl12);
            this.groupControl5.Controls.Add(this.btnGuncelle);
            this.groupControl5.Controls.Add(this.txtUrunAd);
            this.groupControl5.Controls.Add(this.labelControl11);
            this.groupControl5.Controls.Add(this.txtUrunID);
            this.groupControl5.Controls.Add(this.labelControl4);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(0, 0);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.ShowCaption = false;
            this.groupControl5.Size = new System.Drawing.Size(299, 320);
            this.groupControl5.TabIndex = 1;
            this.groupControl5.Text = "groupControl5";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(90, 156);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Properties.Appearance.Options.UseFont = true;
            this.txtTutar.Size = new System.Drawing.Size(159, 24);
            this.txtTutar.TabIndex = 39;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(90, 125);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Properties.Appearance.Options.UseFont = true;
            this.txtFiyat.Size = new System.Drawing.Size(159, 24);
            this.txtFiyat.TabIndex = 38;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(90, 95);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Properties.Appearance.Options.UseFont = true;
            this.txtMiktar.Size = new System.Drawing.Size(159, 24);
            this.txtMiktar.TabIndex = 37;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(48, 166);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 35;
            this.labelControl9.Text = "TUTAR";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(48, 132);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(29, 13);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "FİYAT";
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(139, 239);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 35);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(28, 73);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(49, 13);
            this.labelControl12.TabIndex = 32;
            this.labelControl12.Text = "ÜRÜN ADI";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(140, 198);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 35);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(90, 65);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.Properties.Appearance.Options.UseFont = true;
            this.txtUrunAd.Size = new System.Drawing.Size(159, 24);
            this.txtUrunAd.TabIndex = 8;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(35, 44);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(42, 13);
            this.labelControl11.TabIndex = 25;
            this.labelControl11.Text = "URUN ID";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(90, 37);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunID.Properties.Appearance.Options.UseFont = true;
            this.txtUrunID.Size = new System.Drawing.Size(159, 24);
            this.txtUrunID.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(39, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "MİKTAR";
            // 
            // frmFaturaUrunDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 320);
            this.Controls.Add(this.groupControl5);
            this.Name = "frmFaturaUrunDuzenleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATURA ÜRÜN DÜZENLEME";
            this.Load += new System.EventHandler(this.frmFaturaUrunDuzenleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.TextEdit txtUrunAd;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtUrunID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}