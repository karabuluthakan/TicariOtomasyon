using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TicariOtomasyon.CLASS;

namespace TicariOtomasyon
{
    public partial class frmFatura : Form
    {
        public frmFatura()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from INVOICEINFORMATIONS", sql.baglanti());
            da.Fill(dt);
            gridControlFatura.DataSource = dt;
        }

        void Temizle()
        {
            txtAlici.Text = txtFaturaID.Text = txtFiyat.Text = txtID.Text = txtMiktar.Text = txtSeri.Text = txtSira.Text = txtTeslimAlan.Text = txtTeslimEden.Text = txtTutar.Text = txtUrunAd.Text = txtUrunID.Text = txtVergiDairesi.Text = mtxtSaat.Text = mtxtTarih.Text = string.Empty;
        }
        private void frmFatura_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }
        void FirmaHareketVeriGiris()
        {
            SqlCommand comm = new SqlCommand("insert into COMPANYMOVEMENTS (URUNID,ADET,PERSONEL,FIRMA,TOPLAM,FATURAID,TARIH) values(@URUNID,@ADET,@PERSONEL,@FIRMA,@TOPLAM,@FATURAID,@TARIH)", sql.baglanti());
            comm.Parameters.AddWithValue("@URUNID", txtUrunID.Text);
            comm.Parameters.AddWithValue("@ADET", txtMiktar.Text);
            comm.Parameters.AddWithValue("@PERSONEL", luPersonel.EditValue);
            comm.Parameters.AddWithValue("@FIRMA", luFirma.EditValue);
            comm.Parameters.AddWithValue("@TOPLAM", txtTutar.Text);
            comm.Parameters.AddWithValue("@FATURAID", txtFaturaID.Text);
            comm.Parameters.AddWithValue("@TARIH", mtxtTarih.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
        }
        void MusteriHareketVeriGiris()
        {
            SqlCommand comm = new SqlCommand("insert into CUSTOMERMOVEMENTS (URUNID,ADET,PERSONEL,MUSTERI,TOPLAM,FATURAID,TARIH) values(@URUNID,@ADET,@PERSONEL,@MUSTERI,@TOPLAM,@FATURAID,@TARIH)", sql.baglanti());
            comm.Parameters.AddWithValue("@URUNID", txtUrunID.Text);
            comm.Parameters.AddWithValue("@ADET", txtMiktar.Text);
            comm.Parameters.AddWithValue("@PERSONEL", luPersonel.EditValue);
            comm.Parameters.AddWithValue("@MUSTERI", luFirma.EditValue);
            comm.Parameters.AddWithValue("@TOPLAM", txtTutar.Text);
            comm.Parameters.AddWithValue("@FATURAID", txtFaturaID.Text);
            comm.Parameters.AddWithValue("@TARIH", mtxtTarih.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
        }

        void StokAzaltma()
        {
            SqlCommand comm = new SqlCommand("update PRODUCTS set adet=adet-@p1 where ID=@p2", sql.baglanti());
            comm.Parameters.AddWithValue("@p1", txtMiktar.Text);
            comm.Parameters.AddWithValue("@p2", txtUrunID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
        }
         
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFaturaID.Text.Trim() == null )
            {
                SqlCommand comm = new SqlCommand("insert into INVOICEINFORMATIONS (SERI,SIRANO,TARIH,SAAT,VERGIDAIRESI,ALICI,TESLIMALAN,TESLIMEDEN) values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", sql.baglanti());
                comm.Parameters.AddWithValue("@P1", txtSeri.Text);
                comm.Parameters.AddWithValue("@P2", txtSira.Text);
                comm.Parameters.AddWithValue("@P3", mtxtTarih.Text);
                comm.Parameters.AddWithValue("@P4", mtxtSaat.Text);
                comm.Parameters.AddWithValue("@P5", txtVergiDairesi.Text);
                comm.Parameters.AddWithValue("@P6", txtAlici.Text);
                comm.Parameters.AddWithValue("@P7", txtTeslimAlan.Text);
                comm.Parameters.AddWithValue("@P8", txtTeslimEden.Text);
                comm.ExecuteNonQuery();
                sql.baglanti().Close();
                 
                StokAzaltma();

                MessageBox.Show("Fatura bilgisi eklendi!", "Kayıt tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            } 
            else if (txtFaturaID.Text.Trim() != null && comboBox1.Text == "MÜŞTERİ")
            {
                double fiyat, miktar, tutar;
                fiyat = Convert.ToDouble(txtFiyat.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                tutar = Convert.ToDouble(txtTutar.Text);
                SqlCommand comm = new SqlCommand("insert into INVOICEDETAIL (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values(@P1,@P2,@P3,@P4,@P5)", sql.baglanti());
                comm.Parameters.AddWithValue("@P1", txtUrunAd.Text);
                comm.Parameters.AddWithValue("@P2", txtMiktar.Text);
                comm.Parameters.AddWithValue("@P3", txtFiyat.Text);
                comm.Parameters.AddWithValue("@P4", txtTutar.Text);
                comm.Parameters.AddWithValue("@P5", txtFaturaID.Text);
                comm.ExecuteNonQuery();
                sql.baglanti().Close();
                MusteriHareketVeriGiris();
                StokAzaltma();
                MessageBox.Show("Faturaya ait ürün bilgisi eklendi!", "Kayıt tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else if (txtFaturaID.Text.Trim() != null && comboBox1.Text == "FİRMA")
            {
                double fiyat, miktar, tutar;
                fiyat = Convert.ToDouble(txtFiyat.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                tutar = Convert.ToDouble(txtTutar.Text);
                SqlCommand comm = new SqlCommand("insert into INVOICEDETAIL (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values(@P1,@P2,@P3,@P4,@P5)", sql.baglanti());
                comm.Parameters.AddWithValue("@P1", txtUrunAd.Text);
                comm.Parameters.AddWithValue("@P2", txtMiktar.Text);
                comm.Parameters.AddWithValue("@P3", txtFiyat.Text);
                comm.Parameters.AddWithValue("@P4", txtTutar.Text);
                comm.Parameters.AddWithValue("@P5", txtFaturaID.Text);
                comm.ExecuteNonQuery();
                sql.baglanti().Close();
                FirmaHareketVeriGiris();
                StokAzaltma();
                MessageBox.Show("Faturaya ait ürün bilgisi eklendi!", "Kayıt tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("update INVOICEINFORMATIONS set SERI=@P1,SIRANO=@P2,TARIH=@P3,SAAT=@P4,VERGIDAIRESI=@P5,ALICI=@P6,TESLIMALAN=@P7,TESLIMEDEN=@P8 WHERE FATURABILGIID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@P1", txtSeri.Text);
            comm.Parameters.AddWithValue("@P2", txtSira.Text);
            comm.Parameters.AddWithValue("@P3", mtxtTarih.Text);
            comm.Parameters.AddWithValue("@P4", mtxtSaat.Text);
            comm.Parameters.AddWithValue("@P5", txtVergiDairesi.Text);
            comm.Parameters.AddWithValue("@P6", txtAlici.Text);
            comm.Parameters.AddWithValue("@P7", txtTeslimAlan.Text);
            comm.Parameters.AddWithValue("@P8", txtTeslimEden.Text);
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Fatura bilgisi güncellendi!", "Güncelleme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("delete from INVOICEINFORMATIONS where FATURABILGIID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Fatura bilgileri silindi!", "Silme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gridViewFirmalar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridViewFirmalar.GetDataRow(gridViewFirmalar.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["FATURABILGIID"].ToString();
                txtSeri.Text = dr["SERI"].ToString();
                txtSira.Text = dr["SIRANO"].ToString();
                mtxtTarih.Text = dr["TARIH"].ToString();
                mtxtSaat.Text = dr["SAAT"].ToString();
                txtVergiDairesi.Text = dr["VERGIDAIRESI"].ToString();
                txtAlici.Text = dr["ALICI"].ToString();
                txtTeslimAlan.Text = dr["TESLIMALAN"].ToString();
                txtTeslimEden.Text = dr["TESLIMEDEN"].ToString();
            }
        }

        private void gridViewFirmalar_DoubleClick(object sender, EventArgs e)
        {
            frmFaturaUrunDetay frm = new frmFaturaUrunDetay();
            DataRow dr = gridViewFirmalar.GetDataRow(gridViewFirmalar.FocusedRowHandle);

            if (dr != null)
            {
                frm.ID = dr["FATURABILGIID"].ToString();
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("select URUNAD,SATISFIYAT PRODUCTS WHERE ID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@ID", txtUrunID);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                txtUrunAd.Text = dr[0].ToString();
                txtFiyat.Text = dr[1].ToString();
            }
            sql.baglanti().Close();
        }
    }
}
