using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TourApp
{
    public partial class ProfileForm : Form
    {
        private string userType;
        private int userId;

        public ProfileForm(string userType, int userId)
        {
            this.userType = userType;
            this.userId = userId;
            InitializeComponent();
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                string query;
                switch (userType)
                {
                    case "Client":
                        query = "SELECT * FROM Client WHERE ID_Client = @UserID";
                        break;
                    case "Employee":
                        query = "SELECT * FROM Employee WHERE ID_Employee = @UserID";
                        break;
                    case "Admin":
                        query = "SELECT * FROM Admin WHERE ID_Admin = @UserID";
                        break;
                    default:
                        throw new InvalidOperationException("Unknown user type");
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (userType == "Client")
                    {
                        lblName.Text = $"ФІО: {reader["FirstName"].ToString().Trim()} {reader["LastName"].ToString().Trim()}";
                        lblEmail.Text = $"Email: {reader["Email"].ToString().Trim()}";
                        lblPhone.Text = $"Телефон: {reader["Phone"].ToString().Trim()}";
                    }
                    else if (userType == "Admin")
                    {
                        lblName.Text = $"ФІО: {reader["AdmFirstName"].ToString().Trim()} {reader["AdmLastName"].ToString().Trim()}";
                        lblEmail.Text = $"Email: {reader["AdmEmail"].ToString().Trim()}";
                        lblPhone.Text = $"Телефон: {reader["AdmPhone"].ToString().Trim()}";
                    }
                    else if (userType == "Employee")
                    {
                        lblName.Text = $"ФІО: {reader["EmplFirstName"].ToString().Trim()} {reader["EmplLastName"].ToString().Trim()}";
                        lblEmail.Text = $"Email: {reader["Email"].ToString().Trim()}";
                        lblPhone.Text = $"Телефон: {reader["Phone"].ToString().Trim()}";
                    }
                    lblName.AutoSize = true;
                    lblEmail.AutoSize = true;
                    lblPhone.AutoSize = true;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
