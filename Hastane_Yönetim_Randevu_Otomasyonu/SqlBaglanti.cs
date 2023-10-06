using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Yönetim_Randevu_Otomasyonu
{
     class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection cnct = new SqlConnection("Data Source=root\\SQLEXPRESS;Initial Catalog=db_Hastane;Integrated Security=True");
            cnct.Open();
            return cnct;
         }
    }
}
