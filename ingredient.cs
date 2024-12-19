using SoTayNauAn.DAO;
using System;
using System.Collections;
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
    public partial class ingredient : Form
    {

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ingredientGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // Lấy chuỗi tìm kiếm từ TextBox
            string searchText = unitTextBox.Text.Trim().ToLower();

            // Truy vấn toàn bộ dữ liệu từ cơ sở dữ liệu
            string query = "SELECT TenNL, DonViTinh FROM NguyenLieu";
            dataProvider dataProvider = new dataProvider();
            DataTable originalDataTable = dataProvider.ExecuteQuery(query, new object[] { });

            // Kiểm tra nếu không có dữ liệu từ cơ sở dữ liệu
            if (originalDataTable == null || originalDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu từ cơ sở dữ liệu!");
                return;
            }

            // Kiểm tra nếu TextBox để trống, hiển thị toàn bộ dữ liệu
            if (string.IsNullOrEmpty(searchText))
            {
                ingredientGridView.DataSource = originalDataTable; // Hiển thị toàn bộ dữ liệu
                return;
            }

            // Lọc dữ liệu dựa trên chuỗi tìm kiếm
            var filteredRows = originalDataTable.AsEnumerable().Where(row =>
                row.Field<string>("TenNL").ToLower().Contains(searchText) ||
                row.Field<string>("DonViTinh").ToLower().Contains(searchText)
            );

            // Hiển thị dữ liệu lọc
            if (filteredRows.Any())
            {
                DataTable filteredDataTable = filteredRows.CopyToDataTable(); // Chuyển các dòng phù hợp thành DataTable
                ingredientGridView.DataSource = filteredDataTable; // Hiển thị dữ liệu đã lọc
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp!");
                ingredientGridView.DataSource = originalDataTable; // Hiển thị bảng trống
            }

            // Làm mới DataGridView
            //ingredientGridView.DataSource = originalDataTable;
            ingredientGridView.Refresh();
        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ingredientGridView.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                // Lấy giá trị tên nguyên liệu từ hàng được chọn
                string ingredientName = ingredientGridView.SelectedRows[0].Cells["TenNL"].Value.ToString();

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa nguyên liệu '{ingredientName}' không?",
                                                             "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes) // Nếu người dùng chọn Yes
                {
                    // Thực hiện câu lệnh DELETE trong database
                    string query = "DELETE FROM NguyenLieu WHERE TenNL = @tenNL";

                    dataProvider data = new dataProvider();
                    int result = data.ExecuteNonQuery(query, new object[] { ingredientName });

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadIngredientList(); // Tải lại danh sách sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Xử lý khi nhấn Enter trong unitTextBox
        private void unitTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím Enter được nhấn
            if (e.KeyCode == Keys.Enter)
            {
                // Lấy chuỗi tìm kiếm
                string searchText = unitTextBox.Text.Trim();

                // Nếu TextBox trống, hiển thị toàn bộ dữ liệu
                if (string.IsNullOrEmpty(searchText))
                {
                    // Truy vấn toàn bộ dữ liệu từ cơ sở dữ liệu
                    string query = "SELECT TenNL, DonViTinh FROM NguyenLieu";
                    dataProvider dataProvider = new dataProvider();
                    DataTable originalDataTable = dataProvider.ExecuteQuery(query, new object[] { });

                    // Kiểm tra nếu không có dữ liệu từ cơ sở dữ liệu
                    if (originalDataTable == null || originalDataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu từ cơ sở dữ liệu!");
                        return;
                    }

                    // Hiển thị dữ liệu vào DataGridView
                    ingredientGridView.DataSource = originalDataTable;

                    // Làm mới DataGridView
                    ingredientGridView.Refresh();
                }

                // Ngăn chặn hành động mặc định của phím Enter
                e.Handled = true;
            }
        }







        private void saveButton_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các ô văn bản
            string ingredientName = textBox1.Text.Trim();
            string unit = textBox2.Text.Trim();

            // Kiểm tra nếu các giá trị hợp lệ
            if (string.IsNullOrEmpty(ingredientName) || string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "INSERT INTO NguyenLieu (TenNL, DonViTinh) VALUES (@tenNL, @donViTinh)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
{
    { "@tenNL", ingredientName },
    { "@donViTinh", unit },

};


            // Thực hiện câu lệnh với dữ liệu
            dataProvider data = new dataProvider();
            int result = data.ExecuteNonQuery(query, parameters);

            // Kiểm tra kết quả thêm
            if (result > 0)
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIngredientList(); // Cập nhật lại danh sách sau khi thêm
                textBox1.Text = ""; // Xóa tên nguyên liệu
                textBox2.Text = ""; // Xóa đơn vị tính

            }
            else
            {
                MessageBox.Show("Thêm mới thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            main f = new main();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void ingredientGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng nhấn vào hàng, không phải tiêu đề
            {
                DataGridViewRow row = ingredientGridView.Rows[e.RowIndex];

                // Gán giá trị của hàng được chọn vào các ô văn bản
                textBox1.Text = row.Cells["TenNL"].Value.ToString(); // Tên nguyên liệu
                textBox2.Text = row.Cells["DonViTinh"].Value.ToString(); // Đơn vị tính
            }
        }

       private void editButton_Click(object sender, EventArgs e)
{
    // Lấy thông tin từ các ô văn bản
    string ingredientName = textBox1.Text.Trim(); // Tên nguyên liệu mới
    string unit = textBox2.Text.Trim(); // Đơn vị tính mới

    if (string.IsNullOrEmpty(ingredientName) || string.IsNullOrEmpty(unit))
    {
        MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

            // Kiểm tra nếu người dùng đã chọn hàng trong DataGridView
            if (ingredientGridView.SelectedRows.Count > 0)
            {
                // Lấy tên nguyên liệu ban đầu từ hàng được chọn
                string originalIngredientName = ingredientGridView.SelectedRows[0].Cells["TenNL"].Value.ToString();

                // Câu truy vấn SQL với tham số
                string query = "UPDATE NguyenLieu SET TenNL = @newTenNL, DonViTinh = @newDonViTinh WHERE TenNL = @originalTenNL";

                // Tạo tham số cho câu truy vấn
                Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@newTenNL", ingredientName },
        { "@newDonViTinh", unit },
     //   { "@idST", 2 }, // Gán giá trị cố định cho idST
        { "@originalTenNL", originalIngredientName }
    };

                try
                {
                    // Thực thi câu truy vấn
                    dataProvider data = new dataProvider();
                    int result = data.ExecuteNonQuery(query, parameters);

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadIngredientList(); // Tải lại danh sách nguyên liệu sau khi chỉnh sửa
                        textBox1.Text = ""; // Xóa tên nguyên liệu
                        textBox2.Text = ""; // Xóa đơn vị tính

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ và hiển thị thông báo lỗi chi tiết
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
