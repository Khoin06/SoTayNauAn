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
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDishName
            // 
            this.txtDishName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDishName.ForeColor = System.Drawing.Color.Transparent;
            this.txtDishName.Location = new System.Drawing.Point(87, 59);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(200, 22);
            this.txtDishName.TabIndex = 0;
            this.txtDishName.Text = "Tên món ăn";
            this.txtDishName.TextChanged += new System.EventHandler(this.txtDishName_TextChanged);
            // 
            // txtFormulaName
            // 
            this.txtFormulaName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFormulaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormulaName.ForeColor = System.Drawing.Color.Transparent;
            this.txtFormulaName.Location = new System.Drawing.Point(87, 89);
            this.txtFormulaName.Name = "txtFormulaName";
            this.txtFormulaName.Size = new System.Drawing.Size(200, 22);
            this.txtFormulaName.TabIndex = 1;
            this.txtFormulaName.Text = "Tên công thức";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Transparent;
            this.txtTime.Location = new System.Drawing.Point(87, 119);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(200, 22);
            this.txtTime.TabIndex = 2;
            this.txtTime.Text = "                         ";
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.ForeColor = System.Drawing.Color.Transparent;
            this.txtRate.Location = new System.Drawing.Point(87, 149);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(200, 22);
            this.txtRate.TabIndex = 3;
            this.txtRate.Text = "Đánh giá";
            // 
            // txtSteps
            // 
            this.txtSteps.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteps.ForeColor = System.Drawing.Color.White;
            this.txtSteps.Location = new System.Drawing.Point(317, 59);
            this.txtSteps.Multiline = true;
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(300, 110);
            this.txtSteps.TabIndex = 4;
            this.txtSteps.Text = "Các bước thực hiện";
            // 
            // cbIngredient
            // 
            this.cbIngredient.BackColor = System.Drawing.Color.Gainsboro;
            this.cbIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIngredient.ForeColor = System.Drawing.Color.Transparent;
            this.cbIngredient.FormattingEnabled = true;
            this.cbIngredient.Location = new System.Drawing.Point(87, 179);
            this.cbIngredient.Name = "cbIngredient";
            this.cbIngredient.Size = new System.Drawing.Size(140, 24);
            this.cbIngredient.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Gainsboro;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Transparent;
            this.txtQuantity.Location = new System.Drawing.Point(237, 179);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 6;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddIngredient.ForeColor = System.Drawing.Color.White;
            this.btnAddIngredient.Location = new System.Drawing.Point(347, 179);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(75, 23);
            this.btnAddIngredient.TabIndex = 7;
            this.btnAddIngredient.Text = "Thêm";
            this.btnAddIngredient.UseVisualStyleBackColor = false;
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngredientColumn,
            this.QuantityColumn});
            this.dgvIngredients.Location = new System.Drawing.Point(87, 219);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.Size = new System.Drawing.Size(400, 150);
            this.dgvIngredients.TabIndex = 8;
            // 
            // IngredientColumn
            // 
            this.IngredientColumn.HeaderText = "Nguyên liệu";
            this.IngredientColumn.Name = "IngredientColumn";
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Số lượng";
            this.QuantityColumn.Name = "QuantityColumn";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(87, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu công thức";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Recipe";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.titleLabel.Location = new System.Drawing.Point(182, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(280, 34);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Cooking handbook";
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(20, 445);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 30);
            this.homeButton.TabIndex = 12;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // addcook
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(760, 487);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label1);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "addcook";
            this.Text = "Cooking Handbook";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
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
        private Label label1;
        private Label titleLabel;
        private Button homeButton;
    }

    #endregion
}