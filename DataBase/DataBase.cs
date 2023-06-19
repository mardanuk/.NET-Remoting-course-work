using System.Data.SqlClient;

namespace DataBaseMethods
{
    public class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-MJ5G0UJ\\SQLEXPRESS;Database=CW_Smart_Shop;Trusted_Connection=True;");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}