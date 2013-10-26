namespace TPtest
{
    partial class GuestUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestUI));
            this.ExitGuestUI = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.Take_Roll = new System.Windows.Forms.Button();
            this.Hi_Lite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clock_timer = new System.Windows.Forms.Timer(this.components);
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitGuestUI
            // 
            this.ExitGuestUI.Location = new System.Drawing.Point(25, 260);
            this.ExitGuestUI.Name = "ExitGuestUI";
            this.ExitGuestUI.Size = new System.Drawing.Size(75, 23);
            this.ExitGuestUI.TabIndex = 0;
            this.ExitGuestUI.Text = "Exit";
            this.ExitGuestUI.UseVisualStyleBackColor = true;
            this.ExitGuestUI.Click += new System.EventHandler(this.ExitGuestUI_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Coolsville", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Image = ((System.Drawing.Image)(resources.GetObject("title_label.Image")));
            this.title_label.Location = new System.Drawing.Point(12, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(114, 42);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Guest";
            // 
            // Take_Roll
            // 
            this.Take_Roll.Location = new System.Drawing.Point(6, 14);
            this.Take_Roll.Name = "Take_Roll";
            this.Take_Roll.Size = new System.Drawing.Size(75, 40);
            this.Take_Roll.TabIndex = 2;
            this.Take_Roll.Text = "Take Roll";
            this.Take_Roll.UseVisualStyleBackColor = true;
            // 
            // Hi_Lite
            // 
            this.Hi_Lite.Location = new System.Drawing.Point(89, 14);
            this.Hi_Lite.Name = "Hi_Lite";
            this.Hi_Lite.Size = new System.Drawing.Size(75, 40);
            this.Hi_Lite.TabIndex = 3;
            this.Hi_Lite.Text = "HiLite";
            this.Hi_Lite.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.Hi_Lite);
            this.groupBox1.Controls.Add(this.Take_Roll);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
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
            this.DateTimeLabel.Location = new System.Drawing.Point(272, 19);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(0, 22);
            this.DateTimeLabel.TabIndex = 5;
            // 
            // GuestUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(384, 312);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.ExitGuestUI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GuestUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teacher\'s Pet - Guest";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitGuestUI;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button Take_Roll;
        private System.Windows.Forms.Button Hi_Lite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer clock_timer;
        private System.Windows.Forms.Label DateTimeLabel;
    }
}