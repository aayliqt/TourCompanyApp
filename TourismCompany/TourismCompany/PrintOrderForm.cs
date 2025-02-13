using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace TourApp
{
    public partial class PrintOrderForm : Form
    {
        private int orderId;
        private int clientId;
        private int tourId;

        private string clientInfo;
        private string orderInfo;
        private string tourInfo;

        public PrintOrderForm(int orderId, int clientId, int tourId)
        {
            this.orderId = orderId;
            this.clientId = clientId;
            this.tourId = tourId;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                connection.Open();
                string clientQuery = @"
            SELECT FirstName, LastName, Email, Phone
            FROM Client
            WHERE ID_Client = @ClientID";
                SqlCommand clientCommand = new SqlCommand(clientQuery, connection);
                clientCommand.Parameters.AddWithValue("@ClientID", clientId);
                SqlDataReader clientReader = clientCommand.ExecuteReader();
                if (clientReader.Read())
                {
                    clientInfo = $"Клієнт:\n" +
                                 $"ФІО: {clientReader["FirstName"].ToString().Trim()} {clientReader["LastName"].ToString().Trim()}\n" +
                                 $"Email: {clientReader["Email"]}\n" +
                                 $"Телефон: {clientReader["Phone"]}\n\n";
                }
                clientReader.Close();

                string orderQuery = @"
            SELECT o.OrderDate, o.Status
            FROM OrderFin o
            WHERE o.ID_Order = @OrderID";
                SqlCommand orderCommand = new SqlCommand(orderQuery, connection);
                orderCommand.Parameters.AddWithValue("@OrderID", orderId);
                SqlDataReader orderReader = orderCommand.ExecuteReader();
                if (orderReader.Read())
                {
                    orderInfo = $"Замовлення:\n" +
                                $"Дата замовлення: {Convert.ToDateTime(orderReader["OrderDate"]).ToShortDateString()}\n" +
                                $"Статус: {orderReader["Status"]}\n\n";
                }
                orderReader.Close();

                string tourQuery = @"
            SELECT TourName, Description, TourPrice, StartDate, EndDate, Transport, Meal, Accommodation
            FROM Tour
            WHERE ID_Tour = @TourID";
                SqlCommand tourCommand = new SqlCommand(tourQuery, connection);
                tourCommand.Parameters.AddWithValue("@TourID", tourId);
                SqlDataReader tourReader = tourCommand.ExecuteReader();
                if (tourReader.Read())
                {
                    tourInfo = $"Тур:\n" +
                               $"Назва: {tourReader["TourName"]}\n" +
                               $"Опис: {tourReader["Description"]}\n" +
                               $"Ціна: {tourReader["TourPrice"]} ₴\n" +
                               $"Дата початку: {Convert.ToDateTime(tourReader["StartDate"]).ToShortDateString()}\n" +
                               $"Дата закінчення: {Convert.ToDateTime(tourReader["EndDate"]).ToShortDateString()}\n" +
                               $"Транспорт: {tourReader["Transport"]}\n" +
                               $"Харчування: {tourReader["Meal"]}\n" +
                               $"Розміщення: {tourReader["Accommodation"]}\n";
                }
                tourReader.Close();

                string countryQuery = "SELECT NameCountry FROM Country WHERE ID_Tour = @TourID";
                SqlCommand countryCommand = new SqlCommand(countryQuery, connection);
                countryCommand.Parameters.AddWithValue("@TourID", tourId);
                SqlDataReader countryReader = countryCommand.ExecuteReader();
                if (countryReader.Read())
                {
                    tourInfo += $"Країна: {countryReader["NameCountry"]}\n";
                }
                countryReader.Close();

                string cityQuery = "SELECT NameCity FROM City WHERE ID_Tour = @TourID";
                SqlCommand cityCommand = new SqlCommand(cityQuery, connection);
                cityCommand.Parameters.AddWithValue("@TourID", tourId);
                SqlDataReader cityReader = cityCommand.ExecuteReader();
                if (cityReader.Read())
                {
                    tourInfo += $"Місто: {cityReader["NameCity"]}\n";
                }
                cityReader.Close();

                string hotelQuery = "SELECT NameHotel, Rating FROM Hotel WHERE ID_Tour = @TourID";
                SqlCommand hotelCommand = new SqlCommand(hotelQuery, connection);
                hotelCommand.Parameters.AddWithValue("@TourID", tourId);
                SqlDataReader hotelReader = hotelCommand.ExecuteReader();
                if (hotelReader.Read())
                {
                    tourInfo += $"Готель: {hotelReader["NameHotel"]}\n" +
                                $"Рейтинг готелю: {hotelReader["Rating"]}\n";
                }
                hotelReader.Close();

                string attractionQuery = "SELECT NameAttraction, Type FROM Attraction WHERE ID_Tour = @TourID";
                SqlCommand attractionCommand = new SqlCommand(attractionQuery, connection);
                attractionCommand.Parameters.AddWithValue("@TourID", tourId);
                SqlDataReader attractionReader = attractionCommand.ExecuteReader();
                if (attractionReader.Read())
                {
                    tourInfo += $"Пам'ятка: {attractionReader["NameAttraction"]}\n" +
                                $"Тип пам'ятки: {attractionReader["Type"]}\n";
                }
                attractionReader.Close();

                txtOrderDetails.Text = $"{clientInfo}{orderInfo}{tourInfo}";
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtOrderDetails.Text, new Font("Arial", 14), Brushes.Black, 100, 100);
        }
    }
}
