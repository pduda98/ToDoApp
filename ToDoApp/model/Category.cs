using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Category
    {
        private int? _id;
        private string _name;
        private string _description = null;

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

        public Category(int id, string name)
        {
            SetId(id);
            SetName(name);
        }
    }
}
