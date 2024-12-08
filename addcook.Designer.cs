using System.Windows.Forms;
using System;

namespace SoTayNauAn
{
    partial class addcook
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
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.txtFormulaName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.cbIngredient = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.IngredientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Tên món ăn
            this.txtDishName.Location = new System.Drawing.Point(20, 20);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(200, 20);
            this.txtDishName.TabIndex = 0;
            this.txtDishName.Text = "Tên món ăn";

            // Công thức
            this.txtFormulaName.Location = new System.Drawing.Point(20, 50);
            this.txtFormulaName.Name = "txtFormulaName";
            this.txtFormulaName.Size = new System.Drawing.Size(200, 20);
            this.txtFormulaName.TabIndex = 1;
            this.txtFormulaName.Text = "Tên công thức";

            // Thời gian
            this.txtTime.Location = new System.Drawing.Point(20, 80);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(200, 20);
            this.txtTime.TabIndex = 2;
             this.txtTime.Text = "Thời gian";

            // Đánh giá
            this.txtRate.Location = new System.Drawing.Point(20, 110);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(200, 20);
            this.txtRate.TabIndex = 3;
            this.txtRate.Text = "Đánh giá";

            // Các bước thực hiện
            this.txtSteps.Location = new System.Drawing.Point(250, 20);
            this.txtSteps.Multiline = true;
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(300, 110);
            this.txtSteps.TabIndex = 4;
           this.txtSteps.Text = "Các bước thực hiện";

            // ComboBox Nguyên liệu
            this.cbIngredient.FormattingEnabled = true;
            this.cbIngredient.Location = new System.Drawing.Point(20, 140);
            this.cbIngredient.Name = "cbIngredient";
            this.cbIngredient.Size = new System.Drawing.Size(140, 21);
            this.cbIngredient.TabIndex = 5;

            // Số lượng
            this.txtQuantity.Location = new System.Drawing.Point(170, 140);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 6;

            // Thêm nguyên liệu
            this.btnAddIngredient.Location = new System.Drawing.Point(280, 140);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(75, 23);
            this.btnAddIngredient.TabIndex = 7;
            this.btnAddIngredient.Text = "Thêm";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
          //  this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);

            // DataGridView Nguyên liệu
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngredientColumn,
            this.QuantityColumn});
            this.dgvIngredients.Location = new System.Drawing.Point(20, 180);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.Size = new System.Drawing.Size(400, 150);
            this.dgvIngredients.TabIndex = 8;

            // Cột Nguyên liệu
            this.IngredientColumn.HeaderText = "Nguyên liệu";
            this.IngredientColumn.Name = "IngredientColumn";

            // Cột Số lượng
            this.QuantityColumn.HeaderText = "Số lượng";
            this.QuantityColumn.Name = "QuantityColumn";

            // Lưu công thức
            this.btnSave.Location = new System.Drawing.Point(20, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu công thức";
            this.btnSave.UseVisualStyleBackColor = true;
           // this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.txtDishName);
            this.Controls.Add(this.txtFormulaName);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtSteps);
            this.Controls.Add(this.cbIngredient);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.dgvIngredients);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Cooking Handbook";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.TextBox txtFormulaName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.ComboBox cbIngredient;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.Button btnSave;
    }

    #endregion
}