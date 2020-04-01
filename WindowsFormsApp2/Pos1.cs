using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Pos1 : Form
    {
        bool flag = false;
        public Pos1()
        {
            InitializeComponent();
            casher1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                returnPro1.BringToFront();
                bunifuFlatButton1.Text = "صندوق البيع";
                flag = true;
            }
            else
            {
                casher1.BringToFront();
                bunifuFlatButton1.Text = "إرجاع منتجات";
                flag = false;
            }


        }
    }
}
