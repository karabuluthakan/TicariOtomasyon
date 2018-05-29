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
    public partial class frmFirmalar : Form
    {
        public frmFirmalar()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from products", sql.baglanti());
            da.Fill(dt);
            gridControlMusteriler.DataSource = dt;
        }

        void Temizle()
        {
            txtAd.Text = txtID.Text = txtKod1.Text = txtKod2.Text = txtKod3.Text = txtMail.Text = txtSektör.Text = txtVergiDairesi.Text = txtVergiNo.Text = txtYetkili.Text = txtYetkiliGorev.Text = mtbxFax.Text = mtbxTel1.Text = mtbxTel2.Text = mtbxTel3.Text = mtbxYetkiliTC.Text = cbil.Text = cbilce.Text = string.Empty;
            txtAd.Focus();
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

        void cariKodAciklama()
        {
            SqlCommand comm = new SqlCommand("select FIRMAKOD1 from codes", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                rtbxKod1.Text = dr[0].ToString();
            }
            sql.baglanti().Close();
        }
        private void frmFirmalar_Load(object sender, EventArgs e)
        {
            Listele();
            SehirListesi();
            Temizle();
            cariKodAciklama();
        }

        private void gridViewFirmalar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridViewFirmalar.GetDataRow(gridViewFirmalar.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtYetkiliGorev.Text = dr["YETKILISTATU"].ToString();
                txtYetkili.Text = dr["YETKILIADSOYAD"].ToString();
                mtbxYetkiliTC.Text = dr["YETKILITC"].ToString();
                txtSektör.Text = dr["SEKTOR"].ToString();
                mtbxTel1.Text = dr["TELEFON1"].ToString();
                mtbxTel2.Text = dr["TELEFON2"].ToString();
                mtbxTel3.Text = dr["TELEFON3"].ToString();
                mtbxFax.Text = dr["FAX"].ToString();
                txtMail.Text = dr["MAIL"].ToString();
                cbil.Text = dr["ILCE"].ToString();
                cbilce.Text = dr["ILCE"].ToString();
                txtVergiDairesi.Text = dr["VERGIDAIRESI"].ToString();
                txtVergiNo.Text = dr["VERGINO"].ToString();
                rtxtAdres.Text = dr["ADRES"].ToString();
                rtbxKod1.Text = dr["OZELKOD1"].ToString();
                rtbxKod2.Text = dr["OZELKOD2"].ToString();
                rtbxKod3.Text = dr["OZELKOD3"].ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("insert into COMPANIES (AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,FAX,MAIL,IL,ILCE,VERGIDAIRESI,VERGINO,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values (@AD,@YETKILISTATU,@YETKILIADSOYAD,@YETKILITC,@SEKTOR,@TELEFON1,@TELEFON2,@TELEFON3,@FAX,@MAIL,@IL,@ILCE,@VERGIDAIRESI,@VERGINO,@ADRES,@OZELKOD1,@OZELKOD2,@OZELKOD3)", sql.baglanti());
            comm.Parameters.AddWithValue("@AD", txtAd.Text);
            comm.Parameters.AddWithValue("@YETKILISTATU", txtYetkiliGorev.Text);
            comm.Parameters.AddWithValue("@YETKILIADSOYAD", txtYetkili.Text);
            comm.Parameters.AddWithValue("@YETKILITC", mtbxYetkiliTC.Text);
            comm.Parameters.AddWithValue("@SEKTOR", txtSektör.Text);
            comm.Parameters.AddWithValue("@TELEFON1", mtbxTel1.Text);
            comm.Parameters.AddWithValue("@TELEFON2", mtbxTel2.Text);
            comm.Parameters.AddWithValue("@TELEFON3", mtbxTel3.Text);
            comm.Parameters.AddWithValue("@FAX", mtbxFax.Text);
            comm.Parameters.AddWithValue("@MAIL", txtMail.Text);
            comm.Parameters.AddWithValue("@IL", cbil.Text);
            comm.Parameters.AddWithValue("@ILCE", cbilce.Text);
            comm.Parameters.AddWithValue("@VERGIDAIRESI", txtVergiDairesi.Text);
            comm.Parameters.AddWithValue("@VERGINO", txtVergiNo.Text);
            comm.Parameters.AddWithValue("@ADRES", rtxtAdres.Text);
            comm.Parameters.AddWithValue("@OZELKOD1", rtbxKod1.Text);
            comm.Parameters.AddWithValue("@OZELKOD2", rtbxKod2.Text);
            comm.Parameters.AddWithValue("@OZELKOD3", rtbxKod3.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Firma bilgileri eklendi!", "Kayıt tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("update COMPANIES set(AD=@AD,YETKILISTATU=@YETKILISTATU,YETKILIADSOYAD=@YETKILIADSOYAD,YETKILITC=@YETKILITC,SEKTOR=@SEKTOR,TELEFON1=@TELEFON1,TELEFON2=@TELEFON2,TELEFON3=@TELEFON3,FAX=@FAX,MAIL=@MAIL,IL=@IL,ILCE=@ILCE,VERGIDAIRESI=@VERGIDAIRESI,VERGINO=@VERGINO,ADRES=@ADRES,OZELKOD1=@OZELKOD1,OZELKOD2=@OZELKOD2,OZELKOD3=@OZELKOD3)", sql.baglanti());
            comm.Parameters.AddWithValue("@AD", txtAd.Text);
            comm.Parameters.AddWithValue("@YETKILISTATU", txtYetkiliGorev.Text);
            comm.Parameters.AddWithValue("@YETKILIADSOYAD", txtYetkili.Text);
            comm.Parameters.AddWithValue("@YETKILITC", mtbxYetkiliTC.Text);
            comm.Parameters.AddWithValue("@SEKTOR", txtSektör.Text);
            comm.Parameters.AddWithValue("@TELEFON1", mtbxTel1.Text);
            comm.Parameters.AddWithValue("@TELEFON2", mtbxTel2.Text);
            comm.Parameters.AddWithValue("@TELEFON3", mtbxTel3.Text);
            comm.Parameters.AddWithValue("@FAX", mtbxFax.Text);
            comm.Parameters.AddWithValue("@MAIL", txtMail.Text);
            comm.Parameters.AddWithValue("@IL", cbil.Text);
            comm.Parameters.AddWithValue("@ILCE", cbilce.Text);
            comm.Parameters.AddWithValue("@VERGIDAIRESI", txtVergiDairesi.Text);
            comm.Parameters.AddWithValue("@VERGINO", txtVergiNo.Text);
            comm.Parameters.AddWithValue("@ADRES", rtxtAdres.Text);
            comm.Parameters.AddWithValue("@OZELKOD1", rtbxKod1.Text);
            comm.Parameters.AddWithValue("@OZELKOD2", rtbxKod2.Text);
            comm.Parameters.AddWithValue("@OZELKOD3", rtbxKod3.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Firma bilgileri güncellendi!", "Güncelleme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("delete from COMPANIES where ID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Firma bilgileri silindi!", "Silme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
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

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
