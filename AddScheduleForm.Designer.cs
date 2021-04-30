namespace SAD_Assignment
{
    partial class AddScheduleForm
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
            this.RouteLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RouteTextBox = new System.Windows.Forms.TextBox();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.BackButton = new System.Windows.Forms.Button();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RouteLabel
            // 
            this.RouteLabel.BackColor = System.Drawing.Color.Chocolate;
            this.RouteLabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteLabel.ForeColor = System.Drawing.Color.White;
            this.RouteLabel.Location = new System.Drawing.Point(37, 51);
            this.RouteLabel.Name = "RouteLabel";
            this.RouteLabel.Size = new System.Drawing.Size(141, 31);
            this.RouteLabel.TabIndex = 0;
            this.RouteLabel.Text = "Route";
            this.RouteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Chocolate;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Chocolate;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Time";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RouteTextBox
            // 
            this.RouteTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteTextBox.Location = new System.Drawing.Point(184, 51);
            this.RouteTextBox.MaxLength = 3;
            this.RouteTextBox.Multiline = true;
            this.RouteTextBox.Name = "RouteTextBox";
            this.RouteTextBox.Size = new System.Drawing.Size(141, 31);
            this.RouteTextBox.TabIndex = 1;
            // 
            // FromTextBox
            // 
            this.FromTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromTextBox.Location = new System.Drawing.Point(184, 98);
            this.FromTextBox.MaxLength = 1000;
            this.FromTextBox.Multiline = true;
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(141, 31);
            this.FromTextBox.TabIndex = 2;
            // 
            // ToTextBox
            // 
            this.ToTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTextBox.Location = new System.Drawing.Point(184, 144);
            this.ToTextBox.MaxLength = 1000;
            this.ToTextBox.Multiline = true;
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(141, 31);
            this.ToTextBox.TabIndex = 3;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Green;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(184, 296);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(141, 27);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Red;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(37, 296);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(141, 27);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 51);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(455, 218);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Location = new System.Drawing.Point(501, 296);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(141, 27);
            this.RefreshBtn.TabIndex = 9;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.AllowDrop = true;
            this.TimePicker.CustomFormat = "HH:mm";
            this.TimePicker.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(184, 191);
            this.TimePicker.MinimumSize = new System.Drawing.Size(120, 31);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(141, 31);
            this.TimePicker.TabIndex = 10;
            this.TimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimePicker_MouseDown);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Red;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(665, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(141, 27);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownHeight = 141;
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TypeComboBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.IntegralHeight = false;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Luxary",
            "Semi Luxary",
            "Intercity"});
            this.TypeComboBox.Location = new System.Drawing.Point(184, 238);
            this.TypeComboBox.MaximumSize = new System.Drawing.Size(141, 0);
            this.TypeComboBox.MinimumSize = new System.Drawing.Size(141, 0);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(141, 25);
            this.TypeComboBox.TabIndex = 12;
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 361);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.RouteTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RouteLabel);
            this.MaximizeBox = false;
            this.Name = "AddScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RouteLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RouteTextBox;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox TypeComboBox;
    }
}