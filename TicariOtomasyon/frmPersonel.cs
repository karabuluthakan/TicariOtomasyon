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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from staffs", sql.baglanti());
            da.Fill(dt);
            GridControl.DataSource = dt;
        }

        void Temizle()
        {
            txtGorev.Text = txtAd.Text = txtID.Text = txtMail.Text = txtSoyad.Text = mtbxTC.Text = mtbxTel.Text = cbil.Text = cbilce.Text = string.Empty;
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
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            Listele();
            SehirListesi();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("insert into staffs (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values(@AD,@SOYAD,@TELEFON,@TC,@MAIL,@IL,@ILCE,@ADRES,@GOREV)", sql.baglanti());
            comm.Parameters.AddWithValue("@AD", txtAd.Text);
            comm.Parameters.AddWithValue("@SOYAD", txtSoyad.Text);
            comm.Parameters.AddWithValue("@TELEFON", mtbxTel.Text);
            comm.Parameters.AddWithValue("@TC", mtbxTC.Text);
            comm.Parameters.AddWithValue("@MAIL", txtMail.Text);
            comm.Parameters.AddWithValue("@IL", cbil.SelectedItem);
            comm.Parameters.AddWithValue("@ILCE", cbilce.SelectedItem);
            comm.Parameters.AddWithValue("@ADRES", rtxtAdres.Text);
            comm.Parameters.AddWithValue("@GOREV", txtGorev.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Personel bilgileri eklendi!", "Kayıt tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtSoyad.Text = dr["SOYAD"].ToString();
                mtbxTel.Text = dr["TELEFON"].ToString();
                mtbxTC.Text = dr["TC"].ToString();
                txtMail.Text = dr["MAIL"].ToString();
                cbil.Text = dr["IL"].ToString();
                cbilce.Text = dr["ILCE"].ToString();
                rtxtAdres.Text = dr["ADRES"].ToString();
                txtGorev.Text = dr["GOREV"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("delete from staffs where ID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Personel bilgileri silindi!", "Silme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("update staffs set AD=@AD,SOYAD=@SOYAD,TELEFON=@TELEFON,TC=@TC,MAIL=@MAIL,IL=@IL,ILCE=@ILCE,ADRES=@ADRES,GOREV=@GOREV WHERE ID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@AD", txtAd.Text);
            comm.Parameters.AddWithValue("@SOYAD", txtSoyad.Text);
            comm.Parameters.AddWithValue("@TELEFON", mtbxTel.Text); 
            comm.Parameters.AddWithValue("@TC", mtbxTC.Text);
            comm.Parameters.AddWithValue("@MAIL", txtMail.Text);
            comm.Parameters.AddWithValue("@IL", cbil.Text);
            comm.Parameters.AddWithValue("@ILCE", cbilce.Text);
            comm.Parameters.AddWithValue("@ADRES", rtxtAdres.Text);
            comm.Parameters.AddWithValue("@GOREV", txtGorev.Text); 
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Personel bilgileri güncellendi!", "Güncelleme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
            Temizle();
        }

        private void cbilce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
