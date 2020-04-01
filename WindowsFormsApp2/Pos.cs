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
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                    pos_SessionsTableAdapter.InsertQuery(1,DateTime.UtcNow);

                    Pos1 pos = new Pos1();
                    pos.Show();
                
                label1.Text = "مفتوح";
                label1.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ/n" + ex.Message, "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
