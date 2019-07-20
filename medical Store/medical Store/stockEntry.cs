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
    public partial class stockEntry : Form
    {
        public stockEntry()
        {
            InitializeComponent();
        }

        private void stockEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalStoreDataSet2.medicine' table. You can move, or remove it, as needed.
            this.medicineTableAdapter.Fill(this.medicalStoreDataSet2.medicine);

            medicineName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            medicineName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void medicineName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

            try
            {
                if (id.Text == "" || qty.Text == "" || batchNo.Text == "")
                {
                    MessageBox.Show("Medicine ID And Qty And Batch are Required");
                }
                else
                {


                    String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    String sql = "INSERT INTO addStock (medicineId ,batchNo ,qty ,mfDate ,expDate ,description,receiveDate,availableQty) VALUES ('" + id.Text + "','" + batchNo.Text + "','" + qty.Text + "','" + mfDate.Text + "','" + expDate.Text + "','" + description.Text + "','" + receiveDate.Text + "','" + qty.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    String sql2 = "UPDATE medicine SET availableQty=availableQty+'" + qty.Text + "',totalQty=totalQty+'" + qty.Text + "' WHERE medicineId='" + id.Text + "'";
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

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {

                e.Handled = true;

            }



        }
    }
}

