using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TourApp
{
    public partial class StatForm : Form
    {
        public StatForm()
        {
            InitializeComponent();
            LoadClientStats();
            LoadTotalRevenueStats();
            LoadCountryStats();
        }

        private void LoadClientStats()
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                string query = "SELECT COUNT(DISTINCT ID_Client) AS ClientCount FROM OrderFin WHERE YEAR(OrderDate) = @Year";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Year", int.Parse(txtYear.Text));

                connection.Open();
                object result = command.ExecuteScalar();
                int clientCount = (result != DBNull.Value) ? (int)result : 0;

                chartClients.Series.Clear();
                Series series = new Series("Clients")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };
                series.Points.Add(clientCount);
                chartClients.Series.Add(series);

                chartClients.Legends.Clear();
                Legend legend = new Legend("Legend")
                {
                    Docking = Docking.Right
                };
                chartClients.Legends.Add(legend);
            }
        }

        private void LoadTotalRevenueStats()
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                string query = "SELECT SUM(t.TourPrice) AS TotalRevenue FROM OrderFin o JOIN Tour t ON o.ID_Tour = t.ID_Tour WHERE o.Status = 'Підтверджено' AND YEAR(o.OrderDate) = @Year";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Year", int.Parse(txtYear.Text));

                connection.Open();
                object result = command.ExecuteScalar();
                decimal totalRevenue = (result != DBNull.Value) ? (decimal)result : 0;

                chartRevenue.Series.Clear();
                Series series = new Series("Revenue")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };

                series.Points.AddXY("Total Revenue", totalRevenue);
                chartRevenue.Series.Add(series);

                chartRevenue.Legends.Clear();
                Legend legend = new Legend("Legend")
                {
                    Docking = Docking.Right
                };
                chartRevenue.Legends.Add(legend);
            }
        }

        private void LoadCountryStats()
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                string query = "SELECT c.NameCountry, COUNT(*) AS TourCount FROM Tour t JOIN Country c ON t.ID_Tour = c.ID_Tour GROUP BY c.NameCountry";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable countryStats = new DataTable();
                adapter.Fill(countryStats);

                chartCountries.Series.Clear();
                Series series = new Series("Countries")
                {
                    ChartType = SeriesChartType.Pie
                };

                int colorIndex = 0;

                foreach (DataRow row in countryStats.Rows)
                {
                    string countryName = row["NameCountry"].ToString();
                    int tourCount = (int)row["TourCount"];

                    DataPoint point = new DataPoint
                    {
                        AxisLabel = countryName,
                        YValues = new[] { (double)tourCount },
                        Label = string.Empty
                    };

                    point.Color = GenerateColor(colorIndex);
                    series.Points.Add(point);
                    colorIndex++;
                }

                chartCountries.Series.Add(series);

                chartCountries.Legends.Clear();
                Legend legend = new Legend("Legend")
                {
                    Docking = Docking.Right,
                    LegendItemOrder = LegendItemOrder.SameAsSeriesOrder,
                    Font = new Font("Arial", 10, FontStyle.Regular)
                };

                foreach (DataPoint point in series.Points)
                {
                    point.LegendText = $"{point.AxisLabel}\n{point.YValues[0]}";
                }

                chartCountries.Legends.Add(legend);
            }
        }
        private Color GenerateColor(int index)
        {
            Random rand = new Random(index);
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }
        private void btnUpdateStats_Click(object sender, EventArgs e)
        {
            LoadClientStats();
            LoadTotalRevenueStats();
            LoadCountryStats();
        }
    }
}