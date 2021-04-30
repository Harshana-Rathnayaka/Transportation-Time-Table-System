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
    public partial class LoginForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M2P60SB\SQLEXPRESS;Initial Catalog=sad_project;Integrated Security=True");
        public static string passingText;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }


        private void login()
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter the username and password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usernameTextBox.Focus();

            }
            else
            {
                try
                {
                    // checking whether the username password is correct with the database
                    SqlCommand cmd = new SqlCommand("SELECT * FROM users where username=@username and password=@password", con);
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    con.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    con.Close();

                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        // Message box with the username if the credentials are correct
                        MessageBox.Show("Have a Nice Day!! ", "Welcome: " + username);
                        this.Hide();

                        string role = ds.Tables[0].Rows[0]["user_type"].ToString();
                        passingText = username;

                        switch (role)
                        {
                            case "USER": // normal users
                                UserHomePage userHomePage = new UserHomePage();
                                userHomePage.Show();
                                break;

                            case "ADMIN": // admin user
                                AdminHomePage adminHomePage = new AdminHomePage();
                                adminHomePage.Show();
                                break;
                        }

                    }
                    else
                    {
                        //error message if the credentials are incorrect
                        MessageBox.Show("The username or password is incorrect. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        usernameTextBox.Clear();
                        passwordTextBox.Clear();
                        usernameTextBox.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
