using System;
using System.Windows.Forms;

namespace SoTayNauAn
{
    partial class recipe : Form
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.recipeGridView = new System.Windows.Forms.DataGridView();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormulaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.titleLabel.Location = new System.Drawing.Point(239, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(280, 34);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Cooking handbook";
            // 
            // recipeGridView
            // 
            this.recipeGridView.AllowUserToAddRows = false;
            this.recipeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DishName,
            this.FormulaName,
            this.Image});
            this.recipeGridView.Location = new System.Drawing.Point(50, 80);
            this.recipeGridView.Name = "recipeGridView";
            this.recipeGridView.RowHeadersVisible = false;
            this.recipeGridView.Size = new System.Drawing.Size(605, 300);
            this.recipeGridView.TabIndex = 1;
            // 
            // DishName
            // 
            this.DishName.HeaderText = "Dish name";
            this.DishName.Name = "DishName";
            this.DishName.Width = 200;
            // 
            // FormulaName
            // 
            this.FormulaName.HeaderText = "Formular name";
            this.FormulaName.Name = "FormulaName";
            this.FormulaName.Width = 200;
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            this.Image.Width = 200;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Location = new System.Drawing.Point(672, 146);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 30);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Location = new System.Drawing.Point(672, 205);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(100, 30);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(672, 264);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 30);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.Gainsboro;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(50, 400);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(200, 29);
            this.searchBox.TabIndex = 5;
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.findButton.ForeColor = System.Drawing.Color.White;
            this.findButton.Location = new System.Drawing.Point(270, 400);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(100, 30);
            this.findButton.TabIndex = 6;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recipe";
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(20, 508);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 30);
            this.homeButton.TabIndex = 19;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // recipe
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.recipeGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.findButton);
            this.Name = "recipe";
            this.Text = "Cooking Handbook";
            ((System.ComponentModel.ISupportInitialize)(this.recipeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private DataGridView recipeGridView;
        private DataGridViewTextBoxColumn DishName;
        private DataGridViewTextBoxColumn FormulaName;
        private DataGridViewImageColumn Image;
        private Button deleteButton;
        private Button newButton;
        private Button editButton;
        private TextBox searchBox;
        private Button findButton;

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Logic for deleting a recipe
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            addcook f = new addcook();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Logic for editing a selected recipe
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            // Logic for searching a recipe
        }

        private Label label1;
        private Button homeButton;
    }
}
