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
    public partial class FormAdmin : Form
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
        public FormAdmin()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            panelWidth = 250;
            hidden = true;
            MonitorStocks();
            
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Text = "Dashboard";
            panel3.Controls.Clear();
            FormDashboard form = new FormDashboard(this);
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
        public void MonitorStocks()
        {
            notificationToolStripMenuItem.DropDownItems.Clear();
            Bitmap notification = Properties.Resources.notification;
            Bitmap bell = Properties.Resources.bell;
            Boolean isEmpty = false;
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblStock WHERE status LIKE 'Critical'", cn);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                isEmpty = false;
            }
            else
            {
                isEmpty = true;
            }
            dr.Close();
            cn.Close();
            if (isEmpty)
            {
                notificationToolStripMenuItem.Text = "Notification";
                notificationToolStripMenuItem.Image = bell;
            }
            else
            {
                try
                {
                    int i = 0;
                    int index = 0;
                    cn.Open();
                    cmd = new SqlCommand("SELECT * FROM tblStock WHERE status LIKE 'Critical'", cn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        i++;
                        notificationToolStripMenuItem.Text = "Notification(" + i + ")";
                        notificationToolStripMenuItem.DropDownItems.Add(dr["name"].ToString() + " is low on stocks. Current quantity " + dr["quantity"] + " " + dr["unitmeasurement"]);
                        notificationToolStripMenuItem.DropDownItems[index].Click += Item_Click;
                        notificationToolStripMenuItem.Image = notification;
                        index++;
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void Item_Click(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Text = "Stocks";
            panel3.Controls.Clear();
            FormStocks form = new FormStocks(this);
            form.username = name;
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Dispose();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormProfile form = new FormProfile(this,null);
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
                if (panel1.Width<=0)
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
            menuToolStripMenuItem.Text = "Menu";
            timer1.Start();
            panel3.Controls.Clear();
            FormMenu form = new FormMenu();
            form.username = name;
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            FormSettings form = new FormSettings();
            form.username = name;
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Text = "User Accounts";
            timer1.Start();
            panel3.Controls.Clear();
            FormUserAccounts form = new FormUserAccounts();
            form.username = name;
            form.name = username;
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Text = "Stocks";
            timer1.Start();
            panel3.Controls.Clear();
            FormStocks form = new FormStocks(this);
            form.username = name;
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Text = "Dashboard";
            timer1.Start();
            panel3.Controls.Clear();
            FormDashboard form = new FormDashboard(this);
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Text = "Orders";
            timer1.Start();
            panel3.Controls.Clear();
            FormOrders form = new FormOrders();
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Text = "Sales Report";
            timer1.Start();
            panel3.Controls.Clear();
            FormSalesReport form = new FormSalesReport();
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Text = "User Logs";
            timer1.Start();
            panel3.Controls.Clear();
            FormUserLogs form = new FormUserLogs();
            form.username = username;
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void notificationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
