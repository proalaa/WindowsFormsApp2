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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Al_Haddad_for_tradingDataSet = new WindowsFormsApp2._Al_Haddad_for_tradingDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bunifuCircleProgressbar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar3 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar4 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
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
            // bunifuCircleProgressbar2
            // 
            this.bunifuCircleProgressbar2.animated = false;
            this.bunifuCircleProgressbar2.animationIterval = 5;
            this.bunifuCircleProgressbar2.animationSpeed = 300;
            this.bunifuCircleProgressbar2.BackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar2.BackgroundImage")));
            this.bunifuCircleProgressbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCircleProgressbar2.LabelVisible = true;
            this.bunifuCircleProgressbar2.LineProgressThickness = 8;
            this.bunifuCircleProgressbar2.LineThickness = 5;
            this.bunifuCircleProgressbar2.Location = new System.Drawing.Point(400, 9);
            this.bunifuCircleProgressbar2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar2.MaxValue = 100;
            this.bunifuCircleProgressbar2.Name = "bunifuCircleProgressbar2";
            this.bunifuCircleProgressbar2.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar2.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar2.Size = new System.Drawing.Size(201, 201);
            this.bunifuCircleProgressbar2.TabIndex = 0;
            this.bunifuCircleProgressbar2.Value = 0;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(115, 9);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(201, 201);
            this.bunifuCircleProgressbar1.TabIndex = 0;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // bunifuCircleProgressbar3
            // 
            this.bunifuCircleProgressbar3.animated = false;
            this.bunifuCircleProgressbar3.animationIterval = 5;
            this.bunifuCircleProgressbar3.animationSpeed = 300;
            this.bunifuCircleProgressbar3.BackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar3.BackgroundImage")));
            this.bunifuCircleProgressbar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCircleProgressbar3.LabelVisible = true;
            this.bunifuCircleProgressbar3.LineProgressThickness = 8;
            this.bunifuCircleProgressbar3.LineThickness = 5;
            this.bunifuCircleProgressbar3.Location = new System.Drawing.Point(933, 9);
            this.bunifuCircleProgressbar3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar3.MaxValue = 100;
            this.bunifuCircleProgressbar3.Name = "bunifuCircleProgressbar3";
            this.bunifuCircleProgressbar3.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar3.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar3.Size = new System.Drawing.Size(201, 201);
            this.bunifuCircleProgressbar3.TabIndex = 0;
            this.bunifuCircleProgressbar3.Value = 0;
            // 
            // bunifuCircleProgressbar4
            // 
            this.bunifuCircleProgressbar4.animated = true;
            this.bunifuCircleProgressbar4.animationIterval = 1;
            this.bunifuCircleProgressbar4.animationSpeed = 1;
            this.bunifuCircleProgressbar4.BackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar4.BackgroundImage")));
            this.bunifuCircleProgressbar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuCircleProgressbar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCircleProgressbar4.LabelVisible = true;
            this.bunifuCircleProgressbar4.LineProgressThickness = 8;
            this.bunifuCircleProgressbar4.LineThickness = 5;
            this.bunifuCircleProgressbar4.Location = new System.Drawing.Point(664, 9);
            this.bunifuCircleProgressbar4.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar4.MaxValue = 100;
            this.bunifuCircleProgressbar4.Name = "bunifuCircleProgressbar4";
            this.bunifuCircleProgressbar4.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar4.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar4.Size = new System.Drawing.Size(201, 201);
            this.bunifuCircleProgressbar4.TabIndex = 0;
            this.bunifuCircleProgressbar4.Value = 20;
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
            this.Controls.Add(this.bunifuCircleProgressbar4);
            this.Controls.Add(this.bunifuCircleProgressbar3);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.bunifuCircleProgressbar2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1239, 792);
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
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar4;
        private _Al_Haddad_for_tradingDataSet _Al_Haddad_for_tradingDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private _Al_Haddad_for_tradingDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private _Al_Haddad_for_tradingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
