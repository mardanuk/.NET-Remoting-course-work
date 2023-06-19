using DB_project.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace DB_project.Forms
{
    public partial class EditAvailibilty : Form
    {

        public Model model;
        public EditAvailibilty(Model md)
        {
            model = md;
            InitializeComponent();
            FillData();
        }

        void FillData()
        {
            FillProducts();
            FillShops();
        }
        public void FillProducts()
        {
            try
            {
                DataTable response = model.SharedTCP.GetAllProducts();
                foreach (DataRow dataRow in response.Rows)
                {
                    int id = (int)dataRow["product_id"];
                    string name = (string)dataRow["name"];
                    int price = (int)dataRow["price"];
                    productsForShop.Items.Add(new Item { Label = name, Value = id, Image = (string)dataRow["image"] });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void FillShops()
        {
            shop.Items.Clear();
            DataTable response = model.SharedTCP.GetAllShops();
            foreach (DataRow dataRow in response.Rows)
            {
                int shopId = (int)dataRow["shop_id"];
                string shopName = (string)dataRow["name"];

                shop.Items.Add(new Item { Label = shopName, Value = shopId });
            }
        }

        public class Item
        {
            public int Value { get; set; }
            public string Label { get; set; }
            public string Image { get; set; }

            public override string ToString()
            {
                return Label;
            }

        }
        private void btn_CheckProductAvaibility_Click_1(object sender, EventArgs e)
        {
            if (shop.SelectedItem != null && productsForShop.SelectedItem != null)
            {
                int stockCount = 0;
                DataTable response = model.SharedTCP.GetProductAvalibility(((Item)productsForShop.SelectedItem).Value, ((Item)shop.SelectedItem).Value);
                if (response.Rows.Count == 0)
                {
                    model.SharedHTTP.SetProductAvability(((Item)productsForShop.SelectedItem).Value, ((Item)shop.SelectedItem).Value);
                }
                else
                {
                    foreach (DataRow dataRow in response.Rows)
                    {
                        stockCount += (int)dataRow["count"];
                    }
                }
                countInShops.Text = stockCount.ToString();
            }
        }

        private void btn_order_Click_1(object sender, EventArgs e)
        {
            if (!(shop.SelectedIndex == -1 || productsForShop.SelectedIndex == -1 || productCount.Value == 0))
            {
                int stockCount = 0;
                DataTable response = model.SharedTCP.GetProductAvalibility(((Item)productsForShop.SelectedItem).Value, ((Item)shop.SelectedItem).Value);
                if (response.Rows.Count == 0)
                {
                    model.SharedHTTP.SetProductAvability(((Item)productsForShop.SelectedItem).Value, ((Item)shop.SelectedItem).Value);
                }
                else
                {
                    stockCount = (int)response.Rows[0]["count"];
                }
                orderResponse.Text = "В пукнкт выдачи по адрес: " + shop.SelectedItem + " добавлен товар: " + productsForShop.SelectedItem + " в количестве " + productCount.Value+"шт.";
                model.SharedHTTP.UpdateProductAvability(((Item)productsForShop.SelectedItem).Value, ((Item)shop.SelectedItem).Value, stockCount + (int)productCount.Value);

            }
        }
    }
}
