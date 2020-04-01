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
    public partial class إضافة_مورد : Form
    {
        public إضافة_مورد()
        {
            InitializeComponent();
        }

        private void إضافة_مورد_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.CATOGRIES' table. You can move, or remove it, as needed.
            this.cATOGRIESTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.CATOGRIES);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var row = _Al_Haddad_for_tradingDataSet.Persons.NewPersonsRow();
                row["Name"] = bunifuCustomTextbox1.Text;
                row["Phone_Number"] = textBox2.Text;
                row["Email"] = textBox5.Text;
                row["Debt_id"] = DBNull.Value;
                row["Location"] = textBox1.Text;
                row["Type"] = 1;
                _Al_Haddad_for_tradingDataSet.Persons.AddPersonsRow(row);
                var adapter = new _Al_Haddad_for_tradingDataSetTableAdapters.PersonsTableAdapter();
                var result = adapter.Update(row);
                MessageBox.Show(result.ToString());
                MessageBox.Show("تم إضافة البيانات بنجاح", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا\n " + ex.Message, "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        } 
    }
}
