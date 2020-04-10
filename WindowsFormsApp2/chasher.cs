using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using FastMember;

namespace WindowsFormsApp2
{
   
    public partial class casher : UserControl
    {
        DataTable Dt = new DataTable();
        List<ProductDTO> productList;
        public int Total { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public casher()
        {
            InitializeComponent();
            
            Total = 0;
            this.productsAllnfoTableAdapter.Fill(this._Al_Haddad_for_tradingDataSet1.productsAllnfo);
            productList = new List<ProductDTO>();
        }
        
        private void casher_Load(object sender, EventArgs e)
        {
           
        }
        private void RefAutCom()
        {
            var AutCom = new AutoCompleteStringCollection();
            using (var en = new Entities1())
            {
                var query = from dt in en.Persons
                            where dt.Type == false
                            select dt;
                foreach (var ed in query)
                {
                    AutCom.Add(ed.Name.ToString());
                }

            }
            textBox1.AutoCompleteCustomSource = AutCom;
        }
        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Dt = new DataTable();

                var SKU = Convert.ToInt64(maskedTextBox1.Text);
                ProductDTO productDTo = new ProductDTO();
                productList.AddRange(productDTo.GetProducts(SKU));
                using (var reader = ObjectReader.Create(productList)) //fast_memeber lib
                {
                    Dt.Load(reader);
                }
                DataView view = new DataView(Dt);
                var dt2 = view.ToTable(true, "SKU", "اسم_المنتج", "الكمية", "الوحده", "سعر_الشراء", "السعر_المقترح", "السعر_النهائي");
                dataGridView1.DataSource = dt2;

                for (int i = 0; i < 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } // need improvment in next version
        private void GetTotal()
        {
            if (dataGridView1.Rows.Count > 1)
            {
                Total = 0;
                foreach (DataGridViewRow Row in dataGridView1.Rows)
                {
                    var f = Convert.ToInt32(Row.Cells[6].Value);
                    Total += f;

                }
                label1.Text = Total.ToString();
                label4.Text = Total.ToString();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
           var d = Convert.ToInt64(e.Row.Cells["SKU"].Value);
            productList.RemoveAll(a => a.SKU == d);
            GetTotal();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GetTotal();
            
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            GetTotal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            إضافة_عميل cus = new إضافة_عميل();
            cus.Show();
            if(cus.DoReload)
            {
                RefAutCom();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
