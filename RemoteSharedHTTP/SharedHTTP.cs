using System;
using System.Data.SqlClient;
using System.Data;
using DataBaseMethods;
using System.Reflection;
using RemoteSharedTCP;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace RemoteSharedHTTP
{
    public class SharedHTTP : MarshalByRefObject
    {
        DataBase dataBase = new DataBase();

        public SharedHTTP()
        {
            Console.WriteLine("\n-----SharedHTTP was created-----");
        }
        ~SharedHTTP()
        {
            Console.WriteLine("\n-----SharedHTTP was destroyed-----");
        }
        void ExecuteModificatorSQL(string query)
        {
            dataBase.openConnection();
            SqlCommand commandAccount = new SqlCommand(query, dataBase.getConnection());
            commandAccount.ExecuteNonQuery();
            dataBase.closeConnection();
        }
        public void createAccount(string login, string password)
        {
            string query = $"INSERT INTO User_Info(login, password, user_status) " +
                $"VALUES( '{login}', '{password}', 0 ) ";
            ExecuteModificatorSQL(query);
        }
        public void SetProductAvability(int productId, int shopId, int count = 0)
        {
            string query = $"INSERT INTO Product_Avability ([shop_id], [product_id], [count]) VALUES ({shopId}, {productId}, {count});";
            ExecuteModificatorSQL(query);
        }

        public void UpdateProductAvability(int productId, int shopId, int count)
        {
            string query = $"UPDATE Product_Avability " +
                    $"SET [count]={count} " +
                    $"WHERE shop_id={shopId} AND product_id={productId};";
            ExecuteModificatorSQL(query);
        }
        public void setOrder(int productId, int shopId, int count)
        {
            string query = $"INSERT INTO Orders " +
                        $"(user_id, product_id, shop_id, order_date, count)" +
                        $" VALUES " +
                        $"({SharedTCP.idClient}, {productId}, {shopId}, '{DateTime.Now.ToString("yyyy-MM-dd")}', {count})";
            ExecuteModificatorSQL(query);
        }
        public void UpdateUserInfo(string name, string login, string password)
        {
            string query = $"UPDATE User_Info SET [name]='{name}', [login]='{login}', [password]='{password}'  WHERE user_id={SharedTCP.idClient};";
            ExecuteModificatorSQL(query);
        }
    }
}