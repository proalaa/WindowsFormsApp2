namespace WindowsFormsApp2
{
    partial class Catogries
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
            System.Windows.Forms.Label nameLabel;
            this.cATOGRIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATOGRIESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cATOGRIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATOGRIESBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // _Al_Haddad_for_tradingDataSet
            // 
            // 
            // cATOGRIESBindingSource
            // 
            this.cATOGRIESBindingSource.DataMember = "CATOGRIES";
            // 
            // cATOGRIESBindingSource1
            // 
            this.cATOGRIESBindingSource1.DataMember = "CATOGRIES";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(40, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cATOGRIESBindingSource1, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(95, 62);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(323, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Catogries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Catogries";
            this.Text = "Catogries";
            this.Load += new System.EventHandler(this.Catogries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cATOGRIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATOGRIESBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cATOGRIESBindingSource;
        private System.Windows.Forms.BindingSource cATOGRIESBindingSource1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button1;
    }
}