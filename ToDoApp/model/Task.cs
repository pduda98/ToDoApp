using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Task
    {
        private int? _id;
        private string _name;
        private int _categoryId;
        private string _description = null;
        private DateTime? _deadline = null;
        private char _status;       // u - unfinished; s - successfully finished; f - finished;
        private bool? _isImportant;
        private int? _subtaskOf;

        public void SetId(int id)
        {
            _id = id;
        }
        public int? GetId()
        {
            return _id;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }
        public string GetDescription()
        {
            return _description;
        }
        public void SetCategoryId(int categoryId)
        {
            _categoryId = categoryId;
        }
        public int GetCategoryId()
        {
            return _categoryId;
        }
        public void SetDeadline(DateTime? deadline)
        {
            _deadline = deadline;
        }
        public DateTime? GetDeadline()
        {
            return _deadline;
        }
        public void SetStatus(char status)
        {
            _status = status;
        }
        public char GetStatus()
        {
            return _status;
        }
        public bool? GetIsImportant()
        {
            return _isImportant;
        }
        public void SetIsImportant(bool isImportant)
        {
            _isImportant = isImportant;
        }
        public int? GetSubtaskOf()
        {
            return _subtaskOf;
        }
        public void SetSubtaskOf(int subtaskOf)
        {
            _subtaskOf = subtaskOf;
        }
        public void FailTask()
        {
            _status = 'f';
        }
        public void FinishTask()
        {
            _status = 's';
        }
        private void SetNecceseryFields(string name, int categoryId, char status)
        {
            SetName(name);
            SetStatus(status);
            SetCategoryId(categoryId);
        }
        public Task(int id, string name, int categoryId, char status)
        {
            SetNecceseryFields(name, categoryId, status);
            SetId(id);
        }

        public Task(int id, string name, char status)
        {
            SetNecceseryFields(name, 1, status);
            SetId(id);
        }
        public Task(int id, string name, int categoryId)
        {
            SetNecceseryFields(name, categoryId, 'u');
            SetId(id);
        }
        public Task(int id, string name)
        {
            SetNecceseryFields(name, 1, 'u');
            SetId(id);
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
