
namespace DB_project.Forms
{
    partial class MainForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.text_Availibility = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productsForCount = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.аккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.админпанельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пунктыВыдачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наличиеТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
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
            this.groupBox3.Location = new System.Drawing.Point(645, 60);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(550, 682);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Заказать";
            // 
            // btn_CheckProductAvaibility
            // 
            this.btn_CheckProductAvaibility.BackColor = System.Drawing.Color.White;
            this.btn_CheckProductAvaibility.Location = new System.Drawing.Point(357, 181);
            this.btn_CheckProductAvaibility.Margin = new System.Windows.Forms.Padding(6);
            this.btn_CheckProductAvaibility.Name = "btn_CheckProductAvaibility";
            this.btn_CheckProductAvaibility.Size = new System.Drawing.Size(181, 50);
            this.btn_CheckProductAvaibility.TabIndex = 12;
            this.btn_CheckProductAvaibility.Text = "Узнать кол-во";
            this.btn_CheckProductAvaibility.UseVisualStyleBackColor = false;
            this.btn_CheckProductAvaibility.Click += new System.EventHandler(this.btn_CheckProductAvaibility_Click);
            // 
            // countInShops
            // 
            this.countInShops.BackColor = System.Drawing.Color.White;
            this.countInShops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countInShops.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.countInShops.Location = new System.Drawing.Point(264, 181);
            this.countInShops.Margin = new System.Windows.Forms.Padding(6);
            this.countInShops.Name = "countInShops";
            this.countInShops.ReadOnly = true;
            this.countInShops.Size = new System.Drawing.Size(81, 44);
            this.countInShops.TabIndex = 11;
            this.countInShops.Text = "";
            // 
            // orderResponse
            // 
            this.orderResponse.BackColor = System.Drawing.Color.White;
            this.orderResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderResponse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderResponse.Location = new System.Drawing.Point(18, 368);
            this.orderResponse.Margin = new System.Windows.Forms.Padding(6);
            this.orderResponse.Name = "orderResponse";
            this.orderResponse.Size = new System.Drawing.Size(520, 269);
            this.orderResponse.TabIndex = 7;
            this.orderResponse.Text = "";
            // 
            // productCountLabel
            // 
            this.productCountLabel.AutoSize = true;
            this.productCountLabel.Location = new System.Drawing.Point(12, 190);
            this.productCountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.productCountLabel.Name = "productCountLabel";
            this.productCountLabel.Size = new System.Drawing.Size(240, 23);
            this.productCountLabel.TabIndex = 6;
            this.productCountLabel.Text = "Количество в магазине\r\n";
            // 
            // productCount
            // 
            this.productCount.Location = new System.Drawing.Point(14, 266);
            this.productCount.Margin = new System.Windows.Forms.Padding(6);
            this.productCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.productCount.Name = "productCount";
            this.productCount.Size = new System.Drawing.Size(520, 38);
            this.productCount.TabIndex = 10;
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.White;
            this.btn_order.Location = new System.Drawing.Point(12, 316);
            this.btn_order.Margin = new System.Windows.Forms.Padding(6);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(526, 40);
            this.btn_order.TabIndex = 9;
            this.btn_order.Text = "Заказать";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Выберие товар";
            // 
            // productsForShop
            // 
            this.productsForShop.FormattingEnabled = true;
            this.productsForShop.Location = new System.Drawing.Point(12, 132);
            this.productsForShop.Margin = new System.Windows.Forms.Padding(6);
            this.productsForShop.Name = "productsForShop";
            this.productsForShop.Size = new System.Drawing.Size(522, 31);
            this.productsForShop.TabIndex = 6;
            // 
            // shop
            // 
            this.shop.FormattingEnabled = true;
            this.shop.Location = new System.Drawing.Point(12, 62);
            this.shop.Margin = new System.Windows.Forms.Padding(6);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(522, 31);
            this.shop.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Выберите откуда доставить товар";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.text_Availibility);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.text_price);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.productsForCount);
            this.groupBox2.Location = new System.Drawing.Point(36, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(578, 669);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Каталог";
            // 
            // text_Availibility
            // 
            this.text_Availibility.AutoSize = true;
            this.text_Availibility.Location = new System.Drawing.Point(14, 528);
            this.text_Availibility.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.text_Availibility.Name = "text_Availibility";
            this.text_Availibility.Size = new System.Drawing.Size(239, 23);
            this.text_Availibility.TabIndex = 11;
            this.text_Availibility.Text = "Отсутвует в магазинах";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 492);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Наличие";
            // 
            // text_price
            // 
            this.text_price.AutoSize = true;
            this.text_price.Location = new System.Drawing.Point(84, 119);
            this.text_price.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(36, 23);
            this.text_price.TabIndex = 9;
            this.text_price.Text = "0p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Цена";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 148);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите товар\r\n";
            // 
            // productsForCount
            // 
            this.productsForCount.FormattingEnabled = true;
            this.productsForCount.Location = new System.Drawing.Point(12, 62);
            this.productsForCount.Margin = new System.Windows.Forms.Padding(6);
            this.productsForCount.Name = "productsForCount";
            this.productsForCount.Size = new System.Drawing.Size(512, 31);
            this.productsForCount.TabIndex = 4;
            this.productsForCount.SelectedIndexChanged += new System.EventHandler(this.productsForCount_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аккаунтToolStripMenuItem,
            this.админпанельToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1211, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // аккаунтToolStripMenuItem
            // 
            this.аккаунтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьПрофильToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.аккаунтToolStripMenuItem.Name = "аккаунтToolStripMenuItem";
            this.аккаунтToolStripMenuItem.Size = new System.Drawing.Size(123, 32);
            this.аккаунтToolStripMenuItem.Text = "Аккаунт";
            // 
            // открытьПрофильToolStripMenuItem
            // 
            this.открытьПрофильToolStripMenuItem.Name = "открытьПрофильToolStripMenuItem";
            this.открытьПрофильToolStripMenuItem.Size = new System.Drawing.Size(316, 32);
            this.открытьПрофильToolStripMenuItem.Text = "Открыть профиль";
            this.открытьПрофильToolStripMenuItem.Click += new System.EventHandler(this.OpenProfileItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(316, 32);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // админпанельToolStripMenuItem
            // 
            this.админпанельToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пунктыВыдачиToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.наличиеТовараToolStripMenuItem});
            this.админпанельToolStripMenuItem.Name = "админпанельToolStripMenuItem";
            this.админпанельToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.админпанельToolStripMenuItem.Text = "Админ-панель";
            this.админпанельToolStripMenuItem.Visible = false;
            // 
            // пунктыВыдачиToolStripMenuItem
            // 
            this.пунктыВыдачиToolStripMenuItem.Name = "пунктыВыдачиToolStripMenuItem";
            this.пунктыВыдачиToolStripMenuItem.Size = new System.Drawing.Size(284, 32);
            this.пунктыВыдачиToolStripMenuItem.Text = "Пункты выдачи";
            this.пунктыВыдачиToolStripMenuItem.Click += new System.EventHandler(this.EditShopsToolStripMenuItem_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(284, 32);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.ProductsToolStripMenuItem_Click);
            // 
            // наличиеТовараToolStripMenuItem
            // 
            this.наличиеТовараToolStripMenuItem.Name = "наличиеТовараToolStripMenuItem";
            this.наличиеТовараToolStripMenuItem.Size = new System.Drawing.Size(293, 32);
            this.наличиеТовараToolStripMenuItem.Text = "Наличие товара";
            this.наличиеТовараToolStripMenuItem.Click += new System.EventHandler(this.ProductAvailibilityToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1211, 730);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Каталог";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label productCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productsForCount;
        private System.Windows.Forms.ComboBox shop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox productsForShop;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.NumericUpDown productCount;
        private System.Windows.Forms.RichTextBox orderResponse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem аккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьПрофильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem админпанельToolStripMenuItem;
        private System.Windows.Forms.RichTextBox countInShops;
        private System.Windows.Forms.Button btn_CheckProductAvaibility;
        private System.Windows.Forms.Label text_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text_Availibility;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem пунктыВыдачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наличиеТовараToolStripMenuItem;
    }

    #region Windows Form Designer generated code


    #endregion
}
