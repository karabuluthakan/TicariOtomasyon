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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from CUSTOMERS", sql.baglanti());
            da.Fill(dt);
            gcMusteriler.DataSource = dt;
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
        private void frmMusteri_Load(object sender, EventArgs e)
        {
            Listele();
            SehirListesi();
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("insert into customers (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRESI,VERGINO) values(@AD,@SOYAD,@TELEFON,@TELEFON2,@TC,@MAIL,@IL,@ILCE,@ADRES,@VERGIDAIRESI,@VERGINO)", sql.baglanti());
            comm.Parameters.AddWithValue("@AD", txtAd.Text);
            comm.Parameters.AddWithValue("@SOYAD", txtSoyad.Text);
            comm.Parameters.AddWithValue("@TELEFON", mtbxTel1.Text);
            comm.Parameters.AddWithValue("@TELEFON2", mtbxTel2.Text);
            comm.Parameters.AddWithValue("@TC", mtbxTC.Text);
            comm.Parameters.AddWithValue("@MAIL", txtMail.Text);
            comm.Parameters.AddWithValue("@IL", cbil.SelectedItem);
            comm.Parameters.AddWithValue("@ILCE", cbilce.SelectedItem);
            comm.Parameters.AddWithValue("@ADRES", rtxtAdres.Text);
            comm.Parameters.AddWithValue("@VERGIDAIRESI", txtVergiDairesi.Text);
            comm.Parameters.AddWithValue("@VERGINO", txtVergiNo.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Müşteri eklendi!", "Kayıt tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("update customers set AD=@AD,SOYAD=@SOYAD,TELEFON=@TELEFON,TELEFON2=@TELEFON2,TC=@TC,MAIL=@MAIL,IL=@IL,ILCE=@ILCE,ADRES=@ADRES,VERGIDAIRESI=@VERGIDAIRESI,VERGINO=@VERGINO WHERE ID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@AD", txtAd.Text);
            comm.Parameters.AddWithValue("@SOYAD", txtSoyad.Text);
            comm.Parameters.AddWithValue("@TELEFON", mtbxTel1.Text);
            comm.Parameters.AddWithValue("@TELEFON2", mtbxTel2.Text);
            comm.Parameters.AddWithValue("@TC", mtbxTC.Text);
            comm.Parameters.AddWithValue("@MAIL", txtMail.Text);
            comm.Parameters.AddWithValue("@IL", cbil.Text);
            comm.Parameters.AddWithValue("@ILCE", cbilce.Text);
            comm.Parameters.AddWithValue("@ADRES", rtxtAdres.Text);
            comm.Parameters.AddWithValue("@VERGIDAIRESI", txtVergiDairesi.Text);
            comm.Parameters.AddWithValue("@VERGINO", txtVergiNo.Text);
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Müşteri bilgileri güncellendi!", "Güncelleme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        { 
            SqlCommand comm = new SqlCommand("delete from customers where ID=@ID",sql.baglanti());
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Müşteri silindi!", "Silme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void gvMusteriler_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gvMusteriler.GetDataRow(gvMusteriler.FocusedRowHandle);
            if (dr!=null)
            { 
                txtID.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtSoyad.Text = dr["SOYAD"].ToString();
                mtbxTel1.Text = dr["TELEFON"].ToString();
                mtbxTel2.Text = dr["TELEFON2"].ToString();
                mtbxTC.Text = dr["TC"].ToString();
                txtMail.Text = dr["MAIL"].ToString();
                cbil.Text = dr["IL"].ToString();
                cbilce.Text = dr["ILCE"].ToString();
                rtxtAdres.Text = dr["ADRES"].ToString();
                txtVergiDairesi.Text = dr["VERGIDAIRESI"].ToString();
                txtVergiNo.Text = dr["VERGINO"].ToString();
            }
        }
    }
}
