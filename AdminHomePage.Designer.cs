namespace SAD_Assignment
{
    partial class AdminHomePage
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
            this.NewScheduleBtn = new System.Windows.Forms.Button();
            this.AllSchedulesBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewScheduleBtn
            // 
            this.NewScheduleBtn.BackColor = System.Drawing.Color.Teal;
            this.NewScheduleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewScheduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewScheduleBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewScheduleBtn.ForeColor = System.Drawing.Color.White;
            this.NewScheduleBtn.Location = new System.Drawing.Point(65, 142);
            this.NewScheduleBtn.Name = "NewScheduleBtn";
            this.NewScheduleBtn.Size = new System.Drawing.Size(88, 78);
            this.NewScheduleBtn.TabIndex = 1;
            this.NewScheduleBtn.Text = "New Schedule";
            this.NewScheduleBtn.UseVisualStyleBackColor = false;
            this.NewScheduleBtn.Click += new System.EventHandler(this.NewScheduleBtn_Click);
            // 
            // AllSchedulesBtn
            // 
            this.AllSchedulesBtn.BackColor = System.Drawing.Color.Teal;
            this.AllSchedulesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllSchedulesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AllSchedulesBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllSchedulesBtn.ForeColor = System.Drawing.Color.White;
            this.AllSchedulesBtn.Location = new System.Drawing.Point(196, 142);
            this.AllSchedulesBtn.Name = "AllSchedulesBtn";
            this.AllSchedulesBtn.Size = new System.Drawing.Size(88, 78);
            this.AllSchedulesBtn.TabIndex = 2;
            this.AllSchedulesBtn.Text = "All Schedules";
            this.AllSchedulesBtn.UseVisualStyleBackColor = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Firebrick;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(328, 142);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(88, 78);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Crimson;
            this.TimeLabel.Location = new System.Drawing.Point(356, 331);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(116, 21);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.Crimson;
            this.DateLabel.Location = new System.Drawing.Point(12, 331);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(104, 21);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(92, 66);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(176, 39);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "Welcome";
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AllSchedulesBtn);
            this.Controls.Add(this.NewScheduleBtn);
            this.Name = "AdminHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewScheduleBtn;
        private System.Windows.Forms.Button AllSchedulesBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label welcomeLabel;
    }
}