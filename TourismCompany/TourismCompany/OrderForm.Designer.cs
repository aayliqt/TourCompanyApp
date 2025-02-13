using System.Windows.Forms;

namespace TourApp
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtHotel;
        private System.Windows.Forms.TextBox txtHotelRating;
        private System.Windows.Forms.TextBox txtAttractionName;
        private System.Windows.Forms.TextBox txtAttractionType;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.TextBox txtMeal;
        private System.Windows.Forms.TextBox txtAccommodation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.Label lblAccommodation;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblHotelRating;
        private System.Windows.Forms.Label lblAttractionName;
        private System.Windows.Forms.Label lblAttractionType;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnPrintOrder;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.txtMeal = new System.Windows.Forms.TextBox();
            this.txtAccommodation = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblTransport = new System.Windows.Forms.Label();
            this.lblMeal = new System.Windows.Forms.Label();
            this.lblAccommodation = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.txtHotelRating = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblHotelRating = new System.Windows.Forms.Label();
            this.txtAttractionName = new System.Windows.Forms.TextBox();
            this.txtAttractionType = new System.Windows.Forms.TextBox();
            this.lblAttractionName = new System.Windows.Forms.Label();
            this.lblAttractionType = new System.Windows.Forms.Label();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnPrintOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(12, 12);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(620, 150);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightBlue;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(116, 179);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(205, 13);
            this.txtName.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.LightBlue;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtDescription.Location = new System.Drawing.Point(116, 205);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(205, 13);
            this.txtDescription.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.LightBlue;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPrice.Location = new System.Drawing.Point(116, 231);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(205, 13);
            this.txtPrice.TabIndex = 5;
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.LightBlue;
            this.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCapacity.Location = new System.Drawing.Point(116, 257);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.ReadOnly = true;
            this.txtCapacity.Size = new System.Drawing.Size(205, 13);
            this.txtCapacity.TabIndex = 6;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtpStartDate.CalendarMonthBackground = System.Drawing.Color.LightBlue;
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(116, 284);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(205, 20);
            this.dtpStartDate.TabIndex = 7;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtpEndDate.CalendarMonthBackground = System.Drawing.Color.LightBlue;
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(116, 309);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(205, 20);
            this.dtpEndDate.TabIndex = 8;
            // 
            // txtTransport
            // 
            this.txtTransport.BackColor = System.Drawing.Color.LightBlue;
            this.txtTransport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTransport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTransport.Location = new System.Drawing.Point(116, 336);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.ReadOnly = true;
            this.txtTransport.Size = new System.Drawing.Size(205, 13);
            this.txtTransport.TabIndex = 9;
            // 
            // txtMeal
            // 
            this.txtMeal.BackColor = System.Drawing.Color.LightBlue;
            this.txtMeal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMeal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMeal.Location = new System.Drawing.Point(116, 362);
            this.txtMeal.Name = "txtMeal";
            this.txtMeal.ReadOnly = true;
            this.txtMeal.Size = new System.Drawing.Size(205, 13);
            this.txtMeal.TabIndex = 10;
            // 
            // txtAccommodation
            // 
            this.txtAccommodation.BackColor = System.Drawing.Color.LightBlue;
            this.txtAccommodation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAccommodation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAccommodation.Location = new System.Drawing.Point(432, 338);
            this.txtAccommodation.Name = "txtAccommodation";
            this.txtAccommodation.ReadOnly = true;
            this.txtAccommodation.Size = new System.Drawing.Size(200, 13);
            this.txtAccommodation.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(0, 181);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Назва туру:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDescription.Location = new System.Drawing.Point(0, 207);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(41, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Опис:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPrice.Location = new System.Drawing.Point(0, 233);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Ціна:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCapacity.Location = new System.Drawing.Point(0, 259);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(80, 13);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "К-сть місць:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblStartDate.Location = new System.Drawing.Point(0, 285);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(91, 13);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Дата початку:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEndDate.Location = new System.Drawing.Point(0, 311);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(110, 13);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "Дата закінчення:";
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTransport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTransport.Location = new System.Drawing.Point(0, 337);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(74, 13);
            this.lblTransport.TabIndex = 7;
            this.lblTransport.Text = "Транспорт:";
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMeal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMeal.Location = new System.Drawing.Point(0, 363);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(80, 13);
            this.lblMeal.TabIndex = 8;
            this.lblMeal.Text = "Харчування:";
            // 
            // lblAccommodation
            // 
            this.lblAccommodation.AutoSize = true;
            this.lblAccommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccommodation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAccommodation.Location = new System.Drawing.Point(327, 341);
            this.lblAccommodation.Name = "lblAccommodation";
            this.lblAccommodation.Size = new System.Drawing.Size(83, 13);
            this.lblAccommodation.TabIndex = 9;
            this.lblAccommodation.Text = "Розміщення:";
            this.lblAccommodation.Click += new System.EventHandler(this.lblAccommodation_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.LightBlue;
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCountry.Location = new System.Drawing.Point(432, 181);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(200, 13);
            this.txtCountry.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.LightBlue;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCity.Location = new System.Drawing.Point(432, 207);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(200, 13);
            this.txtCity.TabIndex = 13;
            // 
            // txtHotel
            // 
            this.txtHotel.BackColor = System.Drawing.Color.LightBlue;
            this.txtHotel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtHotel.Location = new System.Drawing.Point(432, 233);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.ReadOnly = true;
            this.txtHotel.Size = new System.Drawing.Size(200, 13);
            this.txtHotel.TabIndex = 14;
            // 
            // txtHotelRating
            // 
            this.txtHotelRating.BackColor = System.Drawing.Color.LightBlue;
            this.txtHotelRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHotelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHotelRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtHotelRating.Location = new System.Drawing.Point(432, 259);
            this.txtHotelRating.Name = "txtHotelRating";
            this.txtHotelRating.ReadOnly = true;
            this.txtHotelRating.Size = new System.Drawing.Size(200, 13);
            this.txtHotelRating.TabIndex = 15;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCountry.Location = new System.Drawing.Point(327, 186);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(51, 13);
            this.lblCountry.TabIndex = 16;
            this.lblCountry.Text = "Країна:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCity.Location = new System.Drawing.Point(327, 210);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(44, 13);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "Місто:";
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHotel.Location = new System.Drawing.Point(327, 238);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(52, 13);
            this.lblHotel.TabIndex = 18;
            this.lblHotel.Text = "Готель:";
            // 
            // lblHotelRating
            // 
            this.lblHotelRating.AutoSize = true;
            this.lblHotelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHotelRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHotelRating.Location = new System.Drawing.Point(327, 262);
            this.lblHotelRating.Name = "lblHotelRating";
            this.lblHotelRating.Size = new System.Drawing.Size(105, 13);
            this.lblHotelRating.TabIndex = 19;
            this.lblHotelRating.Text = "Рейтинг готелю:";
            // 
            // txtAttractionName
            // 
            this.txtAttractionName.BackColor = System.Drawing.Color.LightBlue;
            this.txtAttractionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAttractionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAttractionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAttractionName.Location = new System.Drawing.Point(432, 286);
            this.txtAttractionName.Name = "txtAttractionName";
            this.txtAttractionName.ReadOnly = true;
            this.txtAttractionName.Size = new System.Drawing.Size(200, 13);
            this.txtAttractionName.TabIndex = 20;
            this.txtAttractionName.TextChanged += new System.EventHandler(this.txtAttractionName_TextChanged);
            // 
            // txtAttractionType
            // 
            this.txtAttractionType.BackColor = System.Drawing.Color.LightBlue;
            this.txtAttractionType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAttractionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAttractionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAttractionType.Location = new System.Drawing.Point(432, 312);
            this.txtAttractionType.Name = "txtAttractionType";
            this.txtAttractionType.ReadOnly = true;
            this.txtAttractionType.Size = new System.Drawing.Size(200, 13);
            this.txtAttractionType.TabIndex = 21;
            this.txtAttractionType.TextChanged += new System.EventHandler(this.txtAttractionType_TextChanged);
            // 
            // lblAttractionName
            // 
            this.lblAttractionName.AutoSize = true;
            this.lblAttractionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAttractionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAttractionName.Location = new System.Drawing.Point(327, 289);
            this.lblAttractionName.Name = "lblAttractionName";
            this.lblAttractionName.Size = new System.Drawing.Size(105, 13);
            this.lblAttractionName.TabIndex = 22;
            this.lblAttractionName.Text = "Назва пам\'ятки:";
            // 
            // lblAttractionType
            // 
            this.lblAttractionType.AutoSize = true;
            this.lblAttractionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAttractionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAttractionType.Location = new System.Drawing.Point(327, 315);
            this.lblAttractionType.Name = "lblAttractionType";
            this.lblAttractionType.Size = new System.Drawing.Size(90, 13);
            this.lblAttractionType.TabIndex = 23;
            this.lblAttractionType.Text = "Тип пам\'ятки:";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.Orange;
            this.btnConfirmOrder.Location = new System.Drawing.Point(657, 241);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(183, 49);
            this.btnConfirmOrder.TabIndex = 0;
            this.btnConfirmOrder.Text = "Підтвердити";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.Orange;
            this.btnDeleteOrder.Location = new System.Drawing.Point(657, 381);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(183, 48);
            this.btnDeleteOrder.TabIndex = 3;
            this.btnDeleteOrder.Text = "Видалити";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPrintOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrintOrder.ForeColor = System.Drawing.Color.Orange;
            this.btnPrintOrder.Location = new System.Drawing.Point(657, 315);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(183, 48);
            this.btnPrintOrder.TabIndex = 2;
            this.btnPrintOrder.Text = "Роздрукувати замовлення";
            this.btnPrintOrder.UseVisualStyleBackColor = false;
            this.btnPrintOrder.Click += new System.EventHandler(this.btnPrintOrder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(657, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 179);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(651, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 33);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tour Agency";
            // 
            // OrderForm
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHotelRating);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtHotelRating);
            this.Controls.Add(this.txtHotel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblAccommodation);
            this.Controls.Add(this.lblMeal);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAccommodation);
            this.Controls.Add(this.txtMeal);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.txtAttractionName);
            this.Controls.Add(this.txtAttractionType);
            this.Controls.Add(this.lblAttractionName);
            this.Controls.Add(this.lblAttractionType);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnPrintOrder);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "OrderForm";
            this.Text = "Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox pictureBox1;
        private Label label3;
    }
}
