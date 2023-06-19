using DB_project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_project.Forms
{
    public partial class AdminPanel : Form
    {
        const int shopsTableType = 0;
        const int productsTableType = 1;
        const int avaibilityTableType = 2;
        int tableType;

        string tableName;
        DataTable dataTable = new DataTable();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        BindingSource bindingSource1 = new BindingSource();
        MainForm parentForm;
        Model model;

        /// <summary>
        /// Создание админ панели
        /// </summary>
        /// <param name="mainForm">Текущая форма, от которой создастся админПанель</param>
        /// <param name="tableType">Для какой таблицы создастся админ панель: 
        /// 0 - shops,
        /// 1 - products,
        /// 2 - avaibility </param>
        public AdminPanel(Model md, MainForm mainForm, int tableType)
        {
            try
            {
                Console.WriteLine("not ok");
                if (tableType >= 0 && tableType <= 2)
                {
                    Console.WriteLine("ok");
                    typeLabel = new Label();
                    model = md;
                    parentForm = mainForm;
                    this.tableType = tableType;
                    if (tableType == shopsTableType)
                    {
                        Console.WriteLine("shop");
                        tableName = "Shop";
                        typeLabel.Text = "Редактировать магазины";
                    }
                    else if (tableType == productsTableType)
                    {
                        Console.WriteLine("product");
                        tableName = "Product";
                        typeLabel.Text = "Редактировать товары";
                    }
                    else if (tableType == avaibilityTableType)
                    {
                        tableName = "Product_Availibility";
                        typeLabel.Text = "Редактировать наличие товаров";
                    }
                    else
                    {
                        throw new Exception("ldslm");
                    }
                    InitializeComponent();
                    dataAdapter = model.SharedTCP.GetTable(ref dataTable, tableName);
                    Console.WriteLine("data 01 "+ dataTable.Rows[0][1]);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds, $"{tableName}");

                    bindingSource1.DataSource = dataTable;
                    table_Admin.DataSource = table_Admin.DataSource = bindingSource1;
                }
                else
                {
                    throw new Exception("Значение tableType должно принимать значения от 0 до 2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_AddShop_Click(object sender, EventArgs e)
        {
            DataRow dr = dataTable.NewRow();
            Console.WriteLine(dataTable.Rows.Count);
            dr.ItemArray = new object[] { (int)dataTable.Rows[dataTable.Rows.Count - 1][0] + 1, "" };
            dataTable.Rows.InsertAt(dr, table_Admin.Rows.Count);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update((DataTable)bindingSource1.DataSource);
            UdpdateParentForm();
            MessageBox.Show("Данные обновлены");
        }
        void UdpdateParentForm()
        {
            if (tableType == productsTableType)
                parentForm.FillProducts();
            else if (tableType == shopsTableType)
                parentForm.FillShops();
        }
        private void btn_RemoveShop_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (table_Admin.SelectedRows.Count > 0)
            {
                while (table_Admin.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = table_Admin.SelectedRows[0];
                    dr.Selected = false;
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    DataRow FindMyRow = dataTable.Rows[table_Admin.CurrentCell.RowIndex];
                    Console.WriteLine("Index: " + (table_Admin.CurrentCell.RowIndex) + " Value: " + dataTable.Rows[table_Admin.CurrentCell.RowIndex]);
                    FindMyRow.Delete();

                    dataAdapter.Update((DataTable)bindingSource1.DataSource);
                    UdpdateParentForm();
                    index++;
                }
            }
            else
                MessageBox.Show("Выделите строки таблицы, которые необходимо удалить", "Пояснение");

        }
    }
}
