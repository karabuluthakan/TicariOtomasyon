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
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from products", sql.baglanti());
            da.Fill(dt);
            gcUrunler.DataSource = dt;
        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Veri kaydetme
            SqlCommand comm = new SqlCommand("insert into products (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values(@URUNAD,@MARKA,@MODEL,@YIL,@ADET,@ALISFIYAT,@SATISFIYAT,@DETAY)", sql.baglanti());
            comm.Parameters.AddWithValue("@URUNAD", txtAd.Text);
            comm.Parameters.AddWithValue("@MARKA", txtMarka.Text);
            comm.Parameters.AddWithValue("@MODEL", txtModel.Text);
            comm.Parameters.AddWithValue("@YIL", txtYil.Text);
            comm.Parameters.AddWithValue("@ADET", int.Parse((nudAdet.Value).ToString()));
            comm.Parameters.AddWithValue("@ALISFIYAT", decimal.Parse((txtAlisFiyat.Text)));
            comm.Parameters.AddWithValue("@SATISFIYAT", decimal.Parse((txtSatisFiyat.Text)));
            comm.Parameters.AddWithValue("@DETAY", rtxtDetay.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Ürün eklendi!", "Kayıt tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("delete from products where ID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Ürün silindi!", "Silme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("update products set URUNAD=@URUNAD,MARKA=@MARKA,MODEL=@MODEL,YIL=@YIL,ADET=@ADET,ALISFIYAT=@ALISFIYAT,SATISFIYAT=@SATISFIYAT,DETAY=@DETAY where ID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@URUNAD", txtAd.Text);
            comm.Parameters.AddWithValue("@MARKA", txtMarka.Text);
            comm.Parameters.AddWithValue("@MODEL", txtModel.Text);
            comm.Parameters.AddWithValue("@YIL", txtYil.Text);
            comm.Parameters.AddWithValue("@ADET", int.Parse((nudAdet.Value).ToString()));
            comm.Parameters.AddWithValue("@ALISFIYAT", decimal.Parse((txtAlisFiyat.Text)));
            comm.Parameters.AddWithValue("@SATISFIYAT", decimal.Parse((txtSatisFiyat.Text)));
            comm.Parameters.AddWithValue("@DETAY", rtxtDetay.Text);
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Ürün güncellendi!", "Güncelleme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["ID"].ToString();
            txtAd.Text = dr["URUNAD"].ToString();
            txtMarka.Text = dr["MARKA"].ToString();
            txtModel.Text = dr["MODEL"].ToString();
            txtYil.Text = dr["YIL"].ToString();
            nudAdet.Value = Convert.ToDecimal(dr["ADET"]);
            txtAlisFiyat.Text = dr["ALISFIYAT"].ToString();
            txtSatisFiyat.Text = dr["SATISFIYAT"].ToString();
            rtxtDetay.Text = dr["DETAY"].ToString();
        }


    }
}
