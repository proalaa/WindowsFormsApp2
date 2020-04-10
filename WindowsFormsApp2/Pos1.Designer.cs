namespace WindowsFormsApp2
{
    partial class Pos1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.poSsTableAdapter1 = new WindowsFormsApp2._Al_Haddad_for_tradingDataSetTableAdapters.POSsTableAdapter();
            this.pos_SessionsTableAdapter1 = new WindowsFormsApp2._Al_Haddad_for_tradingDataSetTableAdapters.Pos_SessionsTableAdapter();
            this.casher1 = new WindowsFormsApp2.casher();
            this.returnPro1 = new WindowsFormsApp2.returnPro();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.casher1);
            this.panel1.Controls.Add(this.returnPro1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 798);
            this.panel1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(931, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(281, 51);
            this.button4.TabIndex = 1;
            this.button4.Text = "إرجاع منتجات";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(645, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(281, 51);
            this.button3.TabIndex = 1;
            this.button3.Text = "الفواتير ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(346, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "سحب / ايداع مبلغ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "إغلاق الصندوق";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // poSsTableAdapter1
            // 
            this.poSsTableAdapter1.ClearBeforeFill = true;
            // 
            // pos_SessionsTableAdapter1
            // 
            this.pos_SessionsTableAdapter1.ClearBeforeFill = true;
            // 
            // casher1
            // 
            this.casher1.Discount = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.casher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.casher1.Location = new System.Drawing.Point(0, 0);
            this.casher1.Name = "casher1";
            this.casher1.Size = new System.Drawing.Size(1223, 798);
            this.casher1.TabIndex = 0;
            this.casher1.Tax = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.casher1.Total = 0;
            // 
            // returnPro1
            // 
            this.returnPro1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.returnPro1.Location = new System.Drawing.Point(0, 3);
            this.returnPro1.Name = "returnPro1";
            this.returnPro1.Size = new System.Drawing.Size(1223, 663);
            this.returnPro1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(0, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1211, 55);
            this.panel2.TabIndex = 4;
            // 
            // Pos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 895);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Pos1";
            this.Text = "Pos1";
            this.Load += new System.EventHandler(this.Pos1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private casher casher1;
        private returnPro returnPro1;
        private System.Windows.Forms.Button button1;
        private _Al_Haddad_for_tradingDataSetTableAdapters.POSsTableAdapter poSsTableAdapter1;
        private _Al_Haddad_for_tradingDataSetTableAdapters.Pos_SessionsTableAdapter pos_SessionsTableAdapter1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
    }
}