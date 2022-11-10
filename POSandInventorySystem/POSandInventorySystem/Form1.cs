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
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        
        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string id = "";
            string username = "";
            string role = "";
            string name = "";
            string status = "";
            string email = "";
            string address = "";
            string contactno = "";

            try
            {

                Boolean found = false;
                Boolean isEmpty = false;
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM tblUser ", cn);
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
                    cn.Open();
                    cmd = new SqlCommand("INSERT INTO tblUser(username,password,name,role,status)VALUES('admin','admin','Admin','Admin','Active')", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("(Default username: admin,Default password: admin)", "Admin Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cn.Open();
                    cmd = new SqlCommand("SELECT * FROM tblUser WHERE username = @username AND password = @password", cn);
                    cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        found = true;
                        id = dr["id"].ToString();
                        username = dr["username"].ToString();
                        name = dr["name"].ToString();
                        role = dr["role"].ToString();
                        status = dr["status"].ToString();
                        email = dr["email"].ToString();
                        address = dr["address"].ToString();
                        contactno = dr["contactno"].ToString();
                    }
                    else
                    {
                        found = false;
                    }
                    cn.Close();
                    if (found)
                    {
                        if (status == "Active")
                        {
                            if (role == "Admin") 
                            {
                                MessageBox.Show("Welcome " + name + "!", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                usernameTextBox.Clear();
                                passwordTextBox.Clear();
                                this.Hide();
                                FormAdmin form = new FormAdmin();
                                form.nameToolStripMenuItem.Text = name;
                                form.id = id;
                                form.username = username;
                                form.name = name;
                                form.role = role;
                                form.email = email;
                                form.address = address;
                                form.contactno = contactno;
                                form.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Welcome " + name + "!", "Cashier Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                usernameTextBox.Clear();
                                passwordTextBox.Clear();
                                this.Hide();
                                FormCashier form = new FormCashier();
                                form.nameToolStripMenuItem.Text = name;
                                form.id = id;
                                form.username = username;
                                form.name = name;
                                form.role = role;
                                form.email = email;
                                form.address = address;
                                form.contactno = contactno;
                                form.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("This account is currently deactivated", "Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
    }
}
