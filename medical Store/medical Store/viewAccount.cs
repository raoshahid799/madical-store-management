using System;
using System.Configuration;using System.Data.SqlClient;
using System.Windows.Forms;

namespace medical_Store
{
    public partial class viewAccount : Form
    {
        public viewAccount()
        {
            InitializeComponent();
        }

        private void viewAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalStoreDataSet8.account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.medicalStoreDataSet8.account);
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Selected)
                {
                    int index = dataGridView1.CurrentRow.Index;

                    DialogResult result = MessageBox.Show("User Name\t" + dataGridView1[0, index].Value.ToString(), "Medical Shop", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        userName.Text = dataGridView1[0, index].Value.ToString();
                        password.Text = dataGridView1[1, index].Value.ToString();
                        accountType.Text = dataGridView1[2, index].Value.ToString();

                        Update2.Enabled = true;
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

        private void Update2_Click(object sender, EventArgs e)
        {
            try
            {
                if (userName.Text == "" || password.Text == "")
                {
                    MessageBox.Show("User Name and password must be Filled !");
                }
                else
                {
                    String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    String sql = "UPDATE account SET userName='" + userName.Text + "',password='" + password.Text + "' WHERE type='" + accountType.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");

                    this.accountTableAdapter.Fill(this.medicalStoreDataSet8.account);

                    con.Close();
                }

                Update2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}