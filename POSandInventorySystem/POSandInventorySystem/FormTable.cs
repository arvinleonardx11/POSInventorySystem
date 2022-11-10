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

namespace POSandInventorySystem
{
    public partial class FormTable : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public FormTable()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public void LoadOrders()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblCart WHERE status = 'Ordered'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString(), dr[7].ToString(), dr[10].ToString(), dr[12].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadOrdersDaily()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblCart WHERE status = 'Ordered' AND DATEDIFF(DAY,datetime,GETDATE() )<1", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString(), dr[7].ToString(), dr[10].ToString(), dr[12].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadOrdersWeekly()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblCart WHERE status = 'Ordered' AND DATEDIFF(DAY,datetime,GETDATE() )<7", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString(), dr[7].ToString(), dr[10].ToString(), dr[12].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadOrdersMonthly()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblCart WHERE status = 'Ordered' AND DATEDIFF(DAY,datetime,GETDATE() )<30", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString(), dr[7].ToString(), dr[10].ToString(), dr[12].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadOrdersYearly()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblCart WHERE status = 'Ordered' AND DATEDIFF(DAY,datetime,GETDATE() )<365", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString(), dr[7].ToString(), dr[10].ToString(), dr[12].ToString());
            }
            dr.Close();
            cn.Close();
        }
    }
}
