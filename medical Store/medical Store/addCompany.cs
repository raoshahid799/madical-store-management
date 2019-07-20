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
    public partial class addCompany : Form
    {
        public addCompany()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cName.Text == "" || city.Text == "")
                {
                    MessageBox.Show("Company Name And City are Required");
                }
                else
                {
                    String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    String sql = "INSERT INTO companyName (name ,city,contact,date,remarks,address) VALUES ('" + cName.Text + "','" + city.Text + "','" + contact.Text + "','" + date.Text + "','" + remark.Text + "','" + address.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data saved");
                    cName.Text = "";

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }

        private void city_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }

        private void contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}