using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TourApp
{
    public partial class AddTourForm : Form
    {
        private int? tourId;

        public AddTourForm(int? tourId = null)
        {
            this.tourId = tourId;
            InitializeComponent();
            if (tourId != null) LoadTourData();
            LoadDropdowns();
        }

        private void LoadTourData()
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                string query = "SELECT * FROM Tour WHERE ID_Tour = @TourID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TourID", tourId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtName.Text = reader["TourName"].ToString();
                    txtDescription.Text = reader["Description"].ToString();
                    txtPrice.Text = reader["TourPrice"].ToString();
                    txtCapacity.Text = reader["Capacity"].ToString();
                    dtpStartDate.Value = Convert.ToDateTime(reader["StartDate"]);
                    dtpEndDate.Value = Convert.ToDateTime(reader["EndDate"]);
                    txtTransport.Text = reader["Transport"].ToString();
                    txtMeal.Text = reader["Meal"].ToString();
                    txtAccommodation.Text = reader["Accommodation"].ToString();
                }
                string attractionQuery = "SELECT NameAttraction, Type FROM Attraction WHERE ID_Tour = @TourID";
                SqlCommand attractionCommand = new SqlCommand(attractionQuery, connection);
                attractionCommand.Parameters.AddWithValue("@TourID", tourId);

                SqlDataReader attractionReader = attractionCommand.ExecuteReader();
                if (attractionReader.Read())
                {
                    txtAttractionName.Text = attractionReader["NameAttraction"].ToString();
                    txtAttractionType.Text = attractionReader["Type"].ToString();
                }
                attractionReader.Close();
            }
        }

        private void LoadDropdowns()
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                connection.Open();

                string countryQuery = "SELECT DISTINCT NameCountry FROM Country";
                SqlCommand countryCommand = new SqlCommand(countryQuery, connection);
                SqlDataReader countryReader = countryCommand.ExecuteReader();
                while (countryReader.Read())
                {
                    cmbCountry.Items.Add(countryReader["NameCountry"].ToString());
                }
                countryReader.Close();

                string cityQuery = "SELECT DISTINCT NameCity FROM City";
                SqlCommand cityCommand = new SqlCommand(cityQuery, connection);
                SqlDataReader cityReader = cityCommand.ExecuteReader();
                while (cityReader.Read())
                {
                    txtCity.Text = cityReader["NameCity"].ToString();
                }
                cityReader.Close();

                string hotelQuery = "SELECT DISTINCT NameHotel FROM Hotel";
                SqlCommand hotelCommand = new SqlCommand(hotelQuery, connection);
                SqlDataReader hotelReader = hotelCommand.ExecuteReader();
                while (hotelReader.Read())
                {
                    txtHotel.Text = hotelReader["NameHotel"].ToString();
                }
                hotelReader.Close();

                for (int i = 1; i <= 5; i++)
                {
                    cmbHotelRating.Items.Add(i);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string tourQuery = tourId == null
                        ? "INSERT INTO Tour (TourName, StartDate, EndDate, TourPrice, Transport, Accommodation, Meal, Capacity) " +
                          "VALUES (@Name, @StartDate, @EndDate, @Price, @Transport, @Accommodation, @Meal, @Capacity); SELECT SCOPE_IDENTITY();"
                        : "UPDATE Tour SET TourName = @Name, StartDate = @StartDate, EndDate = @EndDate, TourPrice = @Price, " +
                          "Transport = @Transport, Accommodation = @Accommodation, Meal = @Meal, Capacity = @Capacity WHERE ID_Tour = @TourID";

                    SqlCommand tourCommand = new SqlCommand(tourQuery, connection, transaction);
                    tourCommand.Parameters.AddWithValue("@Name", txtName.Text);
                    tourCommand.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                    tourCommand.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                    tourCommand.Parameters.AddWithValue("@Price", txtPrice.Text);
                    tourCommand.Parameters.AddWithValue("@Transport", txtTransport.Text);
                    tourCommand.Parameters.AddWithValue("@Accommodation", txtAccommodation.Text);
                    tourCommand.Parameters.AddWithValue("@Meal", txtMeal.Text);
                    tourCommand.Parameters.AddWithValue("@Capacity", txtCapacity.Text);

                    if (tourId != null)
                        tourCommand.Parameters.AddWithValue("@TourID", tourId);

                    int newTourId = tourId == null ? Convert.ToInt32(tourCommand.ExecuteScalar()) : (int)tourId;

                    string countryQuery = "INSERT INTO Country (ID_Tour, NameCountry) VALUES (@TourID, @Country)";
                    SqlCommand countryCommand = new SqlCommand(countryQuery, connection, transaction);
                    countryCommand.Parameters.AddWithValue("@TourID", newTourId);
                    countryCommand.Parameters.AddWithValue("@Country", cmbCountry.SelectedItem);
                    countryCommand.ExecuteNonQuery();

                    string cityQuery = "INSERT INTO City (ID_Tour, NameCity) VALUES (@TourID, @City)";
                    SqlCommand cityCommand = new SqlCommand(cityQuery, connection, transaction);
                    cityCommand.Parameters.AddWithValue("@TourID", newTourId);
                    cityCommand.Parameters.AddWithValue("@City", txtCity.Text);
                    cityCommand.ExecuteNonQuery();

                    string hotelQuery = "INSERT INTO Hotel (ID_Tour, NameHotel, Rating) VALUES (@TourID, @Hotel, @HotelRating)";
                    SqlCommand hotelCommand = new SqlCommand(hotelQuery, connection, transaction);
                    hotelCommand.Parameters.AddWithValue("@TourID", newTourId);
                    hotelCommand.Parameters.AddWithValue("@Hotel", txtHotel.Text);
                    hotelCommand.Parameters.AddWithValue("@HotelRating", cmbHotelRating.SelectedItem);
                    hotelCommand.ExecuteNonQuery();

                    string attractionQuery = "INSERT INTO Attraction (ID_Tour, NameAttraction, Type) VALUES (@TourID, @AttractionName, @AttractionType)";
                    SqlCommand attractionCommand = new SqlCommand(attractionQuery, connection, transaction);
                    attractionCommand.Parameters.AddWithValue("@TourID", newTourId);
                    attractionCommand.Parameters.AddWithValue("@AttractionName", txtAttractionName.Text);
                    attractionCommand.Parameters.AddWithValue("@AttractionType", txtAttractionType.Text);
                    attractionCommand.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Тур успішно збережено!", "Успіх", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Помилка збереження: {ex.Message}", "Помилка", MessageBoxButtons.OK);
                }
            }
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            try
            {
                AddCountryForm addCountryForm = new AddCountryForm();
                addCountryForm.StartPosition = FormStartPosition.CenterScreen;
                addCountryForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка відкриття форми додавання країни: {ex.Message}", "Помилка", MessageBoxButtons.OK);
            }

            cmbCountry.Items.Clear();
            LoadDropdowns();
        }

        private void cmbHotelRating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
