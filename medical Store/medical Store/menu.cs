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
    public partial class menu : Form
    {
        private Timer time = new Timer();
        private Timer time2 = new Timer();
        private String account;

        public menu(String account)
        {
            this.account = account;
            InitializeComponent();

            if (account == "user")
            {
                accountInfoToolStripMenuItem.Enabled = false;
            }
        }

        private void addCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewCompany view = new viewCompany(account);
            view.Show();
        }

        private void addMedicineTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewMedicineType view = new viewMedicineType(account);
            view.Show();
        }

        private void addMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewMedicine add = new viewMedicine(account);
            add.Show();
        }

        private void stockEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewStock view = new viewStock(account);
            view.Show();
        }

        private void damageStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewDamageStock damage = new viewDamageStock(account);
            damage.Show();
        }

        private void saleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sale sal = new sale();
            sal.Show();
        }

        private void viewSaleHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewSale view = new viewSale();
            view.Show();
        }

        private void medicineStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lowStock low = new lowStock();
            low.Show();
        }

        private void menu_Move(object sender, EventArgs e)
        {
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lowStock low = new lowStock();
            low.Show();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            lowStock low = new lowStock();
            low.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            time.Interval = 3000;
            time.Tick += time_Tick;
            time.Start();

            time2.Interval = 12000;
            time2.Tick += time2_Tick;
            time2.Start();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            try
            {
                // String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;

                var conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;

                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String sql = "SELECT name FROM medicine WHERE availableQty<'20'"; // 20 sy less than hoge tu icon aye ga

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    lowStockNotify.ShowBalloonTip(1000);
                }
                reader.Close();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                time.Stop();
            }
        }

        private void time2_Tick(object sender, EventArgs e)
        {
            try
            {
                //String conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;

                var conString = ConfigurationManager.ConnectionStrings["medical_Store.Properties.Settings.medicalStoreConnectionString"].ConnectionString;

                SqlConnection con = new SqlConnection(conString);
                con.Open();

                // checking expire date

                DateTime curDate = DateTime.Now.Date;

                String sql2 = "SELECT medicineId FROM addStock WHERE expDate BETWEEN '" + curDate.ToShortDateString() + "' AND '" + curDate.AddMonths(3).ToShortDateString() + "'";

                SqlCommand cmd2 = new SqlCommand(sql2, con);
                SqlDataReader reader2 = cmd2.ExecuteReader();

                if (reader2.HasRows)
                {
                    expireNotify.ShowBalloonTip(1000);

                    expireNotify.Visible = false;
                }

                reader2.Close();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                time2.Stop();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lowStockNotify.Visible = false;
        }

        private void expireMedicineStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expireStock expire = new expireStock();
            expire.Show();
        }

        private void showExpireMedicineInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expireStock expire = new expireStock();
            expire.Show();
        }

        private void expireNotify_BalloonTipClicked(object sender, EventArgs e)
        {
            expireStock expire = new expireStock();
            expire.Show();
        }

        private void accountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAccount view = new viewAccount();
            view.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}