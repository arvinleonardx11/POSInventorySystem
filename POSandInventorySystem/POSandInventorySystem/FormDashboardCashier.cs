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
    public partial class FormDashboardCashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        FormCashier formcashier;
        public FormDashboardCashier(FormCashier form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            CountMenu();
            CountOrders();
            formcashier = form;
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

        private void CountOrders()
        {
            int i = 0;
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblCart WHERE status = 'Ordered'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
            }
            label1.Text = i.ToString();
            dr.Close();
            cn.Close();
        }

        private void FormDashboardCashier_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            formcashier.menuToolStripMenuItem.Text = "POS";
            formcashier.panel3.Controls.Clear();
            FormPOS form = new FormPOS();
            form.TopLevel = false;
            formcashier.panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            formcashier.panel3.Controls.Clear();
            FormOrders form = new FormOrders();
            form.TopLevel = false;
            formcashier.panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
