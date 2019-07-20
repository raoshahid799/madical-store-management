using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace medical_Store
{
    public partial class sale : Form
    {
        public sale()
        {
            InitializeComponent();
        }

        private int tItem = 0;
        private decimal totalNetAmount = 0;
        private decimal totalGrossAmount = 0;

        private void sale_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            // TODO: This line of code loads data into the 'medicalStoreDataSet2.medicine' table. You can move, or remove it, as needed.
            this.medicineTableAdapter.Fill(this.medicalStoreDataSet2.medicine);
            // TODO: This line of code loads data into the 'medicalStoreDataSet2.medicine' table. You can move, or remove it, as needed.
            this.medicineTableAdapter.Fill(this.medicalStoreDataSet2.medicine);
            //medicineName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //medicineName.AutoCompleteSource = AutoCompleteSource.AllUrl;
            loadBatchNo();

            loadCashMemoNo();
        }

        public void loadCashMemoNo()
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT MAX(cashMemoNo) FROM MasterSale";
                SqlCommand cmd = new SqlCommand(sql, con);
                String val = cmd.ExecuteScalar().ToString();
                if (val == "")
                {
                    cashMemoNo.Text = "1";
                }
                else
                {
                    int cm = int.Parse(val);
                    cm++;
                    cashMemoNo.Text = "" + cm;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadBatchNo()
        {
            try
            {
                batchNo.Items.Clear();// combo box ko clear kr dy ga
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT DISTINCT(batchNo) FROM addStock WHERE medicineId='" + medicineId.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        batchNo.Items.Add(reader.GetValue(0));
                    }
                }

                reader.Close();
                con.Close();
                batchNo.Text = "Select Batch No.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void medicineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadBatchNo();
        }

        private void qty_Validating(object sender, CancelEventArgs e)
        {
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Selected)
                {
                    int index = dataGridView1.CurrentRow.Index;

                    DialogResult result = MessageBox.Show("Medicine Name\t" + dataGridView1["medicineNameColoumn", index].Value.ToString(), "Medical Shop", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        dataGridView1.Rows.RemoveAt(index);
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

        private void addItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (batchNo.Text == "Select Batch No." || qty.Text == "")
                {
                    MessageBox.Show("Frist Select the batch No then Enter Quantity OR Enter Qty. !", "Medicine Management System", MessageBoxButtons.OK);
                    qty.Text = "";
                }
                else
                {
                    decimal net = 0;
                    decimal pr = 0;
                    String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    String sql = "SELECT batchNo,expDate FROM addStock WHERE medicineId='" + medicineId.Text + "' AND batchNo='" + batchNo.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int index = dataGridView1.Rows.Add();
                    DataGridViewRow row = this.dataGridView1.Rows[index];

                    if (reader.HasRows)
                    {
                        reader.Read();
                        row.Cells["medicineIdColoumn"].Value = medicineId.Text;
                        row.Cells["medicineNameColoumn"].Value = medicineName.Text;
                        row.Cells["batchNoColoumn"].Value = "" + reader.GetValue(0);
                        row.Cells["qtyColoumn"].Value = qty.Text;
                        row.Cells["expiryDateColoumn"].Value = reader.GetDateTime(1);
                    }

                    reader.Close();

                    String sql2 = "SELECT manufacture,price FROM medicine WHERE medicineId='" + medicineId.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    SqlDataReader reader2 = cmd2.ExecuteReader();

                    if (reader2.HasRows)
                    {
                        reader2.Read();
                        row.Cells["manufactureColoumn"].Value = "" + reader2.GetValue(0);

                        pr = Convert.ToDecimal(reader2.GetValue(1));
                        row.Cells["priceColoumn"].Value = "" + pr;
                    }
                    reader2.Close();
                    con.Close();

                    net = Convert.ToDecimal(qty.Text) * pr;

                    row.Cells["netAmountColoumn"].Value = "" + net;

                    tItem++;
                    totalItem.Text = "" + tItem;
                    totalGrossAmount += net;
                    totalNetAmount += net;

                    grossAmount.Text = totalGrossAmount.ToString("0.00");
                    netAmount.Text = totalNetAmount.ToString("0.00");

                    qty.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void medicineId_TextChanged(object sender, EventArgs e)
        {
            loadBatchNo();
        }

        private void disc_Validating(object sender, CancelEventArgs e)
        {
        }

        private void save_Click(object sender, EventArgs e)
        {
            save.Enabled = false;
            addItem.Enabled = false;
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Atleast On Item Must Be Added");
                }
                else
                {
                    String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    String sql = " INSERT INTO masterSale (cashMemoNo,CustomerName ,date ,gross ,disc ,net) VALUES ('" + cashMemoNo.Text + "','" + customerName.Text + "','" + date.Text + "','" + grossAmount.Text + "','" + disc.Text + "','" + netAmount.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow row = dataGridView1.Rows[i];

                        String sql2 = "UPDATE medicine SET availableQty=availableQty-'" + row.Cells["qtyColoumn"].Value.ToString() + "' WHERE medicineId='" + row.Cells["medicineIdColoumn"].Value.ToString() + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, con);
                        cmd2.ExecuteNonQuery();

                        String sql3 = "UPDATE addStock SET availableQty=availableQty-'" + row.Cells["qtyColoumn"].Value.ToString() + "' WHERE medicineId='" + row.Cells["medicineIdColoumn"].Value.ToString() + "' AND batchNo='" + row.Cells["batchNoColoumn"].Value.ToString() + "' ";
                        SqlCommand cmd3 = new SqlCommand(sql3, con);
                        cmd3.ExecuteNonQuery();

                        String sql4 = " INSERT INTO childSale (cashMemoNo,medicineId ,medicineName ,batchNo ,price ,qty,expiryDate,manufacture) VALUES ('" + cashMemoNo.Text + "','" + row.Cells["medicineIdColoumn"].Value.ToString() + "','" + row.Cells["medicineNameColoumn"].Value.ToString() + "','" + row.Cells["batchNoColoumn"].Value.ToString() + "','" + row.Cells["priceColoumn"].Value.ToString() + "','" + row.Cells["qtyColoumn"].Value.ToString() + "','" + row.Cells["expiryDateColoumn"].Value.ToString() + "','" + row.Cells["manufactureColoumn"].Value.ToString() + "')";
                        SqlCommand cmd4 = new SqlCommand(sql4, con);
                        cmd4.ExecuteNonQuery();
                    }

                    MessageBox.Show("Saved");

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            print.Enabled = true;
        }

        private void newBill_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to make new Bill ?", "Medicine Management", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                tItem = 0;

                totalNetAmount = 0;
                totalGrossAmount = 0;
                totalItem.Text = "";
                grossAmount.Text = "";
                netAmount.Text = "";
                totalItem.Text = "";

                loadCashMemoNo();
                save.Enabled = true;
            }
        }

        private void disc_TextChanged(object sender, EventArgs e)
        {
            if (disc.Text != "")
            {
                decimal d = Convert.ToDecimal(disc.Text);
                decimal ta = totalNetAmount - d;
                netAmount.Text = ta.ToString("0.00");
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            printSaleForm printForm = new printSaleForm();
            invoideStoreDataSet dataSet = new invoideStoreDataSet();
            CrystalReport2 report = new CrystalReport2();

            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT cashMemoNo,CustomerName,gross,disc,net  FROM masterSale WHERE cashMemoNo='" + cashMemoNo.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                //DataTable table = new DataTable();
                adapter.Fill(dataSet.masterSale);

                String sql2 = "SELECT medicineName,price,qty FROM childSale WHERE cashMemoNo='" + cashMemoNo.Text + "'";
                SqlDataAdapter adapter2 = new SqlDataAdapter(sql2, con);
                //DataTable table = new DataTable();
                adapter2.Fill(dataSet.childSale);
                report.SetDataSource(dataSet);

                dataSet.EnforceConstraints = false;
                printForm.crystalReportViewer1.ReportSource = report;
                printForm.Show();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (qty.Text == "")
                {
                    //when quantity is empty then do nothing
                }
                else if (batchNo.Text == "Select Batch No." || batchNo.Text == "")
                {
                    MessageBox.Show("Frist Select the batch No then Enter Quantity !", "Medicine Management System", MessageBoxButtons.OK);
                    qty.Text = "";
                }
                else
                {
                    String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    String sql = "SELECT availableQty,expDate FROM addStock WHERE medicineId='" + medicineId.Text + "' AND batchNo='" + batchNo.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        DateTime expDate;
                        int medicineQty;

                        medicineQty = reader.GetInt32(0);
                        expDate = reader.GetDateTime(1);

                        if (date.Value > expDate)
                        {
                            MessageBox.Show("Medicine Is Expired", "Medicine Management System", MessageBoxButtons.OK);
                            qty.Text = "";
                        }
                        else if (int.Parse(qty.Text) > medicineQty)
                        {
                            MessageBox.Show("Quantity is unAvailable", "Medicine Management System", MessageBoxButtons.OK);

                            qty.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "Medicine Management System", MessageBoxButtons.OK);

                        batchNo.Text = "";
                    }

                    reader.Close();
                    con.Close();
                    // batchNo.Text = "Select Batch No.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void qty_Validating_1(object sender, CancelEventArgs e)
        {
        }
    }
}