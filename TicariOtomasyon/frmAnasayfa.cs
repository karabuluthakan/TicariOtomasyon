using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        frmUrun urun;
        frmMusteri musteri;
        frmFirmalar firma;
        frmPersonel personel;
        frmRehber rehber;
        frmGiderler gider;
        frmBankalar banka;
        frmFatura fatura;
        frmNotlar notlar;
        frmHareketler hareket;
        frmStoklar stok;
        frmAyarlar ayar;
        public string kullanici;
        private void btnUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urun == null)
            {
                urun = new frmUrun();
                urun.MdiParent = this;
                urun.Show();
            }
        }

        private void btnMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (musteri == null)
            {
                musteri = new frmMusteri();
                musteri.MdiParent = this;
                musteri.Show();
            }
        }

        private void btnFirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (firma == null)
            {
                firma = new frmFirmalar();
                firma.MdiParent = this;
                firma.Show();
            }
        }

        private void btnPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personel == null)
            {
                personel = new frmPersonel();
                personel.MdiParent = this;
                personel.Show();
            }

        }

        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rehber == null)
            {
                rehber = new frmRehber();
                rehber.MdiParent = this;
                rehber.Show();
            }
        }

        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gider == null)
            {
                gider = new frmGiderler();
                gider.MdiParent = this;
                gider.Show();
            }
        }

        private void btnBanka_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (banka == null)
            {
                banka = new frmBankalar();
                banka.MdiParent = this;
                banka.Show();
            }
        }

        private void btnFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fatura == null)
            {
                fatura = new frmFatura();
                fatura.MdiParent = this;
                fatura.Show();
            }
        }

        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (notlar == null)
            {
                notlar = new frmNotlar();
                notlar.MdiParent = this;
                notlar.Show();
            }
        }

        private void btnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hareket == null)
            {
                hareket = new frmHareketler();
                hareket.MdiParent = this;
                hareket.Show();
            }
        }

        private void btnStok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stok == null)
            {
                stok = new frmStoklar();
                stok.MdiParent = this;
                stok.Show();
            }
        }

        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ayar == null)
            {
                ayar = new frmAyarlar();
                ayar.MdiParent = this;
                ayar.Show();
            }
        }

        private void btnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBaslangic baslangic = new frmBaslangic();
            if (baslangic == null)
            {
                baslangic = new frmBaslangic();
                baslangic.MdiParent = this;
                baslangic.Show();
            }
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            frmBaslangic baslangic = new frmBaslangic();
            if (baslangic == null)
            {
                baslangic = new frmBaslangic();
                baslangic.MdiParent = this;
                baslangic.Show();
            }
        }

        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKasa kasa = new frmKasa();
            if (kasa == null)
            {
                kasa = new frmKasa();
                kasa.AD = kullanici;
                kasa.MdiParent = this;
                kasa.Show();
            }
        }

        private void btnRapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRaporlar rapor = new frmRaporlar();
            if (rapor == null)
            {
                rapor = new frmRaporlar(); 
                rapor.MdiParent = this;
                rapor.Show();
            }
        }
    }
}
