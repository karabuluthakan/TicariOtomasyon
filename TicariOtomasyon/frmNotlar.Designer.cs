namespace TicariOtomasyon
{
    partial class frmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotlar));
            this.gcMusteriler = new DevExpress.XtraGrid.GridControl();
            this.gvMusteriler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mtxtSaat = new System.Windows.Forms.MaskedTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtHitap = new DevExpress.XtraEditors.TextEdit();
            this.txtOlusturan = new DevExpress.XtraEditors.TextEdit();
            this.txtBaslik = new DevExpress.XtraEditors.TextEdit();
            this.mtxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rtxtDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOlusturan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcMusteriler
            // 
            this.gcMusteriler.Location = new System.Drawing.Point(-1, -1);
            this.gcMusteriler.MainView = this.gvMusteriler;
            this.gcMusteriler.Name = "gcMusteriler";
            this.gcMusteriler.Size = new System.Drawing.Size(716, 512);
            this.gcMusteriler.TabIndex = 4;
            this.gcMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMusteriler});
            // 
            // gvMusteriler
            // 
            this.gvMusteriler.GridControl = this.gcMusteriler;
            this.gvMusteriler.Name = "gvMusteriler";
            this.gvMusteriler.OptionsView.ShowGroupPanel = false;
            this.gvMusteriler.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvMusteriler_FocusedRowChanged);
            this.gvMusteriler.DoubleClick += new System.EventHandler(this.gvMusteriler_DoubleClick);
            // 
            // mtxtSaat
            // 
            this.mtxtSaat.Location = new System.Drawing.Point(85, 88);
            this.mtxtSaat.Mask = "00:00";
            this.mtxtSaat.Name = "mtxtSaat";
            this.mtxtSaat.Size = new System.Drawing.Size(159, 21);
            this.mtxtSaat.TabIndex = 3;
            this.mtxtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.txtHitap);
            this.groupControl1.Controls.Add(this.txtOlusturan);
            this.groupControl1.Controls.Add(this.txtBaslik);
            this.groupControl1.Controls.Add(this.mtxtTarih);
            this.groupControl1.Controls.Add(this.mtxtSaat);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.rtxtDetay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(716, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(249, 512);
            this.groupControl1.TabIndex = 3;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(127, 409);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(110, 35);
            this.btnTemizle.TabIndex = 35;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtHitap
            // 
            this.txtHitap.Location = new System.Drawing.Point(85, 182);
            this.txtHitap.Name = "txtHitap";
            this.txtHitap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHitap.Properties.Appearance.Options.UseFont = true;
            this.txtHitap.Size = new System.Drawing.Size(159, 24);
            this.txtHitap.TabIndex = 27;
            // 
            // txtOlusturan
            // 
            this.txtOlusturan.Location = new System.Drawing.Point(85, 152);
            this.txtOlusturan.Name = "txtOlusturan";
            this.txtOlusturan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOlusturan.Properties.Appearance.Options.UseFont = true;
            this.txtOlusturan.Size = new System.Drawing.Size(159, 24);
            this.txtOlusturan.TabIndex = 26;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(85, 119);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslik.Properties.Appearance.Options.UseFont = true;
            this.txtBaslik.Size = new System.Drawing.Size(159, 24);
            this.txtBaslik.TabIndex = 25;
            // 
            // mtxtTarih
            // 
            this.mtxtTarih.Location = new System.Drawing.Point(85, 58);
            this.mtxtTarih.Mask = "00/00/0000";
            this.mtxtTarih.Name = "mtxtTarih";
            this.mtxtTarih.Size = new System.Drawing.Size(159, 21);
            this.mtxtTarih.TabIndex = 24;
            this.mtxtTarih.ValidatingType = typeof(System.DateTime);
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
            this.btnSil.Location = new System.Drawing.Point(127, 450);
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
            this.btnGuncelle.Location = new System.Drawing.Point(127, 368);
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
            this.btnKaydet.Location = new System.Drawing.Point(127, 327);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 35);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rtxtDetay
            // 
            this.rtxtDetay.Location = new System.Drawing.Point(85, 215);
            this.rtxtDetay.Name = "rtxtDetay";
            this.rtxtDetay.Size = new System.Drawing.Size(159, 94);
            this.rtxtDetay.TabIndex = 11;
            this.rtxtDetay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 215);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(32, 13);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "DETAY";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 125);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 13);
            this.labelControl8.TabIndex = 11;
            this.labelControl8.Text = "BAŞLIK";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 91);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(26, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "SAAT";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 158);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "OLUŞTURAN";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 190);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "HİTAP";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "TARİH";
            // 
            // frmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 511);
            this.Controls.Add(this.gcMusteriler);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmNotlar";
            this.Text = "NOTLAR";
            this.Load += new System.EventHandler(this.frmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOlusturan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMusteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMusteriler;
        private System.Windows.Forms.MaskedTextBox mtxtSaat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.RichTextBox rtxtDetay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHitap;
        private DevExpress.XtraEditors.TextEdit txtOlusturan;
        private DevExpress.XtraEditors.TextEdit txtBaslik;
        private System.Windows.Forms.MaskedTextBox mtxtTarih;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}