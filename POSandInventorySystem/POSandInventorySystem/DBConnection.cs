using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POSandInventorySystem
{
    internal class DBConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public string MyConnection()
        {
            string con = @"Data Source=DESKTOP-U2P89PU\SQLEXPRESS;Initial Catalog=POS_INV_DB;Integrated Security=True";

            return con;
        }

        public double GetVat()
        {
            double vat = 0;
            cn.ConnectionString = MyConnection();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblVAT", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                vat = Double.Parse(dr["vat"].ToString());
            }
            dr.Close();
            cn.Close();
            return vat;
        }
    }
}
