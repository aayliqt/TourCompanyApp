using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TourApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введіть Email та пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
                {
                    connection.Open();
                    string query = @"
                SELECT Email, ClientPassword AS Password, ID_Client AS UserId, 'Client' AS UserType FROM Client WHERE Email = @Email AND ClientPassword = @Password
                UNION ALL
                SELECT Email, EmplPassword AS Password, ID_Employee AS UserId, 'Employee' AS UserType FROM Employee WHERE Email = @Email AND EmplPassword = @Password
                UNION ALL
                SELECT AdmEmail AS Email, AdmPassword AS Password, ID_Admin AS UserId, 'Admin' AS UserType FROM Admin WHERE AdmEmail = @Email AND AdmPassword = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string userType = reader["UserType"].ToString();
                            int userId = Convert.ToInt32(reader["UserId"]);

                            MessageBox.Show("Ви успішно увійшли!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TourForm tourForm = new TourForm(userType, userId);
                            tourForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Неправильний Email або пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при вході: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}