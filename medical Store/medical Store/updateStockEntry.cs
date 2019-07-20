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
    public partial class updateStockEntry : Form
    {
        String mediName;
        String stockId;
        String mediId;
        int currentQty;
        public updateStockEntry(String mediName, String mediId, String stockId)
        {
            this.mediName = mediName;
            this.stockId = stockId;
            this.mediId = mediId;
            InitializeComponent();
        }

        private void updateStockEntry_Load(object sender, EventArgs e)
        {
            medicineName.Text = mediName;
            medicineId.Text = mediId;

            try
            {
                String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT batchNo ,qty ,mfDate ,expDate ,description,receiveDate FROM AddStock WHERE stockId='" + stockId + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();
                batchNo.Text = "" + read.GetValue(0);
                qty.Text = "" + read.GetValue(1);
                mfDate.Text = "" + read.GetValue(2);
                expDate.Text = "" + read.GetValue(3);
                description.Text = "" + read.GetValue(4);
                receiveDate.Text = "" + read.GetValue(5);

                read.Close();
                con.Close();
                currentQty = int.Parse(qty.Text);

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
                if (qty.Text == "" || batchNo.Text == "")
                {
                    MessageBox.Show("Medicine Qty And Batch are Required");
                }
                else
                {
                    int newQty = currentQty - int.Parse(qty.Text);

                    String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    String sql = "UPDATE addStock SET batchNo ='" + batchNo.Text + "',qty ='" + qty.Text + "' ,mfDate ='" + mfDate.Text + "' ,expDate ='" + expDate.Text + "',description = '" + description.Text + "',receiveDate ='" + receiveDate.Text + "', availableQty=availableQty-'" + newQty + "'   WHERE stockId='" + stockId + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    String sql2 = "UPDATE medicine SET availableQty=availableQty-'" + newQty + "',totalQty=totalQty-'" + newQty + "' WHERE medicineId='" + mediId + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();




                    MessageBox.Show("Updated");


                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
    }
}
