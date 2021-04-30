using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SAD_Assignment
{
    public partial class AllSchedules : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M2P60SB\SQLEXPRESS;Initial Catalog=sad_project;Integrated Security=True");

        SqlDataAdapter adpt;
        DataTable dt;

        public AllSchedules()
        {
            InitializeComponent();
            showData();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            // refreshing the data 
            try
            {
                con.Open();

                adpt = new SqlDataAdapter("SELECT * FROM schedules ORDER BY ID", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }
        }

        private void showData()
        {
            con.Open();

            adpt = new SqlDataAdapter("SELECT * FROM schedules ORDER BY ID", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
