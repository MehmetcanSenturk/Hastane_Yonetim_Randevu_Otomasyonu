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
    public partial class HastaGirisFormu : Form
    {
        public HastaGirisFormu()
        {
            InitializeComponent();
        }
        SqlBaglanti cnnct = new SqlBaglanti();
        private void HastaGirisFormu_Load(object sender, EventArgs e)
        {

        }

        private void linkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayitFormu fr = new HastaKayitFormu();
            fr .Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2",cnnct.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskdTc.Text);
            cmd.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader(); 
            if(dr.Read())
            {
                HastaDetayFormu fr = new HastaDetayFormu();
                fr.tc=mskdTc.Text;
                fr .Show();
                this.Hide();    
            }
            else
            {
               MessageBox.Show("Hatalı TCKN veya Şifre");
            }
        }
    }
}
