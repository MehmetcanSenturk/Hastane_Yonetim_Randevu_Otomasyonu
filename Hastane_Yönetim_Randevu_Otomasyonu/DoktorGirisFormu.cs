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
    public partial class DoktorGirisFormu : Form
    {
        public DoktorGirisFormu()
        {
            InitializeComponent();
        }
        SqlBaglanti cnnct = new SqlBaglanti();
        private void DoktorGirisFormu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", cnnct.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskdTc.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                DoktorPaneli fr = new DoktorPaneli();
                fr.TCKN = mskdTc.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı TCKN veya şifre");
            }
            cnnct.baglanti().Close();
        }
    }
}
