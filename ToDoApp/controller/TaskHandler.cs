using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ToDoApp
{
    static class TaskHandler
    {
        static public List<Task> GetTasks(string query)
        {
            List<Task> tasks = new List<Task>();
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
                        Task tmpTask = new Task((int)myReader["id"], myReader["name"].ToString(), (int)myReader["category_id"]);
                        if ((string)myReader["description"] != null)
                        {
                            tmpTask.Description = (string)myReader["description"];
                        }
                        tmpTask.IsImportant = (bool)myReader["important"];
                        tmpTask.Status = Convert.ToChar(myReader["status"]);
                        //Console.WriteLine((char)myReader["status"]);
                        if (myReader["deadline"] != DBNull.Value)
                        {

                            tmpTask.Deadline = (DateTime?)(myReader["deadline"]);
                        }
                        tasks.Add(tmpTask);
                    }
                }
                else
                {
                    Console.WriteLine(myReader);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            DatabaseConnection.databaseConnection.Close();


            return tasks;
        }
        static public List<Task> GetUnfinishedTasks()
        {
            return GetTasks("SELECT * FROM `tasks` WHERE `status` = 'u' ORDER BY -deadline DESC");
        }
        static public List<Task> GetFinishedTasks()
        {
            return GetTasks("SELECT * FROM `tasks` `status` = 's'");
        }
        static public List<Task> GetFailedTasks()
        {
            return GetTasks("SELECT * FROM `tasks` `status` = 'f'");
        }
        static public List<Task> GetAllTasks()
        {
            return GetTasks("SELECT * FROM `tasks` ");
        }
        static public void SetTaskFinished(int id)
        {
            string partquery = "`tasks` SET `status` = 's' WHERE `tasks`.`id` = " + id;
            Handler.Update(partquery);
        }
        static public void SetTaskFailed(int id)
        {
            string partquery = "`tasks` SET `status` = 'f' WHERE `tasks`.`id` = " + id;
            Handler.Update(partquery);
        }
        static public void AddTask(Task task)
        {
            string partquery = "`tasks` (`id`, `name`, `category_id`, `description`, `deadline`, `status`, `important`, `subtask_of`) " +
                "VALUES (NULL, '" +
                task.Name + "', '" + task.CategoryId + "', '" + task.Description + "', "; 
            if(task.Deadline == null)
            {
                partquery += "NULL";
            }
            else
            { 
                partquery += "'" + task.Deadline.ToString() + "'";
            }

            partquery += ", 'u', '" + task.IsImportant + "', ";
            if (task.SubtaskOf == null)
            {
                partquery += "NULL);";
            }
            else
            {
                partquery += "'" + task.SubtaskOf + "');";
            }

            Handler.Insert(partquery);
        }
    }

}
