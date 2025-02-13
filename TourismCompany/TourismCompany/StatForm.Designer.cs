using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TourApp
{
    partial class StatForm
    {
        private System.ComponentModel.IContainer components = null;
        private Chart chartClients;
        private Chart chartRevenue;
        private Chart chartCountries;
        private TextBox txtYear;
        private Button btnUpdateStats;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.chartClients = new Chart();
            this.chartRevenue = new Chart();
            this.chartCountries = new Chart();
            this.txtYear = new TextBox();
            this.btnUpdateStats = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.chartClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountries)).BeginInit();

            this.SuspendLayout();

            // chartClients
            ChartArea chartAreaClients = new ChartArea();
            this.chartClients.ChartAreas.Add(chartAreaClients);
            this.chartClients.Location = new System.Drawing.Point(12, 12);
            this.chartClients.Name = "chartClients";
            this.chartClients.Size = new System.Drawing.Size(400, 300);
            this.chartClients.TabIndex = 0;
            this.chartClients.Text = "chartClients";

            // Title for chartClients
            Title titleClients = new Title("Clients Statistics", Docking.Top, new Font("Arial", 12, FontStyle.Bold), Color.Black);
            this.chartClients.Titles.Add(titleClients);

            // chartRevenue
            ChartArea chartAreaRevenue = new ChartArea();
            this.chartRevenue.ChartAreas.Add(chartAreaRevenue);
            this.chartRevenue.Location = new System.Drawing.Point(418, 12);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Size = new System.Drawing.Size(400, 300);
            this.chartRevenue.TabIndex = 1;
            this.chartRevenue.Text = "chartRevenue";

            // Title for chartRevenue
            Title titleRevenue = new Title("Revenue Statistics", Docking.Top, new Font("Arial", 12, FontStyle.Bold), Color.Black);
            this.chartRevenue.Titles.Add(titleRevenue);

            // Set chartRevenue to a column chart (not pie)
            this.chartRevenue.Series.Clear();
            Series seriesRevenue = new Series
            {
                ChartType = SeriesChartType.Column,  // Changed to Column chart
                Name = "Revenue",
                IsValueShownAsLabel = true
            };
            this.chartRevenue.Series.Add(seriesRevenue);

            // chartCountries
            ChartArea chartAreaCountries = new ChartArea();
            this.chartCountries.ChartAreas.Add(chartAreaCountries);
            this.chartCountries.Location = new System.Drawing.Point(824, 12);
            this.chartCountries.Name = "chartCountries";
            this.chartCountries.Size = new System.Drawing.Size(400, 300);
            this.chartCountries.TabIndex = 2;
            this.chartCountries.Text = "chartCountries";

            // Title for chartCountries
            Title titleCountries = new Title("Countries Statistics", Docking.Top, new Font("Arial", 12, FontStyle.Bold), Color.Black);
            this.chartCountries.Titles.Add(titleCountries);

            // txtYear
            this.txtYear.Location = new System.Drawing.Point(12, 330);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 23);
            this.txtYear.TabIndex = 3;
            this.txtYear.Text = "2024";

            // btnUpdateStats
            this.btnUpdateStats.Location = new System.Drawing.Point(130, 330);
            this.btnUpdateStats.Name = "btnUpdateStats";
            this.btnUpdateStats.Size = new System.Drawing.Size(100, 26);
            this.btnUpdateStats.TabIndex = 4;
            this.btnUpdateStats.Text = "Обновить";
            this.btnUpdateStats.UseVisualStyleBackColor = true;

            // Set button styles for Popup look, dark blue background, orange text
            this.btnUpdateStats.BackColor = Color.FromArgb(0, 0, 64);
            this.btnUpdateStats.ForeColor = Color.Orange;
            this.btnUpdateStats.FlatStyle = FlatStyle.Popup;
            this.btnUpdateStats.Font = new Font("Arial", 10, FontStyle.Bold);

            this.btnUpdateStats.Click += new System.EventHandler(this.btnUpdateStats_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 370);
            this.Controls.Add(this.btnUpdateStats);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.chartCountries);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.chartClients);
            this.Name = "StatForm";
            this.Text = "Статистика";

            this.BackColor = Color.LightBlue;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.ForeColor = Color.FromArgb(0, 0, 64); 
                }
            }

    ((System.ComponentModel.ISupportInitialize)(this.chartClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


    }
}
