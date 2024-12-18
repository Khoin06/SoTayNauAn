using SoTayNauAn.DAO;
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
    public partial class ingredient : Form
    {


        // private void ingredientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        // {

        // }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ingredientGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string searchTerm = unitTextBox.Text.Trim(); // Lấy từ khóa tìm kiếm từ hộp văn bản
            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Thực hiện câu lệnh SELECT tìm kiếm trong cơ sở dữ liệu
                string query = "SELECT * FROM NguyenLieu WHERE TenNL LIKE @searchTerm";

                dataProvider data = new dataProvider();
                DataTable result = data.ExecuteQuery(query, new object[] { "%" + searchTerm + "%" });

                if (result.Rows.Count > 0)
                {
                    ingredientGridView.DataSource = result; // Cập nhật DataGridView với kết quả tìm kiếm
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nguyên liệu nào với từ khóa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void unitTextBox_TextChanged(object sender, EventArgs e)
        {

                string searchText = searchBox.Text.ToLower(); // Lấy giá trị tìm kiếm và chuyển thành chữ thường

                string query = "SELECT TenNL, DonViTinh FROM NguyenLieu";
                dataProvider data = new dataProvider();
                DataTable dataTable = data.ExecuteQuery(query, new object[] { });

                if (!string.IsNullOrEmpty(searchText))
                {
                    // Lọc các hàng theo chuỗi tìm kiếm
                    var filteredRows = dataTable.AsEnumerable().Where(row =>
                        row.Field<string>("TenNL").ToLower().Contains(searchText) ||
                        row.Field<string>("DonViTinh").ToLower().Contains(searchText)
                    );

                    dataTable = filteredRows.CopyToDataTable(); // Tạo bảng dữ liệu mới từ các hàng phù hợp
                }

                ingredientGridView.DataSource = dataTable; // Cập nhật DataGridView
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

            // Chuẩn bị câu lệnh SQL để thêm dữ liệu
            string query = "INSERT INTO NguyenLieu (TenNL, DonViTinh) VALUES (@tenNL, @donViTinh)";

            // Sử dụng Dictionary để chứa các tham số cho câu lệnh SQL
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@tenNL", ingredientName },
        { "@donViTinh", unit }
    };

            // Thực hiện câu lệnh với dữ liệu
            dataProvider data = new dataProvider();
            int result = data.ExecuteNonQuery(query, parameters);

            // Kiểm tra kết quả thêm
            if (result > 0)
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIngredientList(); // Cập nhật lại danh sách sau khi thêm
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


    }       
    }
