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
    public partial class frmNotlar : Form
    {
        public frmNotlar()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from NOTES", sql.baglanti());
            da.Fill(dt);
            gcMusteriler.DataSource = dt;
        }

        void Temizle()
        {
            txtBaslik.Text = txtHitap.Text = txtID.Text = txtOlusturan.Text = mtxtSaat.Text = mtxtTarih.Text = rtxtDetay.Text = string.Empty;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("insert into NOTES (TARIH,SAAT,BASLIK,OLUSTURAN,HITAP,DETAY) values (@P1,@P3,@P3,@P4,@P5,@P6)", sql.baglanti());
            comm.Parameters.AddWithValue("@P1", mtxtTarih.Text);
            comm.Parameters.AddWithValue("@P2", mtxtSaat.Text);
            comm.Parameters.AddWithValue("@P3", txtBaslik.Text);
            comm.Parameters.AddWithValue("@P4", txtOlusturan.Text);
            comm.Parameters.AddWithValue("@P5", txtHitap.Text);
            comm.Parameters.AddWithValue("@P6", rtxtDetay.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            Listele();
            MessageBox.Show("Not eklendi!", "Kayıt tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("update NOTES set TARIH=@P1,SAAT=@P2,BASLIK=@P3,OLUSTURAN=@P4,HITAP=@P4,DETAY=@P6 WHERE ID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@P1", mtxtTarih.Text);
            comm.Parameters.AddWithValue("@P2", mtxtSaat.Text);
            comm.Parameters.AddWithValue("@P3", txtBaslik.Text);
            comm.Parameters.AddWithValue("@P4", txtOlusturan.Text);
            comm.Parameters.AddWithValue("@P5", txtHitap.Text);
            comm.Parameters.AddWithValue("@P6", rtxtDetay.Text);
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Not içeriği güncellendi!", "Güncelleme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("delete from NOTES where ID=@ID", sql.baglanti());
            comm.Parameters.AddWithValue("@ID", txtID.Text);
            comm.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Not silindi!", "Silme tamamlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void frmNotlar_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void gvMusteriler_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gvMusteriler.GetDataRow(gvMusteriler.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                mtxtTarih.Text = dr["TARIH"].ToString();
                mtxtSaat.Text = dr["SAAT"].ToString();
                txtBaslik.Text = dr["BASLIK"].ToString();
                txtOlusturan.Text = dr["OLUSTURAN"].ToString();
                txtHitap.Text = dr["HITAP"].ToString();
                rtxtDetay.Text = dr["DETAY"].ToString();
            }
        }

        private void gvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            frmNotDetay frm = new frmNotDetay();
            DataRow dr = gvMusteriler.GetDataRow(gvMusteriler.FocusedRowHandle);

            if (dr != null)
            {
                frm.metin = dr["DETAY"].ToString();
            }
            frm.Show();
        }
    }
}
