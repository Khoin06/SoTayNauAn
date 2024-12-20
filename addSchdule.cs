﻿using SoTayNauAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoTayNauAn
{
    public partial class addSchdule : Form
    {
        public addSchdule()
        {
            InitializeComponent();
            LoadAccountList();
        }
        void LoadAccountList()
        {
            string query = @"
SELECT 
    m.TenMenu AS DayAndSession,
    ct.TenCT AS Dish,
    CASE
        WHEN ct.Buoi = N'Sáng' THEN N'Sáng'
        WHEN ct.Buoi = N'Trưa' THEN N'Trưa'
        WHEN ct.Buoi = N'Tối' THEN N'Tối'
        ELSE N'Không xác định'
    END AS Buoi,
    CASE
        WHEN m.TenMenu LIKE '%Thứ 2%' THEN N'Thứ 2'
        WHEN m.TenMenu LIKE '%Thứ 3%' THEN N'Thứ 3'
        WHEN m.TenMenu LIKE '%Thứ 4%' THEN N'Thứ 4'
        WHEN m.TenMenu LIKE '%Thứ 5%' THEN N'Thứ 5'
        WHEN m.TenMenu LIKE '%Thứ 6%' THEN N'Thứ 6'
        WHEN m.TenMenu LIKE '%Thứ 7%' THEN N'Thứ 7'
        ELSE N'Không xác định'
    END AS Thu
FROM MENU m
JOIN ChitietM ct ON m.TenMenu = ct.TenMenu
ORDER BY Thu, Buoi;";

            dataProvider data = new dataProvider();
            DataTable table = data.ExecuteQuery(query, new object[] { });

            // Tạo cột cho DataGridView nếu chưa có
            if (scheduleGridView.Columns.Count == 0)
            {
                scheduleGridView.Columns.Add("Buoi", "Buổi");
                scheduleGridView.Columns.Add("Thu2", "Thứ 2");
                scheduleGridView.Columns.Add("Thu3", "Thứ 3");
                scheduleGridView.Columns.Add("Thu4", "Thứ 4");
                scheduleGridView.Columns.Add("Thu5", "Thứ 5");
                scheduleGridView.Columns.Add("Thu6", "Thứ 6");
                scheduleGridView.Columns.Add("Thu7", "Thứ 7");
            }

            // Xóa dữ liệu cũ
            scheduleGridView.Rows.Clear();

            // Tạo các hàng cho Buổi: Sáng, Trưa, Tối
            scheduleGridView.Rows.Add("Sáng", "", "", "");
            scheduleGridView.Rows.Add("Trưa", "", "", "");
            scheduleGridView.Rows.Add("Tối", "", "", "");

            // Đổ dữ liệu vào các ô tương ứng
            foreach (DataRow row in table.Rows)
            {
                string buoi = row["Buoi"].ToString();
                string thu = row["Thu"].ToString();
                string dish = row["Dish"] != DBNull.Value ? row["Dish"].ToString() : ""; // Xử lý null

                int rowIndex = -1;

                if (buoi == "Sáng") rowIndex = 0;
                else if (buoi == "Trưa") rowIndex = 1;
                else if (buoi == "Tối") rowIndex = 2;

                if (rowIndex != -1)
                {
                    if (thu == "Thứ 2") scheduleGridView.Rows[rowIndex].Cells[1].Value = dish;
                    else if (thu == "Thứ 3") scheduleGridView.Rows[rowIndex].Cells[2].Value = dish;
                    else if (thu == "Thứ 4") scheduleGridView.Rows[rowIndex].Cells[3].Value = dish;
                    else if (thu == "Thứ 5") scheduleGridView.Rows[rowIndex].Cells[3].Value = dish;
                    else if (thu == "Thứ 6") scheduleGridView.Rows[rowIndex].Cells[3].Value = dish;
                    else if (thu == "Thứ 7") scheduleGridView.Rows[rowIndex].Cells[3].Value = dish;


                }
            }
        }





        int GetDayColumnIndex(string day)
        {
            switch (day)
            {
                case "Monday": return 0;
                case "Tuesday": return 1;
                case "Wednesday": return 2;
                case "Thursday": return 3;
                case "Friday": return 4;
                case "Saturday": return 5;
                case "Sunday": return 6;
                default: return -1;
            }
        }

        private void InitializeComponent()
        {

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();


 ///           System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
 ///           System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
 ///           System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
  ///          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
   ///         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
   ///         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
   ///         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
  ///          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();


            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scheduleGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(241, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sổ Tay Nấu Ăn ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 35);
            this.label1.TabIndex = 11;

            this.label1.Text = "Lịch trình ";

            // 
            // scheduleGridView
            // 
            this.scheduleGridView.AllowUserToAddRows = false;
            this.scheduleGridView.AllowUserToDeleteRows = false;
            this.scheduleGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scheduleGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.scheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});

            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scheduleGridView.DefaultCellStyle = dataGridViewCellStyle8;


// /            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//  /           dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
//  /           dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//  /           dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
//  /           dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
//   /          dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//   /          dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//  /           this.scheduleGridView.DefaultCellStyle = dataGridViewCellStyle24;

            this.scheduleGridView.Location = new System.Drawing.Point(77, 110);

            this.scheduleGridView.Name = "scheduleGridView";
            this.scheduleGridView.RowHeadersVisible = false;
            this.scheduleGridView.Size = new System.Drawing.Size(496, 200);
            this.scheduleGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Buổi";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn1
            // 

            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;


          ///  dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
          ///  this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle17;

            this.dataGridViewTextBoxColumn1.HeaderText = "Thứ 2";

            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 

            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;


          ///  dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
          ///  this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle18;

            this.dataGridViewTextBoxColumn2.HeaderText = "Thứ 3";

            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 

            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;


           /// dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
           /// this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle19;

            this.dataGridViewTextBoxColumn3.HeaderText = "Thứ 4";

            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 

            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;


           /// dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
          ///  this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle20;

            this.dataGridViewTextBoxColumn4.HeaderText = "Thứ 5";

            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 

            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;


//  //           dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//   //          this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle21;

            this.dataGridViewTextBoxColumn5.HeaderText = "Thứ 6";

            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 


//             dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//             this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle22;

            this.dataGridViewTextBoxColumn6.HeaderText = "Thứ 7";

            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 



//             dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//             this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle23;

            this.dataGridViewTextBoxColumn7.HeaderText = "Chủ nhật";

            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(594, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(489, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 20;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = false;
            // 


            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(266, 365);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 29);
            this.textBox2.TabIndex = 22;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(23, 431);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 30);
            this.homeButton.TabIndex = 23;
            this.homeButton.Text = "Trang chủ ";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(594, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 24;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // addSchdule
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(768, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scheduleGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "addSchdule";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label2;
        private Label label1;
        private DataGridView scheduleGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Button button1;

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private Button button3;
        private TextBox textBox2;
        private Button homeButton;


        private void homeButton_Click(object sender, EventArgs e)
        {
            main f = new main();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)

        {

        }

        private Button button2;
    }
}
