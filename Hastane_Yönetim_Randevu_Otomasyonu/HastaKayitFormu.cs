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
    public partial class HastaKayitFormu : Form
    {
        public HastaKayitFormu()
        {
            InitializeComponent();
        }
        SqlBaglanti cnct = new SqlBaglanti();
        private void btnKayit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",cnct.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
            cmd.Parameters.AddWithValue("@p3", mskdTc.Text);
            cmd.Parameters.AddWithValue("@p4", mskdTelNo.Text);
            cmd.Parameters.AddWithValue("@p5", txtSifre.Text);
            cmd.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            cmd.ExecuteNonQuery();
            cnct.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz: " + txtSifre.Text,"Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
