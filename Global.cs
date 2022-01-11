using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PetShop
{
    class Global
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader reader;

        public static void BuatKoneksi()
        {
            con = new SqlConnection("Data Source=DESKTOP-24CUDME;Initial Catalog=db_petshop;Integrated Security=True");
            con.Open();
        }
    }
}
