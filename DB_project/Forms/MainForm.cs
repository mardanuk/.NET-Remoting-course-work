using System;
using System.Drawing;
using System.Windows.Forms;
using DB_project.Forms;
using DB_project.Classes;
using System.Data;
using System.IO;

namespace DB_project.Forms
{
    public partial class MainForm : Form
    {
        public Model model;
        public MainForm(Model md)
        {
            model = md;
            InitializeComponent();
            FillData();
            DataRow userInfo = model.SharedTCP.GetProfile().Rows[0];
            bool isAdmin = (bool)userInfo["user_status"];
            if (isAdmin)
            {
                админпанельToolStripMenuItem.Visible = true;
            }
        }

        void FillData()
        {
            productsForCount.Items.Clear();
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

                    // Загрузка (кеширование) изображения //
                    if (File.Exists("Images\\" + (string)dataRow["image"]))
                    {
                        File.WriteAllBytes("Images\\" + (string)dataRow["image"], Upload((string)dataRow["image"]));
                        productsForCount.Items.Add(new Item { Label = name, Value = id, Image = (string)dataRow["image"] });
                        productsForShop.Items.Add(new Item { Label = name, Value = id, Image = (string)dataRow["image"] });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public byte[] Upload(string path)
        {
            return File.ReadAllBytes("Images\\" + path);
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

        private void productsForCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            text_Availibility.Text = "";
            if (productsForCount.SelectedIndex != -1)
            {

                pictureBox1.Image = new Bitmap("Images\\" + ((Item)productsForCount.SelectedItem).Image);

                DataTable avalibility = model.SharedTCP.GetProductAvalibility(((Item)productsForCount.SelectedItem).Value);
                DataTable shops = model.SharedTCP.GetAllShops();
                DataTable products = model.SharedTCP.GetProduct(((Item)productsForCount.SelectedItem).Value);

                if (avalibility.Rows.Count == 0)
                {
                    text_price.Text = "0p";
                    text_Availibility.Text = "Отсутвует в магазинах";
                }
                foreach (DataRow dataRow in avalibility.Rows)
                {
                    text_price.Text = products.Rows[0]["price"] + "p";
                    text_Availibility.Text += $"{shops.Rows[(int)dataRow["shop_id"] - 1]["name"].ToString().Trim()} \t | кол-во: {dataRow["count"]}\n";
                }
            }
        }

        private void btn_order_Click(object sender, EventArgs e)
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
                if (stockCount > 0 && stockCount >= productCount.Value)
                {
                    model.SharedHTTP.setOrder((int)((Item)productsForShop.SelectedItem).Value, (int)((Item)shop.SelectedItem).Value, (int)productCount.Value);
                    orderResponse.Text = "Доставлено из " + shop.SelectedItem + " " + productsForShop.SelectedItem + " в размере " + productCount.Value;
                    model.SharedHTTP.UpdateProductAvability(((Item)productsForShop.SelectedItem).Value, ((Item)shop.SelectedItem).Value, stockCount - (int)productCount.Value);
                }
                else
                {
                    MessageBox.Show("Выбранное количество больше, чем имеется в магазинах");
                }
            }
        }


        private void productCountLabel_Click(object sender, EventArgs e)
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
        private void btn_CheckProductAvaibility_Click(object sender, EventArgs e)
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
        private void OpenProfileItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(model);
            profile.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditShopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(model, this, 0);
            adminPanel.Show();
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(model, this, 1);
            adminPanel.Show();
        }

        private void ProductAvailibilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAvailibilty editAvailibilty = new EditAvailibilty(model);
            editAvailibilty.Show();
        }
    }
}