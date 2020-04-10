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
    public partial class إضافة_عميل : Form
    {
        public إضافة_عميل()
        {
            InitializeComponent();
            DoReload = false;
        }
        public bool DoReload;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var cmx = new Entities1())
            {
                var PhoneNumber =  Convert.ToInt64(textBox1.Text);
                var d = new Person() { Name = textBox2.Text, Phone_Number = PhoneNumber, Email = textBox3.Text, Type = false };
                cmx.Persons.Add(d);
                if (cmx.SaveChanges() == 1) { 
                    MessageBox.Show("تم اضافة عميل بنجاح");
                    DoReload = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
