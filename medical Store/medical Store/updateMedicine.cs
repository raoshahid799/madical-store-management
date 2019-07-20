using System;
using System.Configuration;using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace medical_Store
{
    public partial class updateMedicine : Form
    {
        private String medicineId;

        public updateMedicine(String medicineId)
        {
            this.medicineId = medicineId;

            InitializeComponent();
        }

        private void updateMedicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalStoreDataSet3.medicineType' table. You can move, or remove it, as needed.
            this.medicineTypeTableAdapter.Fill(this.medicalStoreDataSet3.medicineType);
            // TODO: This line of code loads data into the 'medicalStoreDataSet6.companyName' table. You can move, or remove it, as needed.
            this.companyNameTableAdapter.Fill(this.medicalStoreDataSet6.companyName);

            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT medicineId,name ,manufacture ,medicineType ,date ,price ,shelf ,description FROM medicine WHERE medicineId='" + medicineId + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();
                id.Text = "" + read.GetValue(0);
                name.Text = "" + read.GetValue(1);
                manufacture.Text = "" + read.GetValue(2);
                medicineType.Text = "" + read.GetValue(3);
                date.Text = "" + read.GetValue(4);
                price.Text = "" + read.GetValue(5);
                shelf.Text = "" + read.GetValue(6);
                description.Text = "" + read.GetValue(7);

                read.Close();
                con.Close();
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
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "UPDATE medicine    SET name ='" + name.Text + "' ,manufacture ='" + manufacture.Text + "' ,medicineType ='" + medicineType.Text + "',date ='" + date.Text + "',price ='" + price.Text + "',shelf ='" + shelf.Text + "',description ='" + description.Text + "' WHERE medicineId='" + id.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Information has been UPdate");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}