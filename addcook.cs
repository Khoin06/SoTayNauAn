using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoTayNauAn.DAO;

namespace SoTayNauAn
{
    public partial class addcook : Form
    {
        private dataProvider dataProvider;

        public addcook()
        {
            InitializeComponent();
            dataProvider = new dataProvider(); // Khởi tạo dataProvider
        }



        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string dishName = txtDishName.Text.Trim();
            string formulaName = txtFormulaName.Text.Trim();
            string image = txtImage.Text.Trim();
            string steps = txtSteps.Text.Trim();
            string rate = txtRate.Text.Trim();
            string time = txtTime.Text.Trim();
            

            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrEmpty(dishName) || string.IsNullOrEmpty(formulaName) || string.IsNullOrEmpty(image) || string.IsNullOrEmpty(steps) || string.IsNullOrEmpty(rate) || string.IsNullOrEmpty(time))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo");
                return;
            }

            // Kiểm tra và chuyển đổi thời gian nấu
            if (!int.TryParse(time, out int cookingTime))
            {
                MessageBox.Show("Thời gian nấu phải là số nguyên hợp lệ.", "Thông báo");
                return;
            }

            // Câu lệnh kiểm tra món ăn có tồn tại trong bảng MonAn
            string queryCheckDish = "SELECT IdMA FROM MonAn WHERE TenMA = @dishName";
            var parametersCheckDish = new Dictionary<string, object>
    {
        { "@dishName", dishName }
    };

            DataTable dishTable = dataProvider.ExecuteQuery(queryCheckDish, parametersCheckDish);

            if (dishTable.Rows.Count == 0)
            {
                MessageBox.Show($"Món ăn '{dishName}' chưa tồn tại. Vui lòng thêm món ăn trước.", "Thông báo");
                return;
            }

            // Lấy IdMA của món ăn
            int idMA = Convert.ToInt32(dishTable.Rows[0]["IdMA"]);

            // Thực hiện thêm công thức vào bảng CongThuc
            string queryInsert = @"
        INSERT INTO CongThuc (TenCT, TenMA, HinhAnh, MoTa, DanhGia, ThoiGianNau) 
        VALUES (@TenCT, @TenMA,@HinhAnh, @MoTa, @DanhGia, @ThoiGianNau)";

            var parametersInsert = new Dictionary<string, object>
    {
        { "@TenCT", formulaName },
        { "@TenMA", dishName },
        {"@HinhAnh", image },
        { "@MoTa", steps },
        { "@DanhGia", rate },
        { "@ThoiGianNau", cookingTime }
    };

            try
            {
                int rowsAffected = dataProvider.ExecuteNonQuery(queryInsert, parametersInsert);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Công thức đã được lưu thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu công thức.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
            
            themNLvaoCT themNguyenLieuForm = new themNLvaoCT(formulaName);  
            // Hiển thị form themNLvaoCT
            themNguyenLieuForm.ShowDialog(); // Sử dụng ShowDialog() để mở form dưới dạng modal
        }

        private void addcook_Load(object sender, EventArgs e)
        {
            txtDishName.LostFocus += TxtDishName_LostFocus;
            lstSuggestions.LostFocus += LstSuggestions_LostFocus;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            main f = new main();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            recipe f = new recipe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void txtDishName_Enter(object sender, EventArgs e)
        {
            if (txtDishName.Text == "Tên món ăn")
            {
                txtDishName.Text = "";
                txtDishName.ForeColor = Color.Black; // Đặt màu chữ về đen
            }
        }
        private void txtImage_Enter(object sender, EventArgs e)
        {
            if (txtImage.Text == "Hình ảnh")
            {
                txtImage.Text = "";
                txtImage.ForeColor = Color.Black; // Đặt màu chữ về đen
            }
        }
        private void txtFormulaName_Enter(object sender, EventArgs e)
        {
            // Kiểm tra tên món ăn trong cơ sở dữ liệu
            string inputDishName = txtDishName.Text.Trim();

            if (!string.IsNullOrEmpty(inputDishName) && inputDishName != "Tên món ăn")
            {
                string queryCheck = "SELECT COUNT(*) FROM MonAn WHERE TenMA = @input";
                var parametersCheck = new Dictionary<string, object>
                {
                    { "@input", inputDishName }
                };

                DataTable resultTable = dataProvider.ExecuteQuery(queryCheck, parametersCheck);
                int count = Convert.ToInt32(resultTable.Rows[0][0]);

                if (count == 0)
                {
                    // Nếu món ăn chưa tồn tại, thêm vào cơ sở dữ liệu
                    string queryInsert = "INSERT INTO MonAn (TenMA) VALUES (@input)";
                    var parametersInsert = new Dictionary<string, object>
                    {
                        { "@input", inputDishName }
                    };

                    dataProvider.ExecuteNonQuery(queryInsert, parametersInsert);

                    //MessageBox.Show($"Món ăn '{inputDishName}' đã được thêm vào cơ sở dữ liệu.", "Thông báo");
                }
            }
            if (txtFormulaName.Text == "Tên công thức")
            {
                txtFormulaName.Text = "";
                txtFormulaName.ForeColor = Color.Black;
            }

        }

        private void txtTime_Enter(object sender, EventArgs e)
        {
            if (txtTime.Text == "Thời gian")
            {
                txtTime.Text = "";
                txtTime.ForeColor = Color.Black;
            }
        }

        private void txtRate_Enter(object sender, EventArgs e)
        {
            if (txtRate.Text == "Đánh giá")
            {
                txtRate.Text = "";
                txtRate.ForeColor = Color.Black;
            }
        }

        private void txtSteps_Enter(object sender, EventArgs e)
        {
            if (txtSteps.Text == "Các bước thực hiện")
            {
                txtSteps.Text = "";
                txtSteps.ForeColor = Color.Black;
            }
        }

        private void txtDishName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDishName.Text))
            {
                txtDishName.Text = "Tên món ăn";
                txtDishName.ForeColor = Color.Gray;
            }
        }

        private void txtImage_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImage.Text))
            {
                txtImage.Text = "Hình ảnh";
                txtImage.ForeColor = Color.Gray;
            }
        }
        private void txtFormulaName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFormulaName.Text))
            {
                txtFormulaName.Text = "Tên công thức";
                txtFormulaName.ForeColor = Color.Gray;
            }
        }

        private void txtTime_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTime.Text))
            {
                txtTime.Text = "Thời gian";
                txtTime.ForeColor = Color.Gray;
            }
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRate.Text))
            {
                txtRate.Text = "Đánh giá";
                txtRate.ForeColor = Color.Gray;
            }
        }

        private void txtSteps_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSteps.Text))
            {
                txtSteps.Text = "Các bước thực hiện";
                txtSteps.ForeColor = Color.Gray;
            }
        }
        private void TxtDishName_LostFocus(object sender, EventArgs e)
        {
            // Ẩn danh sách gợi ý nếu nhấn ra ngoài
            if (!lstSuggestions.Focused)
            {
                lstSuggestions.Visible = false;
            }
        }

        private void LstSuggestions_LostFocus(object sender, EventArgs e)
        {
            // Ẩn danh sách gợi ý nếu mất focus
            lstSuggestions.Visible = false;
        }
        private void txtDishName_TextChanged(object sender, EventArgs e)
        {
            string input = txtDishName.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                lstSuggestions.Visible = false;
                return;
            }

            // Truy vấn cơ sở dữ liệu lấy danh sách gợi ý
            string query = "SELECT TenMA FROM MonAn WHERE TenMA LIKE @input";
            var parameters = new Dictionary<string, object>
            {
                { "@input", "%" + input + "%" }
            };

            DataTable suggestionsTable = dataProvider.ExecuteQuery(query, parameters);

            List<string> suggestions = suggestionsTable.AsEnumerable()
                .Select(row => row.Field<string>("TenMA"))
                .ToList();

            if (suggestions.Any())
            {
                lstSuggestions.DataSource = suggestions;
                lstSuggestions.BringToFront();
                lstSuggestions.Visible = true;
            }
            else
            {
                lstSuggestions.Visible = false;
            }
        }

        private void lstSuggestions_Click(object sender, EventArgs e)
        {
            if (lstSuggestions.SelectedItem != null)
            {
                txtDishName.Text = lstSuggestions.SelectedItem.ToString();
                lstSuggestions.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtImage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFormulaName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


