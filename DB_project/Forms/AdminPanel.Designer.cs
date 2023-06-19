namespace DB_project.Forms
{
    partial class AdminPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.typeLabel = new System.Windows.Forms.Label();
            this.table_Admin = new System.Windows.Forms.DataGridView();
            this.btn_RemoveShop = new System.Windows.Forms.Button();
            this.btn_AddShop = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(20, 36);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(247, 34);
            this.typeLabel.TabIndex = 21;
            this.typeLabel.Text = "РЕДАКТИРОВАТЬ";
            // 
            // table_Admin
            // 
            this.table_Admin.AllowUserToAddRows = false;
            this.table_Admin.AllowUserToDeleteRows = false;
            this.table_Admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_Admin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Admin.DefaultCellStyle = dataGridViewCellStyle1;
            this.table_Admin.Location = new System.Drawing.Point(20, 128);
            this.table_Admin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.table_Admin.Name = "table_Admin";
            this.table_Admin.RowHeadersWidth = 51;
            this.table_Admin.Size = new System.Drawing.Size(1137, 427);
            this.table_Admin.TabIndex = 22;
            // 
            // btn_RemoveShop
            // 
            this.btn_RemoveShop.Location = new System.Drawing.Point(243, 588);
            this.btn_RemoveShop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_RemoveShop.Name = "btn_RemoveShop";
            this.btn_RemoveShop.Size = new System.Drawing.Size(219, 40);
            this.btn_RemoveShop.TabIndex = 24;
            this.btn_RemoveShop.Text = "Удалить строку";
            this.btn_RemoveShop.UseVisualStyleBackColor = true;
            this.btn_RemoveShop.Click += new System.EventHandler(this.btn_RemoveShop_Click);
            // 
            // btn_AddShop
            // 
            this.btn_AddShop.Location = new System.Drawing.Point(20, 588);
            this.btn_AddShop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_AddShop.Name = "btn_AddShop";
            this.btn_AddShop.Size = new System.Drawing.Size(198, 40);
            this.btn_AddShop.TabIndex = 23;
            this.btn_AddShop.Text = "Добавить строку";
            this.btn_AddShop.UseVisualStyleBackColor = true;
            this.btn_AddShop.Click += new System.EventHandler(this.btn_AddShop_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(978, 588);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(178, 40);
            this.btn_Submit.TabIndex = 26;
            this.btn_Submit.Text = "Подтвердить";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1200, 647);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_RemoveShop);
            this.Controls.Add(this.btn_AddShop);
            this.Controls.Add(this.table_Admin);
            this.Controls.Add(this.typeLabel);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminPanel";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.table_Admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.DataGridView table_Admin;
        private System.Windows.Forms.Button btn_RemoveShop;
        private System.Windows.Forms.Button btn_AddShop;
        private System.Windows.Forms.Button btn_Submit;
    }
}