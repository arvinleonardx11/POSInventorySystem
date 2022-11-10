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
    public partial class FormSettings : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string username;
        public FormSettings()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Settings - Category";
            panel2.Controls.Clear();
            FormCategory form = new FormCategory();
            form.username = username;
            form.TopLevel = false;
            panel2.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void addOnsButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Settings - Add-Ons";
            panel2.Controls.Clear();
            FormAddOns form = new FormAddOns();
            form.username = username;
            form.TopLevel = false;
            panel2.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void clearButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void saveButton2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void nameCategoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nameCategoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void nameAddonsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
