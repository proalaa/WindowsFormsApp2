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
    public partial class إضافة_منتج : Form
    {
        public إضافة_منتج()
        {
            InitializeComponent();
            
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
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.Places' table. You can move, or remove it, as needed.
            this.placesTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.Places);
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.Inventories' table. You can move, or remove it, as needed.
            this.inventoriesTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.Inventories);
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.UNITS' table. You can move, or remove it, as needed.
            this.uNITSTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.UNITS);
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.Persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.Persons);
            // TODO: This line of code loads data into the '_Al_Haddad_for_tradingDataSet.CATOGRIES' table. You can move, or remove it, as needed.
            this.cATOGRIESTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.CATOGRIES);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                _Al_Haddad_for_tradingDataSet.ProductsRow dataRow = _Al_Haddad_for_tradingDataSet.Products.NewProductsRow();
                
                dataRow["Sku"] = textBox2.Text;
                dataRow["Name"] = bunifuCustomTextbox1.Text;
                dataRow["Inv_id"] = comboBox4.SelectedValue;
                dataRow["unit"] = comboBox3.SelectedValue;
                dataRow["Quantity"] = textBox3.Text;
                dataRow["Catogrey_id"] = comboBox1.SelectedValue;
                dataRow["Sup_id"] = comboBox2.SelectedValue;
                dataRow["Description"] = null;
                dataRow["SPrice"] = textBox4.Text;
                dataRow["BPrice"] = textBox5.Text;
                dataRow["Tax"] = 0;
                dataRow["Place_id"] = comboBox5.SelectedValue;
                _Al_Haddad_for_tradingDataSet.Products.AddProductsRow(dataRow);
                MessageBox.Show("تم إضافة البيانات بنجاح", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Al_Haddad_for_tradingDataSetTableAdapters.ProductsTableAdapter productsTable = new _Al_Haddad_for_tradingDataSetTableAdapters.ProductsTableAdapter();
                productsTable.Adapter.Update(_Al_Haddad_for_tradingDataSet.Products);
                
                
            }
            catch(Exception ex)
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
    }
    }

