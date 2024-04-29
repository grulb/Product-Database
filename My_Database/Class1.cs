using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace My_Database
{
    internal class Class1
    {
        NpgsqlConnection npgsqlConnection = new NpgsqlConnection(@"Host=localhost;Database=ShopDB;Username=postgres;Password=1233");

        public void openConnection()
        {
            if (npgsqlConnection.State == System.Data.ConnectionState.Closed)
            {
                npgsqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (npgsqlConnection.State == System.Data.ConnectionState.Open)
            {
                npgsqlConnection.Close();
            }
        }

        public NpgsqlConnection GetConnection()
        {
            return npgsqlConnection;
        }
    }
}
