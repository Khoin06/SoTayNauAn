using QuanLyQuanCafe;
using SoTayNauAn.DAO;
using System;
using System.Data;
using System.Data.SqlClient;
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
                case "Thứ 2": return 0;
                case "Thứ 3": return 1;
                case "Thứ 4": return 2;
                case "Thứ 5": return 3;
                case "Thứ 6": return 4;
                case "Thứ 7": return 5;
                case "Chủ nhật": return 6;
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có ô nào được chọn hay không
            if (scheduleGridView.CurrentCell != null)
            {
                int rowIndex = scheduleGridView.CurrentCell.RowIndex;
                int columnIndex = scheduleGridView.CurrentCell.ColumnIndex;

                // Bỏ qua nếu người dùng chọn cột đầu tiên (Buổi) hoặc cột ngoài phạm vi ngày
                if (columnIndex == 0 || rowIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn một ô hợp lệ chứa món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy tên món ăn trong ô
                string dish = scheduleGridView.Rows[rowIndex].Cells[columnIndex].Value?.ToString();

                if (!string.IsNullOrEmpty(dish))
                {
                    DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa món: {dish} không?",
                                                          "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Xóa món ăn trong cơ sở dữ liệu
                            string query = "DELETE FROM ChitietM WHERE TenCT = @TenCT";
                            dataProvider data = new dataProvider();

                            // Sử dụng SqlParameter để truyền giá trị tham số
                            SqlParameter parameter = new SqlParameter("@TenCT", SqlDbType.NVarChar)
                            {
                                Value = dish // Gán giá trị cho tham số
                            };

                            // Thực thi câu lệnh
                            int rowsAffected = data.ExecuteNonQuery(query, new SqlParameter[] { parameter });

                            if (rowsAffected > 0)
                            {
                                // Xóa thành công, cập nhật giao diện
                                MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Xóa món ăn khỏi bảng
                                scheduleGridView.Rows[rowIndex].Cells[columnIndex].Value = null;
                            }
                            else
                            {
                                MessageBox.Show("Xóa món ăn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ô được chọn không chứa món ăn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ô để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editSchdule f = new editSchdule();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
