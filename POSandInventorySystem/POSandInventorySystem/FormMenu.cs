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
    public partial class FormMenu : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string id;
        public string username;
        public FormMenu()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            Default();
            LoadMenu();
            LoadComboBox();
        }
        private void Default()
        {
            nameTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
            sizeComboBox.SelectedIndex = -1;
            priceTextBox.Text = "";
            addMenuButton.Enabled = true;
            nameTextBox.Enabled = false;
            categoryComboBox.Enabled = false;
            sizeComboBox.Enabled = false;
            priceTextBox.Enabled = false;
            firstButton.Visible = false;
            secondButton.Visible = false;
            thirdButton.Visible = false;
        }
        public void LoadMenu()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblMenu WHERE name LIKE '" + searchTextBox.Text + "%' OR category LIKE '" + searchTextBox.Text + "%' OR size LIKE '" + searchTextBox.Text + "%' OR price LIKE '" + searchTextBox.Text + "%'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());

            }
            dr.Close();
            cn.Close();
        }
        public void LoadComboBox()
        {
            //comboCategory.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT category FROM tblCategory WHERE usefor LIKE 'Menu'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categoryComboBox.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void addMenuButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
            sizeComboBox.SelectedIndex = -1;
            priceTextBox.Text = "";
            nameTextBox.Enabled = true;
            categoryComboBox.Enabled = true;
            sizeComboBox.Enabled = true;
            priceTextBox.Enabled = true;
            firstButton.Tag = "Save";
            firstButton.BackgroundImage = Properties.Resources.Asset_7;
            firstButton.Visible = true;
            secondButton.Tag = "Cancel";
            secondButton.BackgroundImage = Properties.Resources.Asset_14;
            secondButton.Visible = true;
            thirdButton.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            if (firstButton.Tag.ToString() == "Edit")
            {
                nameTextBox.Enabled = true;
                categoryComboBox.Enabled = true;
                sizeComboBox.Enabled = true;
                priceTextBox.Enabled = true;
                firstButton.Visible = false;
                secondButton.Tag = "Clear";
                secondButton.BackgroundImage = Properties.Resources.Asset_13;
                secondButton.Visible = true;
                thirdButton.Visible = true;
            }
            if (firstButton.Tag.ToString() == "Save")
            {

                if (nameTextBox.Text == "" || categoryComboBox.Text == "" || sizeComboBox.Text == "" || priceTextBox.Text == "")
                {
                    if (nameTextBox.Text == "")
                    {
                        MessageBox.Show("Enter Menu Name", "Menu Name Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (categoryComboBox.Text == "")
                    {
                        MessageBox.Show("Select Menu Category", "Menu Category Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (sizeComboBox.Text == "")
                    {
                        MessageBox.Show("Select Menu Size", "Menu Size Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (priceTextBox.Text == "")
                    {
                        MessageBox.Show("Enter Menu Price", "Menu Price Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("Save this Menu?", "Save Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cn.Open();
                            cmd = new SqlCommand("INSERT INTO tblMenu(name,category,size,price)VALUES(@name,@category,@size,@price)", cn);
                            cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                            cmd.Parameters.AddWithValue("@category", categoryComboBox.Text);
                            cmd.Parameters.AddWithValue("@size", sizeComboBox.Text);
                            cmd.Parameters.AddWithValue("@price", priceTextBox.Text);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            cn.Open();
                            cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                            cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                            cmd.Parameters.AddWithValue("@action", "Added A Menu(" + nameTextBox.Text + ")");
                            cmd.Parameters.AddWithValue("@performedby", username);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Menu Saved Successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            nameTextBox.Text = "";
                            categoryComboBox.Text = "";
                            sizeComboBox.Text = "";
                            priceTextBox.Text = "";
                            nameTextBox.Focus();
                            LoadMenu();
                        }

                    }
                    catch (Exception ex)
                    {
                        cn.Close();
                        MessageBox.Show(ex.Message);
                    }
                }

                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                nameTextBox.Enabled = false;
                categoryComboBox.Enabled = false;
                sizeComboBox.Enabled = false;
                priceTextBox.Enabled = false;
                firstButton.Tag = "Edit";
                firstButton.BackgroundImage = Properties.Resources.Asset_9;
                firstButton.Visible = true;
                secondButton.Tag = "Delete";
                secondButton.BackgroundImage = Properties.Resources.Asset_10;
                secondButton.Visible = true;
                thirdButton.Visible = false;
                id = dataGridView1[1, e.RowIndex].Value.ToString();
                nameTextBox.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                categoryComboBox.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                sizeComboBox.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                priceTextBox.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            }
            
        }

        private void secondButton_Click(object sender, EventArgs e)
        {
            if (secondButton.Tag.ToString() == "Cancel")
            {
                Default();
            }
            if(secondButton.Tag.ToString() == "Clear")
            {
                nameTextBox.Text = "";
                categoryComboBox.SelectedIndex = -1;
                sizeComboBox.SelectedIndex = -1;
                priceTextBox.Text = "";
                nameTextBox.Focus();
            }
            if (secondButton.Tag.ToString() == "Delete")
            {
                if (MessageBox.Show("Delete this Menu?", "Delete Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("DELETE FROM tblMenu WHERE id LIKE " + id + "", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    cn.Open();
                    cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                    cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                    cmd.Parameters.AddWithValue("@action", "Deleted A Menu(" + nameTextBox.Text + ")");
                    cmd.Parameters.AddWithValue("@performedby", username);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Menu Deleted Successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Default();
                    LoadMenu();
                }
            }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
           
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void firstButton_TextChanged(object sender, EventArgs e)
        {

        }

        private void thirdButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || categoryComboBox.Text == "" || sizeComboBox.Text == "" || priceTextBox.Text == "") 
            {
                if(nameTextBox.Text == "")
                {
                    MessageBox.Show("Enter Menu Name", "Menu Name Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (categoryComboBox.Text == "")
                {
                    MessageBox.Show("Select Menu Category", "Menu Category Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (sizeComboBox.Text == "")
                {
                    MessageBox.Show("Select Menu Size", "Menu Size Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (priceTextBox.Text == "")
                {
                    MessageBox.Show("Enter Menu Price", "Menu Price Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Update this Menu?", "Update Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cmd = new SqlCommand("UPDATE tblMenu SET name=@name,category=@category,size=@size,price=@price WHERE id LIKE " + id + "", cn);
                        cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@category", categoryComboBox.Text);
                        cmd.Parameters.AddWithValue("@size", sizeComboBox.Text);
                        cmd.Parameters.AddWithValue("@price", priceTextBox.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        cn.Open();
                        cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                        cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@action", "Updated A Menu(" + nameTextBox.Text + ")");
                        cmd.Parameters.AddWithValue("@performedby", username);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Menu Updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nameTextBox.Text = "";
                        categoryComboBox.Text = "";
                        sizeComboBox.Text = "";
                        priceTextBox.Text = "";
                        Default();
                        LoadMenu();
                    }

                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
