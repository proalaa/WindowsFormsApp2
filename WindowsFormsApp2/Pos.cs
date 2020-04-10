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
    public partial class Pos : UserControl
    {
        public Pos()
        {
            InitializeComponent();
            StatusChecker();
        }

        private  void StatusChecker()
        {
            
            if ((bool)poSsTableAdapter1.ActiveQuery(1))
            {
                label1.Text = "مفتوح";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "مغلق";
                label1.ForeColor = Color.Red;
            }
        }
        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int session  ;
            try
            {
                
                if (!(bool)poSsTableAdapter1.ActiveQuery(1))
                {
                    poSsTableAdapter1.UpdateQuery(true, 1);
                }
                else
                {
                    session = pos_SessionsTableAdapter.InsertQuery(1, DateTime.UtcNow);
                }

                Pos1 pos = new Pos1();
                pos.Show();

                StatusChecker();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ/n" + ex.Message, "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pos_Enter(object sender, EventArgs e)
        {
            StatusChecker();
        }

        private void Pos_Load(object sender, EventArgs e)
        {

        }

        private void Pos_Validated(object sender, EventArgs e)
        {
            StatusChecker();

        }

        private void Pos_Validating(object sender, CancelEventArgs e)
        {
            StatusChecker();
        }

       
    }
}
