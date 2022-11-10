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
    public partial class FormOrders : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public FormOrders()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadOrders();
        }
        public void LoadOrders()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblCart WHERE status = 'Ordered' AND (cashier LIKE '" + searchTextBox.Text + "%' OR datetime LIKE '" + searchTextBox.Text + "%' OR transactionno LIKE '" + searchTextBox.Text + "%' OR menuname LIKE '" + searchTextBox.Text + "%' OR size LIKE '" + searchTextBox.Text + "%' OR sugarlevel LIKE '" + searchTextBox.Text + "%' OR addonsname LIKE '" + searchTextBox.Text + "%' OR quantity LIKE '" + searchTextBox.Text + "%')", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString(), dr[7].ToString(), dr[10].ToString(), dr[12].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
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

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblCart WHERE status = 'Ordered' AND CAST(datetime AS DATE) = CAST(GETDATE() AS DATE)", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString(), dr[7].ToString(), dr[10].ToString(), dr[12].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
