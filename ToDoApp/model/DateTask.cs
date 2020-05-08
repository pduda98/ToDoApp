using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.model
{
    class DateTask
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public char TaskGroup { get; set; }
        public DateTime Date { get; set; }
        public char Status { get; set; }
    }
}
