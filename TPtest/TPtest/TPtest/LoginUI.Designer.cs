namespace TPtest
{
    partial class LoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.username_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.ExitTP = new System.Windows.Forms.Button();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.User_Type = new System.Windows.Forms.Label();
            this.Enter_Password = new System.Windows.Forms.Label();
            this.clock_timer = new System.Windows.Forms.Timer(this.components);
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(24, 75);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(100, 20);
            this.username_text.TabIndex = 0;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(24, 114);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(100, 20);
            this.password_text.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(130, 114);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // ExitTP
            // 
            this.ExitTP.Location = new System.Drawing.Point(25, 260);
            this.ExitTP.Name = "ExitTP";
            this.ExitTP.Size = new System.Drawing.Size(75, 23);
            this.ExitTP.TabIndex = 3;
            this.ExitTP.Text = "Exit";
            this.ExitTP.UseVisualStyleBackColor = true;
            this.ExitTP.Click += new System.EventHandler(this.ExitTP_Click);
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.BackColor = System.Drawing.Color.SeaGreen;
            this.LoginTitle.Font = new System.Drawing.Font("Coolsville", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.Image = ((System.Drawing.Image)(resources.GetObject("LoginTitle.Image")));
            this.LoginTitle.Location = new System.Drawing.Point(18, 9);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(237, 42);
            this.LoginTitle.TabIndex = 4;
            this.LoginTitle.Text = "Teacher\'s Pet";
            // 
            // User_Type
            // 
            this.User_Type.AutoSize = true;
            this.User_Type.BackColor = System.Drawing.Color.SeaGreen;
            this.User_Type.Location = new System.Drawing.Point(22, 59);
            this.User_Type.Name = "User_Type";
            this.User_Type.Size = new System.Drawing.Size(32, 13);
            this.User_Type.TabIndex = 5;
            this.User_Type.Text = "User:";
            // 
            // Enter_Password
            // 
            this.Enter_Password.AutoSize = true;
            this.Enter_Password.BackColor = System.Drawing.Color.SeaGreen;
            this.Enter_Password.Location = new System.Drawing.Point(22, 98);
            this.Enter_Password.Name = "Enter_Password";
            this.Enter_Password.Size = new System.Drawing.Size(56, 13);
            this.Enter_Password.TabIndex = 6;
            this.Enter_Password.Text = "Password:";
            // 
            // clock_timer
            // 
            this.clock_timer.Enabled = true;
            this.clock_timer.Interval = 1000;
            this.clock_timer.Tick += new System.EventHandler(this.clock_timer_Tick);
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DateTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateTimeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLabel.Image = ((System.Drawing.Image)(resources.GetObject("DateTimeLabel.Image")));
            this.DateTimeLabel.Location = new System.Drawing.Point(272, 19);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(2, 24);
            this.DateTimeLabel.TabIndex = 7;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(384, 312);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.Enter_Password);
            this.Controls.Add(this.User_Type);
            this.Controls.Add(this.LoginTitle);
            this.Controls.Add(this.ExitTP);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher\'s Pet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button ExitTP;
        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.Label User_Type;
        private System.Windows.Forms.Label Enter_Password;
        private System.Windows.Forms.Timer clock_timer;
        private System.Windows.Forms.Label DateTimeLabel;

    }
}

