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
    public partial class viewMedicineType : Form
    {
        private String account;

        public viewMedicineType(String account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void viewMedicineType_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            if (account == "user")
                delete.Enabled = false;
            // TODO: This line of code loads data into the 'medicalStoreDataSet1.medicineType' table. You can move, or remove it, as needed.
            this.medicineTypeTableAdapter.Fill(this.medicalStoreDataSet1.medicineType);
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            addMedicinetype add = new addMedicinetype();
            add.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT * FROM medicineType WHERE id='" + companyId.Text + "'";
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

                String sql = "SELECT * FROM medicineType WHERE name like'%" + comName.Text + "%'";
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

        private void showAll_Click(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT * FROM medicineType";
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

                    DialogResult result = MessageBox.Show("Medicine Type\t" + dataGridView1["nameDataGridView", index].Value.ToString(), "Medical Shop", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                        SqlConnection con = new SqlConnection(conString);
                        con.Open();

                        String sql = "DELETE  FROM MedicineType WHERE id='" + dataGridView1["idDataGridView", index].Value.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Delete Successfully");

                        con.Close();
                        this.medicineTypeTableAdapter.Fill(this.medicalStoreDataSet1.medicineType);
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

        private void companyId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void comName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            printSaleForm printForm = new printSaleForm();
            medicalStoreDataSet1 dataSet = new medicalStoreDataSet1();
            dataSet.EnforceConstraints = false;

            medicineTypeReport report = new medicineTypeReport();

            try
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    DataRow dr = dt.NewRow();

                    if (row.DataBoundItem != null)
                    {
                        dr = (DataRow)((DataRowView)row.DataBoundItem).Row;

                        dataSet.medicineType.ImportRow(dr);
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