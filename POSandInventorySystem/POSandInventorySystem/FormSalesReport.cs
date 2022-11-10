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
    public partial class FormSalesReport : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public FormSalesReport()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            DailySales();
            WeeklySales();
            MonthlySales();
            YearlySales();
        }

        private void DailySales()
        {
            int i = 0;
            cn.Open();
            cmd = new SqlCommand("SELECT SUM(totalamount) FROM tblSales WHERE DATEDIFF(DAY,datetime,GETDATE() )<1", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                daily.Text = "Daily Sales: " + dr[0].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void WeeklySales()
        {
            int i = 0;
            cn.Open();
            cmd = new SqlCommand("SELECT SUM(totalamount) FROM tblSales WHERE DATEDIFF(DAY,datetime,GETDATE() )<7", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                weekly.Text = "Weekly Sales: " + dr[0].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void MonthlySales()
        {
            int i = 0;
            cn.Open();
            cmd = new SqlCommand("SELECT SUM(totalamount) FROM tblSales WHERE DATEDIFF(DAY,datetime,GETDATE() )<30", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                monthly.Text = "Monthly Sales: " + dr[0].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void YearlySales()
        {
            int i = 0;
            cn.Open();
            cmd = new SqlCommand("SELECT SUM(totalamount) FROM tblSales WHERE DATEDIFF(DAY,datetime,GETDATE() )<365", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                yearly.Text = "Yearly Sales: " + dr[0].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == 0)
            {
                panel4.Controls.Clear();
                FormTable form = new FormTable();
                form.LoadOrdersDaily();
                form.TopLevel = false;
                panel4.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
            if (metroComboBox1.SelectedIndex == 1)
            {
                panel4.Controls.Clear();
                FormTable form = new FormTable();
                form.LoadOrdersWeekly();
                form.TopLevel = false;
                panel4.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
            if (metroComboBox1.SelectedIndex == 2)
            {
                panel4.Controls.Clear();
                FormTable form = new FormTable();
                form.LoadOrdersMonthly();
                form.TopLevel = false;
                panel4.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
            if (metroComboBox1.SelectedIndex == 3)
            {
                panel4.Controls.Clear();
                FormTable form = new FormTable();
                form.LoadOrdersYearly();
                form.TopLevel = false;
                panel4.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
            if (metroComboBox1.SelectedIndex == 4)
            {
                panel4.Controls.Clear();
                FormTable form = new FormTable();
                form.LoadOrders();
                form.TopLevel = false;
                panel4.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex >= 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == 0)
            {
                panel4.Controls.Clear();
                FormChart form = new FormChart();
                form.LoadChartDaily();
                form.TopLevel = false;
                panel4.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
            if (metroComboBox1.SelectedIndex == 1)
            {
                panel4.Controls.Clear();
                FormChart form = new FormChart();
                form.LoadChartWeekly();
                form.TopLevel = false;
                panel4.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
            if (metroComboBox1.SelectedIndex == 2)
            {
                panel4.Controls.Clear();
                FormChart form = new FormChart();
                form.LoadChartMonthly();
                form.TopLevel = false;
                panel4.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
            if (metroComboBox1.SelectedIndex == 3)
            {
                panel4.Controls.Clear();
                FormChart form = new FormChart();
                form.LoadChartYearly();
                form.TopLevel = false;
                panel4.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
            if (metroComboBox1.SelectedIndex == 4)
            {
                panel4.Controls.Clear();
                FormChart form = new FormChart();
                form.LoadChart();
                form.TopLevel = false;
                panel4.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
        }

        private void daily_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    
}
