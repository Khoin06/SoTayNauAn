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

namespace SoTayNauAn
{
    public partial class fSignUp : Form
    {
        // Mock database for demonstration purposes
        private Dictionary<string, string> userDatabase = new Dictionary<string, string>()
        {
            { "admin", "123456" },
            { "user1", "password1" }
        };

        public fSignUp()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (userDatabase.ContainsKey(username) && userDatabase[username] == password)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                fLogin f = new fLogin();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}