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
    public partial class FormDashboard : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        FormAdmin formadmin;
        public FormDashboard(FormAdmin form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            CountMenu();
            CountStock();
            CountUser();
            CountSales();
            formadmin = form;
        }

        private void CountMenu()
        {
            int i = 0;
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblMenu", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
            }
            label5.Text = i.ToString();
            dr.Close();
            cn.Close();
        }

        private void CountStock()
        {
            int i = 0;
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblStock", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
            }
            label1.Text = i.ToString();
            dr.Close();
            cn.Close();
        }

        private void CountUser()
        {
            int i = 0;
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblUser", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
            }
            label6.Text = i.ToString();
            dr.Close();
            cn.Close();
        }

        private void CountSales()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT SUM(totalamount) FROM tblSales WHERE DATEDIFF(DAY,datetime,GETDATE() )<1", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = dr[0].ToString();
            }
            dr.Close();
            cn.Close();
            label7.Text = "Daily Sales (" + DateTime.Today.ToString("D") + ")";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            formadmin.menuToolStripMenuItem.Text = "Stocks";
            formadmin.panel3.Controls.Clear();
            FormStocks form = new FormStocks(formadmin);
            form.TopLevel = false;
            formadmin.panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            formadmin.menuToolStripMenuItem.Text = "Menu";
            formadmin.panel3.Controls.Clear();
            FormMenu form = new FormMenu();
            form.TopLevel = false;
            formadmin.panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            formadmin.menuToolStripMenuItem.Text = "User Accounts";
            formadmin.panel3.Controls.Clear();
            FormUserAccounts form = new FormUserAccounts();
            form.TopLevel = false;
            formadmin.panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            formadmin.menuToolStripMenuItem.Text = "Sales Report";
            formadmin.panel3.Controls.Clear();
            FormSalesReport form = new FormSalesReport();
            form.TopLevel = false;
            formadmin.panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
