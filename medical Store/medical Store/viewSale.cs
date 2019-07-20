using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;using System.Data.SqlClient;
namespace medical_Store
{
    public partial class viewSale : Form
    {
        public viewSale()
        {
            InitializeComponent();
        }

        private void viewSale_Load(object sender, EventArgs e)
        {

            try
            {

                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;


                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT * FROM masterSale";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                if (cashMemoNo.Text == "")
                {
                    MessageBox.Show("Please Enter Text Then Search", "Medicine Management");
                }

                else
                {
                    String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    String sql = "SELECT * FROM masterSale WHERE cashMemoNo='" + cashMemoNo.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void mediName_TextChanged(object sender, EventArgs e)
        {

            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT * FROM masterSale WHERE CustomerName like'%" + customerName.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void searchDate_Click(object sender, EventArgs e)
        {


            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT * FROM masterSale WHERE date BETWEEN '" + fromDate.Text + "' AND '" + toDate.Text + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            decimal nAmount = 0;
            decimal gAmount = 0;
            decimal discount = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (dataGridView1["netDataGridViewTextBoxColumn", i].Value != DBNull.Value)
                    nAmount += Convert.ToDecimal(dataGridView1["netDataGridViewTextBoxColumn", i].Value);

                if (dataGridView1["grossDataGridViewTextBoxColumn", i].Value != DBNull.Value)
                    gAmount += Convert.ToDecimal(dataGridView1["grossDataGridViewTextBoxColumn", i].Value);

                if (dataGridView1["discDataGridViewTextBoxColumn", i].Value != DBNull.Value)
                    discount += Convert.ToDecimal(dataGridView1["discDataGridViewTextBoxColumn", i].Value);

            }

            netAmount.Text = nAmount.ToString("0.00");
            disc.Text = discount.ToString("0.00");
            grossAmount.Text = gAmount.ToString("0.00");

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {


            int index = dataGridView1.CurrentRow.Index;
            String cashMemoId = dataGridView1["cashMemoNoDataGridViewTextBoxColumn", index].Value.ToString();
            updateSale sale = new updateSale(cashMemoId);
            sale.Show();

        }

        private void cashMemoNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {

                e.Handled = true;

            }

        }

        private void report_Click(object sender, EventArgs e)
        {

            printSaleForm printForm = new printSaleForm();
            medicalStoreDataSet7 dataSet = new medicalStoreDataSet7();
            dataSet.EnforceConstraints = false;

            viewSaleReport report = new viewSaleReport();


            try
            {

                DataTable dt = new DataTable();
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {

                    DataRow dr = dt.NewRow();

                    if (row.DataBoundItem != null)
                    {
                        dr = (DataRow)((DataRowView)row.DataBoundItem).Row;

                        dataSet.masterSale.ImportRow(dr);
                    }

                }




                report.SetDataSource(dataSet);


                printForm.crystalReportViewer1.ReportSource = report;
                printForm.Show();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
