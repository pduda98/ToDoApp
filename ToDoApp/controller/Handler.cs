using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ToDoApp
{
    static class Handler
    {
        static public void Insert(string partQuery)
        {
            string query = "INSERT INTO " + partQuery;
            DatabaseConnection.Do(query);
        }
        static public void Delete(string partQuery)
        {
            string query = "DELETE " + partQuery;
            DatabaseConnection.Do(query);
        }
        static public void Update(string partQuery)
        {
            string query = "UPDATE " + partQuery;
            DatabaseConnection.Do(query);
        }
    }
}
