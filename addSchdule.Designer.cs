using System.Windows.Forms;

namespace SoTayNauAn
{
    partial class addSchdule
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
            this.SuspendLayout();

            // Title Label
            Label titleLabel = new Label
            {
                Text = "Cooking Handbook",
                Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Brown,
                AutoSize = true,
                Location = new System.Drawing.Point(250, 10)
            };
            this.Controls.Add(titleLabel);

            // Subtitle Label
            Label subtitleLabel = new Label
            {
                Text = "Add a new Schedule",
                Font = new System.Drawing.Font("Arial", 14),
                ForeColor = System.Drawing.Color.Black,
                AutoSize = true,
                Location = new System.Drawing.Point(300, 60)
            };
            this.Controls.Add(subtitleLabel);

            // Name Label
            Label nameLabel = new Label
            {
                Text = "Name",
                Font = new System.Drawing.Font("Arial", 12),
                Location = new System.Drawing.Point(100, 100),
                AutoSize = true
            };
            this.Controls.Add(nameLabel);

            // Name TextBox
            TextBox nameTextBox = new TextBox
            {
                Location = new System.Drawing.Point(160, 100),
                Size = new System.Drawing.Size(300, 30),
            };
            this.Controls.Add(nameTextBox);

            // New Button
            Button newButton = new Button
            {
                Text = "New",
                Font = new System.Drawing.Font("Arial", 12),
                BackColor = System.Drawing.Color.LightCoral,
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(480, 100),
                Size = new System.Drawing.Size(80, 40)
            };
            this.Controls.Add(newButton);

            // Delete Button
            Button deleteButton = new Button
            {
                Text = "Delete",
                Font = new System.Drawing.Font("Arial", 12),
                BackColor = System.Drawing.Color.LightCoral,
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(480, 160),
                Size = new System.Drawing.Size(80, 40)
            };
            this.Controls.Add(deleteButton);

            // Save Button
            Button saveButton = new Button
            {
                Text = "Save",
                Font = new System.Drawing.Font("Arial", 12),
                BackColor = System.Drawing.Color.LightCoral,
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(480, 220),
                Size = new System.Drawing.Size(80, 40)
            };
            this.Controls.Add(saveButton);

            // DataGridView for Schedule
            DataGridView scheduleGrid = new DataGridView
            {
                ColumnCount = 7,
                RowCount = 3,
                Location = new System.Drawing.Point(100, 150),
                Size = new System.Drawing.Size(360, 120),
                AllowUserToAddRows = false,
                AllowUserToResizeRows = false
            };

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < days.Length; i++)
            {
                scheduleGrid.Columns[i].HeaderText = days[i];
                scheduleGrid.Columns[i].Width = 50;
            }
            this.Controls.Add(scheduleGrid);

            // Meal Type Radio Buttons
            RadioButton breakfastRadio = new RadioButton
            {
                Text = "Breakfast",
                Location = new System.Drawing.Point(100, 300),
                AutoSize = true
            };
            this.Controls.Add(breakfastRadio);

            RadioButton lunchRadio = new RadioButton
            {
                Text = "Lunch",
                Location = new System.Drawing.Point(200, 300),
                AutoSize = true
            };
            this.Controls.Add(lunchRadio);

            RadioButton dinnerRadio = new RadioButton
            {
                Text = "Dinner",
                Location = new System.Drawing.Point(300, 300),
                AutoSize = true
            };
            this.Controls.Add(dinnerRadio);

            // Day ComboBox
            ComboBox dayComboBox = new ComboBox
            {
                Location = new System.Drawing.Point(400, 300),
                Size = new System.Drawing.Size(100, 30),
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            dayComboBox.Items.AddRange(days);
            this.Controls.Add(dayComboBox);

            // Meal ListBox
            ListBox mealListBox = new ListBox
            {
                Location = new System.Drawing.Point(100, 350),
                Size = new System.Drawing.Size(200, 100),
            };
            mealListBox.Items.AddRange(new string[] { "Cá Kho", "Nem Rán" });
            this.Controls.Add(mealListBox);

            // Add Button
            Button addButton = new Button
            {
                Text = "Add",
                Font = new System.Drawing.Font("Arial", 12),
                BackColor = System.Drawing.Color.LightCoral,
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(320, 400),
                Size = new System.Drawing.Size(80, 40)
            };
            this.Controls.Add(addButton);

            // Home Button
            Button homeButton = new Button
            {
                Text = "Home",
                Font = new System.Drawing.Font("Arial", 12),
                BackColor = System.Drawing.Color.Gray,
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(20, 500),
                Size = new System.Drawing.Size(80, 40)
            };
            this.Controls.Add(homeButton);

            // Component Settings
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
        }

        #endregion
    }
}