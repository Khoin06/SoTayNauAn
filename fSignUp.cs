using QuanLyQuanCafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SoTayNauAn
{
    public partial class fSignUp : Form
    {
        public fSignUp()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text.Trim();
            string password = txbPassWord.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tên đăng kí và mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối database và kiểm tra
            string connectionString = @"Data Source=DESKTOP-0FKCP5H;Initial Catalog=CookBook;User ID=sa;Password=123456";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kiểm tra nếu tài khoản đã tồn tại
                    string queryCheck = "SELECT COUNT(*) FROM Nguoidung WHERE TK = @username";
                    SqlCommand checkCommand = new SqlCommand(queryCheck, connection);
                    checkCommand.Parameters.AddWithValue("@username", username);

                    int userExists = (int)checkCommand.ExecuteScalar();

                    if (userExists > 0)
                    {
                        MessageBox.Show("Tên đăng kí đã tồn tại! Vui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Thêm tài khoản mới vào cơ sở dữ liệu
                        string queryInsert = "INSERT INTO Nguoidung (TK, MK) VALUES (@username, @password)";
                        SqlCommand insertCommand = new SqlCommand(queryInsert, connection);
                        insertCommand.Parameters.AddWithValue("@username", username);
                        insertCommand.Parameters.AddWithValue("@password", password);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fLogin f = new fLogin();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi thoát
            Environment.Exit(0);
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {
            string password = txbPassWord.Text;
        }

    }
}
