using System.Windows.Forms;
namespace TourApp
{
    partial class StartForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnClient;
        private Button btnEmployee;
        private Button btnAdmin;
        private Button btnExit;
        private Button btnLogin;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.btnClient = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClient.ForeColor = System.Drawing.Color.Orange;
            this.btnClient.Location = new System.Drawing.Point(424, 90);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(200, 48);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Клієнт";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Orange;
            this.btnEmployee.Location = new System.Drawing.Point(218, 90);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(200, 48);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Менеджер";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Orange;
            this.btnAdmin.Location = new System.Drawing.Point(12, 90);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(200, 48);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Адміністратор";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.Orange;
            this.btnExit.Location = new System.Drawing.Point(631, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.Orange;
            this.btnLogin.Location = new System.Drawing.Point(218, 335);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 48);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Логін";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(648, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 179);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.Color.Orange;
            label1.Location = new System.Drawing.Point(211, 250);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(219, 59);
            label1.TabIndex = 6;
            label1.Text = "Sign In";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Orange;
            label2.Location = new System.Drawing.Point(211, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(232, 59);
            label2.TabIndex = 7;
            label2.Text = "Sign Up";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(642, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tour Agency";
            // 
            // StartForm
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(856, 446);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnClient);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "StartForm";
            this.Text = "Стартова сторінка";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox pictureBox1;
        private Label label3;
    }
}
