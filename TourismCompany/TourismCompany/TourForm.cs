using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace TourApp
{
    public partial class TourForm : Form
    {
        private string userType;
        private int userId;

        public TourForm(string userType, int userId)
        {
            this.userType = userType;
            this.userId = userId;
            InitializeComponent();
            LoadTours();
            AddAdminButton();
        }

        private void LoadTours(string searchQuery = "")
        {
            using (SqlConnection connection = new SqlConnection(@"Server=WIN-J9OCU7DJ8KE; Database=TourAgency; Integrated Security=True"))
            {
                string query = "SELECT * FROM Tour WHERE TourName LIKE @SearchQuery";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                DataTable tours = new DataTable();
                adapter.Fill(tours);

                flowLayoutPanelTours.Controls.Clear();

                foreach (DataRow row in tours.Rows)
                {
                    Button tourButton = new Button
                    {
                        Text = $"{row["TourName"]} - {row["TourPrice"]} ₴",
                        Width = 200,
                        Height = 100,
                        Tag = row["ID_Tour"],
                        BackColor = Color.FromArgb(0, 0, 64), 
                        ForeColor = Color.Orange,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        FlatStyle = FlatStyle.Flat
                    };

                    tourButton.FlatAppearance.BorderSize = 0;
                    tourButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 100);
                    tourButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 50);

                    tourButton.MouseEnter += (s, e) => { tourButton.BackColor = Color.FromArgb(0, 0, 100); };
                    tourButton.MouseLeave += (s, e) => { tourButton.BackColor = Color.FromArgb(0, 0, 64); };

                    tourButton.Click += (s, e) => ShowTourDetails((int)row["ID_Tour"]);
                    flowLayoutPanelTours.Controls.Add(tourButton);
                }
            }
        }

        private void AddAdminButton()
        {
            if (userType == "Admin" || userType == "Employee")
            {
                Button btnAddTour = new Button
                {
                    Text = "Додати тур",
                    Width = 200,
                    Height = 50,
                    BackColor = Color.FromArgb(0, 0, 64),
                    ForeColor = Color.Orange,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat
                };

                btnAddTour.FlatAppearance.BorderSize = 0;
                btnAddTour.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 100);
                btnAddTour.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 50);

                btnAddTour.MouseEnter += (s, e) => { btnAddTour.BackColor = Color.FromArgb(0, 0, 100); };
                btnAddTour.MouseLeave += (s, e) => { btnAddTour.BackColor = Color.FromArgb(0, 0, 64); };

                btnAddTour.Click += (s, e) => OpenAddTourForm();
                flowLayoutPanelTours.Controls.Add(btnAddTour);
            }

            if (userType == "Admin")
            {
                Button btnManagers = new Button
                {
                    Text = "Список менеджерів",
                    Width = 200,
                    Height = 50,
                    BackColor = Color.FromArgb(0, 0, 64),
                    ForeColor = Color.Orange,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat 
                };

                btnManagers.FlatAppearance.BorderSize = 0;
                btnManagers.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 100);
                btnManagers.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 50);

                btnManagers.MouseEnter += (s, e) => { btnManagers.BackColor = Color.FromArgb(0, 0, 100); };
                btnManagers.MouseLeave += (s, e) => { btnManagers.BackColor = Color.FromArgb(0, 0, 64); };

                btnManagers.Click += (s, e) => OpenUpdateEmployeesForm();
                flowLayoutPanelTours.Controls.Add(btnManagers);
            }
        }

        private void OpenAddTourForm()
        {
            AddTourForm addTourForm = new AddTourForm();
            addTourForm.Show();
        }

        private void OpenUpdateEmployeesForm()
        {
            UpdateEmployeesForm updateEmployeesForm = new UpdateEmployeesForm();
            updateEmployeesForm.Show();
        }

        private void ShowTourDetails(int tourId)
        {
            TourDetailsForm tourDetailsForm = new TourDetailsForm(tourId, userType, userId);
            tourDetailsForm.Show();
        }

        private void ShowEmployeeTourOptions(int tourId)
        {
            EditTourForm editTourForm = new EditTourForm(tourId);
            editTourForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(userType, userId);
            profileForm.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(userId, userType);
            orderForm.Show();
        }
        private void btnStats_Click(object sender, EventArgs e)
        {
            if (userType != "Admin" && userType != "Employee")
            {
                MessageBox.Show("У вас немає доступу", "Доступ заборонено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                StatForm statForm = new StatForm();
                statForm.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text;
            LoadTours(searchQuery);
        }
    }
}
