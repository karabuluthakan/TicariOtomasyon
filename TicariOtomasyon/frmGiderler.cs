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
    public partial class frmGiderler : Form
    {
        public frmGiderler()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from EXPENSES", sql.baglanti());
            da.Fill(dt);
            GridControl.DataSource = dt;
        }

        void Temizle()
        {

        }
        private void frmGiderler_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("insert into EXPENSES (AY,YIL,ELEKTRIK,SU,INTERNET,MAASLAR,EKSTRA,NOTLAR,ID) values(@AY,@YIL,@ELEKTRIK,@SU,@INTERNET,@MAASLAR,@EKSTRA,@NOTLAR,@ID)", sql.baglanti());
            comm.Parameters.AddWithValue("@AY", cbAy.Text);
            comm.Parameters.AddWithValue("@YIL", cbYil.Text);
            comm.Parameters.AddWithValue("@ELEKTRIK", txtElektrik.Text);
            comm.Parameters.AddWithValue("@SU", txtSu.Text);
            comm.Parameters.AddWithValue("@INTERNET", txtInternet.Text);
            comm.Parameters.AddWithValue("@MAASLAR", txtMaaslar.Text);
            comm.Parameters.AddWithValue("@EKSTRA", rtxtEkstra.Text);
            comm.Parameters.AddWithValue("@NOTLAR", rtxtNotlar.Text);
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Gider bilgileri eklendi!", "Kayıt tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("update EXPENSES set  AY=@AY,YIL=@YIL,ELEKTRIK=@ELEKTRIK,SU=@SU,INTERNET=@INTERNET,MAASLAR=@MAASLAR,EKSTRA=@EKSTRA,NOTLAR=@NOTLAR where ID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@AY", cbAy.Text);
            comm.Parameters.AddWithValue("@YIL", cbYil.Text);
            comm.Parameters.AddWithValue("@ELEKTRIK", decimal.Parse(txtElektrik.Text));
            comm.Parameters.AddWithValue("@SU", decimal.Parse(txtSu.Text));
            comm.Parameters.AddWithValue("@INTERNET", decimal.Parse(txtInternet.Text));
            comm.Parameters.AddWithValue("@MAASLAR", decimal.Parse(txtMaaslar.Text));
            comm.Parameters.AddWithValue("@EKSTRA", decimal.Parse(rtxtEkstra.Text));
            comm.Parameters.AddWithValue("@NOTLAR", rtxtNotlar.Text);
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Gider bilgileri güncellendi!", "Güncelleme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("delete from EXPENSES where ID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Gider bilgileri silindi!", "Silme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                cbAy.Text = dr["AY"].ToString();
                cbYil.Text = dr["YIL"].ToString();
                txtElektrik.Text = dr["ELEKTRIK"].ToString();
                txtSu.Text = dr["SU"].ToString();
                txtInternet.Text = dr["INTERNET"].ToString();
                txtMaaslar.Text = dr["MAASLAR"].ToString();
                rtxtEkstra.Text = dr["EKSTRA"].ToString();
                rtxtNotlar.Text = dr["NOTLAR"].ToString();
            }
        }
    }
}
