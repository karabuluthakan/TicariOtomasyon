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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("select * from ADMIN WHERE KULLANICIAD=@P1 AND SIFRE=@P2",sql.baglanti());
            comm.Parameters.AddWithValue("@P1",txtKullaniciAd.Text);
            comm.Parameters.AddWithValue("@P2", txtSifre.Text);
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                frmAnasayfa frm = new frmAnasayfa();
                frm.kullanici = txtKullaniciAd.Text;
                frm.ShowDialog();
                this.Hide();
            }
            else if (txtKullaniciAd.Text.Trim()==null)
            {
                MessageBox.Show("Kullanıcı adı bilgisi boş bırakılamaz","Eksik bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtKullaniciAd.Focus();
            }
            else if (txtSifre.Text.Trim() == null)
            {
                MessageBox.Show("Şifre alanı boş bırakılamaz", "Eksik bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifre.Focus();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız!", "Yanlış bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sql.baglanti().Close();
        }
    }
}
