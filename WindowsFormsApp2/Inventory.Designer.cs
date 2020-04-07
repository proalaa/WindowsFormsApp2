namespace WindowsFormsApp2
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.اسمالمنتجDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.سعرالشراءDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.سعرالبيعDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الوحدهDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الصنفDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.المكانDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.المخزنDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsAllnfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Al_Haddad_for_tradingDataSet1 = new WindowsFormsApp2._Al_Haddad_for_tradingDataSet1();
            this.productsAllnfoTableAdapter = new WindowsFormsApp2._Al_Haddad_for_tradingDataSet1TableAdapters.productsAllnfoTableAdapter();
            this.productsAllnfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsAllnfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Al_Haddad_for_tradingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsAllnfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(179)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "إضافة منتج";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(734, 58);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(179)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(163, 59);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "إضافة منتج";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(179)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 5;
            this.bunifuFlatButton2.ButtonText = "استيراد اكسل";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Enabled = false;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(469, 58);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(179)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(161, 59);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "استيراد اكسل";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(179)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 5;
            this.bunifuFlatButton3.ButtonText = "تصدير اكسل";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Enabled = false;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(303, 58);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(179)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(158, 59);
            this.bunifuFlatButton3.TabIndex = 2;
            this.bunifuFlatButton3.Text = "تصدير اكسل";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuFlatButton3);
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 178);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(720, 66);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(163, 31);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "ادخل اسم المنتج:";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1041, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "الكترونيات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(918, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "ادوات منزلية";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1151, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "الكل ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(225, 67);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(489, 30);
            this.bunifuCustomTextbox1.TabIndex = 11;
            this.bunifuCustomTextbox1.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.bunifuCustomTextbox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Location = new System.Drawing.Point(0, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1256, 601);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sKUDataGridViewTextBoxColumn,
            this.اسمالمنتجDataGridViewTextBoxColumn,
            this.سعرالشراءDataGridViewTextBoxColumn,
            this.سعرالبيعDataGridViewTextBoxColumn,
            this.الوحدهDataGridViewTextBoxColumn,
            this.الصنفDataGridViewTextBoxColumn,
            this.المكانDataGridViewTextBoxColumn,
            this.المخزنDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsAllnfoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1256, 481);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sKUDataGridViewTextBoxColumn
            // 
            this.sKUDataGridViewTextBoxColumn.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sKUDataGridViewTextBoxColumn.Name = "sKUDataGridViewTextBoxColumn";
            this.sKUDataGridViewTextBoxColumn.Width = 125;
            // 
            // اسمالمنتجDataGridViewTextBoxColumn
            // 
            this.اسمالمنتجDataGridViewTextBoxColumn.DataPropertyName = "اسم المنتج";
            this.اسمالمنتجDataGridViewTextBoxColumn.HeaderText = "اسم المنتج";
            this.اسمالمنتجDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.اسمالمنتجDataGridViewTextBoxColumn.Name = "اسمالمنتجDataGridViewTextBoxColumn";
            this.اسمالمنتجDataGridViewTextBoxColumn.Width = 125;
            // 
            // سعرالشراءDataGridViewTextBoxColumn
            // 
            this.سعرالشراءDataGridViewTextBoxColumn.DataPropertyName = "سعر الشراء";
            this.سعرالشراءDataGridViewTextBoxColumn.HeaderText = "سعر الشراء";
            this.سعرالشراءDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.سعرالشراءDataGridViewTextBoxColumn.Name = "سعرالشراءDataGridViewTextBoxColumn";
            this.سعرالشراءDataGridViewTextBoxColumn.Width = 125;
            // 
            // سعرالبيعDataGridViewTextBoxColumn
            // 
            this.سعرالبيعDataGridViewTextBoxColumn.DataPropertyName = "سعر البيع";
            this.سعرالبيعDataGridViewTextBoxColumn.HeaderText = "سعر البيع";
            this.سعرالبيعDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.سعرالبيعDataGridViewTextBoxColumn.Name = "سعرالبيعDataGridViewTextBoxColumn";
            this.سعرالبيعDataGridViewTextBoxColumn.Width = 125;
            // 
            // الوحدهDataGridViewTextBoxColumn
            // 
            this.الوحدهDataGridViewTextBoxColumn.DataPropertyName = "الوحده";
            this.الوحدهDataGridViewTextBoxColumn.HeaderText = "الوحده";
            this.الوحدهDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.الوحدهDataGridViewTextBoxColumn.Name = "الوحدهDataGridViewTextBoxColumn";
            this.الوحدهDataGridViewTextBoxColumn.Width = 125;
            // 
            // الصنفDataGridViewTextBoxColumn
            // 
            this.الصنفDataGridViewTextBoxColumn.DataPropertyName = "الصنف";
            this.الصنفDataGridViewTextBoxColumn.HeaderText = "الصنف";
            this.الصنفDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.الصنفDataGridViewTextBoxColumn.Name = "الصنفDataGridViewTextBoxColumn";
            this.الصنفDataGridViewTextBoxColumn.Width = 125;
            // 
            // المكانDataGridViewTextBoxColumn
            // 
            this.المكانDataGridViewTextBoxColumn.DataPropertyName = "المكان";
            this.المكانDataGridViewTextBoxColumn.HeaderText = "المكان";
            this.المكانDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.المكانDataGridViewTextBoxColumn.Name = "المكانDataGridViewTextBoxColumn";
            this.المكانDataGridViewTextBoxColumn.Width = 125;
            // 
            // المخزنDataGridViewTextBoxColumn
            // 
            this.المخزنDataGridViewTextBoxColumn.DataPropertyName = "المخزن";
            this.المخزنDataGridViewTextBoxColumn.HeaderText = "المخزن";
            this.المخزنDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.المخزنDataGridViewTextBoxColumn.Name = "المخزنDataGridViewTextBoxColumn";
            this.المخزنDataGridViewTextBoxColumn.Width = 125;
            // 
            // productsAllnfoBindingSource
            // 
            this.productsAllnfoBindingSource.DataMember = "productsAllnfo";
            this.productsAllnfoBindingSource.DataSource = this._Al_Haddad_for_tradingDataSet1;
            // 
            // _Al_Haddad_for_tradingDataSet1
            // 
            this._Al_Haddad_for_tradingDataSet1.DataSetName = "_Al_Haddad_for_tradingDataSet1";
            this._Al_Haddad_for_tradingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsAllnfoTableAdapter
            // 
            this.productsAllnfoTableAdapter.ClearBeforeFill = true;
            // 
            // productsAllnfoBindingSource1
            // 
            this.productsAllnfoBindingSource1.DataMember = "productsAllnfo";
            this.productsAllnfoBindingSource1.DataSource = this._Al_Haddad_for_tradingDataSet1;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(1239, 803);
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsAllnfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Al_Haddad_for_tradingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsAllnfoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource productsAllnfoBindingSource;
        private _Al_Haddad_for_tradingDataSet1 _Al_Haddad_for_tradingDataSet1;
        private _Al_Haddad_for_tradingDataSet1TableAdapters.productsAllnfoTableAdapter productsAllnfoTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn اسمالمنتجDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn سعرالشراءDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn سعرالبيعDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الوحدهDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الكميةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الصنفDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn المكانDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الموردDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn المخزنDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productsAllnfoBindingSource1;
    }
}
