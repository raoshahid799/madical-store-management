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
    public partial class addMedicine : Form
    {
        public addMedicine()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text == "" || medicineType.Text == "" || company.Text == "" || price.Text == "")
                {
                    MessageBox.Show("Medicine Name,Medicine Type,Company and Price are Required !");
                }
                else
                {
                    String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    String sql = "INSERT INTO medicine (name ,manufacture ,medicineType ,date ,price ,shelf ,description ,availableQty ,totalQty) VALUES ('" + name.Text + "','" + company.Text + "','" + medicineType.Text + "','" + date.Text + "','" + price.Text + "','" + shelf.Text + "','" + description.Text + "','0','0')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine has Saved");

                    name.Text = "";
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addMedicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalStoreDataSet6.companyName' table. You can move, or remove it, as needed.
            this.companyNameTableAdapter.Fill(this.medicalStoreDataSet6.companyName);
            // TODO: This line of code loads data into the 'medicalStoreDataSet5.medicineType' table. You can move, or remove it, as needed.
            this.medicineTypeTableAdapter1.Fill(this.medicalStoreDataSet5.medicineType);
            // TODO: This line of code loads data into the 'medicalStoreDataSet4.medicineType' table. You can move, or remove it, as needed.
            this.medicineTypeTableAdapter.Fill(this.medicalStoreDataSet4.medicineType);
        }

        private void medicineType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}