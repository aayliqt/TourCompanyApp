using System;
using System.Windows.Forms;
using TourismCompany;

namespace TourApp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm("Client");
            registrationForm.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm("Employee");
            registrationForm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm("Admin");
            registrationForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}