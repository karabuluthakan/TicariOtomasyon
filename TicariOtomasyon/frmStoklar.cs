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
    public partial class frmStoklar : Form
    {
        public frmStoklar()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();

        void UrunListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select URUNAD,SUM(ADET) FROM PRODUCTS GROUP BY URUNAD", sql.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void UrunMiktar()
        {
            SqlCommand comm = new SqlCommand("select URUNAD,SUM(ADET) FROM PRODUCTS GROUP BY URUNAD", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr != null)
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            sql.baglanti().Close();
        }

        void FirmaSehir()
        {
            SqlCommand comm = new SqlCommand("select IL,COUNT(*) FROM PRODUCTS GROUP BY IL", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr != null)
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            sql.baglanti().Close();
        }
        private void frmStoklar_Load(object sender, EventArgs e)
        {
            UrunListele();
            UrunMiktar();
            FirmaSehir();
        }
         

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmStokDetay frm = new frmStokDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frm.AD = dr["URUNAD"].ToString();
            }
            frm.Show();
        }
    }
}
