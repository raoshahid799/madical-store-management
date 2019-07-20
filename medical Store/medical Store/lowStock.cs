using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;

using System.Configuration;

using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_Store
{
    public partial class lowStock : Form
    {
        private SqlDataAdapter adapter8;

        public lowStock()
        {
            InitializeComponent();
        }

        private void lowStock_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.Rows.Clear();
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                String sql = "SELECT medicineId ,name ,manufacture ,medicineType ,date ,price ,shelf ,description ,availableQty FROM medicine WHERE availableQty<='" + qty.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int index = dataGridView1.Rows.Add();
                        DataGridViewRow row = this.dataGridView1.Rows[index];
                        row.Cells["medicineIdColoumn"].Value = reader.GetValue(0);
                        row.Cells["medicineNameColoumn"].Value = reader.GetValue(1);
                        row.Cells["manufactureColoumn"].Value = reader.GetValue(2);
                        row.Cells["medicineTypeColoumn"].Value = reader.GetValue(3);
                        row.Cells["dateColoumn"].Value = reader.GetValue(4);
                        row.Cells["priceColoumn"].Value = reader.GetValue(5);
                        row.Cells["shelfColoumn"].Value = reader.GetValue(6);
                        row.Cells["descriptionColoumn"].Value = reader.GetValue(7);
                        row.Cells["qtyColoumn"].Value = reader.GetValue(8);
                        row.Cells["amountColoumn"].Value = (Convert.ToDecimal(reader.GetValue(5)) * Convert.ToDecimal(reader.GetValue(8))).ToString("0.00");
                    }
                }

                String sql2 = "SELECT * FROM medicine";
                adapter8 = new SqlDataAdapter(sql2, con);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            calculateAmount();
        }

        private void medicineName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicineId ,name ,manufacture ,medicineType ,date ,price ,shelf ,description ,availableQty FROM medicine WHERE availableQty<='" + qty.Text + "' AND  name like '%" + medicineName.Text + "%'";

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int index = dataGridView1.Rows.Add();
                        DataGridViewRow row = this.dataGridView1.Rows[index];

                        row.Cells["medicineIdColoumn"].Value = reader.GetValue(0);
                        row.Cells["medicineNameColoumn"].Value = reader.GetValue(1);
                        row.Cells["manufactureColoumn"].Value = reader.GetValue(2);
                        row.Cells["medicineTypeColoumn"].Value = reader.GetValue(3);
                        row.Cells["dateColoumn"].Value = reader.GetValue(4);
                        row.Cells["priceColoumn"].Value = reader.GetValue(5);
                        row.Cells["shelfColoumn"].Value = reader.GetValue(6);
                        row.Cells["descriptionColoumn"].Value = reader.GetValue(7);
                        row.Cells["qtyColoumn"].Value = reader.GetValue(8);
                        row.Cells["amountColoumn"].Value = (Convert.ToDecimal(reader.GetValue(5)) * Convert.ToDecimal(reader.GetValue(8))).ToString("0.00");
                    }
                }

                String sql2 = "SELECT * FROM medicine WHERE availableQty<='" + qty.Text + "' AND  name like '%" + medicineName.Text + "%' ";
                adapter8 = new SqlDataAdapter(sql2, con);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            calculateAmount(); //calculate the total amount of medicine
        }

        private void qtySearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (qty.Text == "")
                {
                    MessageBox.Show("Please Enter valid Character Then Search", "Medicine Management", MessageBoxButtons.OK);
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    String sql = "SELECT medicineId ,name ,manufacture ,medicineType ,date ,price ,shelf ,description ,availableQty FROM medicine WHERE availableQty<='" + qty.Text + "'";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int index = dataGridView1.Rows.Add();
                            DataGridViewRow row = this.dataGridView1.Rows[index];

                            row.Cells["medicineIdColoumn"].Value = reader.GetValue(0);
                            row.Cells["medicineNameColoumn"].Value = reader.GetValue(1);
                            row.Cells["manufactureColoumn"].Value = reader.GetValue(2);
                            row.Cells["medicineTypeColoumn"].Value = reader.GetValue(3);
                            row.Cells["dateColoumn"].Value = reader.GetValue(4);
                            row.Cells["priceColoumn"].Value = reader.GetValue(5);
                            row.Cells["shelfColoumn"].Value = reader.GetValue(6);
                            row.Cells["descriptionColoumn"].Value = reader.GetValue(7);
                            row.Cells["qtyColoumn"].Value = reader.GetValue(8);
                            row.Cells["amountColoumn"].Value = (Convert.ToDecimal(reader.GetValue(5)) * Convert.ToDecimal(reader.GetValue(8))).ToString("0.00");
                        }
                    }

                    String sql2 = "SELECT * FROM medicine WHERE availableQty<='" + qty.Text + "'";
                    adapter8 = new SqlDataAdapter(sql2, con);

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            calculateAmount(); // calcatute total amount of medicine
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                if (medicineId.Text == "")
                {
                    MessageBox.Show("Please Enter valid Character Then Search", "Medicine Management", MessageBoxButtons.OK);
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    String sql = "SELECT medicineId ,name ,manufacture ,medicineType ,date ,price ,shelf ,description ,availableQty FROM medicine WHERE availableQty<='" + qty.Text + "' AND medicineId='" + medicineId.Text + "'";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int index = dataGridView1.Rows.Add();
                            DataGridViewRow row = this.dataGridView1.Rows[index];

                            row.Cells["medicineIdColoumn"].Value = reader.GetValue(0);
                            row.Cells["medicineNameColoumn"].Value = reader.GetValue(1);
                            row.Cells["manufactureColoumn"].Value = reader.GetValue(2);
                            row.Cells["medicineTypeColoumn"].Value = reader.GetValue(3);
                            row.Cells["dateColoumn"].Value = reader.GetValue(4);
                            row.Cells["priceColoumn"].Value = reader.GetValue(5);
                            row.Cells["shelfColoumn"].Value = reader.GetValue(6);
                            row.Cells["descriptionColoumn"].Value = reader.GetValue(7);
                            row.Cells["qtyColoumn"].Value = reader.GetValue(8);
                            row.Cells["amountColoumn"].Value = (Convert.ToDecimal(reader.GetValue(5)) * Convert.ToDecimal(reader.GetValue(8))).ToString("0.00");
                        }
                    }

                    String sql2 = "SELECT * FROM medicine WHERE  availableQty<='" + qty.Text + "' AND medicineId='" + medicineId.Text + "'";
                    adapter8 = new SqlDataAdapter(sql2, con);

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            calculateAmount();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicineId ,name ,manufacture ,medicineType ,date ,price ,shelf ,description ,availableQty FROM medicine WHERE availableQty<='" + qty.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int index = dataGridView1.Rows.Add();
                        DataGridViewRow row = this.dataGridView1.Rows[index];

                        row.Cells["medicineIdColoumn"].Value = reader.GetValue(0);
                        row.Cells["medicineNameColoumn"].Value = reader.GetValue(1);
                        row.Cells["manufactureColoumn"].Value = reader.GetValue(2);
                        row.Cells["medicineTypeColoumn"].Value = reader.GetValue(3);
                        row.Cells["dateColoumn"].Value = reader.GetValue(4);
                        row.Cells["priceColoumn"].Value = reader.GetValue(5);
                        row.Cells["shelfColoumn"].Value = reader.GetValue(6);
                        row.Cells["descriptionColoumn"].Value = reader.GetValue(7);
                        row.Cells["qtyColoumn"].Value = reader.GetValue(8);
                        row.Cells["amountColoumn"].Value = (Convert.ToDecimal(reader.GetValue(5)) * Convert.ToDecimal(reader.GetValue(8))).ToString("0.00");
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            calculateAmount();
        }

        private void calculateAmount()
        {
            decimal nAmount = 0;
            decimal nQty = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1["amountColoumn", i].Value != DBNull.Value)
                    nAmount += Convert.ToDecimal(dataGridView1["amountColoumn", i].Value);
                if (dataGridView1["qtyColoumn", i].Value != DBNull.Value)
                    nQty += Convert.ToDecimal(dataGridView1["qtyColoumn", i].Value);
            }

            netAmount.Text = nAmount.ToString("0.00");
            netQty.Text = nQty.ToString("0.00");
        }

        private void report_Click(object sender, EventArgs e)
        {
            printSaleForm printForm = new printSaleForm();
            stockDataSet dataSet = new stockDataSet();
            dataSet.EnforceConstraints = false;

            lowStockReport report = new lowStockReport();

            try
            {
                adapter8.Fill(dataSet.medicine);

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