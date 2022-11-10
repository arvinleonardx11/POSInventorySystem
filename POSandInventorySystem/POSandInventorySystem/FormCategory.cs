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
    public partial class FormCategory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string username;
        public FormCategory()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void clearButton1_Click(object sender, EventArgs e)
        {
            nameCategoryTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
            sugarlevelComboBox.SelectedIndex = -1;
            addonsComboBox.SelectedIndex = -1;
        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
            if (nameCategoryTextBox.Text == "" || categoryComboBox.Text == "" || (sugarlevelComboBox.Visible && sugarlevelComboBox.Text == "") || (addonsComboBox.Visible && addonsComboBox.Text == ""))
            {
                if (nameCategoryTextBox.Text == "")
                {
                    MessageBox.Show("Enter Category Name", "Category Name Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameCategoryTextBox.Focus();
                }
                else if (categoryComboBox.Text == "")
                {
                    MessageBox.Show("Select Category", "Category Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    categoryComboBox.Focus();
                }
                else if (sugarlevelComboBox.Visible && sugarlevelComboBox.Text == "")
                {
                    MessageBox.Show("Select if Sugar Level is needed for this Category", "Sugar Level not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sugarlevelComboBox.Focus();
                }
                else if (addonsComboBox.Visible && addonsComboBox.Text == "")
                {
                    MessageBox.Show("Select if Add-Ons is needed for this Category", "Add-Ons not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addonsComboBox.Focus();
                }
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Save this Category?", "Save Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cmd = new SqlCommand("INSERT INTO tblCategory(category,usefor,sugarlevel,addons)VALUES(@category,@usefor,@sugarlevel,@addons)", cn);
                        cmd.Parameters.AddWithValue("@category", nameCategoryTextBox.Text);
                        cmd.Parameters.AddWithValue("@usefor", categoryComboBox.Text);
                        cmd.Parameters.AddWithValue("@sugarlevel", sugarlevelComboBox.Text);
                        cmd.Parameters.AddWithValue("@addons", addonsComboBox.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        cn.Open();
                        cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                        cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@action", "Added A Category(" + nameCategoryTextBox.Text + ")");
                        cmd.Parameters.AddWithValue("@performedby", username);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Category Saved Successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        nameCategoryTextBox.Text = "";
                        categoryComboBox.SelectedIndex = -1;
                        sugarlevelComboBox.SelectedIndex = -1;
                        addonsComboBox.SelectedIndex = -1;

                    }

                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex == 0)
            {
                sugarlevelComboBox.Visible = true;
                addonsComboBox.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
            }
            else if (categoryComboBox.SelectedIndex == 1 || categoryComboBox.SelectedIndex == -1)
            {
                sugarlevelComboBox.Visible = false;
                addonsComboBox.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
        }

        private void nameCategoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
