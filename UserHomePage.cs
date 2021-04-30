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
    public partial class UserHomePage : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M2P60SB\SQLEXPRESS;Initial Catalog=sad_project;Integrated Security=True");

        SqlDataAdapter adpt;
        DataTable dt;

        public static string searchingColumn;

        public UserHomePage()
        {
            InitializeComponent();
            showData();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            refreshData();
            SearchBox.Clear();
            SearchTypeComboBox.SelectedIndex = -1;
            SearchBox.Enabled = false;
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

        private void SearchData(string search)
        {
            con.Open();
            string query = "SELECT * FROM schedules WHERE "+ searchingColumn +" like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchBox.Text);
        }

        private void SearchTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SearchLabel.Text = "Search by " + SearchTypeComboBox.Text;

            SearchBox.Enabled = true;

            string searchType = SearchTypeComboBox.Text;

            switch (searchType)
            {
                case "Route":
                    searchingColumn = "route";
                    break;

                case "Destination":
                    searchingColumn = "ends_at";
                    break;

                case "Starting Point":
                    searchingColumn = "start_from";
                    break;

                case "Departure Time":
                    searchingColumn = "departure_time";
                    break;

                case "Type":
                    searchingColumn = "type";
                    break;
            }
        }
    }
}
