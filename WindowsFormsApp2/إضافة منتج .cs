using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class إضافة_منتج : Form
    {
        _Al_Haddad_for_tradingDataSetTableAdapters.ProductsTableAdapter e;
        public إضافة_منتج()
        {
            InitializeComponent();
            var collection = new AutoCompleteStringCollection();


            e = new _Al_Haddad_for_tradingDataSetTableAdapters.ProductsTableAdapter();
            var sd = e.GetData();
            var d = sd.CreateDataReader();
            while (d.Read())
            {
                collection.Add(d.GetString(1));
            }
            bunifuCustomTextbox1.AutoCompleteCustomSource = collection;


        }
        Products products = new Products();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            إضافة_مورد NSup = new إضافة_مورد();
            NSup.Show();
        }



        private void إضافة_منتج_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.CATOGRIES' table. You can move, or remove it, as needed.
            this.cATOGRIESTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.CATOGRIES);
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.Persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.Persons);
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.Inventories' table. You can move, or remove it, as needed.
            this.inventoriesTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.Inventories);
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.Invoices' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.UNITS' table. You can move, or remove it, as needed.
            this.uNITSTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.UNITS);
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.Places' table. You can move, or remove it, as needed.
            this.placesTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.Places);
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.Inventories' table. You can move, or remove it, as needed.
            this.inventoriesTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.Inventories);
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.UNITS' table. You can move, or remove it, as needed.
            this.uNITSTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.UNITS);
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.Persons' table. You can move, or remove it, as needed.
            this.cATOGRIESTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.CATOGRIES);
            try
            {
                this.personsTableAdapter.FillBytype1(this._Al_Haddad_for_tradingDataSet.Persons);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            try

            {
                var product = new Products();
                product.NewProduct(textBox2.Text, bunifuCustomTextbox1.Text, comboBox4.SelectedValue.ToString(), comboBox3.SelectedValue.ToString(), textBox3.Text, comboBox1.SelectedValue.ToString(), null, textBox4.Text, textBox5.Text, comboBox5.SelectedValue.ToString(), comboBox2.SelectedValue.ToString(), "1", "1");
            MessageBox.Show("تم إضافة البيانات بنجاح", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (FormatException fx)
            {
                MessageBox.Show("خطا\n " + fx.Message, "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show("خطا\n " + ex.Message, "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personsTableAdapter.FillBy(this._Al_Haddad_for_tradingDataSet.Persons);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            var RanNum = rand.Next(100000, 999999).ToString() + rand.Next(000000, 999999).ToString();
            textBox2.Text = RanNum;

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_Validated(object sender, EventArgs e)
        {
            //using (var adapter = new _Al_Haddad_for_tradingDataSetTableAdapters.ProductsTableAdapter())
            //{
            //    if (!String.IsNullOrEmpty(bunifuCustomTextbox1.Text))
            //    {
            //        textBox2.Text = adapter.ScalarQuery(bunifuCustomTextbox1.Text).ToString()   ;
            //    }
            //} // it throws error when table is empty
        }

        private void fillBytype1ToolStripButton_Click(object sender, EventArgs e)
        {
           

        }
    }
}