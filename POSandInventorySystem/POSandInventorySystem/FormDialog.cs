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
    public partial class FormDialog : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string id;
        public string username;
        public Boolean deleteall;
        FormUserLogs form;
        public FormDialog(FormUserLogs form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.form = form;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string password = "";
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM tblUser WHERE username = @username", cn);
                cmd.Parameters.AddWithValue("@username", username);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    password = dr["password"].ToString();
                }
                cn.Close();
                if (passwordTextBox.Text == password)
                {
                    if (deleteall)
                    {
                        if (MessageBox.Show("Delete all logs?", "Clear User Logs", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cn.Open();
                            cmd = new SqlCommand("DELETE FROM tblUserLogs", cn);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("User Logs Cleared.", "User Logs Cleared Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form.LoadUsersLogs();
                            this.Dispose();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Delete this log?", "Delete this Log", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cn.Open();
                            cmd = new SqlCommand("DELETE FROM tblUserLogs WHERE id LIKE " + id + "", cn);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("User Logs Data Deleted.", "User Log Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form.LoadUsersLogs();
                            this.Dispose();

                        }
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect Password", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
