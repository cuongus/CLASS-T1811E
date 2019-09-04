using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectMySql
{
    class DBConnect
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user id=root;password=password;database=bt575");
            return conn;
        }
    }
}
