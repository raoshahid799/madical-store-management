using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;

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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            //  this.BackColor = ColorTranslator.FromHtml("#DF3D82");
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                var conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;

                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT userName,password,type FROM account where userName='" + userName.Text + "' AND password='" + password.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader.GetString(2).Trim() == "admin")
                    {
                        menu men = new menu("admin");
                        men.Closed += (s, arg) => this.Close();
                        this.Hide();
                        men.Show();
                    }
                    else
                    {
                        menu men = new menu("user");
                        men.Closed += (s, arg) => this.Close();
                        this.Hide();
                        men.Show();
                    }
                }
                else
                {
                    MessageBox.Show("You Entered Wrong Password OR User Name", "Medicine Management", MessageBoxButtons.OK);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}