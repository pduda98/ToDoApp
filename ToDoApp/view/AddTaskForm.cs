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
    public partial class AddTaskForm : Form
    {
        private bool _isDeadline;
        private MainForm _masterForm;
        public AddTaskForm(MainForm sender)
        {
            InitializeComponent();
            _isDeadline = false;
            _masterForm = sender;

        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isDeadline)
            {
                _isDeadline = true;
                deadlineDateTimePicker.Visible = true;
            }
            else
            {
                _isDeadline = false;
                deadlineDateTimePicker.Visible = false;
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            Task tempTask = new Task(nameTextBox.Text,'u');
            tempTask.SetDescription(descriptionTextBox.Text);
            tempTask.SetIsImportant(isImportantCheckBox.Checked);
            tempTask.SetCategoryId(1);
            if (isDeadlineCheckBox.Checked)
            {
                tempTask.SetDeadline(deadlineDateTimePicker.Value);
            }
            TaskHandler.AddTask(tempTask);
            Close();
            _masterForm.RefreshPanel();
        }
    }
}
