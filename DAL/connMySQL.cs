using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace FormControle.DAL
{
    internal class connMySQL
    {
        private MySqlConnection connection;

        private string server = "";
        private string port = "";
        private string dbname = "";
        private string uid = "";
        private string pwd = "";

        public connMySQL()
        {
            string dsn = $"server={server};Port={port};database={dbname};Uid={uid};Pwd={pwd}";
            connection = new MySqlConnection(dsn);
        }

        public MySqlConnection toConnect()
        {
            if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
            return connection;
        }

        public void disconnect()
        {
            if(connection.State == System.Data.ConnectionState.Open) connection.Close();
        }
    }
}
