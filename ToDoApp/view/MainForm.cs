using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp.view;

namespace ToDoApp
{
    public partial class MainForm : Form
    {
        
        public void RefreshPanel()
        {
            mainPanel.Controls.Clear();
            CreateMyPanel();
        }

        public void CreateMyPanel()
        {
            //List<Category> categories
            List<Task> tasks = TaskHandler.GetUnfinishedTasks();
            List<Category> categories = CategoryHandler.GetCategories();
            
            int i = 0;
            Panel[] taskPanel = new Panel[tasks.Count];
            Button[] failButton = new Button[tasks.Count];
            Button[] finishButton = new System.Windows.Forms.Button[tasks.Count];
            Button[] editButton = new System.Windows.Forms.Button[tasks.Count];
            Label[] statusLabel = new System.Windows.Forms.Label[tasks.Count];
            Label[] isImportantLabel = new System.Windows.Forms.Label[tasks.Count];
            Label[] deadlineLabel = new System.Windows.Forms.Label[tasks.Count];
            Label[] descriptionLabel = new System.Windows.Forms.Label[tasks.Count];
            Label[] nameLabel = new System.Windows.Forms.Label[tasks.Count];
            Label[] categoryLabel = new System.Windows.Forms.Label[tasks.Count];
            foreach (Task task in tasks)
            {
                taskPanel[i] = new Panel
                {
                    BackColor = System.Drawing.Color.LightSkyBlue,
                    Location = new Point(13, 13+ 144 * i),
                    Name = "tasktaskPanel" + (int)task.GetId(),
                    Size = new System.Drawing.Size(727, 142),
                    TabIndex = 9 + (int)task.GetId() * 9 + 5
                    
            };
                taskPanel[i].SuspendLayout();

                failButton[i] = new Button
                {
                    Location = new Point(615, 60),
                    Name = "failButton" + (int)task.GetId(),
                    Size = new System.Drawing.Size(75, 78),
                    TabIndex = 8 + (int)task.GetId() * 9 + 5,
                    Text = "nie udane",
                    UseVisualStyleBackColor = true,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.White,
                    //BackgroundImage = ((System.Drawing.Image)(TaskView.resources.GetObject("failButton.BackgroundImage")));
            };
                failButton[i].Click += (object sender, EventArgs e) =>
                {
                    TaskHandler.SetTaskFailed((int)task.GetId());
                    RefreshPanel();
                };

                finishButton[i] = new Button
                {
                    Location = new System.Drawing.Point(534, 60),
                    Name = "finishButton" + (int)task.GetId(),
                    Size = new System.Drawing.Size(75, 78),
                    TabIndex = 7 + (int)task.GetId() * 9 + 5,
                    Text = "zrobione",
                    UseVisualStyleBackColor = true,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.White
            };
                finishButton[i].Click += (object sender, EventArgs e) =>
                {
                    TaskHandler.SetTaskFinished((int)task.GetId());
                    RefreshPanel();
                };

                editButton[i] = new Button
                {
                    Location = new System.Drawing.Point(615, 3),
                    Name = "editButton" + (int)task.GetId(),
                    Size = new System.Drawing.Size(79, 23),
                    TabIndex = 6 + (int)task.GetId() * 9 + 5,
                    Text = "edytuj",
                    UseVisualStyleBackColor = true,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold)
                };
                
                statusLabel[i] = new Label
                {
                    Location = new System.Drawing.Point(322, 32),
                    Name = "statusLabel" + (int)task.GetId(),
                    Size = new System.Drawing.Size(100, 22),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    TabIndex = 5 + (int)task.GetId() * 9 + 5,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold)
                };
                if (task.GetStatus() == 'f')
                {
                    statusLabel[i].Text = "zadanie nieudane";
                }
                if (task.GetStatus() == 's')
                {
                    statusLabel[i].Text = "ukończone";
                }

                isImportantLabel[i] = new Label
                {
                    Location = new System.Drawing.Point(322, 4),
                    Name = "isImportatnLabel" + (int)task.GetId(),
                    Size = new System.Drawing.Size(100, 22),
                    TabIndex = 4 + (int)task.GetId() * 9 + 5,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold)
                };
                if (task.GetIsImportant()!=null && (bool)task.GetIsImportant())
                {
                    isImportantLabel[i].Text = "ważne";
                }

                deadlineLabel[i] = new Label
                {
                    Location = new System.Drawing.Point(428, 3),
                    Name = "deadlineLabel" + (int)task.GetId(),
                    Size = new System.Drawing.Size(100, 22),
                    TabIndex = 3 + (int)task.GetId() * 9 + 5,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold)
                };
                if (task.GetDeadline() != null)
                {
                    deadlineLabel[i].Text = task.GetDeadline().ToString();
                }

                descriptionLabel[i] = new Label
                {
                    Location = new System.Drawing.Point(4, 60),
                    Name = "decsriptionLabel" + (int)task.GetId(),
                    Size = new System.Drawing.Size(524, 78),
                    TabIndex = 1 + (int)task.GetId() * 9 + 5,
                    Text = task.GetDescription(),
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F)
                };
                
                nameLabel[i] = new Label
                {
                    Location = new System.Drawing.Point(4, 3),
                    //Multiline = true,
                    Name = "nameLabel" + (int)task.GetId(),
                   // ReadOnly = true,
                    Size = new System.Drawing.Size(312, 51),
                    TabIndex = 0 + (int)task.GetId() * 9 + 5,
                    Text = task.GetName(),
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold)
                };

                categoryLabel[i] = new Label
                {
                    Location = new System.Drawing.Point(428, 32),
                    Name = "categoryLabel" + (int)task.GetId(),
                    Size = new System.Drawing.Size(100, 22),
                    TabIndex = 2 + (int)task.GetId() * 9 + 5
                };
                if(categories.Exists(x => (int)x.GetId() == (int)task.GetCategoryId()))
                {
                    categoryLabel[i].Text = categories.Find(x => (int)x.GetId() == (int)task.GetCategoryId()).GetName();
                }
                 
                taskPanel[i].Controls.Add(failButton[i]);
                taskPanel[i].Controls.Add(finishButton[i]);
                taskPanel[i].Controls.Add(editButton[i]);
                taskPanel[i].Controls.Add(statusLabel[i]);
                taskPanel[i].Controls.Add(isImportantLabel[i]);
                taskPanel[i].Controls.Add(deadlineLabel[i]);
                taskPanel[i].Controls.Add(descriptionLabel[i]);
                taskPanel[i].Controls.Add(nameLabel[i]);
                taskPanel[i].Controls.Add(categoryLabel[i]);


                mainPanel.Controls.Add(taskPanel[i]);
                taskPanel[i].ResumeLayout(false);
                //taskPanel[i].PerformLayout();
                i++;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            CreateMyPanel();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm settingsForm = new AddTaskForm(this);

            // Show the settings form
            settingsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
