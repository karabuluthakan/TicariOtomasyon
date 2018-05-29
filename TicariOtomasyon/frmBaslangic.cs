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
using System.Xml;

namespace TicariOtomasyon
{
    public partial class frmBaslangic : Form
    {
        public frmBaslangic()
        {
            InitializeComponent();
        }

        SQL sql = new SQL();

        void Stoklar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select URUNAD,sum(ADET) from PRODUCTS group by URUNAD having sum(ADET) <= 20 order by sum(ADET)"  , sql.baglanti());
            da.Fill(dt);
            gcStoklar.DataSource = dt;
        }

        void Ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select top 8 TARIH,SAAT,BASLIK from NOTES order by ID desc", sql.baglanti());
            da.Fill(dt);
            gcAjanda.DataSource = dt; 
        }

        void FirmaHareketleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec SONISLEMYAPILANFIRMALAR", sql.baglanti());
            da.Fill(dt);
            gcFirmalar.DataSource = dt;
        }

        void Haberler()
        {
            XmlTextReader xmloku = new XmlTextReader("https://www.ntv.com.tr/gundem.rss");
            while (xmloku.Read())
            {
                if (xmloku.Name=="title")
                {
                    lbHaber.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void frmBaslangic_Load(object sender, EventArgs e)
        {
            Stoklar();
            Ajanda();
            FirmaHareketleri();
            webBrowser1.Navigate("http://www.tcmb.gov.tr/kurlar/today.xml");
        }
    }
}
