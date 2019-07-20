using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class expireStock : Form
    {
        private String curDate = DateTime.Now.ToShortDateString();
        private DateTime exDate = DateTime.Now.Date.AddMonths(3);

        private SqlDataAdapter adapter1, adapter2;

        public expireStock()
        {
            InitializeComponent();
        }

        private void expireStock_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],addStock.stockId AS[Stock ID],addStock.batchNo AS[Batch No.],addStock.receiveDate AS[Product Receive],addStock.mfDate AS[Menufacture Date],addStock.expDate AS[Expire Date],medicine.price AS[Price],addStock.availableQty AS[Available Qty],addStock.availableQty * medicine.price AS[Amount] FROM medicine INNER JOIN addStock ON medicine.medicineId=addStock.medicineId WHERE addStock.expDate BETWEEN '" + curDate + "' AND '" + expireDate.Value.AddMonths(3).ToShortDateString() + "' AND addStock.availableQty>0";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM addStock WHERE expDate BETWEEN '" + curDate + "' AND '" + expireDate.Value.AddMonths(3).ToShortDateString() + "' AND addStock.availableQty>0";
                adapter1 = new SqlDataAdapter(sql1, con);

                String sql2 = "SELECT * FROM medicine";
                adapter2 = new SqlDataAdapter(sql2, con);

                con.Close();
                calculateAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGridView1.Columns[9].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dataGridView1.Columns[9].DefaultCellStyle.BackColor = Color.Red;
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],addStock.stockId AS[Stock ID],addStock.batchNo AS[Batch No.],addStock.receiveDate AS[Product Receive],addStock.mfDate AS[Menufacture Date],addStock.expDate AS[Expire Date],medicine.price AS[Price],addStock.availableQty AS[Available Qty],addStock.availableQty * medicine.price AS[Amount]  FROM medicine INNER JOIN addStock ON medicine.medicineId=addStock.medicineId WHERE addStock.expDate BETWEEN '" + curDate + "' AND '" + expireDate.Value.AddMonths(3).ToShortDateString() + "' AND  medicine.medicineId='" + medicineId.Text + "' AND addStock.availableQty>0";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM addStock WHERE expDate BETWEEN '" + curDate + "' AND '" + expireDate.Value.AddMonths(3).ToShortDateString() + "'AND addStock.availableQty>0";
                adapter1 = new SqlDataAdapter(sql1, con);

                String sql2 = "SELECT * FROM medicine  WHERE medicineId='" + medicineId.Text + "'";
                adapter2 = new SqlDataAdapter(sql2, con);

                con.Close();

                calculateAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void batchSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],addStock.stockId AS[Stock ID],addStock.batchNo AS[Batch No.],addStock.receiveDate AS[Product Receive],addStock.mfDate AS[Menufacture Date],addStock.expDate AS[Expire Date],medicine.price AS[Price],addStock.availableQty AS[Available Qty],addStock.availableQty * medicine.price AS[Amount]  FROM medicine INNER JOIN addStock ON medicine.medicineId=addStock.medicineId WHERE addStock.expDate BETWEEN '" + curDate + "' AND '" + expireDate.Value.AddMonths(3).ToShortDateString() + "' AND  addStock.batchNo='" + batchNo.Text + "'AND addStock.availableQty>0";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM addStock WHERE expDate BETWEEN '" + curDate + "' AND '" + expireDate.Value.AddMonths(3).ToShortDateString() + "' AND batchNo='" + batchNo.Text + "'AND addStock.availableQty>0";
                adapter1 = new SqlDataAdapter(sql1, con);

                String sql2 = "SELECT * FROM medicine";
                adapter2 = new SqlDataAdapter(sql2, con);

                con.Close();
                calculateAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void medicineName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],addStock.stockId AS[Stock ID],addStock.batchNo AS[Batch No.],addStock.receiveDate AS[Product Receive],addStock.mfDate AS[Menufacture Date],addStock.expDate AS[Expire Date],medicine.price AS[Price],addStock.availableQty AS[Available Qty],addStock.availableQty * medicine.price AS[Amount]  FROM medicine INNER JOIN addStock ON medicine.medicineId=addStock.medicineId WHERE addStock.expDate BETWEEN '" + curDate + "' AND '" + expireDate.Value.AddMonths(3).ToShortDateString() + "' AND  medicine.name like '%" + medicineName.Text + "%' AND addStock.availableQty>0";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM addStock WHERE expDate BETWEEN '" + curDate + "' AND '" + expireDate.Value.AddMonths(3).ToShortDateString() + "' AND batchNo='" + batchNo.Text + "'AND addStock.availableQty>0 ";
                adapter1 = new SqlDataAdapter(sql1, con);

                String sql2 = "SELECT * FROM medicine  WHERE name like '%" + medicineName.Text + "%'";
                adapter2 = new SqlDataAdapter(sql2, con);

                con.Close();

                calculateAmount();
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

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],addStock.stockId AS[Stock ID],addStock.batchNo AS[Batch No.],addStock.receiveDate AS[Product Receive],addStock.mfDate AS[Menufacture Date],addStock.expDate AS[Expire Date],medicine.price AS[Price],addStock.availableQty AS[Available Qty],addStock.availableQty * medicine.price AS[Amount]  FROM medicine INNER JOIN addStock ON medicine.medicineId=addStock.medicineId WHERE addStock.expDate BETWEEN '" + curDate + "' AND '" + expireDate.Text + "'  AND addStock.availableQty>0";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM addStock WHERE expDate BETWEEN '" + curDate + "' AND '" + expireDate.Text + "' AND addStock.availableQty>0";
                adapter1 = new SqlDataAdapter(sql1, con);

                String sql2 = "SELECT * FROM medicine";
                adapter2 = new SqlDataAdapter(sql2, con);

                con.Close();

                calculateAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateAmount()
        {
            decimal nAmount = 0;
            decimal nQty = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[12, i].Value != DBNull.Value)
                    nAmount += Convert.ToDecimal(dataGridView1[12, i].Value);
                if (dataGridView1[11, i].Value != DBNull.Value)
                    nQty += Convert.ToDecimal(dataGridView1[11, i].Value);
            }

            netAmount.Text = nAmount.ToString("0.00");

            netQty.Text = nQty.ToString("0.00");
        }

        private void report_Click(object sender, EventArgs e)
        {
            printSaleForm printForm = new printSaleForm();
            stockDataSet dataSet = new stockDataSet();
            dataSet.EnforceConstraints = false;

            viewExpireStockReport report = new viewExpireStockReport();

            try
            {
                adapter1.Fill(dataSet.addStock);

                adapter2.Fill(dataSet.medicine);

                report.SetDataSource(dataSet);

                printForm.crystalReportViewer1.ReportSource = report;
                printForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],addStock.stockId AS[Stock ID],addStock.batchNo AS[Batch No.],addStock.receiveDate AS[Product Receive],addStock.mfDate AS[Menufacture Date],addStock.expDate AS[Expire Date],medicine.price AS[Price],addStock.availableQty AS[Available Qty],addStock.availableQty * medicine.price AS[Amount] FROM medicine INNER JOIN addStock ON medicine.medicineId=addStock.medicineId WHERE addStock.expDate BETWEEN '" + curDate + "' AND '" + expireDate.Value.AddMonths(3).ToShortDateString() + "' AND addStock.availableQty>0";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM addStock WHERE expDate BETWEEN '" + curDate + "' AND '" + expireDate.Value.AddMonths(3).ToShortDateString() + "'AND addStock.availableQty>0";
                adapter1 = new SqlDataAdapter(sql1, con);

                String sql2 = "SELECT * FROM medicine";
                adapter2 = new SqlDataAdapter(sql2, con);

                con.Close();
                calculateAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGridView1.Columns[9].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dataGridView1.Columns[9].DefaultCellStyle.BackColor = Color.Red;
        }
    }
}