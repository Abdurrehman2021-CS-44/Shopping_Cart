
namespace shoppingCartApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnUpd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal3 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblPrice3 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.txtQuantity1 = new System.Windows.Forms.TextBox();
            this.txtQuantity3 = new System.Windows.Forms.TextBox();
            this.txtQuantity2 = new System.Windows.Forms.TextBox();
            this.lblProduct3 = new System.Windows.Forms.Label();
            this.lblProduct2 = new System.Windows.Forms.Label();
            this.lblProduct1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "Discription                  Quantity                  Price                 Tota" +
                "l"});
            this.listBox1.Location = new System.Drawing.Point(19, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(531, 24);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Items.AddRange(new object[] {
            "                                                                    Total :"});
            this.listBox2.Location = new System.Drawing.Point(19, 223);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(531, 24);
            this.listBox2.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 37);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Shopping Cart";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.DimGray;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal.Location = new System.Drawing.Point(427, 227);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 17);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "0.00 Rs.";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click_1);
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpd.Location = new System.Drawing.Point(19, 263);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(75, 23);
            this.btnUpd.TabIndex = 22;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(463, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Generate Bill";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.lblTotal3);
            this.panel1.Controls.Add(this.lblTotal2);
            this.panel1.Controls.Add(this.lblTotal1);
            this.panel1.Controls.Add(this.lblPrice3);
            this.panel1.Controls.Add(this.lblPrice2);
            this.panel1.Controls.Add(this.lblPrice1);
            this.panel1.Controls.Add(this.txtQuantity1);
            this.panel1.Controls.Add(this.txtQuantity3);
            this.panel1.Controls.Add(this.txtQuantity2);
            this.panel1.Controls.Add(this.lblProduct3);
            this.panel1.Controls.Add(this.lblProduct2);
            this.panel1.Controls.Add(this.lblProduct1);
            this.panel1.Location = new System.Drawing.Point(19, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 123);
            this.panel1.TabIndex = 24;
            // 
            // lblTotal3
            // 
            this.lblTotal3.AutoSize = true;
            this.lblTotal3.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal3.Location = new System.Drawing.Point(456, 88);
            this.lblTotal3.Name = "lblTotal3";
            this.lblTotal3.Size = new System.Drawing.Size(68, 17);
            this.lblTotal3.TabIndex = 32;
            this.lblTotal3.Text = "0.00 Rs.";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal2.Location = new System.Drawing.Point(456, 54);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(68, 17);
            this.lblTotal2.TabIndex = 31;
            this.lblTotal2.Text = "0.00 Rs.";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal1.Location = new System.Drawing.Point(456, 19);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(68, 17);
            this.lblTotal1.TabIndex = 30;
            this.lblTotal1.Text = "0.00 Rs.";
            // 
            // lblPrice3
            // 
            this.lblPrice3.AutoSize = true;
            this.lblPrice3.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrice3.Location = new System.Drawing.Point(323, 87);
            this.lblPrice3.Name = "lblPrice3";
            this.lblPrice3.Size = new System.Drawing.Size(72, 17);
            this.lblPrice3.TabIndex = 29;
            this.lblPrice3.Text = "1700 Rs.";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrice2.Location = new System.Drawing.Point(323, 53);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(72, 17);
            this.lblPrice2.TabIndex = 28;
            this.lblPrice2.Text = "4000 Rs.";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrice1.Location = new System.Drawing.Point(323, 18);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(72, 17);
            this.lblPrice1.TabIndex = 27;
            this.lblPrice1.Text = "1300 Rs.";
            // 
            // txtQuantity1
            // 
            this.txtQuantity1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity1.Location = new System.Drawing.Point(160, 19);
            this.txtQuantity1.Name = "txtQuantity1";
            this.txtQuantity1.Size = new System.Drawing.Size(100, 17);
            this.txtQuantity1.TabIndex = 26;
            this.txtQuantity1.TextChanged += new System.EventHandler(this.txtQuantity1_TextChanged_1);
            // 
            // txtQuantity3
            // 
            this.txtQuantity3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity3.Location = new System.Drawing.Point(160, 88);
            this.txtQuantity3.Name = "txtQuantity3";
            this.txtQuantity3.Size = new System.Drawing.Size(100, 17);
            this.txtQuantity3.TabIndex = 25;
            this.txtQuantity3.TextChanged += new System.EventHandler(this.txtQuantity3_TextChanged_1);
            // 
            // txtQuantity2
            // 
            this.txtQuantity2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity2.Location = new System.Drawing.Point(160, 52);
            this.txtQuantity2.Name = "txtQuantity2";
            this.txtQuantity2.Size = new System.Drawing.Size(100, 17);
            this.txtQuantity2.TabIndex = 24;
            this.txtQuantity2.TextChanged += new System.EventHandler(this.txtQuantity2_TextChanged_1);
            // 
            // lblProduct3
            // 
            this.lblProduct3.AutoSize = true;
            this.lblProduct3.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProduct3.Location = new System.Drawing.Point(7, 88);
            this.lblProduct3.Name = "lblProduct3";
            this.lblProduct3.Size = new System.Drawing.Size(49, 17);
            this.lblProduct3.TabIndex = 23;
            this.lblProduct3.Text = "Pants";
            // 
            // lblProduct2
            // 
            this.lblProduct2.AutoSize = true;
            this.lblProduct2.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProduct2.Location = new System.Drawing.Point(7, 54);
            this.lblProduct2.Name = "lblProduct2";
            this.lblProduct2.Size = new System.Drawing.Size(53, 17);
            this.lblProduct2.TabIndex = 22;
            this.lblProduct2.Text = "Shoes";
            // 
            // lblProduct1
            // 
            this.lblProduct1.AutoSize = true;
            this.lblProduct1.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProduct1.Location = new System.Drawing.Point(7, 19);
            this.lblProduct1.Name = "lblProduct1";
            this.lblProduct1.Size = new System.Drawing.Size(43, 17);
            this.lblProduct1.TabIndex = 21;
            this.lblProduct1.Text = "Shirt";
            this.lblProduct1.Click += new System.EventHandler(this.lblProduct1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal3;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Label lblPrice3;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.TextBox txtQuantity1;
        private System.Windows.Forms.TextBox txtQuantity3;
        private System.Windows.Forms.TextBox txtQuantity2;
        private System.Windows.Forms.Label lblProduct3;
        private System.Windows.Forms.Label lblProduct2;
        private System.Windows.Forms.Label lblProduct1;
    }
}

