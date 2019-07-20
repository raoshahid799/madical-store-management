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
    public partial class viewMedicine : Form
    {
        String account;
        public viewMedicine(String account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void addMedicine_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            if (account == "user")
            {
                delete.Enabled = false;
                update.Enabled = false;
            }

            load();

            // TODO: This line of code loads data into the 'medicalStoreDataSet3.medicineType' table. You can move, or remove it, as needed.
            this.medicineTypeTableAdapter.Fill(this.medicalStoreDataSet3.medicineType);

        }

        private void load()
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT * FROM medicine";
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

        private void refresh_Click(object sender, EventArgs e)
        {
            load();
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            addMedicine add = new addMedicine();
            add.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT * FROM medicine WHERE medicineId='" + medicineId.Text + "'";
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

        private void comName_TextChanged(object sender, EventArgs e)
        {

            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT * FROM medicine WHERE name like'%" + comName.Text + "%'";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT * FROM medicine WHERE medicineType='" + comboBox1.Text + "'";
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

        private void delete_Click(object sender, EventArgs e)
        {


            try
            {
                if (dataGridView1.CurrentRow.Selected)
                {
                    int index = dataGridView1.CurrentRow.Index;

                    DialogResult result = MessageBox.Show("Medicine Name\t" + dataGridView1["nameDataGridViewTextBoxColumn", index].Value.ToString(), "Medical Shop", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                        SqlConnection con = new SqlConnection(conString);
                        con.Open();

                        String sql = "DELETE  FROM medicine WHERE medicineId ='" + dataGridView1["medicineIdDataGridViewTextBoxColumn", index].Value.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Delete Successfully");
                        load();
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

                    DialogResult result = MessageBox.Show("Medicine Name\t" + dataGridView1["nameDataGridViewTextBoxColumn", index].Value.ToString(), "Medical Shop", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {


                        updateMedicine update = new updateMedicine(dataGridView1["medicineIdDataGridViewTextBoxColumn", index].Value.ToString());
                        update.Show();
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

        private void medicineId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {

                e.Handled = true;

            }

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void print_Click(object sender, EventArgs e)
        {

            printSaleForm printForm = new printSaleForm();
            medicalStoreDataSet2 dataSet = new medicalStoreDataSet2();
            dataSet.EnforceConstraints = false;

            viewMedicineReport report = new viewMedicineReport();


            try
            {

                DataTable dt = new DataTable();
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {

                    DataRow dr = dt.NewRow();

                    if (row.DataBoundItem != null)
                    {
                        dr = (DataRow)((DataRowView)row.DataBoundItem).Row;

                        dataSet.medicine.ImportRow(dr);
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

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            decimal availQty = 0;
            decimal totalQty = 0;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (dataGridView1["availableQtyDataGridViewTextBoxColumn", i].Value != DBNull.Value)
                    availQty += Convert.ToDecimal(dataGridView1["availableQtyDataGridViewTextBoxColumn", i].Value);

                if (dataGridView1["totalQtyDataGridViewTextBoxColumn", i].Value != DBNull.Value)
                    totalQty += Convert.ToDecimal(dataGridView1["totalQtyDataGridViewTextBoxColumn", i].Value);

            }

            aQty.Text = availQty.ToString("0.00");
            tQty.Text = totalQty.ToString("0.00");

        }


    }
}
