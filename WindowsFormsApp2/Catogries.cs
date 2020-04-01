using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Catogries : Form
    {
        public Catogries()
        {
            InitializeComponent();
        }

        private void cATOGRIESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cATOGRIESBindingSource.EndEdit();

        }

        private void Catogries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.CATOGRIES' table. You can move, or remove it, as needed.

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
