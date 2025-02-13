using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TourApp
{
    public partial class EditTourForm : Form
    {
        private int tourId;

        public EditTourForm(int tourId)
        {
            this.tourId = tourId;
            InitializeComponent();
            LoadTourData();
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
                else
                {
                    MessageBox.Show("Тур не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                reader.Close();

                string countryQuery = "SELECT NameCountry FROM Country WHERE ID_Tour = @TourID";
                SqlCommand countryCommand = new SqlCommand(countryQuery, connection);
                countryCommand.Parameters.AddWithValue("@TourID", tourId);
                SqlDataReader countryReader = countryCommand.ExecuteReader();
                if (countryReader.Read())
                {
                    txtCountry.Text = countryReader["NameCountry"].ToString();
                }
                countryReader.Close();

                string cityQuery = "SELECT NameCity FROM City WHERE ID_Tour = @TourID";
                SqlCommand cityCommand = new SqlCommand(cityQuery, connection);
                cityCommand.Parameters.AddWithValue("@TourID", tourId);
                SqlDataReader cityReader = cityCommand.ExecuteReader();
                if (cityReader.Read())
                {
                    txtCity.Text = cityReader["NameCity"].ToString();
                }
                cityReader.Close();

                string hotelQuery = "SELECT NameHotel, Rating FROM Hotel WHERE ID_Tour = @TourID";
                SqlCommand hotelCommand = new SqlCommand(hotelQuery, connection);
                hotelCommand.Parameters.AddWithValue("@TourID", tourId);
                SqlDataReader hotelReader = hotelCommand.ExecuteReader();
                if (hotelReader.Read())
                {
                    txtHotel.Text = hotelReader["NameHotel"].ToString();
                    cmbHotelRating.SelectedItem = hotelReader["Rating"];
                }
                hotelReader.Close();

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string query = "UPDATE Tour SET TourName = @Name, Description = @Description, TourPrice = @Price, Capacity = @Capacity, " +
                                   "StartDate = @StartDate, EndDate = @EndDate, Transport = @Transport, Meal = @Meal, Accommodation = @Accommodation " +
                                   "WHERE ID_Tour = @TourID";

                    SqlCommand command = new SqlCommand(query, connection, transaction);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Description", txtDescription.Text);
                    command.Parameters.AddWithValue("@Price", txtPrice.Text);
                    command.Parameters.AddWithValue("@Capacity", txtCapacity.Text);
                    command.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                    command.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                    command.Parameters.AddWithValue("@Transport", txtTransport.Text);
                    command.Parameters.AddWithValue("@Meal", txtMeal.Text);
                    command.Parameters.AddWithValue("@Accommodation", txtAccommodation.Text);
                    command.Parameters.AddWithValue("@TourID", tourId);
                    command.ExecuteNonQuery();

                    string countryQuery = "UPDATE Country SET NameCountry = @NameCountry WHERE ID_Tour = @TourID";
                    SqlCommand countryCommand = new SqlCommand(countryQuery, connection, transaction);
                    countryCommand.Parameters.AddWithValue("@NameCountry", txtCountry.Text);
                    countryCommand.Parameters.AddWithValue("@TourID", tourId);
                    countryCommand.ExecuteNonQuery();

                    string cityQuery = "UPDATE City SET NameCity = @NameCity WHERE ID_Tour = @TourID";
                    SqlCommand cityCommand = new SqlCommand(cityQuery, connection, transaction);
                    cityCommand.Parameters.AddWithValue("@NameCity", txtCity.Text);
                    cityCommand.Parameters.AddWithValue("@TourID", tourId);
                    cityCommand.ExecuteNonQuery();

                    string hotelQuery = "UPDATE Hotel SET NameHotel = @NameHotel, Rating = @Rating WHERE ID_Tour = @TourID";
                    SqlCommand hotelCommand = new SqlCommand(hotelQuery, connection, transaction);
                    hotelCommand.Parameters.AddWithValue("@NameHotel", txtHotel.Text);
                    hotelCommand.Parameters.AddWithValue("@Rating", cmbHotelRating.SelectedItem);
                    hotelCommand.Parameters.AddWithValue("@TourID", tourId);
                    hotelCommand.ExecuteNonQuery();

                    string attractionQuery = "UPDATE Attraction SET NameAttraction = @AttractionName, Type = @AttractionType WHERE ID_Tour = @TourID";
                    SqlCommand attractionCommand = new SqlCommand(attractionQuery, connection, transaction);
                    attractionCommand.Parameters.AddWithValue("@AttractionName", txtAttractionName.Text);
                    attractionCommand.Parameters.AddWithValue("@AttractionType", txtAttractionType.Text);
                    attractionCommand.Parameters.AddWithValue("@TourID", tourId);
                    attractionCommand.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Зміни збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Помилка збереження: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете видалити цей тур?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
                {
                    string query = "DELETE FROM Tour WHERE ID_Tour = @TourID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TourID", tourId);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Тур вилучено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblCapacity_Click(object sender, EventArgs e)
        {

        }

        private void lblStartDate_Click(object sender, EventArgs e)
        {

        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {

        }

        private void lblTransport_Click(object sender, EventArgs e)
        {

        }

        private void lblMeal_Click(object sender, EventArgs e)
        {

        }

        private void lblAccommodation_Click(object sender, EventArgs e)
        {

        }
    }
}
