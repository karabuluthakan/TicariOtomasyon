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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * FROM ADMIN", sql.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (btnKaydet.Text== "KAYDET")
            {
                SqlCommand comm = new SqlCommand("insert into ADMIN values (@P1,@P2)", sql.baglanti());
                comm.Parameters.AddWithValue("@P1", txtKullanici.Text);
                comm.Parameters.AddWithValue("@P2", txtSifre.Text);
                comm.ExecuteNonQuery();
                sql.baglanti().Close();
                MessageBox.Show("Yeni kullanıcı sisteme kaydedildi", "Kayıt tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else if (btnKaydet.Text == "GÜNCELLE")
            {
                SqlCommand comm = new SqlCommand("update ADMIN set KULLANICIAD=@P1,SIFRE=@P2)", sql.baglanti());
                comm.Parameters.AddWithValue("@P1", txtKullanici.Text);
                comm.Parameters.AddWithValue("@P2", txtSifre.Text);
                comm.ExecuteNonQuery();
                sql.baglanti().Close();
                MessageBox.Show("kullanıcı bilgileri güncellendi", "Güncelleme tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Listele();
            }

        }

        void Temizle()
        {
            txtKullanici.Text = txtSifre.Text = string.Empty;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtKullanici.Text = dr["KULLANICIAD"].ToString();
                txtSifre.Text = dr["SIFRE"].ToString();
            }
        }

        private void txtKullanici_EditValueChanged(object sender, EventArgs e)
        {
            if (txtKullanici.Text.Trim() != null)
            {
                btnKaydet.Text = "GÜNCELLE";
                btnKaydet.BackColor = Color.Blue;
            }
            else
            {
                btnKaydet.Text = "KAYDET";
                btnKaydet.BackColor = Color.Green;
            }
        }
    }
}
