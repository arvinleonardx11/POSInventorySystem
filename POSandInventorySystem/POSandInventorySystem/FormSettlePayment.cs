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
    public partial class FormSettlePayment : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        FormPOS form;
        public FormSettlePayment(FormPOS formPOS)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            form = formPOS;

        }
        public void Compute()
        {
            double total = double.Parse(form.totalLabel.Text);
            double discount;
            double finaltotal;
            double payment;
            double change;
            
            if (discountTextBox.Text == "")
            {
                if (paymentTextBox.Text == "")
                {
                    total = double.Parse(form.totalLabel.Text);
                    discount = 0;
                    finaltotal = total - discount;
                    payment = 0;
                    change = payment - finaltotal;
                    totalLabel.Text = finaltotal.ToString("###0.00");
                    changeLabel.Text = change.ToString("###0.00");
                }
                else
                {
                    total = double.Parse(form.totalLabel.Text);
                    discount = 0;
                    finaltotal = total - discount;
                    payment = double.Parse(paymentTextBox.Text);
                    change = payment - finaltotal;
                    totalLabel.Text = finaltotal.ToString("###0.00");
                    changeLabel.Text = change.ToString("###0.00");
                }
            }else if (paymentTextBox.Text == "")
            {
                if (discountTextBox.Text == "")
                {
                    total = double.Parse(form.totalLabel.Text);
                    discount = 0;
                    finaltotal = total - discount;
                    payment = 0;
                    change = payment - finaltotal;
                    totalLabel.Text = finaltotal.ToString("###0.00");
                    changeLabel.Text = change.ToString("###0.00");
                }
                else
                {
                    total = double.Parse(form.totalLabel.Text);
                    discount = double.Parse(discountTextBox.Text);
                    finaltotal = total - discount;
                    payment = 0;
                    change = payment - finaltotal;
                    totalLabel.Text = finaltotal.ToString("###0.00");
                    changeLabel.Text = change.ToString("###0.00");
                }
            }
            else
            {
                total = double.Parse(form.totalLabel.Text);
                discount = double.Parse(discountTextBox.Text);
                finaltotal = total - discount;
                payment = double.Parse(paymentTextBox.Text);
                change = payment - finaltotal;
                totalLabel.Text = finaltotal.ToString("###0.00");
                changeLabel.Text = change.ToString("###0.00");
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void discountTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void paymentTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (discountTextBox.Text == "")
            {

            }
            else
            {
                Compute();
            }
        }

        private void paymentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (paymentTextBox.Text == "")
            {

            }
            else
            {
                Compute();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Compute();
            if (discountTextBox.Text == "")
            {
                discountTextBox.Text = "0";
            }
            if (paymentTextBox.Text == "")
            {
                paymentTextBox.Text = "0";
            }
            
            if(Double.Parse(changeLabel.Text) <0 || Double.Parse(totalLabel.Text) < 0)
            {
                MessageBox.Show("Can't Settle Invalid Amount", "Settle Payment Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Settle Payment?", "Settle Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cmd = new SqlCommand("INSERT INTO tblSales(datetime,transactionno,discount,totalamount,cashier) VALUES(@datetime,@transactionno,@discount,@totalamount,@cashier)", cn);
                        cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@transactionno", transactionnoLabel.Text);
                        cmd.Parameters.AddWithValue("@discount", discountTextBox.Text);
                        cmd.Parameters.AddWithValue("@totalamount", totalLabel.Text);
                        cmd.Parameters.AddWithValue("@cashier", cashierLabel.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        for (int i = 0; i < form.dataGridView1.Rows.Count; i++)
                        {
                            cn.Open();
                            cmd = new SqlCommand("UPDATE tblCart SET status = 'Ordered' WHERE id LIKE '" + form.dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                        }
                        MessageBox.Show("Settle Successfully.", "Settle Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        form.GetTransactionNo();
                        form.GetData();
                        form.LoadCart();
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
