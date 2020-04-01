using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class SubTask
    {
        private int? _id;
        private int _taskId;
        private string _name;
        private string _description = null;
        private DateTime? _deadline = null;
        char _status;       // u - unfinished; s - successfully finished; f - finished;

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
        public void SetTaskId(int taskId)
        {
            _taskId = taskId;
        }
        public int GetTaskId()
        {
            return _taskId;
        }
        public void SetDeadline(DateTime deadline)
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
        public void FailTask()
        {
            _status = 'f';
        }
        public void FinishTask()
        {
            _status = 's';
        }
        private void SetNecceseryFields(int id, int taskId, string name, char status)
        {
            SetId(id);
            SetName(name);
            SetStatus(status); 
            SetTaskId(taskId);
        }
        public SubTask(int id, string name, int taskId, char status)
        {
            SetNecceseryFields(id, taskId, name, status);
        }
        public SubTask(int id, string name, int taskId)
        {
            SetNecceseryFields(id, taskId, name, 'u');
        }

    }
}
