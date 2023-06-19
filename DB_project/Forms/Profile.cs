using DB_project.Classes;
using RemoteSharedTCP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_project

{
    public partial class Profile : Form
    {
        DataTable dataTable = new DataTable();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        BindingSource bindingSource1 = new BindingSource();

        Model model;
        public Profile(Model md)
        {
            model = md;
            InitializeComponent();

            dataAdapter = model.SharedTCP.GetUserOrders(ref dataTable);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, $"Orders");

            bindingSource1.DataSource = dataTable;
            OrdersTable.DataSource = bindingSource1;
            OrdersTable.Columns[1].Visible = false;
            OrdersTable.Columns[2].Visible = false;
            OrdersTable.Columns[3].Visible = false;

            DataTable userTable = model.SharedTCP.GetProfile();
            nameInput.Text = ((string)userTable.Rows[0]["name"]).Trim();
            loginInput.Text = ((string)userTable.Rows[0]["login"]).Trim();
            passwordInput.Text = ((string)userTable.Rows[0]["password"]).Trim();
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (loginInput.Text != "" && passwordInput.Text != "")
            {
                model.SharedHTTP.UpdateUserInfo(nameInput.Text, loginInput.Text, passwordInput.Text);
                MessageBox.Show("Профиль обновлен");
            }
            else
                MessageBox.Show("Значения пароля/логина не могут быть пустыми");
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            dataAdapter = model.SharedTCP.GetUserOrders(ref dataTable);
            MessageBox.Show("Данные обновлены");
        }

        private void OrderInfoButton_Click(object sender, EventArgs e)
        {
            if (OrdersTable.SelectedRows.Count > 0)
            {
                OrderInfo orderInfo = new OrderInfo(model, (int)(OrdersTable.SelectedRows[0].Cells["order_id"].Value));
                orderInfo.Show();
            }
            else
            {
                MessageBox.Show("Выберите строки");
            }
        }
    }
}