using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TicariOtomasyonDataSet3.PRODUCTS' table. You can move, or remove it, as needed.
            this.PRODUCTSTableAdapter.Fill(this.TicariOtomasyonDataSet3.PRODUCTS);
            // TODO: This line of code loads data into the 'TicariOtomasyonDataSet2.EXPENSES' table. You can move, or remove it, as needed.
            this.EXPENSESTableAdapter.Fill(this.TicariOtomasyonDataSet2.EXPENSES);
            // TODO: This line of code loads data into the 'TicariOtomasyonDataSet1.CUSTOMERS' table. You can move, or remove it, as needed.
            this.CUSTOMERSTableAdapter.Fill(this.TicariOtomasyonDataSet1.CUSTOMERS);
            // TODO: This line of code loads data into the 'TicariOtomasyonDataSet.COMPANIES' table. You can move, or remove it, as needed.
            this.COMPANIESTableAdapter.Fill(this.TicariOtomasyonDataSet.COMPANIES);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer5.RefreshReport();
        }
    }
}
