using DB_project.Classes;
using RemoteSharedTCP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_project

{
    public partial class OrderInfo : Form
    {
        DataTable orderInfo = new DataTable();
        DataTable productInfo = new DataTable();
        DataTable shopInfo = new DataTable();

        Model model;
        public OrderInfo(Model md, int orderId)
        {
            model = md;
            InitializeComponent();
            orderInfo = model.SharedTCP.GetUserOrders(orderId);
            idOrderTextBox.Text=orderId.ToString();
            countTextBox.Text = ((int)orderInfo.Rows[0]["count"]).ToString();
            dateTextBox.Text = (orderInfo.Rows[0]["order_date"]).ToString();
            productInfo = model.SharedTCP.GetProduct((int)(orderInfo.Rows[0]["product_id"]));
            productTextBox.Text= (string)(productInfo.Rows[0]["name"]);
            summTextBox.Text=  ((int)(productInfo.Rows[0]["price"]) * (int)(orderInfo.Rows[0]["count"])).ToString();
            shopInfo = model.SharedTCP.GetShop((int)(orderInfo.Rows[0]["shop_id"]));
            shopTextBox.Text = (string)(shopInfo.Rows[0]["name"]);
        }
    }
}