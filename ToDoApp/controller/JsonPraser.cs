using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

//robione wdg. https://www.youtube.com/watch?v=SholKTNGdHk
//na razie bez zastosowania w programe


namespace ToDoApp.controller
{
    class JsonHandler
    {
        private readonly string _path = $".\\Testowy.json";

        public void create_json()
        {
            try
            {
                var category = getCategory();
                var jsonToWrite = JsonConvert.SerializeObject(category, Formatting.Indented);
            }

            catch (Exception ex)
            {
                //ignorowany na razie
            }


        }

        private string ReadJson()
        {
            try
            {
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }

                return jsonFromFile;

                var customerFromJson = JsonConvert.DeserializeObject<Category>(jsonFromFile);
            }
            catch (Exception ex)
            {
                return "ERROR";
            }
        }



        private Categories getCategory()
        {
            var categories = new Categories
            {
                Id = 1,
                Description = "testowa kategoria",
                Name = "nazwaaa"
            };








            return categories;
        }














        public class Categories
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public string Name { get; set; }
        }

        class DailyTasks
        {
            public int id { get; set; }
            public string name { get; set; }
            public int category_id { get; set; }
            public string description { get; set; }
            public string time { get; set; } //FORMAT CZASU, NIE STRING
            public bool monday { get; set; }
            public bool tuesday { get; set; }
            public bool wednesday { get; set; }
            public bool thursday { get; set; }
            public bool friday { get; set; }
            public bool saturday { get; set; }
            public bool sunday { get; set; }
            public bool important { get; set; }

        }

        class IntervalTasks
        {
            public int id { get; set; }
            public string name { get; set; }
            public int category_id { get; set; }
            public string description { get; set; }
            public string first_deadline { get; set; }
            public string time_interval { get; set; }
            public bool important { get; set; }
        }

        class Tasks
        {
            public int id { get; set; }
            public string name { get; set; }
            public int category_id { get; set; }
            public string description { get; set; }
            public string deadline { get; set; }
            public char status { get; set; }
            public bool importaant { get; set; }
            public int subrask_of { get; set; }
        }




    }
}
