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
    public partial class FormPOS : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        private Button button = new Button();
        public FormPOS()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            if (dataGridView1.RowCount == 0)
            {
                button2.Enabled = true;
                button1.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button2.Enabled = false;
                button1.Enabled = true;
                button3.Enabled = true;
            }
        }

        public void GetTransactionNo()
        {
            try
            {
                string date = DateTime.Now.ToString("yyyyMMdd");
                string transactionno;
                int count;
                cn.Open();
                cmd = new SqlCommand("SELECT TOP 1 transactionno FROM tblCart WHERE transactionno LIKE '" + date + "%' ORDER BY id DESC", cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transactionno = dr[0].ToString();
                    count = int.Parse(transactionno.Substring(8, 4));
                    count = count + 1;
                    transactionLabel.Text = date + count.ToString();
                }
                else
                {
                    transactionno = date + "1001";
                    transactionLabel.Text = transactionno;
                }
                cn.Close();
                
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void GetTableRows()
        {
            
        }

        public void LoadCart()
        {
            try
            {
                dataGridView1.Rows.Clear();
                double total = 0;
                int i = 0;
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM tblCart  WHERE transactionno LIKE '" + transactionLabel.Text + "' AND status LIKE 'On Cart' AND cashier LIKE '" + cashierlabel.Text + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += Double.Parse(dr["total"].ToString());
                    dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["transactionno"].ToString(), dr["menuname"].ToString(), dr["sugarlevel"].ToString(), dr["size"].ToString(), dr["menuprice"].ToString(), dr["addonsname"].ToString(), dr["addonsprice"].ToString(), dr["subtotal"].ToString(), dr["quantity"].ToString(), dr["total"].ToString());
                }
                dr.Close();
                cn.Close();
                totalLabel.Text = total.ToString("#,##0.00");
                if (dataGridView1.RowCount == 0)
                {
                    button2.Enabled = true;
                    button1.Enabled = false;
                    button3.Enabled = false;
                }
                else
                {
                    button2.Enabled = false;
                    button1.Enabled = true;
                    button3.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cn.Close();
            }
        }

        public void GetData()
        {
            categoryFlowLayoutPanel.Controls.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT category FROM tblCategory WHERE usefor LIKE 'Menu'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                button = new Button();
                button.Width = 290;
                button.Height = 50;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new Font("Microsoft Sans Serif", 16);
                button.Text = dr["category"].ToString();
                button.Tag = dr["category"].ToString();
                button.Click += new EventHandler(OnClickCategory);
                categoryFlowLayoutPanel.Controls.Add(button);
            }
            menuFlowLayoutPanel.Controls.Clear();
            cn.Close();
            cn.Open();
            cmd = new SqlCommand("SELECT DISTINCT name FROM tblMenu", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                button = new Button();
                button.Width = 100;
                button.Height = 100;
                button.BackColor = Color.PaleGoldenrod;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new Font("Microsoft Sans Serif", 16);
                button.Text = dr["name"].ToString();
                button.Tag = dr["name"].ToString();
                button.Click += new EventHandler(OnClickMenu);
                menuFlowLayoutPanel.Controls.Add(button);


            }
            cn.Close();
        }
        public void OnClickMenu(object sender, EventArgs e)
        {
            String tag = ((Button)sender).Tag.ToString();
            FormOrderInfo form = new FormOrderInfo(this);
            form.menuLabel.Text = tag;
            form.ShowDialog();

        }

        public void OnClickCategory(object sender, EventArgs e)
        {
            String tag = ((Button)sender).Tag.ToString();
            menuFlowLayoutPanel.Controls.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT DISTINCT name FROM tblMenu WHERE category LIKE '" + tag + "'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                button = new Button();
                button.Width = 100;
                button.Height = 100;
                button.BackColor = Color.PaleGoldenrod;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new Font("Microsoft Sans Serif", 10);
                button.Text = dr["name"].ToString();
                button.Tag = dr["name"].ToString();
                button.Click += new EventHandler(OnClickMenu);
                menuFlowLayoutPanel.Controls.Add(button);
            }
            cn.Close();
        }

        private void FormPOS_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetTransactionNo();
            GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSettlePayment form = new FormSettlePayment(this);
            form.cashierLabel.Text = cashierlabel.Text;
            form.transactionnoLabel.Text = transactionLabel.Text;
            form.totalLabel.Text = totalLabel.Text;
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FormOrderInfo form = new FormOrderInfo(this);
                form.cartid = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                form.menuLabel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.sugarlevel = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.sugarlevelLabel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.size = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.priceLabel.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.addonsLabel.Text="Add-Ons: "+ dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.addons = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.addonspriceLabel.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (form.addonspriceLabel.Text == "")
                {
                    form.addonspriceLabel.Text = "0";
                }
                form.subtotalLabel.Text= dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.quantityTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.totalLabel.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                form.Compute();
                form.button2.Text = "Update";
                form.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Remove Item from Cart?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("DELETE FROM tblCart WHERE id LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item Removed from the Cart Successfully.", "Item Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cn.Open();
                cmd = new SqlCommand("DELETE FROM tblCart  WHERE id LIKE '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            MessageBox.Show("Cart Cleared Successfully.", "Cart Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCart();
        }

        private void menuFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
