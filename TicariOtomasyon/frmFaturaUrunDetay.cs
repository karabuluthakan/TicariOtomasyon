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
    public partial class frmFaturaUrunDetay : Form
    {
        public frmFaturaUrunDetay()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();

        public string ID;

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from INVOICEDETAIL where FATURAID='"
                + ID + "'", sql.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void frmFaturaUrunDetay_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmFaturaUrunDuzenleme frm = new frmFaturaUrunDuzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                frm.URUNID = dr["FATURAURUNID"].ToString();
            }
            frm.Show();
        }
    }
}
