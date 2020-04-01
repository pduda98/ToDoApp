using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ToDoApp
{
    static class DatabaseConnection
    {
        static public string mysqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=todo_db";
        static public MySqlConnection databaseConnection = new MySqlConnection(mysqlConnectionString);

        static public void Do(string query)
        {
            MySqlCommand databaseCommand = new MySqlCommand(query, databaseConnection);
            databaseCommand.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                databaseCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            databaseConnection.Close();
        }
    }
}
