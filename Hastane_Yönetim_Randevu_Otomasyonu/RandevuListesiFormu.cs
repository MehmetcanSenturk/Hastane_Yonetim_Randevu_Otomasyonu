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
    public partial class RandevuListesiFormu : Form
    {
        public RandevuListesiFormu()
        {
            InitializeComponent();
        }
        SqlBaglanti cnnct = new SqlBaglanti();
        private void RandevuListesiFormu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular",cnnct.baglanti());
            da.Fill(dt);    
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int sec;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
