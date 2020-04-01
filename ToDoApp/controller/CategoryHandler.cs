using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ToDoApp
{
    static class CategoryHandler
    {
        static public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            string query = "SELECT * FROM `categories` ";
            MySqlCommand databaseCommand = new MySqlCommand(query, DatabaseConnection.databaseConnection);
            databaseCommand.CommandTimeout = 60;

            try
            {
                DatabaseConnection.databaseConnection.Open();
                MySqlDataReader myReader = databaseCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Category tmpCategory = new Category((int)myReader["id"], myReader["name"].ToString());
                        if (myReader["description"] != null)
                        {
                            tmpCategory.SetDescription(myReader["description"].ToString());
                        }
                        categories.Add(tmpCategory);
                    }
                }
                else
                {
                    Console.WriteLine(myReader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            DatabaseConnection.databaseConnection.Close();

            return categories;
        }
        static public void AddCategory(Category newCategory)
        {
            string query = "INSERT INTO `categories` (`id`, `name`, `description`) " +
                "VALUES(NULL, '" + newCategory.GetName() + "', '" + newCategory.GetDescription() + "');";
            DatabaseConnection.Do(query);
        }
        static public void DeleteCategory(Category categoryToDelete)
        {
            string query = "DELETE FROM `categories` WHERE `id` = " + categoryToDelete.GetId()+";";
            DatabaseConnection.Do(query);
        }
        static public void UpdateCategory(Category newCategory)
        {
            string query = "UPDATE `categories` SET " +
                "`name` = '" + newCategory.GetName() + "'," +
                "`description` = '" + newCategory.GetDescription() + "' " +
                "WHERE `categories`.`id` = " + newCategory.GetId() + ";";
            DatabaseConnection.Do(query);
        }
    }
}
