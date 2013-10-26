namespace TPtest
{
    partial class AdminUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUI));
            this.ExitAdin = new System.Windows.Forms.Button();
            this.Admin_Title = new System.Windows.Forms.Label();
            this.Classroom = new System.Windows.Forms.Button();
            this.Students = new System.Windows.Forms.Button();
            this.Create_Chart = new System.Windows.Forms.Button();
            this.Attendance = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Random_HiLite = new System.Windows.Forms.Button();
            this.Generate_Reports = new System.Windows.Forms.Button();
            this.clock_timer = new System.Windows.Forms.Timer(this.components);
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitAdin
            // 
            this.ExitAdin.Location = new System.Drawing.Point(25, 260);
            this.ExitAdin.Name = "ExitAdin";
            this.ExitAdin.Size = new System.Drawing.Size(75, 23);
            this.ExitAdin.TabIndex = 0;
            this.ExitAdin.Text = "Exit";
            this.ExitAdin.UseVisualStyleBackColor = true;
            this.ExitAdin.Click += new System.EventHandler(this.ExitAdin_Click);
            // 
            // Admin_Title
            // 
            this.Admin_Title.AutoSize = true;
            this.Admin_Title.BackColor = System.Drawing.Color.SeaGreen;
            this.Admin_Title.Font = new System.Drawing.Font("Coolsville", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Title.Image = ((System.Drawing.Image)(resources.GetObject("Admin_Title.Image")));
            this.Admin_Title.Location = new System.Drawing.Point(12, 9);
            this.Admin_Title.Name = "Admin_Title";
            this.Admin_Title.Size = new System.Drawing.Size(278, 42);
            this.Admin_Title.TabIndex = 1;
            this.Admin_Title.Text = "Administration";
            // 
            // Classroom
            // 
            this.Classroom.Location = new System.Drawing.Point(6, 12);
            this.Classroom.Name = "Classroom";
            this.Classroom.Size = new System.Drawing.Size(75, 40);
            this.Classroom.TabIndex = 0;
            this.Classroom.Text = "Design Classroom";
            this.Classroom.UseVisualStyleBackColor = true;
            // 
            // Students
            // 
            this.Students.Location = new System.Drawing.Point(87, 12);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(75, 40);
            this.Students.TabIndex = 1;
            this.Students.Text = "Student Info";
            this.Students.UseVisualStyleBackColor = true;
            // 
            // Create_Chart
            // 
            this.Create_Chart.Location = new System.Drawing.Point(7, 58);
            this.Create_Chart.Name = "Create_Chart";
            this.Create_Chart.Size = new System.Drawing.Size(75, 40);
            this.Create_Chart.TabIndex = 2;
            this.Create_Chart.Text = "Fill Class Seats";
            this.Create_Chart.UseVisualStyleBackColor = true;
            // 
            // Attendance
            // 
            this.Attendance.Location = new System.Drawing.Point(88, 58);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(76, 40);
            this.Attendance.TabIndex = 3;
            this.Attendance.Text = "Take Roll";
            this.Attendance.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.Random_HiLite);
            this.groupBox1.Controls.Add(this.Generate_Reports);
            this.groupBox1.Controls.Add(this.Attendance);
            this.groupBox1.Controls.Add(this.Create_Chart);
            this.groupBox1.Controls.Add(this.Students);
            this.groupBox1.Controls.Add(this.Classroom);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Random_HiLite
            // 
            this.Random_HiLite.Location = new System.Drawing.Point(89, 104);
            this.Random_HiLite.Name = "Random_HiLite";
            this.Random_HiLite.Size = new System.Drawing.Size(75, 40);
            this.Random_HiLite.TabIndex = 5;
            this.Random_HiLite.Text = "HiLite ";
            this.Random_HiLite.UseVisualStyleBackColor = true;
            // 
            // Generate_Reports
            // 
            this.Generate_Reports.Location = new System.Drawing.Point(8, 104);
            this.Generate_Reports.Name = "Generate_Reports";
            this.Generate_Reports.Size = new System.Drawing.Size(75, 40);
            this.Generate_Reports.TabIndex = 4;
            this.Generate_Reports.Text = "Reports";
            this.Generate_Reports.UseVisualStyleBackColor = true;
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
            this.DateTimeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLabel.Image = ((System.Drawing.Image)(resources.GetObject("DateTimeLabel.Image")));
            this.DateTimeLabel.Location = new System.Drawing.Point(300, 21);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(0, 22);
            this.DateTimeLabel.TabIndex = 3;
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(384, 312);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Admin_Title);
            this.Controls.Add(this.ExitAdin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher\'s Pet - Administration";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitAdin;
        private System.Windows.Forms.Label Admin_Title;
        private System.Windows.Forms.Button Classroom;
        private System.Windows.Forms.Button Students;
        private System.Windows.Forms.Button Create_Chart;
        private System.Windows.Forms.Button Attendance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Random_HiLite;
        private System.Windows.Forms.Button Generate_Reports;
        private System.Windows.Forms.Timer clock_timer;
        private System.Windows.Forms.Label DateTimeLabel;
    }
}