namespace TourApp
{
    partial class AddTourForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.cmbHotelRating = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.txtMeal = new System.Windows.Forms.TextBox();
            this.txtAccommodation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelHotel = new System.Windows.Forms.Label();
            this.labelHotelRating = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelTransport = new System.Windows.Forms.Label();
            this.labelMeal = new System.Windows.Forms.Label();
            this.labelAccommodation = new System.Windows.Forms.Label();
            this.labelAttractionName = new System.Windows.Forms.Label();
            this.txtAttractionName = new System.Windows.Forms.TextBox();
            this.labelAttractionType = new System.Windows.Forms.Label();
            this.txtAttractionType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(30, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.Location = new System.Drawing.Point(30, 80);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 60);
            this.txtDescription.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.Location = new System.Drawing.Point(30, 170);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCapacity.Location = new System.Drawing.Point(30, 220);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(200, 22);
            this.txtCapacity.TabIndex = 7;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbCountry.Location = new System.Drawing.Point(250, 30);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(200, 24);
            this.cmbCountry.TabIndex = 9;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCity.Location = new System.Drawing.Point(250, 80);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 22);
            this.txtCity.TabIndex = 11;
            // 
            // txtHotel
            // 
            this.txtHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHotel.Location = new System.Drawing.Point(250, 130);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.Size = new System.Drawing.Size(200, 22);
            this.txtHotel.TabIndex = 13;
            // 
            // cmbHotelRating
            // 
            this.cmbHotelRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbHotelRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbHotelRating.Location = new System.Drawing.Point(250, 180);
            this.cmbHotelRating.Name = "cmbHotelRating";
            this.cmbHotelRating.Size = new System.Drawing.Size(200, 24);
            this.cmbHotelRating.TabIndex = 15;
            this.cmbHotelRating.SelectedIndexChanged += new System.EventHandler(this.cmbHotelRating_SelectedIndexChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtpStartDate.Location = new System.Drawing.Point(250, 230);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 17;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtpEndDate.Location = new System.Drawing.Point(250, 280);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 19;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // txtTransport
            // 
            this.txtTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTransport.Location = new System.Drawing.Point(30, 270);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(200, 22);
            this.txtTransport.TabIndex = 21;
            // 
            // txtMeal
            // 
            this.txtMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMeal.Location = new System.Drawing.Point(30, 320);
            this.txtMeal.Name = "txtMeal";
            this.txtMeal.Size = new System.Drawing.Size(200, 22);
            this.txtMeal.TabIndex = 23;
            // 
            // txtAccommodation
            // 
            this.txtAccommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAccommodation.Location = new System.Drawing.Point(30, 370);
            this.txtAccommodation.Name = "txtAccommodation";
            this.txtAccommodation.Size = new System.Drawing.Size(200, 22);
            this.txtAccommodation.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.Orange;
            this.btnSave.Location = new System.Drawing.Point(30, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 49);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddCountry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCountry.ForeColor = System.Drawing.Color.Orange;
            this.btnAddCountry.Location = new System.Drawing.Point(250, 400);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(200, 49);
            this.btnAddCountry.TabIndex = 26;
            this.btnAddCountry.Text = "Додати країну";
            this.btnAddCountry.UseVisualStyleBackColor = false;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelName.Location = new System.Drawing.Point(30, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(93, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Назва туру";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelDescription.Location = new System.Drawing.Point(30, 60);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 16);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Опис туру";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelPrice.Location = new System.Drawing.Point(30, 150);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(39, 16);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Ціна";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelCapacity.Location = new System.Drawing.Point(30, 200);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(88, 16);
            this.labelCapacity.TabIndex = 6;
            this.labelCapacity.Text = "К-сть місць";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelCountry.Location = new System.Drawing.Point(250, 10);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(56, 16);
            this.labelCountry.TabIndex = 8;
            this.labelCountry.Text = "Країна";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelCity.Location = new System.Drawing.Point(250, 60);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(48, 16);
            this.labelCity.TabIndex = 10;
            this.labelCity.Text = "Місто";
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelHotel.Location = new System.Drawing.Point(250, 110);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(58, 16);
            this.labelHotel.TabIndex = 12;
            this.labelHotel.Text = "Готель";
            // 
            // labelHotelRating
            // 
            this.labelHotelRating.AutoSize = true;
            this.labelHotelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHotelRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelHotelRating.Location = new System.Drawing.Point(250, 160);
            this.labelHotelRating.Name = "labelHotelRating";
            this.labelHotelRating.Size = new System.Drawing.Size(125, 16);
            this.labelHotelRating.TabIndex = 14;
            this.labelHotelRating.Text = "Рейтинг готелю";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelStartDate.Location = new System.Drawing.Point(250, 210);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(108, 16);
            this.labelStartDate.TabIndex = 16;
            this.labelStartDate.Text = "Дата початку";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelEndDate.Location = new System.Drawing.Point(250, 260);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(137, 16);
            this.labelEndDate.TabIndex = 18;
            this.labelEndDate.Text = "Дата завершення";
            // 
            // labelTransport
            // 
            this.labelTransport.AutoSize = true;
            this.labelTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTransport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelTransport.Location = new System.Drawing.Point(30, 250);
            this.labelTransport.Name = "labelTransport";
            this.labelTransport.Size = new System.Drawing.Size(87, 16);
            this.labelTransport.TabIndex = 20;
            this.labelTransport.Text = "Транспорт";
            // 
            // labelMeal
            // 
            this.labelMeal.AutoSize = true;
            this.labelMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMeal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelMeal.Location = new System.Drawing.Point(30, 300);
            this.labelMeal.Name = "labelMeal";
            this.labelMeal.Size = new System.Drawing.Size(96, 16);
            this.labelMeal.TabIndex = 22;
            this.labelMeal.Text = "Харчування";
            // 
            // labelAccommodation
            // 
            this.labelAccommodation.AutoSize = true;
            this.labelAccommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccommodation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelAccommodation.Location = new System.Drawing.Point(30, 350);
            this.labelAccommodation.Name = "labelAccommodation";
            this.labelAccommodation.Size = new System.Drawing.Size(94, 16);
            this.labelAccommodation.TabIndex = 24;
            this.labelAccommodation.Text = "Розміщення";
            // 
            // labelAttractionName
            // 
            this.labelAttractionName.AutoSize = true;
            this.labelAttractionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttractionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelAttractionName.Location = new System.Drawing.Point(250, 350);
            this.labelAttractionName.Name = "labelAttractionName";
            this.labelAttractionName.Size = new System.Drawing.Size(124, 16);
            this.labelAttractionName.TabIndex = 28;
            this.labelAttractionName.Text = "Назва пам`ятки";
            // 
            // txtAttractionName
            // 
            this.txtAttractionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAttractionName.Location = new System.Drawing.Point(250, 370);
            this.txtAttractionName.Name = "txtAttractionName";
            this.txtAttractionName.Size = new System.Drawing.Size(200, 22);
            this.txtAttractionName.TabIndex = 29;
            // 
            // labelAttractionType
            // 
            this.labelAttractionType.AutoSize = true;
            this.labelAttractionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttractionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelAttractionType.Location = new System.Drawing.Point(251, 303);
            this.labelAttractionType.Name = "labelAttractionType";
            this.labelAttractionType.Size = new System.Drawing.Size(105, 16);
            this.labelAttractionType.TabIndex = 30;
            this.labelAttractionType.Text = "Тип пам`ятки";
            // 
            // txtAttractionType
            // 
            this.txtAttractionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAttractionType.Location = new System.Drawing.Point(250, 320);
            this.txtAttractionType.Name = "txtAttractionType";
            this.txtAttractionType.Size = new System.Drawing.Size(200, 22);
            this.txtAttractionType.TabIndex = 31;
            // 
            // AddTourForm
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.txtAccommodation);
            this.Controls.Add(this.labelAccommodation);
            this.Controls.Add(this.txtMeal);
            this.Controls.Add(this.labelMeal);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.labelTransport);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.cmbHotelRating);
            this.Controls.Add(this.labelHotelRating);
            this.Controls.Add(this.txtHotel);
            this.Controls.Add(this.labelHotel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAttractionName);
            this.Controls.Add(this.txtAttractionName);
            this.Controls.Add(this.labelAttractionType);
            this.Controls.Add(this.txtAttractionType);
            this.Name = "AddTourForm";
            this.Text = "Додати тур";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtHotel;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ComboBox cmbHotelRating;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.TextBox txtMeal;
        private System.Windows.Forms.TextBox txtAccommodation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddCountry;

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.Label labelHotelRating;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelTransport;
        private System.Windows.Forms.Label labelMeal;
        private System.Windows.Forms.Label labelAccommodation;

        private System.Windows.Forms.Label labelAttractionName;
        private System.Windows.Forms.TextBox txtAttractionName;
        private System.Windows.Forms.Label labelAttractionType;
        private System.Windows.Forms.TextBox txtAttractionType;
    }
}
