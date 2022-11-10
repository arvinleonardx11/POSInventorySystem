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
    public partial class FormStocks : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string username;
        string id;
        string quantity;
        string reorderlevel;
        string stockname;
        FormAdmin form;
        public FormStocks(FormAdmin formAdmin)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            Default();
            LoadStocks();
            LoadComboBox();
            form = formAdmin;
        }

        private void Default()
        {
            addStocksButton.Enabled = true;
            nameTextBox.Enabled = false;
            categoryComboBox.Enabled = false;
            unitmeasurementTextBox.Enabled = false;
            reorderlevelTextBox.Enabled = false;
            stockinTextBox.Enabled = false;
            stockoutTextBox.Enabled = false;
            nameTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
            unitmeasurementTextBox.Text = "";
            reorderlevelTextBox.Text = "";
            stockinTextBox.Text = "";
            stockoutTextBox.Text = "";
            saveupdateButton.Visible = false;
            clearcancelButton.Visible = false;
            editButton.Visible = false;
            deleteButton.Visible = false;
            stockinstockoutButton.Visible = false;
            updatestocksButton.Visible = false;
            cancelButton.Visible = false;
        }

        public void LoadStocks()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblStock WHERE name LIKE '" + searchTextBox.Text + "%' OR category LIKE '" + searchTextBox.Text + "%' OR unitmeasurement LIKE '" + searchTextBox.Text + "%' OR reorderlevel LIKE '" + searchTextBox.Text + "%' OR quantity LIKE '" + searchTextBox.Text + "%' OR status LIKE '" + searchTextBox.Text + "%'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());

            }
            dr.Close();
            cn.Close();
        }

        public void LoadComboBox()
        {
            //categoryComboBox.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT category FROM tblCategory WHERE usefor LIKE 'Stocks'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categoryComboBox.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void addStocksButton_Click(object sender, EventArgs e)
        {
            addStocksButton.Enabled = true;
            nameTextBox.Enabled = true;
            categoryComboBox.Enabled = true;
            unitmeasurementTextBox.Enabled = true;
            reorderlevelTextBox.Enabled = true;
            stockinTextBox.Enabled = false;
            stockoutTextBox.Enabled = false;
            nameTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
            unitmeasurementTextBox.Text = "";
            reorderlevelTextBox.Text = "";
            stockinTextBox.Text = "";
            stockoutTextBox.Text = "";
            saveupdateButton.Visible = true;
            saveupdateButton.Tag = "Save";
            saveupdateButton.BackgroundImage = Properties.Resources.Asset_7;
            clearcancelButton.Visible = true;
            clearcancelButton.Tag = "Cancel";
            clearcancelButton.BackgroundImage = Properties.Resources.Asset_14;
            editButton.Visible = false;
            deleteButton.Visible = false;
            stockinstockoutButton.Visible = false;
            updatestocksButton.Visible = false;
            cancelButton.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                addStocksButton.Enabled = true;
                nameTextBox.Enabled = false;
                categoryComboBox.Enabled = false;
                unitmeasurementTextBox.Enabled = false;
                reorderlevelTextBox.Enabled = false;
                stockinTextBox.Enabled = false;
                stockoutTextBox.Enabled = false;
                stockinTextBox.Text = "";
                stockoutTextBox.Text = "";
                saveupdateButton.Visible = false;
                clearcancelButton.Visible = false;
                editButton.Visible = true;
                deleteButton.Visible = true;
                stockinstockoutButton.Visible = true;
                updatestocksButton.Visible = false;
                cancelButton.Visible = false;
                id = dataGridView1[1, e.RowIndex].Value.ToString();
                stockname = dataGridView1[2, e.RowIndex].Value.ToString();
                nameTextBox.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                categoryComboBox.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                unitmeasurementTextBox.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                reorderlevelTextBox.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                reorderlevel = dataGridView1[5, e.RowIndex].Value.ToString();
                quantity = dataGridView1[6, e.RowIndex].Value.ToString();
            }
        }

        private void saveupdateButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text=="" || categoryComboBox.Text == "" || unitmeasurementTextBox.Text == "" || reorderlevelTextBox.Text == "")
            {
                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Enter Stocks Name", "Stocks Name Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameTextBox.Focus();
                }
                else if (categoryComboBox.Text == "")
                {
                    MessageBox.Show("Select Stocks Category", "Stocks Category Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    categoryComboBox.Focus();
                }
                else if (unitmeasurementTextBox.Text == "")
                {
                    MessageBox.Show("Select Stocks Unit Measurement", "Stocks Unit Measurement Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    unitmeasurementTextBox.Focus();
                }
                else if (reorderlevelTextBox.Text == "")
                {
                    MessageBox.Show("Enter Stocks Reorder Level", "Stocks Reorder Level Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reorderlevelTextBox.Focus();
                }
            }
            else
            {
                if (saveupdateButton.Tag.ToString() == "Save")
                {
                    try
                    {
                        if (MessageBox.Show("Save this Stock?", "Save Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cn.Open();
                            cmd = new SqlCommand("INSERT INTO tblStock(name,category,unitmeasurement,reorderlevel)VALUES(@name,@category,@unitmeasurement,@reorderlevel)", cn);
                            cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                            cmd.Parameters.AddWithValue("@category", categoryComboBox.Text);
                            cmd.Parameters.AddWithValue("@unitmeasurement", unitmeasurementTextBox.Text);
                            cmd.Parameters.AddWithValue("@reorderlevel", reorderlevelTextBox.Text);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            cn.Open();
                            cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                            cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                            cmd.Parameters.AddWithValue("@action", "Added A Stock(" + nameTextBox.Text + ")");
                            cmd.Parameters.AddWithValue("@performedby", username);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Stock Saved Successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            nameTextBox.Text = "";
                            categoryComboBox.SelectedIndex = -1;
                            unitmeasurementTextBox.Text = "";
                            reorderlevelTextBox.Text = "";
                            nameTextBox.Focus();
                            LoadStocks();
                            form.MonitorStocks();
                        }

                    }
                    catch (Exception ex)
                    {
                        cn.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (saveupdateButton.Tag.ToString() == "Update")
                {
                    try
                    {
                        if (MessageBox.Show("Update this Stock?", "Update Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cn.Open();
                            cmd = new SqlCommand("UPDATE tblStock SET name=@name,category=@category,unitmeasurement=@unitmeasurement,reorderlevel=@reorderlevel WHERE id LIKE " + id + "", cn);
                            cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                            cmd.Parameters.AddWithValue("@category", categoryComboBox.Text);
                            cmd.Parameters.AddWithValue("@unitmeasurement", unitmeasurementTextBox.Text);
                            cmd.Parameters.AddWithValue("@reorderlevel", reorderlevelTextBox.Text);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            cn.Open();
                            cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                            cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                            cmd.Parameters.AddWithValue("@action", "Updated A Stock(" + nameTextBox.Text + ")");
                            cmd.Parameters.AddWithValue("@performedby", username);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Stock Updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Default();
                            LoadStocks();
                            form.MonitorStocks();
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

        private void clearcancelButton_Click(object sender, EventArgs e)
        {
            if (clearcancelButton.Tag.ToString() == "Cancel")
            {
                Default();
            }
            else if (clearcancelButton.Tag.ToString() == "Clear")
            {
                nameTextBox.Text = "";
                categoryComboBox.SelectedIndex = -1;
                unitmeasurementTextBox.Text = "";
                reorderlevelTextBox.Text = "";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Default();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            addStocksButton.Enabled = true;
            nameTextBox.Enabled = true;
            categoryComboBox.Enabled = true;
            unitmeasurementTextBox.Enabled = true;
            reorderlevelTextBox.Enabled = true;
            stockinTextBox.Enabled = false;
            stockoutTextBox.Enabled = false;
            stockinTextBox.Text = "";
            stockoutTextBox.Text = "";
            saveupdateButton.Visible = true;
            saveupdateButton.Tag = "Update";
            saveupdateButton.BackgroundImage = Properties.Resources.Asset_12;
            clearcancelButton.Visible = true;
            clearcancelButton.Tag = "Clear";
            clearcancelButton.BackgroundImage = Properties.Resources.Asset_13;
            editButton.Visible = false;
            deleteButton.Visible = false;
            stockinstockoutButton.Visible = false;
            updatestocksButton.Visible = false;
            cancelButton.Visible = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Stock?", "Delete Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cmd = new SqlCommand("DELETE FROM tblStock WHERE id LIKE " + id + "", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Open();
                cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@action", "Deleted A Stock(" + nameTextBox.Text + ")");
                cmd.Parameters.AddWithValue("@performedby", username);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Stock Deleted Successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Default();
                LoadStocks();
                form.MonitorStocks();
            }
        }

        private void stockinstockoutButton_Click(object sender, EventArgs e)
        {
            addStocksButton.Enabled = true;
            nameTextBox.Enabled = false;
            categoryComboBox.Enabled = false;
            unitmeasurementTextBox.Enabled = false;
            reorderlevelTextBox.Enabled = false;
            stockinTextBox.Enabled = true;
            stockoutTextBox.Enabled = true;
            nameTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
            unitmeasurementTextBox.Text = "";
            reorderlevelTextBox.Text = "";
            stockinTextBox.Text = "";
            stockoutTextBox.Text = "";
            saveupdateButton.Visible = false;
            clearcancelButton.Visible = false;
            editButton.Visible = false;
            deleteButton.Visible = false;
            stockinstockoutButton.Visible = false;
            updatestocksButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void updatestocksButton_Click(object sender, EventArgs e)
        {
            if(stockinTextBox.Text=="" || stockoutTextBox.Text == "")
            {
                if (stockinTextBox.Text == "")
                {
                    MessageBox.Show("Enter Stock In Value", "Stock In Value Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stockinTextBox.Focus();
                }
                else if(stockoutTextBox.Text == "")
                {
                    MessageBox.Show("Enter Stock Out Value", "Stock Out Value Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stockoutTextBox.Focus();
                }
            }
            else
            {
                string status = "";
                double reorder = double.Parse(reorderlevel);
                double initial = double.Parse(quantity);
                double stockin;
                double stockout;
                if (stockoutTextBox.Text == "")
                {
                    stockout = 0;
                }
                else
                {
                    stockout = double.Parse(stockoutTextBox.Text);
                }
                if (stockinTextBox.Text == "")
                {
                    stockin = 0;
                }
                else
                {
                    stockin = double.Parse(stockinTextBox.Text);
                }

                double final = initial + stockin - stockout;

                if (final < reorder)
                {
                    status = "Critical";
                }
                else
                {
                    status = "Normal";
                }
                if (final >= 0)
                {
                    try
                    {
                        if (MessageBox.Show("Update this Stocks Quantity?", "Update Stocks Quantity", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cn.Open();
                            cmd = new SqlCommand("UPDATE tblStock SET quantity=@quantity,status=@status WHERE id LIKE " + id + "", cn);
                            cmd.Parameters.AddWithValue("@quantity", final);
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            cn.Open();
                            cmd = new SqlCommand("INSERT INTO tblUserLogs(datetime,action,performedby) VALUES(@datetime,@action,@performedby)", cn);
                            cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                            cmd.Parameters.AddWithValue("@action", "Updated Quantity of Stocks(" + stockname + ")");
                            cmd.Parameters.AddWithValue("@performedby", username);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Stocks Quantity Updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Default();
                            LoadStocks();
                            form.MonitorStocks();
                        }

                    }
                    catch (Exception ex)
                    {
                        cn.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Quantity", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            
        }

        private void reorderlevelTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void stockinTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void stockoutTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadStocks();
        }

        private void stockinTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void stockoutTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dataGridView1.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if ((Myrow.Cells[7].Value.ToString()) == "Critical")// Or your condition 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.DarkGoldenrod;
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Gainsboro;
                }
            }
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void unitmeasurementTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
