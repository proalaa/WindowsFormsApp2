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
    public partial class returnPro : UserControl
    {
        public returnPro()
        {
            InitializeComponent();
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            bunifuCustomTextbox1.Focus();
        }

        private void bunifuCustomTextbox1_Enter(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void bunifuCustomTextbox1_Leave(object sender, EventArgs e)
        {
            if (label1.Text.Length == 0) 
                label1.Show();
        }
    }
}
