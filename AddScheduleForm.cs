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
    public partial class AddScheduleForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M2P60SB\SQLEXPRESS;Initial Catalog=sad_project;Integrated Security=True");

        SqlDataAdapter adpt;
        DataTable dt;

        public AddScheduleForm()
        {
            InitializeComponent();
            showData();
        }

        private void AddScheduleForm_Load(object sender, EventArgs e)
        {
        }

        private void TimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            TimePicker.CustomFormat = "HH:mm";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            addSchedule();
        }

        private void addSchedule()
        {

            if (RouteTextBox.Text == "" || ToTextBox.Text == "" || FromTextBox.Text == "" || TimePicker.Text == "" || TypeComboBox.Text == "") {
                MessageBox.Show("Please enter all the details.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (TimePicker.Text == DateTime.Now.ToString("HH:mm:ss"))
            {
                MessageBox.Show("Please enter a valid time.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                try
                {

                    con.Open();

                    // adding new schedule
                    string sql = "INSERT INTO schedules (route, start_from, ends_at, departure_time, type) VALUES('" + RouteTextBox.Text + "', '" + FromTextBox.Text + "', '" + ToTextBox.Text + "', '" + TimePicker.Text + "', '" + TypeComboBox.Text + "')";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Schedule created successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    refreshData();

                    RouteTextBox.Clear();
                    ToTextBox.Clear();
                    FromTextBox.Clear();
                    TypeComboBox.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            RouteTextBox.Clear();
            ToTextBox.Clear();
            FromTextBox.Clear();
            TypeComboBox.SelectedIndex = -1;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
