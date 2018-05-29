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
using DevExpress.Charts;

namespace TicariOtomasyon
{
    public partial class frmKasa : Form
    {
        public frmKasa()
        {
            InitializeComponent();
        }
        SQL sql = new SQL();
        public string AD;

        void MusteriHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute MUSTERIHAREKETLER", sql.baglanti());
            da.Fill(dt);
            GridControl2.DataSource = dt;
        }

        void FirmaHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute FIRMAHAREKETLER", sql.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }

        void KasaHesap()
        {
            SqlCommand comm = new SqlCommand("select sum(TUTAR) FROM INVOICEDETAIL", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                lblToplamTutar.Text = dr[0].ToString() + " ₺";
            }
            sql.baglanti().Close();
        }

        void Odemeler()
        {
            SqlCommand comm = new SqlCommand("select (ELEKTRIK+SU+INTERNET+EKSTRA) from EXPENSES order by ID asc", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                lblOdemeler.Text = dr[0].ToString() + " ₺";
            }
            sql.baglanti().Close();
        }

        void PersonelMaas()
        {
            SqlCommand comm = new SqlCommand("select MAASLAR from EXPENSES order by ID asc", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                lblPersonelMaas.Text = dr[0].ToString() + " ₺";
            }
            sql.baglanti().Close();
        }

        void MusteriSayisi()
        {
            SqlCommand comm = new SqlCommand("select conut(*) from CUSTOMERS", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                lblMusteriSayisi.Text = dr[0].ToString();
            }
            sql.baglanti().Close();
        }
        void FirmaSayisi()
        {
            SqlCommand comm = new SqlCommand("select conut(*) from COMPANIES", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                lblFirmaSayisi.Text = dr[0].ToString();
            }
            sql.baglanti().Close();
        }
        void StokSayisi()
        {
            SqlCommand comm = new SqlCommand("select conut(*) from PRODUCTS", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                lblStokMiktari.Text = dr[0].ToString();
            }
            sql.baglanti().Close();
        }
        void PersonelSayisi()
        {
            SqlCommand comm = new SqlCommand("select conut(*) from STAFFS", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                lblPersonelSayisi.Text = dr[0].ToString();
            }
            sql.baglanti().Close();
        }

        void ElektrikFatura()
        {
            SqlCommand comm = new SqlCommand("select top 4 AY,ELEKTRIK FROM EXPENSES ORDER BY ID DESC", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0],dr[1]));
            }
            sql.baglanti().Close();
        }
        void EkstraHarcama()
        {
            SqlCommand comm = new SqlCommand("select top 4 AY,EKSTRA FROM EXPENSES ORDER BY ID DESC", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
            }
            sql.baglanti().Close();
        }
        void SuFatura()
        {
            SqlCommand comm = new SqlCommand("select top 4 AY,SU FROM EXPENSES ORDER BY ID DESC", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
            }
            sql.baglanti().Close();
        }
        void InternetFatura()
        {
            SqlCommand comm = new SqlCommand("select top 4 AY,INTERNET FROM EXPENSES ORDER BY ID DESC", sql.baglanti());
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
            }
            sql.baglanti().Close();
        }
        private void frmKasa_Load(object sender, EventArgs e)
        {
            lblAktifKullanici.Text = AD;
            FirmaHareket();
            MusteriHareket();
            KasaHesap();
            Odemeler();
            PersonelMaas();
            MusteriSayisi();
            FirmaSayisi();
            StokSayisi();
            PersonelSayisi();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 0 && sayac <= 10)
            {
                groupControl15.Text = "Son dört ayın elektrik faturaları";
                ElektrikFatura();
            }
            else if (sayac > 10 && sayac <= 20)
            {
                groupControl15.Text = "Son dört ayın su faturaları";
                chartControl1.Series["AYLAR"].Points.Clear();
                SuFatura();
            }
            else if (sayac > 20 && sayac <= 30)
            {
                groupControl15.Text = "Son dört ayın internet faturaları";
                chartControl1.Series["AYLAR"].Points.Clear();
                InternetFatura();
            }
            else if (sayac > 30 && sayac <= 40)
            {
                groupControl15.Text = "Son dört ayın ekstra harcamaları";
                chartControl1.Series["AYLAR"].Points.Clear();
                EkstraHarcama();
            }
            else if (sayac == 41)
                sayac = 0;
        }
    }
}
