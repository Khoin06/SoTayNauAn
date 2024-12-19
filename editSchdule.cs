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
    public partial class editSchdule : Form
    {
        public editSchdule()
        {
            InitializeComponent();
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
