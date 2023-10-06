using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Yönetim_Randevu_Otomasyonu
{
    public partial class AnaGirisFormu : Form
    {
        public AnaGirisFormu()
        {
            InitializeComponent();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            HastaGirisFormu fr = new HastaGirisFormu();
            fr.Show();
            this.Hide();
        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            DoktorGirisFormu fr = new DoktorGirisFormu();
            fr.Show();
            this.Hide();
        }

        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {
            SekreterGirisFormu fr = new SekreterGirisFormu();
            fr.Show();
            this.Hide();
        }
    }
}
