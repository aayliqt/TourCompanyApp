namespace TourApp
{
    partial class TourDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTourName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.TextBox txtMeal;
        private System.Windows.Forms.Label lblAccommodation;
        private System.Windows.Forms.TextBox txtAccommodation;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.TextBox txtHotel;
        private System.Windows.Forms.Label lblHotelRating;
        private System.Windows.Forms.TextBox txtHotelRating;
        private System.Windows.Forms.Button btnBookTour;
        private System.Windows.Forms.Button btnEditTour;
        private System.Windows.Forms.Button btnDeleteTour;
        private System.Windows.Forms.Label lblAttractionName;
        private System.Windows.Forms.TextBox txtAttractionName;
        private System.Windows.Forms.Label lblAttractionType;
        private System.Windows.Forms.TextBox txtAttractionType;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TourDetailsForm));
            this.lblTourName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblTransport = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.lblMeal = new System.Windows.Forms.Label();
            this.txtMeal = new System.Windows.Forms.TextBox();
            this.lblAccommodation = new System.Windows.Forms.Label();
            this.txtAccommodation = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblHotel = new System.Windows.Forms.Label();
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.lblHotelRating = new System.Windows.Forms.Label();
            this.btnBookTour = new System.Windows.Forms.Button();
            this.btnEditTour = new System.Windows.Forms.Button();
            this.btnDeleteTour = new System.Windows.Forms.Button();
            this.lblAttractionName = new System.Windows.Forms.Label();
            this.txtAttractionName = new System.Windows.Forms.TextBox();
            this.lblAttractionType = new System.Windows.Forms.Label();
            this.txtAttractionType = new System.Windows.Forms.TextBox();
            this.txtHotelRating = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTourName
            // 
            this.lblTourName.AutoSize = true;
            this.lblTourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTourName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTourName.Location = new System.Drawing.Point(12, 9);
            this.lblTourName.Name = "lblTourName";
            this.lblTourName.Size = new System.Drawing.Size(77, 13);
            this.lblTourName.TabIndex = 0;
            this.lblTourName.Text = "Назва туру:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightBlue;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(127, 6);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(250, 13);
            this.txtName.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDescription.Location = new System.Drawing.Point(12, 37);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Опис туру:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.LightBlue;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtDescription.Location = new System.Drawing.Point(127, 34);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(250, 13);
            this.txtDescription.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPrice.Location = new System.Drawing.Point(383, 9);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Ціна туру:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.LightBlue;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPrice.Location = new System.Drawing.Point(498, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(250, 13);
            this.txtPrice.TabIndex = 5;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCapacity.Location = new System.Drawing.Point(383, 37);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(80, 13);
            this.lblCapacity.TabIndex = 6;
            this.lblCapacity.Text = "К-сть місць:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.LightBlue;
            this.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCapacity.Location = new System.Drawing.Point(498, 34);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.ReadOnly = true;
            this.txtCapacity.Size = new System.Drawing.Size(250, 13);
            this.txtCapacity.TabIndex = 7;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblStartDate.Location = new System.Drawing.Point(12, 63);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(91, 13);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Дата початку:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtpStartDate.CalendarMonthBackground = System.Drawing.Color.LightBlue;
            this.dtpStartDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtpStartDate.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpStartDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpStartDate.Location = new System.Drawing.Point(127, 60);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(250, 20);
            this.dtpStartDate.TabIndex = 9;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEndDate.Location = new System.Drawing.Point(383, 66);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(110, 13);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "Дата закінчення:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtpEndDate.CalendarMonthBackground = System.Drawing.Color.LightBlue;
            this.dtpEndDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtpEndDate.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpEndDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEndDate.Location = new System.Drawing.Point(498, 63);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(250, 20);
            this.dtpEndDate.TabIndex = 11;
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTransport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTransport.Location = new System.Drawing.Point(12, 89);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(74, 13);
            this.lblTransport.TabIndex = 12;
            this.lblTransport.Text = "Транспорт:";
            // 
            // txtTransport
            // 
            this.txtTransport.BackColor = System.Drawing.Color.LightBlue;
            this.txtTransport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTransport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTransport.Location = new System.Drawing.Point(127, 86);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.ReadOnly = true;
            this.txtTransport.Size = new System.Drawing.Size(250, 13);
            this.txtTransport.TabIndex = 13;
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMeal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMeal.Location = new System.Drawing.Point(383, 92);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(80, 13);
            this.lblMeal.TabIndex = 14;
            this.lblMeal.Text = "Харчування:";
            // 
            // txtMeal
            // 
            this.txtMeal.BackColor = System.Drawing.Color.LightBlue;
            this.txtMeal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMeal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMeal.Location = new System.Drawing.Point(498, 86);
            this.txtMeal.Name = "txtMeal";
            this.txtMeal.ReadOnly = true;
            this.txtMeal.Size = new System.Drawing.Size(250, 13);
            this.txtMeal.TabIndex = 15;
            // 
            // lblAccommodation
            // 
            this.lblAccommodation.AutoSize = true;
            this.lblAccommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccommodation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAccommodation.Location = new System.Drawing.Point(12, 116);
            this.lblAccommodation.Name = "lblAccommodation";
            this.lblAccommodation.Size = new System.Drawing.Size(83, 13);
            this.lblAccommodation.TabIndex = 16;
            this.lblAccommodation.Text = "Розміщення:";
            // 
            // txtAccommodation
            // 
            this.txtAccommodation.BackColor = System.Drawing.Color.LightBlue;
            this.txtAccommodation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAccommodation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAccommodation.Location = new System.Drawing.Point(127, 113);
            this.txtAccommodation.Name = "txtAccommodation";
            this.txtAccommodation.ReadOnly = true;
            this.txtAccommodation.Size = new System.Drawing.Size(250, 13);
            this.txtAccommodation.TabIndex = 17;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCountry.Location = new System.Drawing.Point(383, 116);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(51, 13);
            this.lblCountry.TabIndex = 18;
            this.lblCountry.Text = "Країна:";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.LightBlue;
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCountry.Location = new System.Drawing.Point(498, 113);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(250, 13);
            this.txtCountry.TabIndex = 19;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCity.Location = new System.Drawing.Point(12, 142);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(44, 13);
            this.lblCity.TabIndex = 20;
            this.lblCity.Text = "Місто:";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.LightBlue;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCity.Location = new System.Drawing.Point(127, 139);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(250, 13);
            this.txtCity.TabIndex = 21;
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHotel.Location = new System.Drawing.Point(383, 145);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(52, 13);
            this.lblHotel.TabIndex = 22;
            this.lblHotel.Text = "Готель:";
            // 
            // txtHotel
            // 
            this.txtHotel.BackColor = System.Drawing.Color.LightBlue;
            this.txtHotel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtHotel.Location = new System.Drawing.Point(498, 142);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.ReadOnly = true;
            this.txtHotel.Size = new System.Drawing.Size(250, 13);
            this.txtHotel.TabIndex = 23;
            // 
            // lblHotelRating
            // 
            this.lblHotelRating.AutoSize = true;
            this.lblHotelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHotelRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHotelRating.Location = new System.Drawing.Point(383, 171);
            this.lblHotelRating.Name = "lblHotelRating";
            this.lblHotelRating.Size = new System.Drawing.Size(59, 13);
            this.lblHotelRating.TabIndex = 24;
            this.lblHotelRating.Text = "Рейтинг:";
            // 
            // btnBookTour
            // 
            this.btnBookTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBookTour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBookTour.ForeColor = System.Drawing.Color.Orange;
            this.btnBookTour.Location = new System.Drawing.Point(15, 291);
            this.btnBookTour.Name = "btnBookTour";
            this.btnBookTour.Size = new System.Drawing.Size(292, 51);
            this.btnBookTour.TabIndex = 20;
            this.btnBookTour.Text = "Забронювати тур";
            this.btnBookTour.UseVisualStyleBackColor = false;
            this.btnBookTour.Click += new System.EventHandler(this.btnBookTour_Click);
            // 
            // btnEditTour
            // 
            this.btnEditTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEditTour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditTour.ForeColor = System.Drawing.Color.Orange;
            this.btnEditTour.Location = new System.Drawing.Point(340, 291);
            this.btnEditTour.Name = "btnEditTour";
            this.btnEditTour.Size = new System.Drawing.Size(292, 51);
            this.btnEditTour.TabIndex = 21;
            this.btnEditTour.Text = "Редактувати тур";
            this.btnEditTour.UseVisualStyleBackColor = false;
            this.btnEditTour.Click += new System.EventHandler(this.btnEditTour_Click);
            // 
            // btnDeleteTour
            // 
            this.btnDeleteTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeleteTour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteTour.ForeColor = System.Drawing.Color.Orange;
            this.btnDeleteTour.Location = new System.Drawing.Point(666, 291);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Size = new System.Drawing.Size(292, 51);
            this.btnDeleteTour.TabIndex = 22;
            this.btnDeleteTour.Text = "Видалити тур";
            this.btnDeleteTour.UseVisualStyleBackColor = false;
            this.btnDeleteTour.Click += new System.EventHandler(this.btnDeleteTour_Click);
            // 
            // lblAttractionName
            // 
            this.lblAttractionName.AutoSize = true;
            this.lblAttractionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAttractionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAttractionName.Location = new System.Drawing.Point(12, 171);
            this.lblAttractionName.Name = "lblAttractionName";
            this.lblAttractionName.Size = new System.Drawing.Size(101, 13);
            this.lblAttractionName.TabIndex = 26;
            this.lblAttractionName.Text = "Назва пам\'ятки";
            // 
            // txtAttractionName
            // 
            this.txtAttractionName.BackColor = System.Drawing.Color.LightBlue;
            this.txtAttractionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAttractionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAttractionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAttractionName.Location = new System.Drawing.Point(127, 169);
            this.txtAttractionName.Name = "txtAttractionName";
            this.txtAttractionName.ReadOnly = true;
            this.txtAttractionName.Size = new System.Drawing.Size(250, 13);
            this.txtAttractionName.TabIndex = 27;
            // 
            // lblAttractionType
            // 
            this.lblAttractionType.AutoSize = true;
            this.lblAttractionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAttractionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAttractionType.Location = new System.Drawing.Point(12, 198);
            this.lblAttractionType.Name = "lblAttractionType";
            this.lblAttractionType.Size = new System.Drawing.Size(86, 13);
            this.lblAttractionType.TabIndex = 28;
            this.lblAttractionType.Text = "Тип пам\'ятки";
            // 
            // txtAttractionType
            // 
            this.txtAttractionType.BackColor = System.Drawing.Color.LightBlue;
            this.txtAttractionType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAttractionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAttractionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAttractionType.Location = new System.Drawing.Point(127, 195);
            this.txtAttractionType.Name = "txtAttractionType";
            this.txtAttractionType.ReadOnly = true;
            this.txtAttractionType.Size = new System.Drawing.Size(250, 13);
            this.txtAttractionType.TabIndex = 29;
            // 
            // txtHotelRating
            // 
            this.txtHotelRating.BackColor = System.Drawing.Color.LightBlue;
            this.txtHotelRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHotelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHotelRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtHotelRating.Location = new System.Drawing.Point(498, 168);
            this.txtHotelRating.Name = "txtHotelRating";
            this.txtHotelRating.ReadOnly = true;
            this.txtHotelRating.Size = new System.Drawing.Size(250, 13);
            this.txtHotelRating.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(769, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tour Agency";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(775, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 179);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // TourDetailsForm
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(970, 381);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTourName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.lblMeal);
            this.Controls.Add(this.txtMeal);
            this.Controls.Add(this.lblAccommodation);
            this.Controls.Add(this.txtAccommodation);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.txtHotel);
            this.Controls.Add(this.lblHotelRating);
            this.Controls.Add(this.txtHotelRating);
            this.Controls.Add(this.btnBookTour);
            this.Controls.Add(this.btnEditTour);
            this.Controls.Add(this.btnDeleteTour);
            this.Controls.Add(this.lblAttractionName);
            this.Controls.Add(this.txtAttractionName);
            this.Controls.Add(this.lblAttractionType);
            this.Controls.Add(this.txtAttractionType);
            this.Name = "TourDetailsForm";
            this.Text = "Деталі туру";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
