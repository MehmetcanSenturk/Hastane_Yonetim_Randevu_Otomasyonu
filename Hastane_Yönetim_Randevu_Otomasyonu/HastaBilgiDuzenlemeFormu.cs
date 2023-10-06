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
    public partial class HastaBilgiDuzenlemeFormu : Form
    {
        public HastaBilgiDuzenlemeFormu()
        {
            InitializeComponent();
        }
        public string TCKN;
        SqlBaglanti cnct =  new SqlBaglanti();
        private void HastaBilgiDuzenlemeFormu_Load(object sender, EventArgs e)
        {
         mskdTc.Text = TCKN;
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1",cnct.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskdTc.Text);
            SqlDataReader reader = cmd.ExecuteReader(); 
            while(reader.Read())
            {
                txtAd.Text= reader[1].ToString();
                txtSoyad.Text= reader[2].ToString();
                mskdTelNo.Text= reader[4].ToString();
                txtSifre.Text= reader[5].ToString();
                cmbCinsiyet.Text= reader[6].ToString();
            }
            cnct.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", cnct.baglanti());
            cmd2.Parameters.AddWithValue("@p1",txtAd.Text);
            cmd2.Parameters.AddWithValue("@p2",txtSoyad.Text);
            cmd2.Parameters.AddWithValue("@p3",mskdTelNo.Text);
            cmd2.Parameters.AddWithValue("@p4",txtSifre.Text);
            cmd2.Parameters.AddWithValue("@p5",cmbCinsiyet.Text);
            cmd2.Parameters.AddWithValue("@p6",mskdTc.Text);
            cmd2.ExecuteNonQuery();
            cnct.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning); 
        }
    }
}
