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
    public partial class DoktorDuzenlemePaneli : Form
    {
        public DoktorDuzenlemePaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti cnnct = new SqlBaglanti();
        private void DoktorDuzenlemePaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Doktorlar", cnnct.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //////////////////////////////////////////////////////////////////////////////////////////
            SqlCommand cmd2 = new SqlCommand("Select BransAd From Tbl_Branslar", cnnct.baglanti());
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                cmbBrans.Items.Add(reader2[0]);
            }
            cnnct.baglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)",cnnct.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4", mskdTCKN.Text);
            cmd.Parameters.AddWithValue("@p5", txtSifre.Text);
            cmd.ExecuteNonQuery();
            cnnct.baglanti().Close();
            MessageBox.Show("Doktor Bilgileri Başarıyla Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString(); 
            txtSoyad.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            mskdTCKN.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From Tbl_Doktorlar where DoktorTC=@p1", cnnct.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskdTCKN.Text);
            cmd.ExecuteNonQuery();
            cnnct.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Silinmiştir","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Hand);   
          // dataGridView1.Refresh();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTC=@p4",cnnct.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4", mskdTCKN.Text);
            cmd.Parameters.AddWithValue("@p5", txtSifre.Text);
            cmd.ExecuteNonQuery();
            cnnct.baglanti().Close();
            MessageBox.Show("Doktor Bilgileri Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
