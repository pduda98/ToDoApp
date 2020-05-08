using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Task
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public DateTime? Deadline { get; set; }
        public char Status { get; set; }    // u - unfinished; s - successfully finished; f - finished;
        public bool? IsImportant { get; set; }
        public int? SubtaskOf { get; set; }



        public void FailTask()
        {
            Status = 'f';
        }
        public void FinishTask()
        {
            Status = 's';
        }
        private void SetNecceseryFields(string name, int categoryId, char status)
        {
            Name = name;
            Status = status;
            CategoryId = categoryId;
        }
        public Task(int id, string name, int categoryId, char status)
        {
            SetNecceseryFields(name, categoryId, status);
            Id = id;
        }

        public Task(int id, string name, char status)
        {
            SetNecceseryFields(name, 1, status);
            Id = id;
        }
        public Task(int id, string name, int categoryId)
        {
            SetNecceseryFields(name, categoryId, 'u');
            Id = id;
        }
        public Task(int id, string name)
        {
            SetNecceseryFields(name, 1, 'u');
            Id = id;
        }
        public Task(string name, int categoryId, char status)
        {
            SetNecceseryFields(name, categoryId, status);

        }

        public Task(string name, char status)
        {
            SetNecceseryFields(name, 1, status);
        }
        public Task(string name, int categoryId)
        {
            SetNecceseryFields(name, categoryId, 'u');
        }
        public Task(string name)
        {
            SetNecceseryFields(name, 1, 'u');
        }
    }
}
