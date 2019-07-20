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
    public partial class viewStock : Form
    {
        private SqlDataAdapter adapter, adapter1, adapter2;

        private String account;

        public viewStock(String account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void viewStock_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            if (account == "user")
            {
                delete.Enabled = false;
                update.Enabled = false;
            }

            LoadMedicine();
        }

        public void LoadMedicine()
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],addStock.stockId AS[Stock ID],addStock.receiveDate AS[Product Receive],addStock.batchNo AS[Batch No.],addStock.mfDate AS[Menufacture Date],addStock.expDate AS[Expire Date],medicine.price AS[Price],addStock.description AS[Description],addStock.availableQty AS[Available Qty],addStock.qty AS[Total Qty.] FROM medicine INNER JOIN addStock ON medicine.medicineId=addStock.medicineId WHERE addStock.availableQty>0";
                adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM addStock WHERE availableQty>0";
                adapter1 = new SqlDataAdapter(sql1, con);

                String sql2 = "SELECT * FROM medicine";
                adapter2 = new SqlDataAdapter(sql2, con);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            stockEntry entry = new stockEntry();
            entry.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],addStock.stockId AS[Stock ID],addStock.receiveDate AS[Product Receive],addStock.batchNo AS[Batch No.],addStock.mfDate AS[Menufacture Date],addStock.expDate AS[Expire Date],medicine.price AS[Price],addStock.description AS[Description],addStock.availableQty AS[Available Qty],addStock.qty AS[Total Qty.] FROM medicine INNER JOIN addStock ON medicine.medicineId=addStock.medicineId WHERE medicine.medicineId='" + medId.Text + "' AND addStock.availableQty>0 ";
                adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM addStock WHERE medicineId='" + medId.Text + "'AND availableQty>0 ";
                adapter1 = new SqlDataAdapter(sql1, con);

                String sql2 = "SELECT * FROM medicine  WHERE medicineId='" + medId.Text + "'";
                adapter2 = new SqlDataAdapter(sql2, con);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],addStock.stockId AS[Stock ID],addStock.receiveDate AS[Product Receive],addStock.batchNo AS[Batch No.],addStock.mfDate AS[Menufacture Date],addStock.expDate AS[Expire Date],medicine.price AS[Price],addStock.description AS[Description],addStock.availableQty AS[Available Qty],addStock.qty AS[Total Qty.] FROM medicine INNER JOIN addStock ON medicine.medicineId=addStock.medicineId WHERE medicine.name like'%" + mediName.Text + "%' AND addStock.availableQty>0";
                adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM addStock WHERE availableQty>0";
                adapter1 = new SqlDataAdapter(sql1, con);

                String sql2 = "SELECT * FROM medicine  WHERE name like'%" + mediName.Text + "%'";
                adapter2 = new SqlDataAdapter(sql2, con);

                con.Close();
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

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],addStock.stockId AS[Stock ID],addStock.receiveDate AS[Product Receive],addStock.batchNo AS[Batch No.],addStock.mfDate AS[Menufacture Date],addStock.expDate AS[Expire Date],medicine.price AS[Price],addStock.description AS[Description],addStock.availableQty AS[Available Qty],addStock.qty AS[Total Qty.] FROM medicine INNER JOIN addStock ON medicine.medicineId=addStock.medicineId WHERE addStock.batchNo='" + batchNo.Text + "' AND addStock.availableQty>0";
                adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM addStock WHERE batchNo='" + batchNo.Text + "' AND availableQty>0";
                adapter1 = new SqlDataAdapter(sql1, con);

                String sql2 = "SELECT * FROM medicine";
                adapter2 = new SqlDataAdapter(sql2, con);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadMedicine();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Selected)
                {
                    int index = dataGridView1.CurrentRow.Index;

                    DialogResult result = MessageBox.Show("Medicine Name\t" + dataGridView1[1, index].Value.ToString(), "Medical Shop", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                        SqlConnection con = new SqlConnection(conString);
                        con.Open();

                        String sql = "DELETE  FROM addStock WHERE stockId ='" + dataGridView1[5, index].Value.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();

                        String sql2 = "UPDATE medicine SET availableQty=availableQty-'" + dataGridView1[11, index].Value.ToString() + "',totalQty=totalQty-'" + dataGridView1[11, index].Value.ToString() + "' WHERE medicineId='" + dataGridView1[0, index].Value.ToString() + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, con);
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("Delete Successfully");
                        LoadMedicine();
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select the Row First");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Selected)
                {
                    int index = dataGridView1.CurrentRow.Index;

                    DialogResult result = MessageBox.Show("Medicine Name\t" + dataGridView1[1, index].Value.ToString(), "Medical Shop", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        String medicineId = dataGridView1[0, index].Value.ToString();

                        String mediName = dataGridView1[1, index].Value.ToString();

                        String stockId = dataGridView1[5, index].Value.ToString();
                        updateStockEntry entry = new updateStockEntry(mediName, medicineId, stockId);
                        entry.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select the Row First");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void medId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void mediName_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void print_Click(object sender, EventArgs e)
        {
            printSaleForm printForm = new printSaleForm();
            stockDataSet dataSet = new stockDataSet();
            dataSet.EnforceConstraints = false;

            viewStockReport report = new viewStockReport();

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

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            decimal availQty = 0;
            decimal totalQty = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[12, i].Value != DBNull.Value)
                    availQty += Convert.ToDecimal(dataGridView1[12, i].Value);

                if (dataGridView1[13, i].Value != DBNull.Value)
                    totalQty += Convert.ToDecimal(dataGridView1[13, i].Value);
            }

            aQty.Text = availQty.ToString("0.00");
            tQty.Text = totalQty.ToString("0.00");
        }
    }
}