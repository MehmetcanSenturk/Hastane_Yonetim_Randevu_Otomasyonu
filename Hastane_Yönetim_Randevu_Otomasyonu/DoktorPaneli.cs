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
    public partial class DoktorPaneli : Form
    {
        public DoktorPaneli()
        {
            InitializeComponent();
        }
        public string TCKN;
        SqlBaglanti cnnct = new SqlBaglanti();
        private void DoktorPaneli_Load(object sender, EventArgs e)
        {
            lblTCKN.Text = TCKN;
            /*
             * DoktorAdSoyad
             */
            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", cnnct.baglanti());
            cmd.Parameters.AddWithValue("@p1",lblTCKN.Text);
            SqlDataReader dr = cmd.ExecuteReader(); 
            while(dr.Read()) 
            {
             lblAdSoyad.Text = dr[0]+ " " + dr[1];   
            }
            cnnct.baglanti().Close();
            /*
             * Randevu
             */
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor='" + lblAdSoyad.Text +"'", cnnct.baglanti());    
            da.Fill(dt);    
            dataGridView1.DataSource = dt;
        }

        private void btnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            DoktorBilgiDuzenlemeFormu fr = new DoktorBilgiDuzenlemeFormu();
            fr.TCKN = lblTCKN.Text;
            fr.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            DuyurularFormu fr = new DuyurularFormu();
            fr.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text = dataGridView1.Rows[sec].Cells[7].Value.ToString();
        }
    }
}
