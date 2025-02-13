using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TourApp
{
    public partial class TourDetailsForm : Form
    {
        private int tourId;
        private string userType;
        private int userId;

        public TourDetailsForm(int tourId, string userType, int userId)
        {
            this.tourId = tourId;
            this.userType = userType;
            this.userId = userId;
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
                    txtHotelRating.Text = hotelReader["Rating"].ToString();
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

        private void btnBookTour_Click(object sender, EventArgs e)
        {
            BookTour();
        }
        private int GetEmployeeId()
        {
            if (userType == "Employee" || userType == "Admin")
            {
                return userId;
            }
            return 0;
        }
        private void BookTour()
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                DateTime orderDate = DateTime.Now;
                string status = "Подано заяву";

                if (userType != "Client")
                {
                    MessageBox.Show("Тілький клієнти можуть бронювати тури.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int clientId = userId;
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string orderQuery = "INSERT INTO OrderFin (OrderDate, Status, ID_Client, ID_Tour) " +
                                        "VALUES (@OrderDate, @Status, @ClientID, @TourID)";
                    SqlCommand orderCommand = new SqlCommand(orderQuery, connection, transaction);
                    orderCommand.Parameters.AddWithValue("@OrderDate", orderDate);
                    orderCommand.Parameters.AddWithValue("@Status", status);
                    orderCommand.Parameters.AddWithValue("@TourID", tourId);
                    orderCommand.Parameters.AddWithValue("@ClientID", clientId);
                    orderCommand.ExecuteNonQuery();

                    string updateTourQuery = "UPDATE Tour SET Capacity = Capacity - 1 WHERE ID_Tour = @TourID AND Capacity > 0";
                    SqlCommand updateTourCommand = new SqlCommand(updateTourQuery, connection, transaction);
                    updateTourCommand.Parameters.AddWithValue("@TourID", tourId);
                    int rowsAffected = updateTourCommand.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("Недостатньо місць для бронювання.");
                    }

                    transaction.Commit();

                    MessageBox.Show("Тур успішно заброньовано! Статус: Подано заяву.", "Успіх", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Помилка під час бронювання: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditTour_Click(object sender, EventArgs e)
        {
            if (userType == "Admin")
            {
                EditTourForm editTourForm = new EditTourForm(tourId);
            editTourForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ви не маєте прав для редагування туру.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            if (userType == "Admin")
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що бажаєте видалити цей тур?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();

                        try
                        {
                            string deleteCountryQuery = "DELETE FROM Country WHERE ID_Tour = @TourID";
                            SqlCommand countryCommand = new SqlCommand(deleteCountryQuery, connection, transaction);
                            countryCommand.Parameters.AddWithValue("@TourID", tourId);
                            countryCommand.ExecuteNonQuery();

                            string deleteCityQuery = "DELETE FROM City WHERE ID_Tour = @TourID";
                            SqlCommand cityCommand = new SqlCommand(deleteCityQuery, connection, transaction);
                            cityCommand.Parameters.AddWithValue("@TourID", tourId);
                            cityCommand.ExecuteNonQuery();

                            string deleteHotelQuery = "DELETE FROM Hotel WHERE ID_Tour = @TourID";
                            SqlCommand hotelCommand = new SqlCommand(deleteHotelQuery, connection, transaction);
                            hotelCommand.Parameters.AddWithValue("@TourID", tourId);
                            hotelCommand.ExecuteNonQuery();

                            string deleteAttractionQuery = "DELETE FROM Attraction WHERE ID_Tour = @TourID";
                            SqlCommand attractionCommand = new SqlCommand(deleteAttractionQuery, connection, transaction);
                            attractionCommand.Parameters.AddWithValue("@TourID", tourId);
                            attractionCommand.ExecuteNonQuery();

                            string deleteTourQuery = "DELETE FROM Tour WHERE ID_Tour = @TourID";
                            SqlCommand tourCommand = new SqlCommand(deleteTourQuery, connection, transaction);
                            tourCommand.Parameters.AddWithValue("@TourID", tourId);
                            tourCommand.ExecuteNonQuery();

                            transaction.Commit();

                            MessageBox.Show("Тур видалено успішно!!", "Успіх", MessageBoxButtons.OK);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Помилка видалення: {ex.Message}", "Помилка", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("У вас немає прав для видалення туру.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
