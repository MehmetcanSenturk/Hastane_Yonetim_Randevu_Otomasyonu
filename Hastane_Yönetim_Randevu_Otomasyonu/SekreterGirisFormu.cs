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
    public partial class SekreterGirisFormu : Form
    {
        public SekreterGirisFormu()
        {
            InitializeComponent();
        }
        SqlBaglanti cnnct  = new SqlBaglanti();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd  = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2",cnnct.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskdTc.Text);
            cmd.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                SekreterDetayFormu fr = new SekreterDetayFormu();
                fr.TCKN = mskdTc.Text;    
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TCKN veya Şifre");
            }
            cnnct.baglanti().Close();
        }
    }
}
