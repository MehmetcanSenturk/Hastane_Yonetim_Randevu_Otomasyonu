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
    public partial class BransPaneli : Form
    {
        public BransPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti cnnct =  new SqlBaglanti();
        private void BransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar",cnnct.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@p1)",cnnct.baglanti());  
            cmd.Parameters.AddWithValue("@p1",txtBransAd.Text);
            cmd.ExecuteNonQuery();
            cnnct.baglanti().Close();
            MessageBox.Show("Branş Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBransAd.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmddel = new SqlCommand("delete from Tbl_Branslar where Bransid=@p1", cnnct.baglanti());
            cmddel.Parameters.AddWithValue("@p1", txtID.Text);
            cmddel.ExecuteNonQuery();
            cnnct.baglanti().Close();
            MessageBox.Show("Branş Başarıyla Silinmiştir");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Branslar set bransAd=@p1 where bransid=@p2", cnnct.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtBransAd.Text);
            cmd.Parameters.AddWithValue("@p2",txtID.Text);
            cmd.ExecuteNonQuery();
            cnnct.baglanti().Close();
            MessageBox.Show("Branş Başarıyla Güncellenmiştir");

        }
    }
}
