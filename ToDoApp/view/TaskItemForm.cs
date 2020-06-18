using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp.view
{
    public partial class TaskItemForm : Form
    {
        Task _task;
        MainForm _motherForm;
        public TaskItemForm(Task task, MainForm motherForm)
        {
            InitializeComponent();
            labelName.Text = task.Name;
            label1.Text = task.Description;
            label2.Text = task.Deadline.ToString();
            if(task.IsImportant == true)
            {
                this.BackColor = Color.FromArgb(255, 225, 225);
            }
            _task = task;
            _motherForm = motherForm;
        }

        private void buttonNotOK_Click(object sender, EventArgs e)
        {
            TaskHandler.SetTaskFailed((int)_task.Id);
            _motherForm.OpenUnfinishedTasks();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            TaskHandler.SetTaskFinished((int)_task.Id);
            _motherForm.OpenUnfinishedTasks();
        }
    }
}
