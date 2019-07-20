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
    public partial class updateSale : Form
    {
        String cashMemoId;
        int tItem = 0;
        decimal totalNetAmount = 0;
        decimal totalGrossAmount = 0;
        decimal totalDisc = 0;
        public updateSale(String cashMemoId)
        {
            this.cashMemoId = cashMemoId;
            InitializeComponent();
        }

        private void updateSale_Load(object sender, EventArgs e)
        {

            try
            {


                decimal net = 0;
                decimal pr = 0;
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT cashMemoNo ,medicineId ,medicineName ,batchNo ,price ,qty ,expiryDate,manufacture FROM childSale WHERE  cashMemoNo='" + cashMemoId + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    int index = dataGridView1.Rows.Add();
                    DataGridViewRow row = this.dataGridView1.Rows[index];
                    cashMemoNo.Text = "" + reader.GetValue(0);
                    row.Cells["medicineIdColoumn"].Value = reader.GetValue(1);
                    row.Cells["medicineNameColoumn"].Value = reader.GetValue(2);
                    row.Cells["batchNoColoumn"].Value = "" + reader.GetValue(3);
                    row.Cells["priceColoumn"].Value = reader.GetValue(4);
                    row.Cells["qtyColoumn"].Value = reader.GetValue(5);
                    row.Cells["expiryDateColoumn"].Value = reader.GetDateTime(6);

                    row.Cells["manufactureColoumn"].Value = "" + reader.GetValue(7);

                    pr = Convert.ToDecimal(reader.GetValue(4));

                    net = Convert.ToDecimal(reader.GetValue(5)) * pr;

                    row.Cells["netAmountColoumn"].Value = "" + net;

                    tItem++;
                }

                reader.Close();


                totalItem.Text = "" + tItem;


                String sql2 = "SELECT cashMemoNo,CustomerName,date,gross,disc,net FROM masterSale WHERE  cashMemoNo='" + cashMemoId + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                reader2.Read();
                cashMemoNo.Text = "" + reader2.GetValue(0);
                customerName.Text = "" + reader2.GetValue(1);
                date.Text = "" + reader2.GetValue(2);
                totalGrossAmount = Convert.ToDecimal(reader2.GetValue(3));
                grossAmount.Text = totalGrossAmount.ToString("0.00"); //i convert String into decimal because we need format 0.00
                totalDisc = Convert.ToDecimal(reader2.GetValue(4));
                disc.Text = totalDisc.ToString("0.00"); //i convert String into decimal because we need format 0.00

                totalNetAmount = Convert.ToDecimal(reader2.GetValue(5));
                netAmount.Text = totalNetAmount.ToString("0.00"); //i convert String into decimal because we need format 0.00


                reader2.Close();
                con.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            this.medicineTableAdapter.Fill(this.medicalStoreDataSet2.medicine);
            // TODO: This line of code loads data into the 'medicalStoreDataSet2.medicine' table. You can move, or remove it, as needed.
            this.medicineTableAdapter.Fill(this.medicalStoreDataSet2.medicine);
            //medicineName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //medicineName.AutoCompleteSource = AutoCompleteSource.AllUrl;
            loadBatchNo();



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
                        String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                        SqlConnection con = new SqlConnection(conString);
                        con.Open();

                        String sql = "DELETE  FROM childSale WHERE cashMemoNo ='" + cashMemoId + "'  AND medicineId='" + dataGridView1["medicineIdColoumn", index].Value.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();

                        String sql2 = "UPDATE medicine SET availableQty=availableQty+'" + dataGridView1["qtyColoumn", index].Value.ToString() + "' WHERE medicineId='" + dataGridView1["medicineIdColoumn", index].Value.ToString() + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, con);
                        cmd2.ExecuteNonQuery();

                        String sql3 = "UPDATE addStock SET availableQty=availableQty+'" + dataGridView1["qtyColoumn", index].Value.ToString() + "' WHERE medicineId='" + dataGridView1["medicineIdColoumn", index].Value.ToString() + "' AND batchNo='" + dataGridView1["batchNoColoumn", index].Value.ToString() + "'";
                        SqlCommand cmd3 = new SqlCommand(sql3, con);
                        cmd3.ExecuteNonQuery();

                        String sql4 = "UPDATE masterSale SET gross=gross-'" + dataGridView1["netAmountColoumn", index].Value.ToString() + "',disc='0',net=net-'" + dataGridView1["netAmountColoumn", index].Value.ToString() + "' WHERE cashMemoNo='" + cashMemoId + "'";
                        SqlCommand cmd4 = new SqlCommand(sql4, con);
                        cmd4.ExecuteNonQuery();



                        MessageBox.Show("Delete Successfully");

                        con.Close();








                        totalNetAmount += totalDisc; //adding discount in net amount so when we remove all item in sale bill then net amount will go in negative value  if discount has given  


                        totalGrossAmount -= Convert.ToDecimal(dataGridView1["netAmountColoumn", index].Value.ToString());
                        totalNetAmount -= Convert.ToDecimal(dataGridView1["netAmountColoumn", index].Value.ToString());



                        grossAmount.Text = totalGrossAmount.ToString("0.00");
                        netAmount.Text = totalNetAmount.ToString("0.00");



                        tItem--;

                        totalItem.Text = "" + tItem;

                        //discount will be zero when remove item new discount will be given
                        totalDisc = 0;
                        disc.Text = "0.00";

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


                    net = Convert.ToDecimal(qty.Text) * pr;

                    row.Cells["netAmountColoumn"].Value = "" + net;

                    tItem++;
                    totalItem.Text = "" + tItem;
                    totalGrossAmount += net;
                    totalNetAmount += net;
                    totalNetAmount += totalDisc; //adding discount in net amount so when we remove all item in sale bill then net amount will go in negative value  if discount has given  

                    grossAmount.Text = totalGrossAmount.ToString("0.00");
                    netAmount.Text = totalNetAmount.ToString("0.00");


                    //discount will be zero when remove item new discount will be given
                    qty.Text = "";
                    disc.Text = "0.00";
                    totalDisc = 0;
                    //inserting data in table    

                    String sql8 = "UPDATE medicine SET availableQty=availableQty-'" + row.Cells["qtyColoumn"].Value.ToString() + "' WHERE medicineId='" + row.Cells["medicineIdColoumn"].Value.ToString() + "'";
                    SqlCommand cmd8 = new SqlCommand(sql8, con);
                    cmd8.ExecuteNonQuery();

                    String sql9 = "UPDATE addStock SET availableQty=availableQty-'" + row.Cells["qtyColoumn"].Value.ToString() + "' WHERE medicineId='" + row.Cells["medicineIdColoumn"].Value.ToString() + "' AND batchNo='" + row.Cells["batchNoColoumn"].Value.ToString() + "' ";
                    SqlCommand cmd9 = new SqlCommand(sql9, con);
                    cmd9.ExecuteNonQuery();


                    String sql10 = " INSERT INTO childSale (cashMemoNo,medicineId ,medicineName ,batchNo ,price ,qty,expiryDate,manufacture) VALUES ('" + cashMemoNo.Text + "','" + row.Cells["medicineIdColoumn"].Value.ToString() + "','" + row.Cells["medicineNameColoumn"].Value.ToString() + "','" + row.Cells["batchNoColoumn"].Value.ToString() + "','" + row.Cells["priceColoumn"].Value.ToString() + "','" + row.Cells["qtyColoumn"].Value.ToString() + "','" + row.Cells["expiryDateColoumn"].Value.ToString() + "','" + row.Cells["manufactureColoumn"].Value.ToString() + "')";
                    SqlCommand cmd10 = new SqlCommand(sql10, con);
                    cmd10.ExecuteNonQuery();


                    String sql11 = "UPDATE masterSale    SET CustomerName ='" + customerName.Text + "',date ='" + date.Text + "',gross ='" + grossAmount.Text + "',disc ='" + disc.Text + "',net ='" + netAmount.Text + "' WHERE cashMemoNo='" + cashMemoId + "'";
                    SqlCommand cmd11 = new SqlCommand(sql11, con);
                    cmd11.ExecuteNonQuery();




                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void update_Click(object sender, EventArgs e)
        {

            update.Enabled = false;
            addItem.Enabled = false;

            try
            {


                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();



                String sql11 = "UPDATE masterSale   SET disc ='" + disc.Text + "',net ='" + netAmount.Text + "' WHERE cashMemoNo='" + cashMemoId + "'";
                SqlCommand cmd11 = new SqlCommand(sql11, con);
                cmd11.ExecuteNonQuery();



                MessageBox.Show("Updated Successfully");


                con.Close();
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
            try
            {
                if (batchNo.Text == "Select Batch No.")
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

                    reader.Close();
                    con.Close();
                    // batchNo.Text = "Select Batch No.";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            print.Enabled = true;

        }

        private void medicineId_TextChanged(object sender, EventArgs e)
        {
            loadBatchNo();
        }

        private void disc_Leave(object sender, EventArgs e)
        {



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

                String sql2 = "SELECT medicineName,price,qty,amount FROM childSale WHERE cashMemoNo='" + cashMemoNo.Text + "'";
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
    }
}
