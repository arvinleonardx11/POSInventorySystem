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
    public partial class FormChangePassword : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string username;
        public FormChangePassword()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            oldPasswordTextBox.Clear();
            newPasswordTextBox.Clear();
            retypeNewPasswordTextBox.Clear();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string password = "";
            if(oldPasswordTextBox.Text=="" || newPasswordTextBox.Text=="" || retypeNewPasswordTextBox.Text == "")
            {
                if (oldPasswordTextBox.Text == "")
                {
                    MessageBox.Show("Enter Old Password", "Old Password Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    oldPasswordTextBox.Focus();
                }
                else if (newPasswordTextBox.Text == "")
                {
                    MessageBox.Show("Enter New Password", "New Password Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    newPasswordTextBox.Focus();
                }
                else if (retypeNewPasswordTextBox.Text == "")
                {
                    MessageBox.Show("Enter Retype New Password", "Retype New Password Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    retypeNewPasswordTextBox.Focus();
                }
            }
            else
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand("SELECT * FROM tblUser WHERE username = @username", cn);
                    cmd.Parameters.AddWithValue("@username", usernameLabel.Text);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        password = dr["password"].ToString();
                    }
                    cn.Close();
                    if (password == oldPasswordTextBox.Text)
                    {
                        if (newPasswordTextBox.Text == retypeNewPasswordTextBox.Text)
                        {
                            cn.Open();
                            cmd = new SqlCommand("UPDATE tblUser SET password=@password WHERE username = @username", cn);
                            cmd.Parameters.AddWithValue("@password", newPasswordTextBox.Text);
                            cmd.Parameters.AddWithValue("@username", usernameLabel.Text);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            cn.Open();
                            cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                            cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                            cmd.Parameters.AddWithValue("@action", "Change Password");
                            cmd.Parameters.AddWithValue("@performedby", username);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Password changed successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            oldPasswordTextBox.Clear();
                            newPasswordTextBox.Clear();
                            retypeNewPasswordTextBox.Clear();


                        }
                        else
                        {
                            MessageBox.Show("New Password didn't match", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            newPasswordTextBox.Clear();
                            retypeNewPasswordTextBox.Clear();
                            newPasswordTextBox.Focus();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Old Password", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        oldPasswordTextBox.Clear();
                        newPasswordTextBox.Clear();
                        retypeNewPasswordTextBox.Clear();
                        oldPasswordTextBox.Focus();
                    }
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            usernameLabel.Parent = pictureBox2;
            label2.Parent = pictureBox2;
            label3.Parent = pictureBox2;
            label4.Parent = pictureBox2;
            submitButton.Parent = pictureBox2;
            clearButton.Parent = pictureBox2;
            usernameLabel.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            clearButton.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
