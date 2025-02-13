using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TourApp
{
    public partial class RegistrationForm : Form
    {
        private string userType;

        public RegistrationForm(string userType)
        {
            this.userType = userType;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                (userType == "Client" && string.IsNullOrWhiteSpace(txtPassport.Text)))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
                {
                    connection.Open();
                    string query;

                    if (userType == "Client")
                    {
                        query = "INSERT INTO Client (FirstName, LastName, Email, Phone, Passport, ClientPassword) " +
                                "VALUES (@FirstName, @LastName, @Email, @Phone, @Passport, @Password)";
                    }
                    else if (userType == "Employee")
                    {
                        query = "INSERT INTO Employee (EmplFirstName, EmplLastName, Phone, Email, EmplPassword) " +
                                "VALUES (@FirstName, @LastName, @Phone, @Email, @Password)";
                    }
                    else if (userType == "Admin")
                    {
                        query = "INSERT INTO Admin (AdmFirstName, AdmLastName, AdmPhone, AdmEmail, AdmPassword) " +
                                "VALUES (@FirstName, @LastName, @Phone, @Email, @Password)";
                    }
                    else
                    {
                        MessageBox.Show("Невідомий тип користувача!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);

                        if (userType == "Client")
                        {
                            command.Parameters.AddWithValue("@Passport", txtPassport.Text);
                        }

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Реєстрація успішно завершена!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час реєстрації: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}