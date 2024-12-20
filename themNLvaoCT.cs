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
    public partial class themNLvaoCT : Form
    {
        private dataProvider dataProvider;
        private List<string> allNguyenLieu;
        public themNLvaoCT(string formulaName)
        {
            InitializeComponent();
            dataProvider = new dataProvider(); // Khởi tạo dataProvider
            textBox4.Text = formulaName;
        }




        private void LoadNguyenLieu()
        {
            DataTable dataTable = dataProvider.ExecuteQuery("SELECT TenNL FROM NguyenLieu", new object[] { });

            allNguyenLieu = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                allNguyenLieu.Add(row["TenNL"].ToString());
            }
        }

        private void themNLvaoCT_Load(object sender, EventArgs e)
        {
            LoadNguyenLieu(); // Gọi phương thức tải dữ liệu
            LoadDataToGridView(); // Tải dữ liệu vào DataGridView
            listBox1.Visible = false; // Ẩn ListBox ban đầu
            ConfigureDataGridView(); // Cấu hình DataGridView
        }

        private void themNLvaoCT_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false; // Ẩn ListBox khi nhấn ra ngoài
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckAndInsertNguyenLieu()
        {
            string tenNL = textBox1.Text.Trim();
            string donViTinh = textBox3.Text.Trim();

            // Kiểm tra nếu một trong hai ô bị trống
            if (string.IsNullOrEmpty(tenNL) || string.IsNullOrEmpty(donViTinh))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin về nguyên liệu và đơn vị.", "Thông báo");
                return;
            }

            // Kiểm tra xem nguyên liệu đã tồn tại trong bảng NguyenLieu chưa
            string queryCheck = "SELECT COUNT(*) FROM NguyenLieu WHERE TenNL = @TenNL AND DonViTinh = @DonViTinh";
            var parametersCheck = new Dictionary<string, object>
    {
        { "@TenNL", tenNL },
        { "@DonViTinh", donViTinh }
    };

            DataTable resultTable = dataProvider.ExecuteQuery(queryCheck, parametersCheck);
            int count = Convert.ToInt32(resultTable.Rows[0][0]);

            if (count > 0)
            {
                // Nguyên liệu đã tồn tại
             //   MessageBox.Show("Nguyên liệu đã tồn tại trong cơ sở dữ liệu.", "Thông báo");
            }
            else
            {
                // Thêm nguyên liệu vào bảng NguyenLieu
                string queryInsert = "INSERT INTO NguyenLieu (TenNL, DonViTinh) VALUES (@TenNL, @DonViTinh)";
                var parametersInsert = new Dictionary<string, object>
        {
            { "@TenNL", tenNL },
            { "@DonViTinh", donViTinh }
        };

                try
                {
                    int rowsAffected = dataProvider.ExecuteNonQuery(queryInsert, parametersInsert);

                    if (rowsAffected > 0)
                    {
                      //  MessageBox.Show("Nguyên liệu đã được thêm thành công!", "Thông báo");
                    }
                    else
                    {
                      //  MessageBox.Show("Đã xảy ra lỗi khi thêm nguyên liệu.", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                   // MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
                }
            }
        }

        private void labelTenNguyenLieu_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            CheckAndInsertNguyenLieu();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (string.IsNullOrEmpty(input))
            {
                listBox1.Visible = false; // Ẩn ListBox nếu không có nội dung nhập
                return;
            }

            // Tìm kiếm gợi ý từ danh sách nguyên liệu
            var suggestions = allNguyenLieu
                .Where(nl => nl.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (suggestions.Any())
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(suggestions.ToArray());
                listBox1.Visible = true; // Hiển thị ListBox nếu có gợi ý
            }
            else
            {
                listBox1.Visible = false; // Ẩn ListBox nếu không có gợi ý
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedNguyenLieu = listBox1.SelectedItem.ToString();
                textBox1.Text = selectedNguyenLieu; // Gán tên nguyên liệu đã chọn vào TextBox1

                // Lấy đơn vị tính và gán vào TextBox3
                string donViTinh = GetDonViTinh(selectedNguyenLieu);
                textBox3.Text = donViTinh;

                listBox1.Visible = false; // Ẩn ListBox
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenCT = textBox4.Text.Trim();
            string tenNL = textBox1.Text.Trim();
            string soLuongNL = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(tenCT) || string.IsNullOrEmpty(tenNL) || string.IsNullOrEmpty(soLuongNL))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo");
                return;
            }

            if (!int.TryParse(soLuongNL, out int parsedSoLuongNL))
            {
                MessageBox.Show("Số lượng phải là một số nguyên hợp lệ.", "Thông báo");
                return;
            }

            string query = "INSERT INTO ChiTietCT (TenCT, TenNL, SoLuongNL) VALUES (@TenCT, @TenNL, @SoLuongNL)";
            var parameters = new Dictionary<string, object>
    {
        { "@TenCT", tenCT },
        { "@TenNL", tenNL },
        { "@SoLuongNL", parsedSoLuongNL }
    };

            try
            {
                int rowsAffected = dataProvider.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                  //  MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo");

                    // Tải lại dữ liệu vào DataGridView
                    LoadDataToGridView();
                }
                else
                {
                //    MessageBox.Show("Đã xảy ra lỗi khi lưu dữ liệu.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }




        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private string GetDonViTinh(string tenNguyenLieu)
        {
            string query = "SELECT DonViTinh FROM NguyenLieu WHERE TenNL = @TenNL";
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@TenNL", tenNguyenLieu }
    };

            DataTable dataTable = dataProvider.ExecuteQuery(query, parameters);
            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0]["DonViTinh"].ToString();
            }

            return string.Empty; // Trả về chuỗi rỗng nếu không tìm thấy
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void SaveToChiTietCT()
        {
            // Lấy dữ liệu từ các TextBox
            string tenCT = textBox4.Text.Trim();
            string tenNL = textBox1.Text.Trim();
            string soLuongNL = textBox2.Text.Trim();

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(tenCT) || string.IsNullOrEmpty(tenNL) || string.IsNullOrEmpty(soLuongNL))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo");
                return;
            }

            if (!int.TryParse(soLuongNL, out int parsedSoLuongNL))
            {
                MessageBox.Show("Số lượng phải là một số nguyên hợp lệ.", "Thông báo");
                return;
            }

            // Lưu dữ liệu vào bảng ChiTietCT
            string query = "INSERT INTO ChiTietCT (TenCT, TenNL, SoLuongNL) VALUES (@TenCT, @TenNL, @SoLuongNL)";
            var parameters = new Dictionary<string, object>
    {
        { "@TenCT", tenCT },
        { "@TenNL", tenNL },
        { "@SoLuongNL", parsedSoLuongNL }
    };

            try
            {
                int rowsAffected = dataProvider.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                  //  MessageBox.Show("Lưu thành công!", "Thông báo");
                }
                else
                {
                   MessageBox.Show("Đã xảy ra lỗi khi lưu dữ liệu.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataToGridView()
        {
            string query = @"
        SELECT 
            CT.TenNL AS [Tên nguyên liệu], 
            NL.DonViTinh AS [Đơn vị], 
            CT.SoLuongNL AS [Số lượng]
        FROM ChiTietCT CT
        INNER JOIN NguyenLieu NL ON CT.TenNL = NL.TenNL
        WHERE CT.TenCT = @TenCT";

            var parameters = new Dictionary<string, object>
    {
        { "@TenCT", textBox4.Text.Trim() }
    };

            try
            {
                DataTable dataTable = dataProvider.ExecuteQuery(query, parameters);

                // Gán dữ liệu vào DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Thông báo");
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Đặt màu chữ là đen
        }

    }
}
