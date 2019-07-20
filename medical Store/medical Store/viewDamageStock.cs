using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace medical_Store
{
    public partial class viewDamageStock : Form
    {
        private SqlDataAdapter adapter1, adapter2;
        private String account;

        public viewDamageStock(String account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void viewDamageStock_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            if (account == "user")
            {
                delete.Enabled = false;
            }

            loadDamageMedicine();
        }

        private void loadDamageMedicine()
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],damageStock.damageStockId AS [Damage Stock Id],damageStock.batchNo AS [Batch No.],damageStock.description AS [Description],damageStock.qty AS [Qty.],damageStock.price AS [Price],damageStock.amount As [Amount] From medicine INNER JOIN damageStock ON medicine.medicineId=damageStock.medicineId";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM damageStock";
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
            loadDamageMedicine();
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            damageStock damage = new damageStock();
            damage.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //jab delete hongy dmage medicine tu again add hojayge stock
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

                        String sql = "DELETE  FROM damageStock WHERE damageStockId ='" + dataGridView1[5, index].Value.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();

                        String sql2 = "UPDATE medicine SET availableQty=availableQty+'" + dataGridView1[8, index].Value.ToString() + "',totalQty=totalQty+'" + dataGridView1[8, index].Value.ToString() + "' WHERE medicineId='" + dataGridView1[0, index].Value.ToString() + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, con);
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("Delete Successfully");
                        loadDamageMedicine();
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

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],damageStock.damageStockId AS [Damage Stock Id],damageStock.batchNo AS [Batch No.],damageStock.description AS [Description],damageStock.qty AS [Qty.],damageStock.price AS [Price],damageStock.amount As [Amount] From medicine INNER JOIN damageStock ON medicine.medicineId=damageStock.medicineId  WHERE medicine.medicineId='" + medId.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM damageStock";
                adapter1 = new SqlDataAdapter(sql1, con);

                String sql2 = "SELECT * FROM medicine WHERE medicineId='" + medId.Text + "'";
                adapter2 = new SqlDataAdapter(sql2, con);

                con.Close();
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

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],damageStock.damageStockId AS [Damage Stock ID],damageStock.batchNo AS [Batch No.],damageStock.description AS [Description],damageStock.qty AS [Qty.],damageStock.price AS [Price],damageStock.amount As [Amount] From medicine INNER JOIN damageStock ON medicine.medicineId=damageStock.medicineId  WHERE medicine.name like '%" + mediName.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM damageStock";
                adapter1 = new SqlDataAdapter(sql1, con);

                String sql2 = "SELECT * FROM medicine WHERE name like '%" + mediName.Text + "%'";
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

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],damageStock.damageStockId AS [Damage Stock ID],damageStock.batchNo AS [Batch No.],damageStock.description AS [Description],damageStock.qty AS [Qty.],damageStock.price AS [Price],damageStock.amount As [Amount] From medicine INNER JOIN damageStock ON medicine.medicineId=damageStock.medicineId  WHERE damageStock.batchNo='" + batchNo.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                String sql1 = "SELECT * FROM damageStock WHERE batchNo='" + batchNo.Text + "'";
                adapter1 = new SqlDataAdapter(sql1, con);

                String sql2 = "SELECT * FROM medicine";
                adapter2 = new SqlDataAdapter(sql2, con);

                dataGridView1.DataSource = table;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void descrip_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicine.medicineId AS[Medicine ID],medicine.name AS[Medicine Name],medicine.manufacture AS[MenuFacture Company],medicine.medicineType AS[Medicine Type],medicine.shelf AS[Shelf],damageStock.damageStockId AS [Damage Stock ID],damageStock.batchNo AS [Batch No.],damageStock.description AS [Description],damageStock.qty AS [Qty.],damageStock.price AS [Price],damageStock.amount As [Amount] From medicine INNER JOIN damageStock ON medicine.medicineId=damageStock.medicineId  WHERE damageStock.description like '%" + descrip.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String sql1 = "SELECT * FROM damageStock WHERE description like '%" + descrip.Text + "%'";
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

        private void medId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            printSaleForm printForm = new printSaleForm();
            damageStockDataSet dataSet = new damageStockDataSet();
            dataSet.EnforceConstraints = false;

            viewDamageReport report = new viewDamageReport();

            try
            {
                adapter1.Fill(dataSet.damageStock);

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
            decimal totalQty = 0;
            decimal totalPrice = 0;
            decimal totalAmount = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[8, i].Value != DBNull.Value)
                    totalQty += Convert.ToDecimal(dataGridView1[8, i].Value);

                if (dataGridView1[9, i].Value != DBNull.Value)
                    totalPrice += Convert.ToDecimal(dataGridView1[9, i].Value);

                if (dataGridView1[10, i].Value != DBNull.Value)
                    totalAmount += Convert.ToDecimal(dataGridView1[10, i].Value);
            }

            tQty.Text = totalQty.ToString("0.00");
            tPrice.Text = totalPrice.ToString("0.00");
            tAmount.Text = totalAmount.ToString("0.00");
        }
    }
}