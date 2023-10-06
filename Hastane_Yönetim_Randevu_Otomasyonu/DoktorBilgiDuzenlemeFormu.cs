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
namespace Hastane_Yönetim_Randevu_Otomasyonu
{
    public partial class DoktorBilgiDuzenlemeFormu : Form
    {
        public DoktorBilgiDuzenlemeFormu()
        {
            InitializeComponent();
        }
        SqlBaglanti cnnct = new SqlBaglanti();
        public string TCKN;
        private void DoktorBilgiDuzenlemeFormu_Load(object sender, EventArgs e)
        {
            mskdTc.Text = TCKN;
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Doktorlar Where DoktorTC=@p1",cnnct.baglanti());
            cmd.Parameters.AddWithValue("@p1",mskdTc.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                cmbBrans.Text  = dr[3].ToString();  
                txtSifre.Text = dr[5].ToString();
            }
            cnnct.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5",cnnct.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtAd.Text);
            cmd.Parameters.AddWithValue("@p2",txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3",cmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4",txtSifre.Text);
            cmd.Parameters.AddWithValue("@p5",mskdTc.Text);
            cmd.ExecuteNonQuery();
            cnnct.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi başarılı");

            
        }
    }
}
