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
    public partial class FormProfile : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string id = "";
        public string username;
        FormAdmin forma;
        FormCashier formc;
        public FormProfile(FormAdmin forma,FormCashier formc)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.forma = forma;
            this.formc = formc;

        }

        public void LoadProfileInformation(string id)
        {
            
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblUser WHERE id = @id", cn);
            cmd.Parameters.AddWithValue("@id", id);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                this.id = dr["id"].ToString();
                usernameLabel.Text = dr["username"].ToString();
                nameTextBox.Text = dr["name"].ToString();
                emailTextBox.Text = dr["email"].ToString();
                addressTextBox.Text = dr["address"].ToString();
                contactnoTextBox.Text = dr["contactno"].ToString();
            }
            else
            {
                MessageBox.Show("Account not Found", "Account not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cn.Close();
            editProfileButton.Enabled = true;
            nameTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            addressTextBox.Enabled = false;
            contactnoTextBox.Enabled = false;
            updateButton.Visible = false;
            cancelButton.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            editProfileButton.Enabled = true;
            nameTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            addressTextBox.Enabled = true;
            contactnoTextBox.Enabled = true;
            updateButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            LoadProfileInformation(id);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "" || emailTextBox.Text=="" || addressTextBox.Text == "" || contactnoTextBox.Text == "")
            {
                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Enter Name", "Name Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameTextBox.Focus();
                }
                if (emailTextBox.Text == "")
                {
                    MessageBox.Show("Enter Email", "Email Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailTextBox.Focus();
                }
                else if (addressTextBox.Text == "")
                {
                    MessageBox.Show("Enter Address", "Address Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addressTextBox.Focus();
                }
                else if (contactnoTextBox.Text == "")
                {
                    MessageBox.Show("Enter Contact Number", "Contact Number Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contactnoTextBox.Focus();
                }
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Update your Profile?", "Update Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cmd = new SqlCommand("UPDATE tblUser SET name=@name,email=@email,address=@address,contactno=@contactno WHERE id LIKE " + id + "", cn);
                        cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                        cmd.Parameters.AddWithValue("@contactno", contactnoTextBox.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        cn.Open();
                        cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                        cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@action", "Update Profile");
                        cmd.Parameters.AddWithValue("@performedby", username);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Profile Updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProfileInformation(id);
                        if (formc == null)
                        {
                            forma.nameToolStripMenuItem.Text = nameTextBox.Text;
                        }else if(forma == null)
                        {
                            formc.nameToolStripMenuItem.Text = nameTextBox.Text;
                        }
                    }

                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void contactnoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45)
            {

            }
            else if (e.KeyChar == 8)
            {

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            usernameLabel.Parent = pictureBox2;
            label2.Parent = pictureBox2;
            label3.Parent = pictureBox2;
            label6.Parent = pictureBox2;
            label5.Parent = pictureBox2;
            editProfileButton.Parent = pictureBox2;
            usernameLabel.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            editProfileButton.BackColor = Color.Transparent;
        }

        private void addressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
