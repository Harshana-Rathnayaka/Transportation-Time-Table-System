using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_Assignment
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            DateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = ("Welcome " + LoginForm.passingText);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void NewScheduleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddScheduleForm addScheduleForm = new AddScheduleForm();
            addScheduleForm.Show();
        }
    }
}
