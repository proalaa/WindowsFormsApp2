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
        public int Pos_Session { get; set; }
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {


        }
      
        

        private void button4_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                returnPro1.BringToFront();
                button4.Text = "صندوق البيع";
                flag = true;
            }
            else
            {
                casher1.BringToFront();
                button4.Text = "إرجاع منتجات";
                flag = false;
            }
        }
          




       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("ستفقد بياناتك في حال الاغلاق \n هل انت حقا متامد من هذه الخطوه", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                poSsTableAdapter1.UpdateQuery(false, 1);
                this.Close();
                pos_SessionsTableAdapter1.EndSession(DateTime.UtcNow);
            }
        }

        private void Pos1_Load(object sender, EventArgs e)
        {

        }
    }
}
