using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TourApp
{
    public partial class OrderForm : Form
    {
        private int clientId;
        private int selectedTourId;
        private string userRole;

        public OrderForm(int clientId, string role)
        {
            this.clientId = clientId;
            this.userRole = role;
            InitializeComponent();
            LoadOrders();

            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
        }

        private void LoadOrders()
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                string query;

                if (userRole == "Admin" || userRole == "Employee")
                {
                    query = @"
                SELECT o.ID_Order, t.TourName, t.ID_Tour, o.OrderDate, o.Status, o.ID_Client
                FROM OrderFin o
                JOIN Tour t ON t.ID_Tour = o.ID_Tour";
                }
                else
                {
                    query = @"
                SELECT o.ID_Order, t.TourName, t.ID_Tour, o.OrderDate, o.Status, o.ID_Client
                FROM OrderFin o
                JOIN Tour t ON t.ID_Tour = o.ID_Tour
                WHERE o.ID_Client = @ClientID";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                if (userRole != "Admin" && userRole != "Employee")
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@ClientID", clientId);
                }

                DataTable orders = new DataTable();
                adapter.Fill(orders);

                dgvOrders.DataSource = orders;

                if (orders.Rows.Count > 0)
                {
                    selectedTourId = (int)orders.Rows[0]["ID_Tour"];
                    LoadTourDetails(selectedTourId);
                }
            }
        }


        private void LoadTourDetails(int tourId)
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
        private void ConfirmOrder(int orderId)
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string updateStatusQuery = "UPDATE OrderFin SET Status = 'Підтверджено' WHERE ID_Order = @OrderID";
                    SqlCommand updateStatusCommand = new SqlCommand(updateStatusQuery, connection, transaction);
                    updateStatusCommand.Parameters.AddWithValue("@OrderID", orderId);
                    updateStatusCommand.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Статус замовлення успішно змінено на 'Підтверджено'.", "Успіх", MessageBoxButtons.OK);
                    LoadOrders();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Помилка зміни статусу замовлення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteOrder(int orderId)
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string deleteOrderQuery = "DELETE FROM OrderFin WHERE ID_Order = @OrderID";
                    SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, connection, transaction);
                    deleteOrderCommand.Parameters.AddWithValue("@OrderID", orderId);
                    deleteOrderCommand.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Замовлення успішно видалено.", "Успіх", MessageBoxButtons.OK);
                    LoadOrders();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Помилка при видаленні замовлення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = (int)dgvOrders.SelectedRows[0].Cells["ID_Order"].Value;

                var result = MessageBox.Show("Ви впевнені, що хочете видалити це замовлення?",
                    "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteOrder(orderId);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть замовлення для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                selectedTourId = (int)dgvOrders.SelectedRows[0].Cells["ID_Tour"].Value;
                LoadTourDetails(selectedTourId);
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = (int)dgvOrders.SelectedRows[0].Cells["ID_Order"].Value;
                ConfirmOrder(orderId);
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть замовлення для підтвердження.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPrintOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = (int)dgvOrders.SelectedRows[0].Cells["ID_Order"].Value;
                int clientId = (int)dgvOrders.SelectedRows[0].Cells["ID_Client"].Value;
                int tourId = (int)dgvOrders.SelectedRows[0].Cells["ID_Tour"].Value;

                PrintOrderForm printForm = new PrintOrderForm(orderId, clientId, tourId);
                printForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть замовлення для друку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtAttractionType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAttractionName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAccommodation_Click(object sender, EventArgs e)
        {

        }
    }
}
