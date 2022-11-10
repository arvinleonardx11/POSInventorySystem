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
    public partial class FormUserAccounts : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string username;
        public string name;
        string id;
        public FormUserAccounts()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            Default();
            LoadUsers();
        }
        private void Default()
        {
            addUserButton.Enabled = true;
            usernameTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            nameTextBox.Enabled = false;
            roleComboBox.Enabled = false;
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            nameTextBox.Text = "";
            roleComboBox.SelectedIndex = -1;
            firstButton.Visible = false;
            secondButton.Visible = false;
            thirdButton.Visible = false;
            fourthButton.Visible = false;

        }
        public void LoadUsers()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblUser WHERE username LIKE '" + searchTextBox.Text + "%' OR  role LIKE '" + searchTextBox.Text + "%' OR password LIKE '" + searchTextBox.Text + "%' OR name LIKE '" + searchTextBox.Text + "%' OR status LIKE '" + searchTextBox.Text + "%' OR email LIKE '" + searchTextBox.Text + "%' OR address LIKE '" + searchTextBox.Text + "%' OR contactno LIKE '" + searchTextBox.Text + "%'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[5].ToString());

            }
            dr.Close();
            cn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            addUserButton.Enabled = false;
            usernameTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            nameTextBox.Enabled = true;
            roleComboBox.Enabled = true;
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            nameTextBox.Text = "";
            roleComboBox.SelectedIndex = -1;
            firstButton.Tag = "Save";
            firstButton.BackgroundImage = Properties.Resources.Asset_7;
            firstButton.Visible = true;
            secondButton.Tag = "Clear";
            secondButton.BackgroundImage = Properties.Resources.Asset_13;
            secondButton.Visible = true;
            thirdButton.Tag = "Cancel";
            thirdButton.BackgroundImage = Properties.Resources.Asset_14;
            thirdButton.Visible = true;
            fourthButton.Visible = false;
        }

        private void secondButton_Click(object sender, EventArgs e)
        {
            if (secondButton.Tag.ToString() == "Clear")
            {
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                nameTextBox.Text = "";
                roleComboBox.SelectedIndex = -1;
            }else if (secondButton.Tag.ToString() == "Delete")
            {
                if (MessageBox.Show("Delete this User?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("DELETE FROM tblUser WHERE id LIKE " + id + "", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    cn.Open();
                    cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                    cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                    cmd.Parameters.AddWithValue("@action", "Deleted An User Account(" + nameTextBox.Text + ")");
                    cmd.Parameters.AddWithValue("@performedby", username);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("User Deleted Successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Default();
                    LoadUsers();
                }
            }
        }

        private void thirdButton_Click(object sender, EventArgs e)
        {
            if (thirdButton.Tag.ToString() == "Cancel")
            {
                Default();
            }
            else if(thirdButton.Tag.ToString() == "Activate")
            {
                try
                {
                    if (MessageBox.Show("Activate this User?", "Activate User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cmd = new SqlCommand("UPDATE tblUser SET status='Active' WHERE id LIKE " + id + "", cn);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        cn.Open();
                        cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                        cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@action", "Activated An User Account(" + nameTextBox.Text + ")");
                        cmd.Parameters.AddWithValue("@performedby", username);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("User Activated Successfully.", "Activation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Default();
                        LoadUsers();
                    }

                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else if (thirdButton.Tag.ToString() == "Deactivate")
            {
                try
                {
                    if (MessageBox.Show("Deactivate this User?", "Deactivate User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cmd = new SqlCommand("UPDATE tblUser SET status='Inactive' WHERE id LIKE " + id + "", cn);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        cn.Open();
                        cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                        cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@action", "Deactivated An User Account(" + nameTextBox.Text + ")");
                        cmd.Parameters.AddWithValue("@performedby", username);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("User Deactivated Successfully.", "Deactivation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Default();
                        LoadUsers();
                    }

                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            if (firstButton.Tag.ToString() == "Save")
            {
                if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || nameTextBox.Text == "" || roleComboBox.Text == "")
                {
                    if (usernameTextBox.Text == "")
                    {
                        MessageBox.Show("Enter Username", "Username Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        usernameTextBox.Focus();
                    }
                    else if (passwordTextBox.Text == "")
                    {
                        MessageBox.Show("Enter Password", "Password Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        passwordTextBox.Focus();
                    }
                    else if (nameTextBox.Text == "")
                    {
                        MessageBox.Show("Enter Name", "Name not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        nameTextBox.Focus();
                    }
                    else if (roleComboBox.Text == "")
                    {
                        MessageBox.Show("Select Role", "Role not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        roleComboBox.Focus();
                    }
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("Save this User?", "Save User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cn.Open();
                            cmd = new SqlCommand("INSERT INTO tblUser(username,password,name,role,status)VALUES(@username,@password,@name,@role,@status)", cn);
                            cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                            cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                            cmd.Parameters.AddWithValue("@role", roleComboBox.Text);
                            cmd.Parameters.AddWithValue("@status", "Active");
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            cn.Open();
                            cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                            cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                            cmd.Parameters.AddWithValue("@action", "Added An User Account(" + nameTextBox.Text + ")");
                            cmd.Parameters.AddWithValue("@performedby", username);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("User Saved Successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers();
                            usernameTextBox.Text = "";
                            passwordTextBox.Text = "";
                            nameTextBox.Text = "";
                            roleComboBox.SelectedIndex = -1;
                        }

                    }
                    catch (Exception ex)
                    {
                        cn.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }else if(firstButton.Tag.ToString() == "Edit")
            {
                addUserButton.Enabled = false;
                usernameTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
                nameTextBox.Enabled = true;
                roleComboBox.Enabled = true;
                firstButton.Visible = false;
                firstButton.Tag = "Edit";
                firstButton.BackgroundImage = Properties.Resources.Asset_9;
                secondButton.Tag = "Clear";
                secondButton.BackgroundImage = Properties.Resources.Asset_13;
                secondButton.Visible = true;
                thirdButton.Tag = "Cancel";
                thirdButton.BackgroundImage = Properties.Resources.Asset_14;
                thirdButton.Visible = true;
                fourthButton.Tag = "Update";
                fourthButton.BackgroundImage = Properties.Resources.Asset_12;
                fourthButton.Visible = true;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int i = 0;
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM tblUser WHERE role LIKE 'Admin'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                }
                dr.Close();
                cn.Close();
                if(dataGridView1[5, e.RowIndex].Value.ToString().Equals("Admin"))
                {
                    if (i == 1)
                    {
                        addUserButton.Enabled = true;
                        usernameTextBox.Enabled = false;
                        passwordTextBox.Enabled = false;
                        nameTextBox.Enabled = false;
                        roleComboBox.Enabled = false;
                        firstButton.Tag = "Edit";
                        firstButton.BackgroundImage = Properties.Resources.Asset_9;
                        firstButton.Visible = true;
                        secondButton.Tag = "Delete";
                        secondButton.BackgroundImage = Properties.Resources.Asset_10;
                        secondButton.Visible = false;
                        if (dataGridView1[9, e.RowIndex].Value.ToString().Equals("Active"))
                        {
                            thirdButton.Tag = "Deactivate";
                            thirdButton.BackgroundImage = Properties.Resources.Asset_19;
                        }
                        else if (dataGridView1[9, e.RowIndex].Value.ToString().Equals("Inactive"))
                        {
                            thirdButton.Tag = "Activate";
                            thirdButton.BackgroundImage = Properties.Resources.Asset_20;
                        }
                        thirdButton.Visible = false;
                        fourthButton.Visible = false;
                        id = dataGridView1[1, e.RowIndex].Value.ToString();
                        usernameTextBox.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                        passwordTextBox.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                        nameTextBox.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                        roleComboBox.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                    }
                    else
                    {
                        addUserButton.Enabled = true;
                        usernameTextBox.Enabled = false;
                        passwordTextBox.Enabled = false;
                        nameTextBox.Enabled = false;
                        roleComboBox.Enabled = false;
                        firstButton.Tag = "Edit";
                        firstButton.BackgroundImage = Properties.Resources.Asset_9;
                        firstButton.Visible = true;
                        secondButton.Tag = "Delete";
                        secondButton.BackgroundImage = Properties.Resources.Asset_10;
                        secondButton.Visible = true;
                        if (dataGridView1[9, e.RowIndex].Value.ToString().Equals("Active"))
                        {
                            thirdButton.BackgroundImage = Properties.Resources.Asset_19;
                            thirdButton.Tag = "Deactivate";
                        }
                        else if (dataGridView1[9, e.RowIndex].Value.ToString().Equals("Inactive"))
                        {
                            thirdButton.BackgroundImage = Properties.Resources.Asset_20;
                            thirdButton.Tag = "Activate";
                        }
                        thirdButton.Visible = true;
                        fourthButton.Visible = false;
                        id = dataGridView1[1, e.RowIndex].Value.ToString();
                        usernameTextBox.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                        passwordTextBox.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                        nameTextBox.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                        roleComboBox.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                    }
                }
                else
                {
                    addUserButton.Enabled = true;
                    usernameTextBox.Enabled = false;
                    passwordTextBox.Enabled = false;
                    nameTextBox.Enabled = false;
                    roleComboBox.Enabled = false;
                    firstButton.Tag = "Edit";
                    firstButton.BackgroundImage = Properties.Resources.Asset_9;
                    firstButton.Visible = true;
                    secondButton.Tag = "Delete";
                    secondButton.BackgroundImage = Properties.Resources.Asset_10;
                    secondButton.Visible = true;
                    if (dataGridView1[9, e.RowIndex].Value.ToString().Equals("Active"))
                    {
                        thirdButton.Tag = "Deactivate";
                        thirdButton.BackgroundImage = Properties.Resources.Asset_19;
                    }
                    else if (dataGridView1[9, e.RowIndex].Value.ToString().Equals("Inactive"))
                    {
                        thirdButton.Tag = "Activate";
                        thirdButton.BackgroundImage = Properties.Resources.Asset_20;
                    }
                    thirdButton.Visible = true;
                    fourthButton.Visible = false;
                    id = dataGridView1[1, e.RowIndex].Value.ToString();
                    usernameTextBox.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                    passwordTextBox.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                    nameTextBox.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                    roleComboBox.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                }
                
            }
        }

        private void fourthButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || nameTextBox.Text == "" || roleComboBox.Text == "")
            {
                if (usernameTextBox.Text == "")
                {
                    MessageBox.Show("Enter Username", "Username Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    usernameTextBox.Focus();
                }
                else if (passwordTextBox.Text == "")
                {
                    MessageBox.Show("Enter Password", "Password Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    passwordTextBox.Focus();
                }
                else if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Enter Name", "Name not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameTextBox.Focus();
                }
                else if (roleComboBox.Text == "")
                {
                    MessageBox.Show("Select Role", "Role not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    roleComboBox.Focus();
                }
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Update this User?", "Update Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cmd = new SqlCommand("UPDATE tblUser SET username=@username,password=@password,name=@name,role=@role WHERE id LIKE " + id + "", cn);
                        cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                        cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                        cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@role", roleComboBox.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        cn.Open();
                        cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                        cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@action", "Updated An User Account(" + nameTextBox.Text + ")");
                        cmd.Parameters.AddWithValue("@performedby", username);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("User Updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Default();
                        LoadUsers();
                    }

                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }
    }
}
