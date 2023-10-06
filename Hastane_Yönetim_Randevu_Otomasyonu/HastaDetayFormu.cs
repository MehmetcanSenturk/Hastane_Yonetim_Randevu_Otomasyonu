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
    public partial class HastaDetayFormu : Form
    {
        public HastaDetayFormu()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglanti cnnct  = new SqlBaglanti();
        private void grpBilgi_Enter(object sender, EventArgs e)
        {

        }

        private void HastaDetayFormu_Load(object sender, EventArgs e)
        {
            /*
             *Ad Soyad Listeleme
             */
            lblTCKN.Text = tc;
            SqlCommand cmd = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC=@p1",cnnct.baglanti());  
            cmd.Parameters.AddWithValue("@p1",lblTCKN.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblAdSoyad.Text = reader[0] +" "+reader[1]; 
            }
            cnnct.baglanti().Close();   
            /*
             *Randevu Geçmişimi Listeleme
             */
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where HastaTC=" + tc, cnnct.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            /*
            *Branşlar
            */
            SqlCommand cmd2 = new SqlCommand("Select BransAd from Tbl_Branslar", cnnct.baglanti());
            SqlDataReader reader1 = cmd2.ExecuteReader();
            while(reader1.Read())
            {
                cmbBrans.Items.Add(reader1[0]);
            }
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", cnnct.baglanti());
            cmd3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while(reader3.Read())
            {
                cmbDoktor.Items.Add(reader3[0]+" "+ reader3[1]);    
            }
            cnnct.baglanti().Close(); 
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter d = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuBrans='" + cmbBrans.Text+"'" +" and RandevuDoktor= '"+cmbDoktor.Text+"' and RandevuDurum=0",cnnct.baglanti());
            d.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }

        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaBilgiDuzenlemeFormu fr  = new HastaBilgiDuzenlemeFormu();
            fr.TCKN = lblTCKN.Text;
            fr.Show();
        }

        private void grpAktifRandevu_Enter(object sender, EventArgs e)
        {

        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3",cnnct.baglanti());
            cmd.Parameters.AddWithValue("@p1", lblTCKN.Text);
            cmd.Parameters.AddWithValue("@p2", richSikayet.Text);
            cmd.Parameters.AddWithValue("@p3", txtid.Text);
            cmd.ExecuteNonQuery();
            cnnct.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);  

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[sec].Cells[0].Value.ToString();
        }
    }
}
