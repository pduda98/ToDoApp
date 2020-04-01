using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ToDoApp
{
    static class SubTaskHandler
    {
        static public List<SubTask> GetSubTasks(int taskId, char? status)
        {
            string query = "SELECT * FROM `subtasks` WHERE  `task_id` = '" + taskId + "'";
            if (status!=null)
            {
                query += "AND `status` = '" + status + "'";
            }
            List<SubTask> tasks = new List<SubTask>();
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
                        SubTask tmpTask = new SubTask((int)myReader["id"], myReader["name"].ToString(), taskId);
                        if ((string)myReader["description"] != null)
                        {
                            tmpTask.SetDescription((string)myReader["description"]);
                        }
                        if (myReader["deadline"] != null)
                        {
                            Console.WriteLine(myReader);
                            tmpTask.SetDeadline(DateTime.Parse(myReader["deadline"].ToString()));
                        }
                        tasks.Add(tmpTask);
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


            return tasks;
        }
        static public List<SubTask> GetUnfinishedSubTasks(int taskId) 
        { 
            return GetSubTasks(taskId, 'u');
        }
        static public List<SubTask> GetFinishedSubTasks(int taskId)
        {
            return GetSubTasks(taskId, 's');
        }
        static public List<SubTask> GetFailedSubTasks(int taskId)
        {
            return GetSubTasks(taskId, 'f');
        }
        static public List<SubTask> GetAllTasks(int taskId)
        {
            return GetSubTasks(taskId, null);
        }

    }
}
