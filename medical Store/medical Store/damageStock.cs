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
    public partial class damageStock : Form
    {
        public damageStock()
        {
            InitializeComponent();
        }

        private void damageStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalStoreDataSet2.medicine' table. You can move, or remove it, as needed.
            this.medicineTableAdapter.Fill(this.medicalStoreDataSet2.medicine);

            name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            name.AutoCompleteSource = AutoCompleteSource.ListItems;

            batchNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            batchNo.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void batchLoad()
        {
            try
            {
                batchNo.Items.Clear();// combo box ko clear kr dy ga
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT DISTINCT(batchNo) FROM addStock WHERE medicineId='" + id.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        batchNo.Items.Add(reader.GetString(0));
                    }
                }

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
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT name,manufacture,medicineType,price FROM medicine WHERE medicineId='" + id.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    name.Text = "" + reader.GetValue(0);
                    mCompany.Text = "" + reader.GetValue(1);
                    medicineType.Text = "" + reader.GetValue(2);
                    price.Text = "" + reader.GetValue(3);

                    batchLoad();
                    batchNo.Text = "Select Batch No.";
                }
                else
                {
                    MessageBox.Show("Not Found !", "Medicine Management");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicineId,name,manufacture,medicineType,price FROM medicine WHERE name='" + name.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    id.Text = "" + reader.GetValue(0);
                    name.Text = "" + reader.GetValue(1);
                    mCompany.Text = "" + reader.GetValue(2);
                    medicineType.Text = "" + reader.GetValue(3);
                    price.Text = "" + reader.GetValue(4);

                    batchLoad();
                }

                con.Close();

                batchNo.Text = "Select Batch No.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == "" || batchNo.Text == "Select Batch No.")
                {
                    MessageBox.Show("Medicine ID And Batch NO are required");
                }
                else
                {
                    String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    String sql = "INSERT INTO damageStock (medicineId ,batchNo ,qty ,price ,mfCompany ,medicineType ,description) VALUES ('" + id.Text + "','" + batchNo.Text + "','" + qty.Text + "','" + price.Text + "','" + mCompany.Text + "','" + medicineType.Text + "','" + description.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    String sql2 = "UPDATE medicine SET availableQty=availableQty-'" + qty.Text + "',totalQty=totalQty-'" + qty.Text + "' WHERE medicineId='" + id.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Saved");

                    con.Close();
                }
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

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}