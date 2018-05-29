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
    public partial class frmStokDetay : Form
    {
        public frmStokDetay()
        {
            InitializeComponent();
        }
        public string AD;
        SQL sql = new SQL();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from PRODUCTS where URUNAD='" + AD + "'", sql.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void frmStokDetay_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
