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
using Microsoft.VisualBasic;

namespace POSandInventorySystem
{
    public partial class FormUserLogs : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string username;
        string id;
        public FormUserLogs()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadUsersLogs();
        }

        public void LoadUsersLogs()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblUserLogs WHERE id LIKE '" + searchTextBox.Text + "%' OR datetime LIKE '" + searchTextBox.Text + "%' OR action LIKE '" + searchTextBox.Text + "%' OR performedby LIKE '" + searchTextBox.Text + "%'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());

            }
            dr.Close();
            cn.Close();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadUsersLogs();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                FormDialog form = new FormDialog(this);
                form.id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                form.username = username;
                form.deleteall = false;
                form.ShowDialog();
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            FormDialog form = new FormDialog(this);
            form.username = username;
            form.deleteall = true;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
