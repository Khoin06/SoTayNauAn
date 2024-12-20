using System.Windows.Forms;
using System;
using System.Drawing;

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
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.txtFormulaName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.lstSuggestions = new System.Windows.Forms.ListBox();
        
            this.SuspendLayout();
            // 
            // txtImage
            // 
            this.txtImage.BackColor = System.Drawing.Color.Gainsboro;
            this.txtImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.ForeColor = System.Drawing.Color.Gray;
            this.txtImage.Location = new System.Drawing.Point(137, 322);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(200, 29);
            this.txtImage.TabIndex = 14;
            this.txtImage.Text = "Hình ảnh";
            this.txtImage.TextChanged += new System.EventHandler(this.txtImage_TextChanged);
            this.txtImage.Enter += new System.EventHandler(this.txtImage_Enter);
            this.txtImage.Leave += new System.EventHandler(this.txtImage_Leave);
            // 
            // txtDishName
            // 
            this.txtDishName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDishName.ForeColor = System.Drawing.Color.Gray;
            this.txtDishName.Location = new System.Drawing.Point(137, 106);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(200, 29);
            this.txtDishName.TabIndex = 0;
            this.txtDishName.Text = "Tên món ăn";
            this.txtDishName.TextChanged += new System.EventHandler(this.txtDishName_TextChanged);
            this.txtDishName.Enter += new System.EventHandler(this.txtDishName_Enter);
            this.txtDishName.Leave += new System.EventHandler(this.txtDishName_Leave);
            // 
            // txtFormulaName
            // 
            this.txtFormulaName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFormulaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormulaName.ForeColor = System.Drawing.Color.Gray;
            this.txtFormulaName.Location = new System.Drawing.Point(137, 159);
            this.txtFormulaName.Name = "txtFormulaName";
            this.txtFormulaName.Size = new System.Drawing.Size(200, 29);
            this.txtFormulaName.TabIndex = 1;
            this.txtFormulaName.Text = "Tên công thức";
            this.txtFormulaName.TextChanged += new System.EventHandler(this.txtFormulaName_TextChanged);
            this.txtFormulaName.Enter += new System.EventHandler(this.txtFormulaName_Enter);
            this.txtFormulaName.Leave += new System.EventHandler(this.txtFormulaName_Leave);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Gray;
            this.txtTime.Location = new System.Drawing.Point(137, 215);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(200, 29);
            this.txtTime.TabIndex = 2;
            this.txtTime.Text = "Thời gian";
            this.txtTime.Enter += new System.EventHandler(this.txtTime_Enter);
            this.txtTime.Leave += new System.EventHandler(this.txtTime_Leave);
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.ForeColor = System.Drawing.Color.Gray;
            this.txtRate.Location = new System.Drawing.Point(137, 273);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(200, 29);
            this.txtRate.TabIndex = 3;
            this.txtRate.Text = "Đánh giá";
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            this.txtRate.Enter += new System.EventHandler(this.txtRate_Enter);
            this.txtRate.Leave += new System.EventHandler(this.txtRate_Leave);
            // 
            // txtSteps
            // 
            this.txtSteps.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteps.ForeColor = System.Drawing.Color.Gray;
            this.txtSteps.Location = new System.Drawing.Point(367, 106);
            this.txtSteps.Multiline = true;
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(300, 229);
            this.txtSteps.TabIndex = 4;
            this.txtSteps.Text = "Các bước thực hiện";
            this.txtSteps.Enter += new System.EventHandler(this.txtSteps_Enter);
            this.txtSteps.Leave += new System.EventHandler(this.txtSteps_Leave);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIngredient.ForeColor = System.Drawing.Color.White;
            this.btnAddIngredient.Location = new System.Drawing.Point(137, 369);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(154, 41);
            this.btnAddIngredient.TabIndex = 7;
            this.btnAddIngredient.Text = "Thêm Nguyên Liệu";
            this.btnAddIngredient.UseVisualStyleBackColor = false;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(367, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 41);
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
            this.titleLabel.Location = new System.Drawing.Point(223, 26);
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
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(112, 445);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 30);
            this.back.TabIndex = 13;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // lstSuggestions
            // 
            this.lstSuggestions.FormattingEnabled = true;
            this.lstSuggestions.ItemHeight = 16;
            this.lstSuggestions.Location = new System.Drawing.Point(137, 134);
            this.lstSuggestions.Name = "lstSuggestions";
            this.lstSuggestions.Size = new System.Drawing.Size(200, 116);
            this.lstSuggestions.TabIndex = 1;
            this.lstSuggestions.Visible = false;
            this.lstSuggestions.Click += new System.EventHandler(this.lstSuggestions_Click);
            // 
            // addcook
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(760, 487);
            this.Controls.Add(this.back);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDishName);
            this.Controls.Add(this.txtFormulaName);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtSteps);
            this.Controls.Add(this.lstSuggestions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "addcook";
            this.Text = "Cooking Handbook";
            this.Load += new System.EventHandler(this.addcook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.TextBox txtFormulaName;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnSave;
        private Label label1;
        private Label titleLabel;
        private Button homeButton;
        private Button back;
        private ListBox lstSuggestions;
    }

    #endregion
}