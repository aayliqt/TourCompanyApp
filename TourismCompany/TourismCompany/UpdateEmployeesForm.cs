using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TourApp
{
    public partial class UpdateEmployeesForm : Form
    {
        public UpdateEmployeesForm()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                string query = "SELECT * FROM Employee";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable employees = new DataTable();
                adapter.Fill(employees);

                dataGridViewEmployees.DataSource = employees;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEmployees.SelectedRows[0];

                txtEmplFirstName.Text = selectedRow.Cells["EmplFirstName"].Value.ToString();
                txtEmplLastName.Text = selectedRow.Cells["EmplLastName"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                lblEmployeeId.Text = selectedRow.Cells["ID_Employee"].Value.ToString();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                int employeeId = Convert.ToInt32(lblEmployeeId.Text);
                string firstName = txtEmplFirstName.Text;
                string lastName = txtEmplLastName.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;

                using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
                {
                    string query = "UPDATE Employee SET EmplFirstName = @FirstName, EmplLastName = @LastName, Phone = @Phone, Email = @Email WHERE ID_Employee = @EmployeeId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Дані співробітника оновлено!", "Успіх", MessageBoxButtons.OK);
                    LoadEmployees();
                }
            }
            else
            {
                MessageBox.Show("Виберіть співробітника для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                int employeeId = Convert.ToInt32(lblEmployeeId.Text);

                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити користувача?", "Підтвердження", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
                    {
                        string query = "DELETE FROM Employee WHERE ID_Employee = @EmployeeId";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Менеджера видалено!", "Успіх", MessageBoxButtons.OK);
                        LoadEmployees();
                    }
                }
            }
            else
            {
                MessageBox.Show("Виберіть співробітника, щоб видалити!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}