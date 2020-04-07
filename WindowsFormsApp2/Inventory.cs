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
using System.IO;
using System.Xml;
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

        

        

    

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = productsAllnfoBindingSource;
            try
            {
                this.productsAllnfoTableAdapter.FillByType1(this._Al_Haddad_for_tradingDataSet1.productsAllnfo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = productsAllnfoBindingSource;
            try
            {
                this.productsAllnfoTableAdapter.FillByType2(this._Al_Haddad_for_tradingDataSet1.productsAllnfo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
         //   dataGridView1.DataSource = productsAllnfoBindingSource;
            try
            {
                this.productsAllnfoTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet1.productsAllnfo);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void bunifuCustomTextbox1_TextChanged_1(object sender, EventArgs e)
        {
            productsAllnfoBindingSource.Filter = "[اسم المنتج] LIKE'%"+bunifuCustomTextbox1.Text+"%'";
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            /* using (DataTable dataTable = new DataTable())
             {
                 if (bunifuCustomTextbox1.Text != null)
                 {
                     MessageBox.Show(((long)int.Parse(bunifuCustomTextbox1.Text)).ToString());
                     dataTable.Rows.Add();
                     //dataGridView1.DataSource = dataTable;
                 }
             } */
            try
            {
                //DataTable dataTable = new DataTable();
                
                //var b = (DataSet)productsAllnfoBindingSource.DataSource;
                //DataSet dataSet = new DataSet();
                
                //foreach(DataRow row in b.Tables[0].Rows)
                //{
                //    if(row.Field<string>(1).Equals(bunifuCustomTextbox1.Text))
                //    {
                //        dataTable.ImportRow(row); 
                //    }
                //}
                //dataSet.Tables.Add(dataTable);
                //productsAllnfoBindingSource.DataSource = dataSet;
                //productsAllnfoBindingSource.ResetBindings(true);
                //f.Rows.Add(b.Rows.Find(dataGridView1.Rows[0].Cells[0].Value));
                //productsAllnfoBindingSource.DataSource = f;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productsAllnfoBindingSource;
            try
            {
                this.productsAllnfoTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet1.productsAllnfo);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
