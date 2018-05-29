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
    public partial class frmFaturaUrunDuzenleme : Form
    {
        public frmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();
        public string URUNID;

        void Listele()
        {
            SqlCommand comm = new SqlCommand("select * from INVOICEDETAIL where FATURAURUNID=@p1", sql.baglanti());
            comm.Parameters.AddWithValue("@p1", URUNID);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                txtFiyat.Text = dr[3].ToString();
                txtMiktar.Text = dr[2].ToString();
                txtTutar.Text = dr[4].ToString();
                txtUrunAd.Text = dr[1].ToString();

                sql.baglanti().Close();
            }
        }
        private void frmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            txtUrunID.Text = URUNID;
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("update INVOICEDETAIL set URUNAD=@P1, MIKTAR=@P2, FIYAT=@P3, TUTAR=@P4 WHERE FATURAID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@P1", txtUrunAd.Text);
            comm.Parameters.AddWithValue("@P2", Convert.ToInt32(txtMiktar.Text));
            comm.Parameters.AddWithValue("@P3", Convert.ToDecimal(txtFiyat.Text));
            comm.Parameters.AddWithValue("@P4", Convert.ToDecimal(txtTutar.Text));
            comm.Parameters.AddWithValue("@ID", txtUrunID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Değişiklikler kaydedildi", "Güncelleme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("delete from INVOICEDETAIL WHERE FATURAID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@ID", txtUrunID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Ürün bilgileri silindi", "Silme işlemi tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
