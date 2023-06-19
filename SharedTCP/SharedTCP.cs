using System;
using System.Data.SqlClient;
using System.Data;
using DataBaseMethods;
using System.Runtime.Remoting.Lifetime;
using System.Data.Common;

namespace RemoteSharedTCP
{
    public class SharedTCP : MarshalByRefObject
    {
        public static int idClient;
        DataBase dataBase = new DataBase();

        public SharedTCP()
        {
            Console.WriteLine("\n-----SharedTCP was created-----");
        }
        ~SharedTCP()
        {
            Console.WriteLine("\n-----SharedTCP was destroyed-----");
        }


        public override Object InitializeLifetimeService()
        {
            ILease lease = (ILease)base.InitializeLifetimeService();

            if (lease.CurrentState == LeaseState.Initial)
            {
                lease.InitialLeaseTime = TimeSpan.FromSeconds(40);
                lease.SponsorshipTimeout = TimeSpan.FromSeconds(110);
                lease.RenewOnCallTime = TimeSpan.FromSeconds(30);
            }

            return lease;
        }

        DataTable ExecuteSelectQuery(string query)
        {
            dataBase.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataBase.closeConnection();
            return table;
        }
        SqlDataAdapter ExecuteSelectQuery(string query, ref DataTable table)
        {
            string connectionString = "Server=DESKTOP-MJ5G0UJ\\SQLEXPRESS;Database=CW_Smart_Shop;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(table);

            return adapter;
        }
        public DataTable tryAuthorization(string login, string password)
        {
            var querySelectClient = $"SELECT * FROM User_Info WHERE login = '{login}' AND password = '{password}'";
            DataTable table = ExecuteSelectQuery(querySelectClient);
            if (table.Rows.Count != 0) idClient = (int)table.Rows[0]["user_id"];
            return table;
        }
        public DataTable GetAllProducts()
        {
            var querySelectClient = $"SELECT * FROM Product";
            return ExecuteSelectQuery(querySelectClient);
        }
        public DataTable GetAllShops()
        {
            var querySelectClient = $"SELECT * FROM Shop";
            return ExecuteSelectQuery(querySelectClient);
        }

        public DataTable GetProduct(int productId)
        {
            var querySelectClient = $"SELECT * FROM Product WHERE product_id={productId}";
            return ExecuteSelectQuery(querySelectClient);
        }
        public DataTable GetShop(int shopId)
        {
            var querySelectClient = $"SELECT * FROM Shop WHERE shop_id={shopId}";
            return ExecuteSelectQuery(querySelectClient);
        }

        public DataTable GetProductAvalibility(int productId)
        {
            var querySelectClient = $"SELECT* FROM Product_Avability WHERE product_id ={productId}";
            return ExecuteSelectQuery(querySelectClient);
        }
        public DataTable GetProductAvalibility(int productId, int shopId)
        {
            var querySelectClient = $"SELECT* FROM Product_Avability WHERE product_id ={productId} AND shop_id={shopId}";
            return ExecuteSelectQuery(querySelectClient);
        }

        public DataTable GetProfile()
        {
            var querySelectClient = $"SELECT * FROM User_Info WHERE user_id={idClient}";
            return ExecuteSelectQuery(querySelectClient);
        }
        public SqlDataAdapter GetUserOrders(ref DataTable table)
        {
            var querySelectClient = $"SELECT * FROM Orders where user_id={idClient}";
            return ExecuteSelectQuery(querySelectClient, ref table);
        }
        public DataTable GetUserOrders(int orderId)
        {
            var querySelectClient = $"SELECT * FROM Orders where order_id={orderId}";
            return ExecuteSelectQuery(querySelectClient);
        }

        public SqlDataAdapter GetTable(ref DataTable table, string tableName)
        {
            var querySelectClient = $"SELECT * FROM {tableName}";
            return ExecuteSelectQuery(querySelectClient, ref table);
        }
    }
}