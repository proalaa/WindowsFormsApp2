namespace WindowsFormsApp2
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Al_Haddad_for_tradingDataSet = new WindowsFormsApp2._Al_Haddad_for_tradingDataSet();
            this.productsTableAdapter = new WindowsFormsApp2._Al_Haddad_for_tradingDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2._Al_Haddad_for_tradingDataSetTableAdapters.TableAdapterManager();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Al_Haddad_for_tradingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(300, 30);
            this.tabControl1.Location = new System.Drawing.Point(-1, 251);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1237, 541);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1229, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "المبيعات";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1229, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "المشتريات";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this._Al_Haddad_for_tradingDataSet;
            // 
            // _Al_Haddad_for_tradingDataSet
            // 
            this._Al_Haddad_for_tradingDataSet.DataSetName = "_Al_Haddad_for_tradingDataSet";
            this._Al_Haddad_for_tradingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATOGRIESTableAdapter = null;
            this.tableAdapterManager.DeptsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.InventoriesTableAdapter = null;
            this.tableAdapterManager.Invoice_ProductsTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.Money_OutTableAdapter = null;
            this.tableAdapterManager.PersonsTableAdapter = null;
            this.tableAdapterManager.PlacesTableAdapter = null;
            this.tableAdapterManager.Pos_SessionsTableAdapter = null;
            this.tableAdapterManager.POSsTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UNITSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2._Al_Haddad_for_tradingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1239, 806);
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Al_Haddad_for_tradingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private _Al_Haddad_for_tradingDataSet _Al_Haddad_for_tradingDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private _Al_Haddad_for_tradingDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private _Al_Haddad_for_tradingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
