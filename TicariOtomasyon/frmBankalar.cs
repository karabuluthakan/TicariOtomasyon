using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicariOtomasyon.CLASS;

namespace TicariOtomasyon
{
    public partial class frmBankalar : Form
    {
        public frmBankalar()
        {
            InitializeComponent();
        }
        SQL sql = new SQL();

        void Temizle()
        {
            txtBankaAd.Text = txtBankaSube.Text = luFirma.Text = txtHesapNo.Text = txtIBAN.Text = txtID.Text = txtYetkili.Text = cbil.Text = cbilce.Text = mtxtTarih.Text = mtxtTel.Text = string.Empty;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute BANKABILGILERI", sql.baglanti());
            da.Fill(dt);
            GridControl1.DataSource = dt;
        }
        void SehirListesi()
        {
            SqlCommand comm = new SqlCommand("select * from cities", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                cbil.Properties.Items.Add(dr[0]);
            }
            sql.baglanti().Close();
        }

        void FirmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID,AD from COMPANIES", sql.baglanti());
            da.Fill(dt);
            luFirma.Properties.NullText = "Bir firma seçiniz!";
            luFirma.Properties.ValueMember = "ID";
            luFirma.Properties.DisplayMember = "FİRMA ADI";
            luFirma.Properties.DataSource=dt;
        }
        private void frmBankalar_Load(object sender, EventArgs e)
        {
            Listele();
            SehirListesi();
            FirmaListesi();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("insert into BANKS (BANKAADI,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID,IL,ILCE) values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11)", sql.baglanti());
            comm.Parameters.AddWithValue("@P1", txtBankaAd.Text);
            comm.Parameters.AddWithValue("@P2", txtBankaSube.Text);
            comm.Parameters.AddWithValue("@P3", txtIBAN.Text);
            comm.Parameters.AddWithValue("@P4", txtHesapNo.Text);
            comm.Parameters.AddWithValue("@P5", txtYetkili.Text);
            comm.Parameters.AddWithValue("@P6", mtxtTel.Text);
            comm.Parameters.AddWithValue("@P7", mtxtTarih.Text);
            comm.Parameters.AddWithValue("@P8", txtHesapTuru.Text);
            comm.Parameters.AddWithValue("@P9", luFirma.EditValue);
            comm.Parameters.AddWithValue("@P10", cbil.Text);
            comm.Parameters.AddWithValue("@P11", cbilce.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Banka bilgisi eklendi!", "Kayıt tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("update products set BANKAADI=@P1,SUBE=@P2,IBAN=@P3,HESAPNO=@P4,YETKILI=@P5,TELEFON=@P6,TARIH=@P7,HESAPTURU=@P8,FIRMAID=@P9,IL=@P10,ILCE=@P11, ID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@P1", txtBankaAd.Text);
            comm.Parameters.AddWithValue("@P2", txtBankaSube.Text);
            comm.Parameters.AddWithValue("@P3", txtIBAN.Text);
            comm.Parameters.AddWithValue("@P4", txtHesapNo.Text);
            comm.Parameters.AddWithValue("@P5", txtYetkili.Text);
            comm.Parameters.AddWithValue("@P6", mtxtTel.Text);
            comm.Parameters.AddWithValue("@P7", mtxtTarih.Text);
            comm.Parameters.AddWithValue("@P8", txtHesapTuru.Text);
            comm.Parameters.AddWithValue("@P9", luFirma.EditValue);
            comm.Parameters.AddWithValue("@P10", cbil.Text);
            comm.Parameters.AddWithValue("@P11", cbilce.Text);
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Banka bilgileri güncellendi!", "Güncelleme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("delete from BANKS where ID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Banka bilgileri silindi!", "Silme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
            Temizle();
        }

        private void cbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbilce.Properties.Items.Clear();
            SqlCommand comm = new SqlCommand("select districts from ilce where sehir=@sehir", sql.baglanti());
            comm.Parameters.AddWithValue("@sehir", cbil.SelectedIndex + 1);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                cbilce.Properties.Items.Add(dr[0]);
            }
            sql.baglanti().Close();
        }
         

        private void gvMusteriler_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gvBankalar.GetDataRow(gvBankalar.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtBankaAd.Text = dr["BANKAADI"].ToString();
                txtIBAN.Text = dr["IBAN"].ToString();
                txtHesapNo.Text = dr["HESAPNO"].ToString();
                txtYetkili.Text = dr["YETKILI"].ToString();
                mtxtTel.Text = dr["TELEFON"].ToString();
                mtxtTarih.Text = dr["TARIH"].ToString();
                txtHesapTuru.Text = dr["HESAPTURU"].ToString(); 
                cbil.Text = dr["IL"].ToString();
                cbilce.Text = dr["ILCE"].ToString();
            }
        }
         
    }
}
