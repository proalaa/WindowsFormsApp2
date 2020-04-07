namespace WindowsFormsApp2
{
    partial class إضافة_منتج
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cATOGRIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Al_Haddad_for_tradingDataSet = new WindowsFormsApp2._Al_Haddad_for_tradingDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.personsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alHaddadfortradingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.uNITSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.inventoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.placesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placesTableAdapter = new WindowsFormsApp2._Al_Haddad_for_tradingDataSetTableAdapters.PlacesTableAdapter();
            this.queriesTableAdapter1 = new WindowsFormsApp2._Al_Haddad_for_tradingDataSetTableAdapters.QueriesTableAdapter();
            this.uNITSTableAdapter = new WindowsFormsApp2._Al_Haddad_for_tradingDataSetTableAdapters.UNITSTableAdapter();
            this.inventoriesTableAdapter = new WindowsFormsApp2._Al_Haddad_for_tradingDataSetTableAdapters.InventoriesTableAdapter();
            this.alHaddadfortradingDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new WindowsFormsApp2._Al_Haddad_for_tradingDataSetTableAdapters.PersonsTableAdapter();
            this.fillBytype1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBytype1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cATOGRIESTableAdapter = new WindowsFormsApp2._Al_Haddad_for_tradingDataSetTableAdapters.CATOGRIESTableAdapter();
            this.fKInvoicesPersons1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new WindowsFormsApp2._Al_Haddad_for_tradingDataSetTableAdapters.InvoicesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cATOGRIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Al_Haddad_for_tradingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alHaddadfortradingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alHaddadfortradingDataSetBindingSource1)).BeginInit();
            this.fillBytype1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvoicesPersons1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(621, 41);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "إسم المنتج";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 106);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "رمز الباركود";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(349, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 28);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(621, 171);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "إسم المورد";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 42);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "الصنف";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "توليد رمز باركود";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "إضافة مورد";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 298);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "الكمية";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(488, 298);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 28);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 240);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "سعر البيع";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(382, 242);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(221, 28);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(613, 243);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "سعر التكلفة";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(28, 242);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(244, 28);
            this.textBox5.TabIndex = 1;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(416, 301);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "الوحدة";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(192, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 49);
            this.button3.TabIndex = 8;
            this.button3.Text = "حفظ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(46, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 49);
            this.button4.TabIndex = 8;
            this.button4.Text = "إلغاء الامر";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bunifuCustomTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(318, 41);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(285, 28);
            this.bunifuCustomTextbox1.TabIndex = 9;
            this.bunifuCustomTextbox1.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            this.bunifuCustomTextbox1.Validated += new System.EventHandler(this.bunifuCustomTextbox1_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(192, 301);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "المخزن";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(613, 351);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "مكان التخزين";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cATOGRIESBindingSource, "ID", true));
            this.comboBox1.DataSource = this.cATOGRIESBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 30);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "ID";
            // 
            // cATOGRIESBindingSource
            // 
            this.cATOGRIESBindingSource.DataMember = "CATOGRIES";
            this.cATOGRIESBindingSource.DataSource = this._Al_Haddad_for_tradingDataSet;
            // 
            // _Al_Haddad_for_tradingDataSet
            // 
            this._Al_Haddad_for_tradingDataSet.DataSetName = "_Al_Haddad_for_tradingDataSet";
            this._Al_Haddad_for_tradingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personsBindingSource1, "ID", true));
            this.comboBox2.DataSource = this.personsBindingSource1;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(349, 175);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(254, 30);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "ID";
            // 
            // personsBindingSource1
            // 
            this.personsBindingSource1.DataMember = "Persons";
            this.personsBindingSource1.DataSource = this._Al_Haddad_for_tradingDataSet;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this._Al_Haddad_for_tradingDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uNITSBindingSource, "ID", true));
            this.comboBox3.DataSource = this.uNITSBindingSource;
            this.comboBox3.DisplayMember = "NAME";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(258, 301);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 30);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.ValueMember = "ID";
            // 
            // uNITSBindingSource
            // 
            this.uNITSBindingSource.DataMember = "UNITS";
            this.uNITSBindingSource.DataSource = this._Al_Haddad_for_tradingDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inventoriesBindingSource, "ID", true));
            this.comboBox4.DataSource = this.inventoriesBindingSource;
            this.comboBox4.DisplayMember = "Name";
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(12, 301);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(174, 30);
            this.comboBox4.TabIndex = 19;
            this.comboBox4.ValueMember = "ID";
            // 
            // inventoriesBindingSource
            // 
            this.inventoriesBindingSource.DataMember = "Inventories";
            this.inventoriesBindingSource.DataSource = this._Al_Haddad_for_tradingDataSet;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.placesBindingSource, "Place_Id", true));
            this.comboBox5.DataSource = this.placesBindingSource;
            this.comboBox5.DisplayMember = "Name";
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(382, 351);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(225, 30);
            this.comboBox5.TabIndex = 20;
            this.comboBox5.ValueMember = "Place_Id";
            // 
            // placesBindingSource
            // 
            this.placesBindingSource.DataMember = "Places";
            this.placesBindingSource.DataSource = this._Al_Haddad_for_tradingDataSet;
            // 
            // placesTableAdapter
            // 
            this.placesTableAdapter.ClearBeforeFill = true;
            // 
            // uNITSTableAdapter
            // 
            this.uNITSTableAdapter.ClearBeforeFill = true;
            // 
            // inventoriesTableAdapter
            // 
            this.inventoriesTableAdapter.ClearBeforeFill = true;
            // 
            // alHaddadfortradingDataSetBindingSource1
            // 
            this.alHaddadfortradingDataSetBindingSource1.DataSource = this._Al_Haddad_for_tradingDataSet;
            this.alHaddadfortradingDataSetBindingSource1.Position = 0;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // fillBytype1ToolStrip
            // 
            this.fillBytype1ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBytype1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBytype1ToolStripButton});
            this.fillBytype1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBytype1ToolStrip.Name = "fillBytype1ToolStrip";
            this.fillBytype1ToolStrip.Size = new System.Drawing.Size(732, 27);
            this.fillBytype1ToolStrip.TabIndex = 21;
            this.fillBytype1ToolStrip.Text = "fillBytype1ToolStrip";
            // 
            // fillBytype1ToolStripButton
            // 
            this.fillBytype1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBytype1ToolStripButton.Name = "fillBytype1ToolStripButton";
            this.fillBytype1ToolStripButton.Size = new System.Drawing.Size(85, 24);
            this.fillBytype1ToolStripButton.Text = "FillBytype1";
            this.fillBytype1ToolStripButton.Click += new System.EventHandler(this.fillBytype1ToolStripButton_Click);
            // 
            // cATOGRIESTableAdapter
            // 
            this.cATOGRIESTableAdapter.ClearBeforeFill = true;
            // 
            // fKInvoicesPersons1BindingSource
            // 
            this.fKInvoicesPersons1BindingSource.DataMember = "FK_Invoices_Persons1";
            this.fKInvoicesPersons1BindingSource.DataSource = this.personsBindingSource1;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // إضافة_منتج
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 489);
            this.Controls.Add(this.fillBytype1ToolStrip);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bunifuCustomTextbox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "إضافة_منتج";
            this.Text = "إضافة_منتج";
            this.Load += new System.EventHandler(this.إضافة_منتج_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cATOGRIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Al_Haddad_for_tradingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alHaddadfortradingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alHaddadfortradingDataSetBindingSource1)).EndInit();
            this.fillBytype1ToolStrip.ResumeLayout(false);
            this.fillBytype1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvoicesPersons1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.BindingSource alHaddadfortradingDataSetBindingSource;
        private _Al_Haddad_for_tradingDataSetTableAdapters.PlacesTableAdapter placesTableAdapter;
        private _Al_Haddad_for_tradingDataSet _Al_Haddad_for_tradingDataSet;
        private _Al_Haddad_for_tradingDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.BindingSource placesBindingSource;
        private System.Windows.Forms.BindingSource uNITSBindingSource;
        private _Al_Haddad_for_tradingDataSetTableAdapters.UNITSTableAdapter uNITSTableAdapter;
        private System.Windows.Forms.BindingSource inventoriesBindingSource;
        private _Al_Haddad_for_tradingDataSetTableAdapters.InventoriesTableAdapter inventoriesTableAdapter;
        private System.Windows.Forms.BindingSource alHaddadfortradingDataSetBindingSource1;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private _Al_Haddad_for_tradingDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.ToolStrip fillBytype1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBytype1ToolStripButton;
        private System.Windows.Forms.BindingSource cATOGRIESBindingSource;
        private _Al_Haddad_for_tradingDataSetTableAdapters.CATOGRIESTableAdapter cATOGRIESTableAdapter;
        private System.Windows.Forms.BindingSource personsBindingSource1;
        private System.Windows.Forms.BindingSource fKInvoicesPersons1BindingSource;
        private _Al_Haddad_for_tradingDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
    }
}