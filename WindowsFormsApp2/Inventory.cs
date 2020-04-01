using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeepAutomation.Barcode.Bean;
using Aspose.BarCode.Generation;

namespace WindowsFormsApp2
{
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();
        }
        /*  BarCode code128 = new BarCode();
            code128.Symbology = KeepAutomation.Barcode.Symbology.EAN8;
            code128.CodeToEncode = "128128128";
            code128.generateBarcodeToImageFile(@"F:\marwan\code125.png");*/ //barcode image generator
        private void button1_Click(object sender, EventArgs e)
        {

          
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            إضافة_منتج NProd = new إضافة_منتج();
            NProd.Show();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByType1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillByType1(this._Al_Haddad_for_tradingDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillByType2(this._Al_Haddad_for_tradingDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByType1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillByType1(this._Al_Haddad_for_tradingDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByType2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillByType2(this._Al_Haddad_for_tradingDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByType1ToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillByType1(this._Al_Haddad_for_tradingDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByType1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillByType1(this._Al_Haddad_for_tradingDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByType2ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillByType2(this._Al_Haddad_for_tradingDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByType1ToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillByType1(this._Al_Haddad_for_tradingDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByType2ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillByType2(this._Al_Haddad_for_tradingDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productsBindingSource;
            try
            {
                this.productsTableAdapter.FillByType1(this._Al_Haddad_for_tradingDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productsBindingSource;
            try
            {
                this.productsTableAdapter.FillByType2(this._Al_Haddad_for_tradingDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productsBindingSource;
            try
            {
                this.productsTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet.Products);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuCustomTextbox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            using (DataTable dataTable = new DataTable())
            {
                if (bunifuCustomTextbox1.Text != null)
                {
                    MessageBox.Show(((long)int.Parse(bunifuCustomTextbox1.Text)).ToString());
                    dataTable.Rows.Add();
                    dataGridView1.DataSource = dataTable;
                }
            } 

        }
    }
}
