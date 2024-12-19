using SoTayNauAn;
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


namespace QuanLyQuanCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text.Trim();
            string passWord = txbPassWord.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Login(userName, passWord))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainf = new main();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Login(string userName, string passWord)
        {
            string connectionString = @"Data Source=MINH-DUCK\SQLEXPRESS;Initial Catalog=CookBook;Integrated Security=True";
            string query = "SELECT * FROM Nguoidung WHERE TK = @userName AND MK = @passWord";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@passWord", passWord);

                    SqlDataReader reader = command.ExecuteReader();
                    return reader.HasRows; // Kiểm tra nếu có dữ liệu trả về từ CSDL.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Mở form đăng ký, ví dụ form đăng ký có tên là fRegister
            fSignUp registerForm = new fSignUp();
            registerForm.Show();
        }


        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            string userName = txbUserName.Text.Trim();
        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {
            string passWord = txbPassWord.Text.Trim();
        }
    }
}
