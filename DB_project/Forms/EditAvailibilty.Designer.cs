namespace DB_project.Forms
{
    partial class EditAvailibilty
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_CheckProductAvaibility = new System.Windows.Forms.Button();
            this.countInShops = new System.Windows.Forms.RichTextBox();
            this.orderResponse = new System.Windows.Forms.RichTextBox();
            this.productCountLabel = new System.Windows.Forms.Label();
            this.productCount = new System.Windows.Forms.NumericUpDown();
            this.btn_order = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productsForShop = new System.Windows.Forms.ComboBox();
            this.shop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(221)))));
            this.groupBox3.Controls.Add(this.btn_CheckProductAvaibility);
            this.groupBox3.Controls.Add(this.countInShops);
            this.groupBox3.Controls.Add(this.orderResponse);
            this.groupBox3.Controls.Add(this.productCountLabel);
            this.groupBox3.Controls.Add(this.productCount);
            this.groupBox3.Controls.Add(this.btn_order);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.productsForShop);
            this.groupBox3.Controls.Add(this.shop);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(18, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.groupBox3.Size = new System.Drawing.Size(825, 980);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Изменить кол-во";
            // 
            // btn_CheckProductAvaibility
            // 
            this.btn_CheckProductAvaibility.BackColor = System.Drawing.Color.White;
            this.btn_CheckProductAvaibility.Location = new System.Drawing.Point(536, 260);
            this.btn_CheckProductAvaibility.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btn_CheckProductAvaibility.Name = "btn_CheckProductAvaibility";
            this.btn_CheckProductAvaibility.Size = new System.Drawing.Size(272, 72);
            this.btn_CheckProductAvaibility.TabIndex = 12;
            this.btn_CheckProductAvaibility.Text = "Узнать кол-во";
            this.btn_CheckProductAvaibility.UseVisualStyleBackColor = false;
            this.btn_CheckProductAvaibility.Click += new System.EventHandler(this.btn_CheckProductAvaibility_Click_1);
            // 
            // countInShops
            // 
            this.countInShops.BackColor = System.Drawing.Color.White;
            this.countInShops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countInShops.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.countInShops.Location = new System.Drawing.Point(396, 260);
            this.countInShops.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.countInShops.Name = "countInShops";
            this.countInShops.ReadOnly = true;
            this.countInShops.Size = new System.Drawing.Size(122, 63);
            this.countInShops.TabIndex = 11;
            this.countInShops.Text = "";
            // 
            // orderResponse
            // 
            this.orderResponse.BackColor = System.Drawing.Color.White;
            this.orderResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderResponse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderResponse.Location = new System.Drawing.Point(27, 529);
            this.orderResponse.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.orderResponse.Name = "orderResponse";
            this.orderResponse.Size = new System.Drawing.Size(780, 387);
            this.orderResponse.TabIndex = 7;
            this.orderResponse.Text = "";
            // 
            // productCountLabel
            // 
            this.productCountLabel.AutoSize = true;
            this.productCountLabel.Location = new System.Drawing.Point(18, 273);
            this.productCountLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.productCountLabel.Name = "productCountLabel";
            this.productCountLabel.Size = new System.Drawing.Size(240, 23);
            this.productCountLabel.TabIndex = 6;
            this.productCountLabel.Text = "Количество в магазине\r\n";
            // 
            // productCount
            // 
            this.productCount.Location = new System.Drawing.Point(21, 382);
            this.productCount.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.productCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.productCount.Name = "productCount";
            this.productCount.Size = new System.Drawing.Size(780, 38);
            this.productCount.TabIndex = 10;
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.White;
            this.btn_order.Location = new System.Drawing.Point(18, 454);
            this.btn_order.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(789, 58);
            this.btn_order.TabIndex = 9;
            this.btn_order.Text = "Добавить";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 341);
            this.label7.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Выберие товар";
            // 
            // productsForShop
            // 
            this.productsForShop.FormattingEnabled = true;
            this.productsForShop.Location = new System.Drawing.Point(18, 190);
            this.productsForShop.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.productsForShop.Name = "productsForShop";
            this.productsForShop.Size = new System.Drawing.Size(781, 31);
            this.productsForShop.TabIndex = 6;
            // 
            // shop
            // 
            this.shop.FormattingEnabled = true;
            this.shop.Location = new System.Drawing.Point(18, 89);
            this.shop.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(781, 31);
            this.shop.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Выберите пункт выдачи";
            // 
            // EditAvailibilty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(890, 1055);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditAvailibilty";
            this.Text = "EditAvailibilty";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_CheckProductAvaibility;
        private System.Windows.Forms.RichTextBox countInShops;
        private System.Windows.Forms.RichTextBox orderResponse;
        private System.Windows.Forms.Label productCountLabel;
        private System.Windows.Forms.NumericUpDown productCount;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox productsForShop;
        private System.Windows.Forms.ComboBox shop;
        private System.Windows.Forms.Label label5;
    }
}