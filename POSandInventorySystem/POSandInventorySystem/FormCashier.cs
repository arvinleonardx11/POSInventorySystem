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
    public partial class FormCashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string id = "";
        public string username = "";
        public string role = "";
        public string name = "";
        public string status = "";
        public string email = "";
        public string address = "";
        public string contactno = "";
        int panelWidth;
        bool hidden;
        public FormCashier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            panelWidth = 250;
            hidden = true;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Dispose();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfile form = new FormProfile(null,this);
            form.username = name;
            form.LoadProfileInformation(id);
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                panel1.Width = panel1.Width + 250;
                if (panel1.Width >= panelWidth)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel1.Width = panel1.Width - 250;
                if (panel1.Width <= 0)
                {
                    timer1.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void changePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePassword form = new FormChangePassword();
            form.username = name;
            form.usernameLabel.Text = username;
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Text = "POS";

            panel3.Height = 865;
            timer1.Start();
            panel3.Controls.Clear();
            FormPOS form = new FormPOS();
            form.cashierlabel.Text = nameToolStripMenuItem.Text;
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCashier_Load(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Text = "Dashboard";
            panel3.Controls.Clear();
            FormDashboardCashier form = new FormDashboardCashier(this);
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Text = "Dashboard";
            panel3.Height = 865;
            timer1.Start();
            panel3.Controls.Clear();
            FormDashboardCashier form = new FormDashboardCashier(this);
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Text = "Orders";

            panel3.Height = 865;
            timer1.Start();
            panel3.Controls.Clear();
            FormOrders form = new FormOrders();
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
