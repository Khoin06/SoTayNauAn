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

namespace QuanLyQuanCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        // Mock database for demonstration purposes
        private Dictionary<string, string> userDatabase = new Dictionary<string, string>()
        {
            { "admin", "123456" }, // Example account
            { "user1", "password1" }
        };

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (userDatabase.ContainsKey(username) && userDatabase[username] == password)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                main f = new main();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Intentionally left blank
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Intentionally left blank
        }

        private void label4_Click(object sender, EventArgs e)
        {
            fSignUp f = new fSignUp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;

            if (userDatabase.ContainsKey(username))
            {
                MessageBox.Show($"Mật khẩu của bạn là: {userDatabase[username]}", "Quên mật khẩu");
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}