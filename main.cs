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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            recipe f = new recipe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ingredient f = new ingredient();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            schdule f = new schdule();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
