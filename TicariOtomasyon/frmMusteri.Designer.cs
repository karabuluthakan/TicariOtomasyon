namespace TicariOtomasyon
{
    partial class frmMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteri));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rtxtAdres = new System.Windows.Forms.RichTextBox();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtVergiNo = new DevExpress.XtraEditors.TextEdit();
            this.cbilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mtbxTC = new System.Windows.Forms.MaskedTextBox();
            this.mtbxTel2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbxTel1 = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gvMusteriler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMusteriler = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMusteriler)).BeginInit();
            this.SuspendLayout();
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
            this.txtID.Location = new System.Drawing.Point(85, 23);
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
            this.btnSil.Location = new System.Drawing.Point(50, 469);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(79, 35);
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
            this.btnGuncelle.Location = new System.Drawing.Point(135, 469);
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
            this.btnKaydet.Location = new System.Drawing.Point(135, 428);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 35);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rtxtAdres
            // 
            this.rtxtAdres.Location = new System.Drawing.Point(85, 328);
            this.rtxtAdres.Name = "rtxtAdres";
            this.rtxtAdres.Size = new System.Drawing.Size(159, 94);
            this.rtxtAdres.TabIndex = 11;
            this.rtxtAdres.Text = "";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(85, 223);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVergiDairesi.Properties.Appearance.Options.UseFont = true;
            this.txtVergiDairesi.Size = new System.Drawing.Size(159, 24);
            this.txtVergiDairesi.TabIndex = 7;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(14, 281);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(9, 13);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "İL";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(85, 195);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Size = new System.Drawing.Size(159, 24);
            this.txtMail.TabIndex = 6;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(14, 203);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 13);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "MAİL";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 115);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(53, 13);
            this.labelControl8.TabIndex = 11;
            this.labelControl8.Text = "TELEFON 1";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 88);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "SOYAD";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(85, 80);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtSoyad.Size = new System.Drawing.Size(159, 24);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(85, 51);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Properties.Appearance.Options.UseFont = true;
            this.txtAd.Size = new System.Drawing.Size(159, 24);
            this.txtAd.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 301);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(22, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "İLÇE";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 148);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "TELEFON 2";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 177);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "T.C.K.NO:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(14, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "AD";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtVergiNo);
            this.groupControl1.Controls.Add(this.cbilce);
            this.groupControl1.Controls.Add(this.cbil);
            this.groupControl1.Controls.Add(this.mtbxTC);
            this.groupControl1.Controls.Add(this.mtbxTel2);
            this.groupControl1.Controls.Add(this.mtbxTel1);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.rtxtAdres);
            this.groupControl1.Controls.Add(this.txtVergiDairesi);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtMail);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtSoyad);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(716, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(249, 512);
            this.groupControl1.TabIndex = 0;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(13, 256);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 13);
            this.labelControl12.TabIndex = 32;
            this.labelControl12.Text = "VERGİ NO";
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Location = new System.Drawing.Point(85, 251);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVergiNo.Properties.Appearance.Options.UseFont = true;
            this.txtVergiNo.Size = new System.Drawing.Size(159, 24);
            this.txtVergiNo.TabIndex = 8;
            // 
            // cbilce
            // 
            this.cbilce.Location = new System.Drawing.Point(85, 303);
            this.cbilce.Name = "cbilce";
            this.cbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbilce.Size = new System.Drawing.Size(159, 20);
            this.cbilce.TabIndex = 10;
            // 
            // cbil
            // 
            this.cbil.Location = new System.Drawing.Point(85, 279);
            this.cbil.Name = "cbil";
            this.cbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbil.Size = new System.Drawing.Size(159, 20);
            this.cbil.TabIndex = 9;
            this.cbil.SelectedIndexChanged += new System.EventHandler(this.cbil_SelectedIndexChanged);
            // 
            // mtbxTC
            // 
            this.mtbxTC.Location = new System.Drawing.Point(85, 169);
            this.mtbxTC.Mask = "00000000000";
            this.mtbxTC.Name = "mtbxTC";
            this.mtbxTC.Size = new System.Drawing.Size(159, 21);
            this.mtbxTC.TabIndex = 5;
            // 
            // mtbxTel2
            // 
            this.mtbxTel2.Location = new System.Drawing.Point(85, 140);
            this.mtbxTel2.Mask = "(999) 000-0000";
            this.mtbxTel2.Name = "mtbxTel2";
            this.mtbxTel2.Size = new System.Drawing.Size(159, 21);
            this.mtbxTel2.TabIndex = 4;
            // 
            // mtbxTel1
            // 
            this.mtbxTel1.Location = new System.Drawing.Point(85, 111);
            this.mtbxTel1.Mask = "(999) 000-0000";
            this.mtbxTel1.Name = "mtbxTel1";
            this.mtbxTel1.Size = new System.Drawing.Size(159, 21);
            this.mtbxTel1.TabIndex = 3;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(13, 230);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(44, 13);
            this.labelControl11.TabIndex = 25;
            this.labelControl11.Text = "VERGİ D.";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 332);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "ADRES";
            // 
            // gvMusteriler
            // 
            this.gvMusteriler.GridControl = this.gcMusteriler;
            this.gvMusteriler.Name = "gvMusteriler";
            this.gvMusteriler.OptionsView.ShowGroupPanel = false;
            this.gvMusteriler.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvMusteriler_FocusedRowChanged);
            // 
            // gcMusteriler
            // 
            this.gcMusteriler.Location = new System.Drawing.Point(-1, -1);
            this.gcMusteriler.MainView = this.gvMusteriler;
            this.gcMusteriler.Name = "gcMusteriler";
            this.gcMusteriler.Size = new System.Drawing.Size(716, 512);
            this.gcMusteriler.TabIndex = 2;
            this.gcMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMusteriler});
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 511);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcMusteriler);
            this.Name = "frmMusteri";
            this.Text = "MÜŞETERİLER";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.RichTextBox rtxtAdres;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMusteriler;
        private DevExpress.XtraGrid.GridControl gcMusteriler;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.MaskedTextBox mtbxTC;
        private System.Windows.Forms.MaskedTextBox mtbxTel2;
        private System.Windows.Forms.MaskedTextBox mtbxTel1;
        private DevExpress.XtraEditors.ComboBoxEdit cbilce;
        private DevExpress.XtraEditors.ComboBoxEdit cbil;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtVergiNo;
    }
}