using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace POSandInventorySystem
{
    public partial class FormChart : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public FormChart()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public void LoadChart()
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT menuname, ISNULL(SUM(quantity),0) as totalquantity FROM tblCart WHERE status LIKE 'Ordered' GROUP BY menuname", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Quantity");
            chart1.DataSource = ds.Tables["Quantity"];
            Series series1 = chart1.Series["Series1"];
            series1.ChartType = SeriesChartType.Column;
            series1.Name = "Quantity";
            var chart = chart1;
            chart.Series[series1.Name].XValueMember = "menuname";
            chart.Series[series1.Name].YValueMembers = "totalquantity";
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].Font = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
            chart.Series[0].LabelForeColor = Color.White;
            cn.Close();
        }

        public void LoadChartDaily()
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT menuname, ISNULL(SUM(quantity),0) as totalquantity FROM tblCart WHERE status LIKE 'Ordered' AND DATEDIFF(DAY,datetime,GETDATE() )<1 GROUP BY menuname", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Quantity");
            chart1.DataSource = ds.Tables["Quantity"];
            Series series1 = chart1.Series["Series1"];
            series1.ChartType = SeriesChartType.Column;
            series1.Name = "Quantity";
            var chart = chart1;
            chart.Series[series1.Name].XValueMember = "menuname";
            chart.Series[series1.Name].YValueMembers = "totalquantity";
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].Font = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
            chart.Series[0].LabelForeColor = Color.White;
            cn.Close();
        }

        public void LoadChartWeekly()
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT menuname, ISNULL(SUM(quantity),0) as totalquantity FROM tblCart WHERE status LIKE 'Ordered' AND DATEDIFF(DAY,datetime,GETDATE() )<7 GROUP BY menuname", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Quantity");
            chart1.DataSource = ds.Tables["Quantity"];
            Series series1 = chart1.Series["Series1"];
            series1.ChartType = SeriesChartType.Column;
            series1.Name = "Quantity";
            var chart = chart1;
            chart.Series[series1.Name].XValueMember = "menuname";
            chart.Series[series1.Name].YValueMembers = "totalquantity";
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].Font = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
            chart.Series[0].LabelForeColor = Color.White;
            cn.Close();
        }

        public void LoadChartMonthly()
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT menuname, ISNULL(SUM(quantity),0) as totalquantity FROM tblCart WHERE status LIKE 'Ordered' AND DATEDIFF(DAY,datetime,GETDATE() )<30 GROUP BY menuname", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Quantity");
            chart1.DataSource = ds.Tables["Quantity"];
            Series series1 = chart1.Series["Series1"];
            series1.ChartType = SeriesChartType.Column;
            series1.Name = "Quantity";
            var chart = chart1;
            chart.Series[series1.Name].XValueMember = "menuname";
            chart.Series[series1.Name].YValueMembers = "totalquantity";
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].Font = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
            chart.Series[0].LabelForeColor = Color.White;
            cn.Close();
        }

        public void LoadChartYearly()
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT menuname, ISNULL(SUM(quantity),0) as totalquantity FROM tblCart WHERE status LIKE 'Ordered' AND DATEDIFF(DAY,datetime,GETDATE() )<365 GROUP BY menuname", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Quantity");
            chart1.DataSource = ds.Tables["Quantity"];
            Series series1 = chart1.Series["Series1"];
            series1.ChartType = SeriesChartType.Column;
            series1.Name = "Quantity";
            
            var chart = chart1;
            chart.Series[series1.Name].XValueMember = "menuname";

            chart.Series[series1.Name].YValueMembers = "totalquantity";
            chart.Series[0].Font = new Font("Microsoft Sans Serif", 30,FontStyle.Bold);
            chart.Series[0].LabelForeColor = Color.White;
            chart.Series[0].IsValueShownAsLabel = true;
            cn.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
