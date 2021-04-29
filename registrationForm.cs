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
    public partial class RegistrationForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M2P60SB\SQLEXPRESS;Initial Catalog=sad_project;Integrated Security=True");

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            register();
        }

        private void register()
        {
            string name = nameTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (name == "" || username == "" || password == "")
            {
                MessageBox.Show("Please enter the required details.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                try
                {

                    con.Open();

                    // registering new account
                    string sql = "INSERT INTO users (name, username, password) VALUES('" + name + "', '" + username + "', '" + password + "')";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully registered! Please log in.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();

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

        private void loginLinkBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
