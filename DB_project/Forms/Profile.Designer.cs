
namespace DB_project
{
    partial class Profile
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OrdersTable = new System.Windows.Forms.DataGridView();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.OrderInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(70, 319);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(9);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(331, 48);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Редактировать";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // loginInput
            // 
            this.loginInput.Location = new System.Drawing.Point(154, 123);
            this.loginInput.Margin = new System.Windows.Forms.Padding(4);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(247, 38);
            this.loginInput.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "Редактировать профиль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Пароль";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(154, 176);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(247, 38);
            this.passwordInput.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Имя";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(154, 229);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(247, 38);
            this.nameInput.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(492, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 34);
            this.label5.TabIndex = 18;
            this.label5.Text = "Заказы";
            // 
            // OrdersTable
            // 
            this.OrdersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersTable.Location = new System.Drawing.Point(498, 114);
            this.OrdersTable.Name = "OrdersTable";
            this.OrdersTable.RowHeadersWidth = 51;
            this.OrdersTable.RowTemplate.Height = 24;
            this.OrdersTable.Size = new System.Drawing.Size(462, 164);
            this.OrdersTable.TabIndex = 19;
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackColor = System.Drawing.Color.White;
            this.ReloadButton.Location = new System.Drawing.Point(836, 319);
            this.ReloadButton.Margin = new System.Windows.Forms.Padding(9);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(124, 48);
            this.ReloadButton.TabIndex = 20;
            this.ReloadButton.Text = "Обновить";
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // OrderInfoButton
            // 
            this.OrderInfoButton.BackColor = System.Drawing.Color.White;
            this.OrderInfoButton.Location = new System.Drawing.Point(578, 319);
            this.OrderInfoButton.Margin = new System.Windows.Forms.Padding(9);
            this.OrderInfoButton.Name = "OrderInfoButton";
            this.OrderInfoButton.Size = new System.Drawing.Size(240, 48);
            this.OrderInfoButton.TabIndex = 21;
            this.OrderInfoButton.Text = "Информация о заказе";
            this.OrderInfoButton.UseVisualStyleBackColor = false;
            this.OrderInfoButton.Click += new System.EventHandler(this.OrderInfoButton_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1041, 404);
            this.Controls.Add(this.OrderInfoButton);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.OrdersTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.btn_edit);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView OrdersTable;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Button OrderInfoButton;
    }
}