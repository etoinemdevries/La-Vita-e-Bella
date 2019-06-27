using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

/*kevin*/
namespace La_Vita_e_Bella.utils
{

    public class DBConnection
    {
        private static string ConnectQuery = "datasource = localhost;username = root; password=; database = la_vita_e_bella";
        private MySqlConnection Connection;

        private DBConnection()
        {
            Connection = new MySqlConnection(ConnectQuery);
        }

        public static DataTable Query(string query)
        {
            DBConnection connection = new DBConnection();

            try
            {
                if (!connection.Connect())
                {
                    Console.WriteLine("Failed to connect");
                    return null;
                }

                MySqlDataAdapter command = new MySqlDataAdapter(query, connection.GetConnection());

                if (!connection.Disconnect())
                {
                    Console.WriteLine("Failed to disconnect");
                    return null;
                }

                DataTable table = new DataTable();
                command.Fill(table);

                if (table.HasErrors)
                {
                    Console.WriteLine("Invalid table data");
                    return null;
                }

                return table;
            }
            catch
            {
                if (connection != null && !connection.Disconnect())
                {
                    Console.WriteLine("Failed to disconnnect");
                }
            }

            return null;
        }

        private bool Connect()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch
            {
            }

            return false;
        }

        private bool Disconnect()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch
            {
            }

            return false;
        }

        public MySqlConnection GetConnection()
        {
            return Connection;
        }
    }
}
