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
    public partial class frmRehber : Form
    {
        public frmRehber()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();

        void MusteriGoster()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AD,SOYAD,TELEFON,TELEFON2,MAIL from CUSTOMERS", sql.baglanti());
            da.Fill(dt);
            GridControl2.DataSource = dt;
        }

        void FirmaGoster()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select AD,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,FAX,MAIL from COMPANIES", sql.baglanti());
            da2.Fill(dt2);
            gridControl1.DataSource = dt2;
        }

        private void frmRehber_Load(object sender, EventArgs e)
        {
            MusteriGoster();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmMail frm = new frmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                frm.mail = dr["MAIL"].ToString();
            }
            frm.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            frmMail frm = new frmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();
            }
            frm.Show();
        }
    }
}
