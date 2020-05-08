using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.model
{
    class IntervalTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description  { get; set; } 
        public int CategoryId { get; set; }
        public DateTime FirstDeadline { get; set; }
        public TimeSpan Interval { get; set; }
        public bool IsImportant { get; set; }
    }
}
