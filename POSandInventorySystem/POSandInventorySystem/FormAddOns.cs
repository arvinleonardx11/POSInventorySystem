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
    public partial class FormAddOns : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string username;
        public FormAddOns()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadComboBox();
        }
        public void LoadComboBox()
        {
            //comboCategory.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT category FROM tblCategory WHERE usefor LIKE 'Menu' and addons LIKE 'Yes'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categoryComboBox.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void clearButton2_Click(object sender, EventArgs e)
        {
            nameAddonsTextBox.Text = "";
            priceTextBox.Text = "";
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

        private void saveButton2_Click(object sender, EventArgs e)
        {
            if (nameAddonsTextBox.Text == "" || priceTextBox.Text == "" || categoryComboBox.Text == "")
            {
                if (nameAddonsTextBox.Text == "")
                {
                    MessageBox.Show("Enter Add-Ons Name", "Add-Ons Name Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameAddonsTextBox.Focus();
                }
                else if (priceTextBox.Text == "")
                {
                    MessageBox.Show("Enter Add-Ons Price", "Add-Ons Price Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    priceTextBox.Focus();
                }
                else if(categoryComboBox.Text == "")
                {
                    MessageBox.Show("Select Add-Ons For", "Add-Ons For Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    categoryComboBox.Focus();
                }
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Save this Add-Ons?", "Save Add-Ons", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cmd = new SqlCommand("INSERT INTO tblAddOns(addons,price,addonsfor)VALUES(@addons,@price,@addonsfor)", cn);
                        cmd.Parameters.AddWithValue("@addons", nameAddonsTextBox.Text);
                        cmd.Parameters.AddWithValue("@price", priceTextBox.Text);
                        cmd.Parameters.AddWithValue("@addonsfor", categoryComboBox.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        cn.Open();
                        cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                        cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@action", "Added An Add-Ons(" + nameAddonsTextBox.Text + ")");
                        cmd.Parameters.AddWithValue("@performedby", username);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Add-Ons Saved Successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nameAddonsTextBox.Text = "";
                        priceTextBox.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void nameAddonsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
