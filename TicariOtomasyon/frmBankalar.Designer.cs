namespace TicariOtomasyon
{
    partial class frmBankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankalar));
            this.GridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvBankalar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.cbilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.luFirma = new DevExpress.XtraEditors.LookUpEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.mtxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapTuru = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtIBAN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtYetkili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaSube = new DevExpress.XtraEditors.TextEdit();
            this.txtBankaAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBankalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridControl1
            // 
            this.GridControl1.Location = new System.Drawing.Point(-1, -1);
            this.GridControl1.MainView = this.gvBankalar;
            this.GridControl1.Name = "GridControl1";
            this.GridControl1.Size = new System.Drawing.Size(716, 512);
            this.GridControl1.TabIndex = 4;
            this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBankalar});
            // 
            // gvBankalar
            // 
            this.gvBankalar.GridControl = this.GridControl1;
            this.gvBankalar.Name = "gvBankalar";
            this.gvBankalar.OptionsView.ShowGroupPanel = false;
            this.gvBankalar.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvMusteriler_FocusedRowChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(13, 261);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(44, 13);
            this.labelControl12.TabIndex = 32;
            this.labelControl12.Text = "TELEFON";
            // 
            // cbilce
            // 
            this.cbilce.Location = new System.Drawing.Point(80, 105);
            this.cbilce.Name = "cbilce";
            this.cbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbilce.Size = new System.Drawing.Size(159, 20);
            this.cbilce.TabIndex = 10; 
            // 
            // cbil
            // 
            this.cbil.Location = new System.Drawing.Point(80, 81);
            this.cbil.Name = "cbil";
            this.cbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbil.Size = new System.Drawing.Size(159, 20);
            this.cbil.TabIndex = 9;
            this.cbil.SelectedIndexChanged += new System.EventHandler(this.cbil_SelectedIndexChanged);
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(80, 255);
            this.mtxtTel.Mask = "(999) 000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(159, 21);
            this.mtxtTel.TabIndex = 4;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(13, 230);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(37, 13);
            this.labelControl11.TabIndex = 25;
            this.labelControl11.Text = "YETKİLİ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.luFirma);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.mtxtTarih);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtHesapTuru);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtIBAN);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.cbilce);
            this.groupControl1.Controls.Add(this.cbil);
            this.groupControl1.Controls.Add(this.mtxtTel);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.txtYetkili);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtHesapNo);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtBankaSube);
            this.groupControl1.Controls.Add(this.txtBankaAd);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(716, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(249, 512);
            this.groupControl1.TabIndex = 3;
            // 
            // luFirma
            // 
            this.luFirma.Location = new System.Drawing.Point(80, 349);
            this.luFirma.Name = "luFirma";
            this.luFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luFirma.Size = new System.Drawing.Size(156, 20);
            this.luFirma.TabIndex = 41; 
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(130, 460);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(110, 35);
            this.btnTemizle.TabIndex = 40;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // mtxtTarih
            // 
            this.mtxtTarih.Location = new System.Drawing.Point(80, 287);
            this.mtxtTarih.Mask = "00/00/0000";
            this.mtxtTarih.Name = "mtxtTarih";
            this.mtxtTarih.Size = new System.Drawing.Size(159, 21);
            this.mtxtTarih.TabIndex = 39;
            this.mtxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(15, 352);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 13);
            this.labelControl8.TabIndex = 37;
            this.labelControl8.Text = "FİRMA"; 
            // 
            // txtHesapTuru
            // 
            this.txtHesapTuru.Location = new System.Drawing.Point(80, 314);
            this.txtHesapTuru.Name = "txtHesapTuru";
            this.txtHesapTuru.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesapTuru.Properties.Appearance.Options.UseFont = true;
            this.txtHesapTuru.Size = new System.Drawing.Size(159, 24);
            this.txtHesapTuru.TabIndex = 36;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 322);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "HESAP TÜRÜ";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(80, 160);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIBAN.Properties.Appearance.Options.UseFont = true;
            this.txtIBAN.Size = new System.Drawing.Size(159, 24);
            this.txtIBAN.TabIndex = 33;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(80, 23);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(159, 24);
            this.txtID.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(15, 460);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 35);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(130, 419);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 35);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(130, 378);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 35);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(80, 225);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYetkili.Properties.Appearance.Options.UseFont = true;
            this.txtYetkili.Size = new System.Drawing.Size(159, 24);
            this.txtYetkili.TabIndex = 7;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(14, 83);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(9, 13);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "İL";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(80, 193);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesapNo.Properties.Appearance.Options.UseFont = true;
            this.txtHesapNo.Size = new System.Drawing.Size(159, 24);
            this.txtHesapNo.TabIndex = 6;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(14, 201);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(50, 13);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "HESAP NO";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 139);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(25, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "ŞUBE";
            // 
            // txtBankaSube
            // 
            this.txtBankaSube.Location = new System.Drawing.Point(80, 131);
            this.txtBankaSube.Name = "txtBankaSube";
            this.txtBankaSube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankaSube.Properties.Appearance.Options.UseFont = true;
            this.txtBankaSube.Size = new System.Drawing.Size(159, 24);
            this.txtBankaSube.TabIndex = 2;
            // 
            // txtBankaAd
            // 
            this.txtBankaAd.Location = new System.Drawing.Point(80, 51);
            this.txtBankaAd.Name = "txtBankaAd";
            this.txtBankaAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankaAd.Properties.Appearance.Options.UseFont = true;
            this.txtBankaAd.Size = new System.Drawing.Size(159, 24);
            this.txtBankaAd.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 103);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(22, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "İLÇE";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 290);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "TARİH";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 171);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "IBAN";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "BANKA ADI";
            // 
            // frmBankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 511);
            this.Controls.Add(this.GridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmBankalar";
            this.Text = "BANKALAR";
            this.Load += new System.EventHandler(this.frmBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBankalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBankalar;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.ComboBoxEdit cbilce;
        private DevExpress.XtraEditors.ComboBoxEdit cbil;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtYetkili;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtBankaSube;
        private DevExpress.XtraEditors.TextEdit txtBankaAd;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtIBAN;
        private DevExpress.XtraEditors.TextEdit txtHesapTuru;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.MaskedTextBox mtxtTarih;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.LookUpEdit luFirma;
    }
}