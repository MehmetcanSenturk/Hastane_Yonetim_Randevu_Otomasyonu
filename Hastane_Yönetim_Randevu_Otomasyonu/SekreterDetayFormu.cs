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
    public partial class SekreterDetayFormu : Form
    {
        public SekreterDetayFormu()
        {
            InitializeComponent();
        }
        public string TCKN;
        public string sec;
        SqlBaglanti cnnct= new SqlBaglanti();   
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void SekreterDetayFormu_Load(object sender, EventArgs e)
        {
            lblTCKN.Text = TCKN;
            txtId.Text = sec;
            /*
             * AD&S
             */
            SqlCommand cmd = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1",cnnct.baglanti());  
            cmd.Parameters.AddWithValue("@p1",lblTCKN.Text);
            SqlDataReader reader1 = cmd.ExecuteReader(); 
            while(reader1.Read())
            {
                lblAdSoyad.Text= reader1[0].ToString();
            }
            cnnct.baglanti().Close();   

            /*
             * Branş Listesini Görüntüle
             */
            DataTable dt1 = new DataTable();
            SqlDataAdapter  da = new SqlDataAdapter("Select BransAd from Tbl_Branslar", cnnct.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            /*
             * Doktor Listesi
             */
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad)as 'Doktorlar',DoktorBrans from Tbl_Doktorlar", cnnct.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            /*
             * ComboBox a Branş
            */
            SqlCommand cmd2 = new SqlCommand("Select BransAd From Tbl_Branslar", cnnct.baglanti());
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                cmdBrans.Items.Add(reader2[0]);
            }
            cnnct.baglanti().Close();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmdsave = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", cnnct.baglanti());
            cmdsave.Parameters.AddWithValue("@p1", mskdTarih.Text);
            cmdsave.Parameters.AddWithValue("@p2", mskdSaat.Text);
            cmdsave.Parameters.AddWithValue("@p3", cmdBrans.Text);
            cmdsave.Parameters.AddWithValue("@p4", cmbDoktor.Text);
            cmdsave.ExecuteNonQuery();
            cnnct.baglanti().Close();
            MessageBox.Show("Randevunuz Başarıyla Oluşturulmuştur");
            
        }

        private void cmdBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();    
            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1",cnnct.baglanti());
            cmd.Parameters.AddWithValue("@p1", cmdBrans.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cmbDoktor.Items.Add(dr[0]+ " " + dr[1]);
            }
            cnnct.baglanti().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@p1)", cnnct.baglanti());
            cmd.Parameters.AddWithValue("@p1", richTextBox1.Text);
            cmd.ExecuteNonQuery();
            cnnct.baglanti().Close();
            MessageBox.Show("Duyurunuz Başarıyla Oluşuturulmuştur");
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            DoktorDuzenlemePaneli fr = new DoktorDuzenlemePaneli();
            fr.Show();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            BransPaneli br = new BransPaneli();
            br.Show();
        }

        private void btnRandevListesi_Click(object sender, EventArgs e)
        {
            RandevuListesiFormu fr = new RandevuListesiFormu();
            fr.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
              
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            DuyurularFormu fr = new DuyurularFormu();
            fr.Show();
        }
    }
}
