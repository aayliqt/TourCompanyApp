using System.Windows.Forms;
using System.Drawing;
using System;

namespace TourApp
{
    partial class RegistrationForm
    {
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblPassport;
        private TextBox txtPassport;
        private Button btnRegister;
        private Button btnCancel;
        private Label label2;

        private void InitializeComponent()
        {
            this.lblFirstName = new Label();
            this.txtFirstName = new TextBox();
            this.lblLastName = new Label();
            this.txtLastName = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.lblPassport = new Label();
            this.txtPassport = new TextBox();
            this.btnRegister = new Button();
            this.btnCancel = new Button();
            this.label2 = new Label();

            // label2
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Orange;
            label2.Location = new System.Drawing.Point(60, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(232, 59);
            label2.TabIndex = 7;
            label2.Text = "Sign Up";

            // lblFirstName
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.Text = "Ім'я:";
            this.lblFirstName.Location = new Point(20, 100);
            this.lblFirstName.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));

            // txtFirstName
            this.txtFirstName.Location = new Point(120, 100);
            this.txtFirstName.Size = new Size(200, 22);
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstName.ForeColor = Color.FromArgb(0, 0, 64);

            // lblLastName
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.Text = "Прізвище:";
            this.lblLastName.Location = new Point(20, 140);
            this.lblLastName.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));

            // txtLastName
            this.txtLastName.Location = new Point(120, 140);
            this.txtLastName.Size = new Size(200, 22);
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.ForeColor = Color.FromArgb(0, 0, 64);

            // lblPhone
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Text = "Телефон:";
            this.lblPhone.Location = new Point(20, 180);
            this.lblPhone.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));

            // txtPhone
            this.txtPhone.Location = new Point(120, 180);
            this.txtPhone.Size = new Size(200, 22);
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.ForeColor = Color.FromArgb(0, 0, 64);

            // lblEmail
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new Point(20, 220);
            this.lblEmail.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));

            // txtEmail
            this.txtEmail.Location = new Point(120, 220);
            this.txtEmail.Size = new Size(200, 22);
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.ForeColor = Color.FromArgb(0, 0, 64);

            // lblPassword
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Text = "Пароль:";
            this.lblPassword.Location = new Point(20, 260);
            this.lblPassword.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));

            // txtPassword
            this.txtPassword.Location = new Point(120, 260);
            this.txtPassword.Size = new Size(200, 22);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.ForeColor = Color.FromArgb(0, 0, 64);

            // lblPassport
            this.lblPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassport.Text = "Паспорт:";
            this.lblPassport.Location = new Point(20, 300);
            this.lblPassport.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPassport.Visible = this.userType == "Client";

            // txtPassport
            this.txtPassport.Location = new Point(120, 300);
            this.txtPassport.Size = new Size(200, 22);
            this.txtPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassport.ForeColor = Color.FromArgb(0, 0, 64);
            this.txtPassport.Visible = this.userType == "Client";

            // btnRegister
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegister.Text = "Зареєструвати";
            this.btnRegister.Size = new Size(140, 50);
            this.btnRegister.Location = new Point(20, 340);
            this.btnRegister.BackColor = Color.FromArgb(0, 0, 64);
            this.btnRegister.FlatStyle = FlatStyle.Popup;
            this.btnRegister.ForeColor = Color.Orange;
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);

            // btnCancel
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.Size = new Size(140, 50);
            this.btnCancel.Location = new Point(180, 340);
            this.btnCancel.BackColor = Color.FromArgb(0, 0, 64);
            this.btnCancel.FlatStyle = FlatStyle.Popup;
            this.btnCancel.ForeColor = Color.Orange;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // RegistrationForm
            this.ClientSize = new Size(350, 420);
            this.BackColor = Color.LightBlue;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.lblPassport);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
        }
    }
}