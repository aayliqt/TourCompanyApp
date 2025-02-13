using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TourApp
{
    public partial class AddCountryForm : Form
    {
        public string CountryName { get; private set; }

        public AddCountryForm()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string countryName = txtCountryName.Text;

            if (!string.IsNullOrEmpty(countryName))
            {
                using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
                {
                    string query = "INSERT INTO Country (NameCountry) VALUES (@Country)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Country", countryName);

                    connection.Open();
                    command.ExecuteNonQuery();
                    CountryName = countryName;

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть назву країни.", "Помилка", MessageBoxButtons.OK);
            }
        }
    }
}
