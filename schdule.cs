using QuanLyQuanCafe;
using SoTayNauAn.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace SoTayNauAn
{
    public partial class schdule : Form
    {
        public schdule()
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
                WHEN m.TenMenu LIKE '%Sáng' THEN N'Sáng'
                WHEN m.TenMenu LIKE '%Trưa' THEN N'Trưa'
                WHEN m.TenMenu LIKE '%Tối' THEN N'Tối'
            END AS Buoi,
            CASE 
                WHEN m.TenMenu LIKE '%Thứ 2%' THEN N'Thứ 2'
                WHEN m.TenMenu LIKE '%Thứ 3%' THEN N'Thứ 3'
                WHEN m.TenMenu LIKE '%Thứ 4%' THEN N'Thứ 4'
            END AS Thu
        FROM MENU m
        JOIN ChitietM ct ON m.TenMenu = ct.TenMenu
        ORDER BY Thu, Buoi";

            dataProvider data = new dataProvider();
            DataTable table = data.ExecuteQuery(query, new object[] { });

            // Tạo cột cho DataGridView nếu chưa có
            if (scheduleGridView.Columns.Count == 0)
            {
                scheduleGridView.Columns.Add("Buoi", "Buổi");
                scheduleGridView.Columns.Add("Thu2", "Thứ 2");
                scheduleGridView.Columns.Add("Thu3", "Thứ 3");
                scheduleGridView.Columns.Add("Thu4", "Thứ 4");
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
                string dish = row["Dish"].ToString();

                int rowIndex = -1;

                if (buoi == "Sáng") rowIndex = 0;
                else if (buoi == "Trưa") rowIndex = 1;
                else if (buoi == "Tối") rowIndex = 2;

                if (rowIndex != -1)
                {
                    if (thu == "Thứ 2") scheduleGridView.Rows[rowIndex].Cells[1].Value = dish;
                    if (thu == "Thứ 3") scheduleGridView.Rows[rowIndex].Cells[2].Value = dish;
                    if (thu == "Thứ 4") scheduleGridView.Rows[rowIndex].Cells[3].Value = dish;
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

        private void button1_Click(object sender, EventArgs e)
        {
            addSchdule f = new addSchdule();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void scheduleGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            main f = new main();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
