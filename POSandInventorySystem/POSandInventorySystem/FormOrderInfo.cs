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
    public partial class FormOrderInfo : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        Button button = new Button();
        public string cartid = "";
        string id = "";
        string name = "";
        public string size = "";
        string category = "";
        string price = "";


        string withsugarlevel = "";
        string withaddons = "";

        public string addons = "None";
        string addonsprice = "0.00";
        public string sugarlevel = "None";
        FormPOS fpos;


        public FormOrderInfo(FormPOS form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fpos = form;
        }

        private void GetData()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblMenu WHERE name LIKE '" + menuLabel.Text + "'", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                id = dr["id"].ToString();
                name = dr["name"].ToString();
                size = dr["size"].ToString();
                category = dr["category"].ToString();
                price = dr["price"].ToString();
            }
            cn.Close();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblMenu WHERE name LIKE '" + menuLabel.Text + "'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                button = new Button();
                button.Width = 190;
                button.Height = 30;
                button.BackColor = Color.PaleGoldenrod;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new Font("Microsoft Sans Serif", 10);
                button.Text = dr["size"].ToString();
                button.Tag = dr["id"].ToString();
                button.Click += new EventHandler(OnClickSize);
                sizeFlowLayoutPanel.Controls.Add(button);
            }
            cn.Close();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblCategory WHERE category LIKE '" + category + "'", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                withsugarlevel = dr["sugarlevel"].ToString();
                withaddons = dr["addons"].ToString();
            }
            cn.Close();
            if (withaddons == "Yes")
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM tblAddOns WHERE addonsfor LIKE '"+category+"'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    button = new Button();
                    button.Width = 190;
                    button.Height = 30;
                    button.BackColor = Color.PaleGoldenrod;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font("Microsoft Sans Serif", 10);
                    button.Text = dr["addons"].ToString();
                    button.Tag = dr["id"].ToString();
                    button.Click += new EventHandler(OnClickAddons);
                    addonsFlowLayoutPanel.Controls.Add(button);
                }
                cn.Close();
            }
            else
            {
                label2.Visible = false;
                panel5.Visible = false;
            }
            if (withsugarlevel == "Yes")
            {
                button0.Visible = true;
                button25.Visible = true;
                button50.Visible = true;
                button75.Visible = true;
                button100.Visible = true;
            }
            else
            {
                panel9.Visible = false;
                panel8.Visible = false;
                button0.Visible = false;
                button25.Visible = false;
                button50.Visible = false;
                button75.Visible = false;
                button100.Visible = false;
            }

        }
        public void OnClickSize(object sender, EventArgs e)
        {
            String tag = ((Button)sender).Tag.ToString();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblMenu WHERE id = '" + tag + "'", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                id = dr["id"].ToString();
                name = dr["name"].ToString();
                size = dr["size"].ToString();
                category = dr["category"].ToString();
                price = dr["price"].ToString();
                priceLabel.Text = price;
                quantityTextBox.Text = "1";
                Compute();
            }
            cn.Close();

        }

        public void OnClickAddons(object sender, EventArgs e)
        {
            String tag = ((Button)sender).Tag.ToString();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblAddons WHERE id = '" + tag + "'", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                addons = dr["addons"].ToString();
                addonsprice = dr["price"].ToString();
                addonsLabel.Text = "Add-Ons: " + dr["addons"].ToString();
                addonspriceLabel.Text = dr["price"].ToString();
                quantityTextBox.Text = "1";
                Compute();
            }
            cn.Close();
        }

        public void Compute()
        {
            double price = double.Parse(priceLabel.Text);
            double addons = double.Parse(addonspriceLabel.Text);
            double subtotal = price + addons;
            subtotalLabel.Text = subtotal.ToString("###0.00");
            double quantity = double.Parse(quantityTextBox.Text);
            double total = subtotal * quantity;
            totalLabel.Text = total.ToString("###0.00");
        }

        private void FormOrderInfo_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "")
            {

            }
            else
            {
                Compute();
            }

        }

        private void button0_Click(object sender, EventArgs e)
        {
            sugarlevel = "0%";
            sugarlevelLabel.Text = "0%";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            sugarlevel = "25%";
            sugarlevelLabel.Text = "25%";
        }

        private void button50_Click(object sender, EventArgs e)
        {
            sugarlevel = "50%";
            sugarlevelLabel.Text = "50%";
        }

        private void button75_Click(object sender, EventArgs e)
        {
            sugarlevel = "75%";
            sugarlevelLabel.Text = "75%";
        }

        private void button100_Click(object sender, EventArgs e)
        {
            sugarlevel = "100%";
            sugarlevelLabel.Text = "100%";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "")
            {
                quantityTextBox.Text = "1";
            }
            else
            {
                int quantity = int.Parse(quantityTextBox.Text);
                quantity++;
                quantityTextBox.Text = quantity.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "")
            {
                quantityTextBox.Text = "1";
            }
            else if (int.Parse(quantityTextBox.Text) < 2)
            {
                quantityTextBox.Text = "1";
            }
            else
            {
                int quantity = int.Parse(quantityTextBox.Text);
                quantity--;
                quantityTextBox.Text = quantity.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button2.Text == "Save")
            {
                if (withsugarlevel == "Yes" || withaddons == "Yes")
                {
                    if (priceLabel.Text == "0" || sugarlevelLabel.Text == "" || addonspriceLabel.Text == "0")
                    {
                        if(priceLabel.Text == "0")
                        {
                            MessageBox.Show("Select Size", "Size not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }else if (sugarlevelLabel.Text == "")
                        {
                            MessageBox.Show("Select Sugar Level", "Sugar Level not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }else if (addonspriceLabel.Text == "0")
                        {
                            MessageBox.Show("Select Add-Ons", "Add-ons not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        try
                        {
                            if (MessageBox.Show("Add to Cart?", "Add to Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                cn.Open();
                                cmd = new SqlCommand("INSERT INTO tblCart(datetime,transactionno,menuname,size,menuprice,sugarlevel,addonsname,addonsprice,quantity,subtotal,total,cashier,status) VALUES(@datetime,@transactionno,@menuname,@size,@menuprice,@sugarlevel,@addonsname,@addonsprice,@quantity,@subtotal,@total,@cashier,@status)", cn);
                                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                                cmd.Parameters.AddWithValue("@transactionno", fpos.transactionLabel.Text);
                                cmd.Parameters.AddWithValue("@menuname", menuLabel.Text);
                                cmd.Parameters.AddWithValue("@size", size);
                                cmd.Parameters.AddWithValue("@menuprice", priceLabel.Text);
                                cmd.Parameters.AddWithValue("@sugarlevel", sugarlevel);
                                cmd.Parameters.AddWithValue("@addonsname", addons);
                                cmd.Parameters.AddWithValue("@addonsprice", addonsprice);
                                cmd.Parameters.AddWithValue("@quantity", quantityTextBox.Text);
                                cmd.Parameters.AddWithValue("@subtotal", subtotalLabel.Text);
                                cmd.Parameters.AddWithValue("@total", totalLabel.Text);
                                cmd.Parameters.AddWithValue("@cashier", fpos.cashierlabel.Text);
                                cmd.Parameters.AddWithValue("@status", "On Cart");
                                cmd.ExecuteNonQuery();
                                cn.Close();
                                MessageBox.Show("Add to Cart Successfully.", "Add to Cart Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fpos.LoadCart();
                                this.Dispose();
                            }

                        }
                        catch (Exception ex)
                        {
                            cn.Close();
                            MessageBox.Show(ex.Message);
                        }
                    }
                    
                }
                else
                {
                    if (priceLabel.Text == "0")
                    {
                        MessageBox.Show("Select Size", "Size not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            if (MessageBox.Show("Add to Cart?", "Add to Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                cn.Open();
                                cmd = new SqlCommand("INSERT INTO tblCart(datetime,transactionno,menuname,size,menuprice,quantity,subtotal,total,cashier,status) VALUES(@datetime,@transactionno,@menuname,@size,@menuprice,@quantity,@subtotal,@total,@cashier,@status)", cn);
                                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                                cmd.Parameters.AddWithValue("@transactionno", fpos.transactionLabel.Text);
                                cmd.Parameters.AddWithValue("@menuname", menuLabel.Text);
                                cmd.Parameters.AddWithValue("@size", size);
                                cmd.Parameters.AddWithValue("@menuprice", priceLabel.Text);
                                cmd.Parameters.AddWithValue("@quantity", quantityTextBox.Text);
                                cmd.Parameters.AddWithValue("@subtotal", subtotalLabel.Text);
                                cmd.Parameters.AddWithValue("@total", totalLabel.Text);
                                cmd.Parameters.AddWithValue("@cashier", fpos.cashierlabel.Text);
                                cmd.Parameters.AddWithValue("@status", "On Cart");
                                cmd.ExecuteNonQuery();
                                cn.Close();
                                MessageBox.Show("Add to Cart Successfully.", "Add to Cart Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fpos.LoadCart();
                                this.Dispose();
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
            else if (button2.Text == "Update")
            {
                if (withsugarlevel == "Yes" || withaddons == "Yes")
                {
                    if (priceLabel.Text == "0" || sugarlevelLabel.Text == "" || addonspriceLabel.Text == "0")
                    {
                        if (priceLabel.Text == "0")
                        {
                            MessageBox.Show("Select Size", "Size not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (sugarlevelLabel.Text == "")
                        {
                            MessageBox.Show("Select Sugar Level", "Sugar Level not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (addonspriceLabel.Text == "0")
                        {
                            MessageBox.Show("Select Add-Ons", "Add-ons not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        try
                        {
                            if (MessageBox.Show("Update this Order?", "Update Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                cn.Open();
                                cmd = new SqlCommand("UPDATE tblCart SET datetime=@datetime,transactionno=@transactionno,menuname=@menuname,size=@size,menuprice=@menuprice,sugarlevel=@sugarlevel,addonsname=@addonsname,addonsprice=@addonsprice,quantity=@quantity,subtotal=@subtotal,total=@total,cashier=@cashier,status=@status WHERE id LIKE " + cartid + "", cn);
                                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                                cmd.Parameters.AddWithValue("@transactionno", fpos.transactionLabel.Text);
                                cmd.Parameters.AddWithValue("@menuname", menuLabel.Text);
                                cmd.Parameters.AddWithValue("@size", size);
                                cmd.Parameters.AddWithValue("@menuprice", priceLabel.Text);
                                cmd.Parameters.AddWithValue("@sugarlevel", sugarlevel);
                                cmd.Parameters.AddWithValue("@addonsname", addons);
                                cmd.Parameters.AddWithValue("@addonsprice", addonsprice);
                                cmd.Parameters.AddWithValue("@quantity", quantityTextBox.Text);
                                cmd.Parameters.AddWithValue("@subtotal", subtotalLabel.Text);
                                cmd.Parameters.AddWithValue("@total", totalLabel.Text);
                                cmd.Parameters.AddWithValue("@cashier", fpos.cashierlabel.Text);
                                cmd.Parameters.AddWithValue("@status", "On Cart");
                                cmd.ExecuteNonQuery();
                                cn.Close();
                                MessageBox.Show("Update Order Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fpos.LoadCart();
                                this.Dispose();
                            }

                        }
                        catch (Exception ex)
                        {
                            cn.Close();
                            MessageBox.Show(ex.Message);
                        }
                    }
                    
                }
                else
                {
                    if (priceLabel.Text == "0")
                    {
                        MessageBox.Show("Select Size", "Size not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            if (MessageBox.Show("Update this Order?", "Update Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                cn.Open();
                                cmd = new SqlCommand("UPDATE tblCart SET datetime=@datetime,transactionno=@transactionno,menuname=@menuname,size=@size,menuprice=@menuprice,quantity=@quantity,subtotal=@subtotal,total=@total,cashier=@cashier,status=@status WHERE id LIKE " + cartid + "", cn);
                                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                                cmd.Parameters.AddWithValue("@transactionno", fpos.transactionLabel.Text);
                                cmd.Parameters.AddWithValue("@menuname", menuLabel.Text);
                                cmd.Parameters.AddWithValue("@size", size);
                                cmd.Parameters.AddWithValue("@menuprice", priceLabel.Text);
                                cmd.Parameters.AddWithValue("@quantity", quantityTextBox.Text);
                                cmd.Parameters.AddWithValue("@subtotal", subtotalLabel.Text);
                                cmd.Parameters.AddWithValue("@total", totalLabel.Text);
                                cmd.Parameters.AddWithValue("@cashier", fpos.cashierlabel.Text);
                                cmd.Parameters.AddWithValue("@status", "On Cart");
                                cmd.ExecuteNonQuery();
                                cn.Close();
                                MessageBox.Show("Update Order Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fpos.LoadCart();
                                this.Dispose();
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
        }

        private void discountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
