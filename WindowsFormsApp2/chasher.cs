using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class casher : UserControl
    {
        public casher()
        {
            InitializeComponent();
        }
        private void bunifuCustomTextbox1_TextChanged_1(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void bunifuCustomTextbox1_Enter(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            bunifuCustomTextbox1.Focus();
        }

        private void bunifuCustomTextbox1_Leave(object sender, EventArgs e)
        {
            if (label1.Text.Length == 0)
                label1.Show();
        }

        private void bunifuCustomTextbox2_Enter(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void bunifuCustomTextbox2_Leave(object sender, EventArgs e)
        {
            if (label2.Text.Length == 0)
                label2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            bunifuCustomTextbox2.Focus();
        }

        private void bunifuCustomTextbox2_TextChanged_1(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
