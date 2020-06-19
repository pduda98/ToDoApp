using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp.view;
using FontAwesome.Sharp;

namespace ToDoApp
{
    public partial class MainForm : Form
    {
        //Fields
        private IconButton CurrentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        


        public void RefreshPanel()
        {
            mainPanel.Controls.Clear();
        }

        public void CreateMyPanel(List<Task> tasks)
        {
            //List<Category> categories
            
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
                    Location = new Point(13, 13 + 144 * i),
                    Name = "tasktaskPanel" + (int)task.Id,
                    Size = new System.Drawing.Size(727, 142),
                    TabIndex = 9 + (int)task.Id * 9 + 5

                };
                taskPanel[i].SuspendLayout();

                failButton[i] = new Button
                {
                    Location = new Point(615, 60),
                    Name = "failButton" + (int)task.Id,
                    Size = new System.Drawing.Size(75, 78),
                    TabIndex = 8 + (int)task.Id * 9 + 5,
                    Text = "nie udane",
                    UseVisualStyleBackColor = true,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.White,
                    //BackgroundImage = ((System.Drawing.Image)(TaskView.resources.GetObject("failButton.BackgroundImage")));
                };
                failButton[i].Click += (object sender, EventArgs e) =>
                {
                    TaskHandler.SetTaskFailed((int)task.Id);
                    RefreshPanel();
                };

                finishButton[i] = new Button
                {
                    Location = new System.Drawing.Point(534, 60),
                    Name = "finishButton" + (int)task.Id,
                    Size = new System.Drawing.Size(75, 78),
                    TabIndex = 7 + (int)task.Id * 9 + 5,
                    Text = "zrobione",
                    UseVisualStyleBackColor = true,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.White
                };
                finishButton[i].Click += (object sender, EventArgs e) =>
                {
                    TaskHandler.SetTaskFinished((int)task.Id);
                    RefreshPanel();
                };

                editButton[i] = new Button
                {
                    Location = new System.Drawing.Point(615, 3),
                    Name = "editButton" + (int)task.Id,
                    Size = new System.Drawing.Size(79, 23),
                    TabIndex = 6 + (int)task.Id * 9 + 5,
                    Text = "edytuj",
                    UseVisualStyleBackColor = true,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold)
                };

                statusLabel[i] = new Label
                {
                    Location = new System.Drawing.Point(322, 32),
                    Name = "statusLabel" + (int)task.Id,
                    Size = new System.Drawing.Size(100, 22),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    TabIndex = 5 + (int)task.Id * 9 + 5,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold)
                };
                if (task.Status == 'f')
                {
                    statusLabel[i].Text = "zadanie nieudane";
                }
                if (task.Status == 's')
                {
                    statusLabel[i].Text = "ukończone";
                }

                isImportantLabel[i] = new Label
                {
                    Location = new System.Drawing.Point(322, 4),
                    Name = "isImportatnLabel" + (int)task.Id,
                    Size = new System.Drawing.Size(100, 22),
                    TabIndex = 4 + (int)task.Id * 9 + 5,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold)
                };
                if ((bool)task.IsImportant)
                {
                    isImportantLabel[i].Text = "ważne";
                }

                deadlineLabel[i] = new Label
                {
                    Location = new System.Drawing.Point(428, 3),
                    Name = "deadlineLabel" + (int)task.Id,
                    Size = new System.Drawing.Size(100, 22),
                    TabIndex = 3 + (int)task.Id * 9 + 5,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold)
                };
                if (task.Deadline != null)
                {
                    deadlineLabel[i].Text = task.Deadline.ToString();
                }

                descriptionLabel[i] = new Label
                {
                    Location = new System.Drawing.Point(4, 60),
                    Name = "decsriptionLabel" + (int)task.Id,
                    Size = new System.Drawing.Size(524, 78),
                    TabIndex = 1 + (int)task.Id * 9 + 5,
                    Text = task.Description,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F)
                };

                nameLabel[i] = new Label
                {
                    Location = new System.Drawing.Point(4, 3),
                    //Multiline = true,
                    Name = "nameLabel" + (int)task.Id,
                    // ReadOnly = true,
                    Size = new System.Drawing.Size(312, 51),
                    TabIndex = 0 + (int)task.Id * 9 + 5,
                    Text = task.Name,
                    Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold)
                };

                categoryLabel[i] = new Label
                {
                    Location = new System.Drawing.Point(428, 32),
                    Name = "categoryLabel" + (int)task.Id,
                    Size = new System.Drawing.Size(100, 22),
                    TabIndex = 2 + (int)task.Id * 9 + 5
                };
                if (categories.Exists(x => (int)x.Id == (int)task.CategoryId))
                {
                    categoryLabel[i].Text = categories.Find(x => (int)x.Id == (int)task.CategoryId).Name;
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


                panelmain.Controls.Add(taskPanel[i]);
                taskPanel[i].ResumeLayout(false);
                //taskPanel[i].PerformLayout();
                i++;
            }
        }


        //Constructor
        public MainForm()
        {
            InitializeComponent();
            List<Task> tasks = TaskHandler.GetUnfinishedTasks();
            //CreateMyPanel(tasks);
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60); //60 to rozmiar przycisku

            //Usunięcie góry formularza
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            iconButtonExit.BackgroundImage = Image.FromFile(".\\pics\\Exit.png");
            iconButtonExit.BackgroundImageLayout = ImageLayout.Stretch;

            iconButtonMinimize.BackgroundImage = Image.FromFile(".\\pics\\Minimize.png");
            iconButtonMinimize.BackgroundImageLayout = ImageLayout.Stretch;

            iconButtonMaximize.BackgroundImage = Image.FromFile(".\\pics\\Maximize.png");
            iconButtonMaximize.BackgroundImageLayout = ImageLayout.Stretch;
        }

        //podświetlenie przycisku
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                CurrentBtn = (IconButton)senderBtn;
                CurrentBtn.BackColor = Color.FromArgb(37, 36, 81);
                CurrentBtn.ForeColor = color;
                CurrentBtn.TextAlign = ContentAlignment.MiddleCenter;
                CurrentBtn.IconColor = color;
                CurrentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, CurrentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
            iconCurrentChildForm.IconChar = CurrentBtn.IconChar;
            iconCurrentChildForm.IconColor = color;
        }

        //wyłączenie podświetlenia
        private void DisableButton()
        {
            if (CurrentBtn != null)
            {
                CurrentBtn.BackColor = Color.DarkSlateBlue; //tutaj kolor przycisku
                CurrentBtn.ForeColor = Color.WhiteSmoke;
                CurrentBtn.TextAlign = ContentAlignment.MiddleCenter;
                CurrentBtn.IconColor = Color.WhiteSmoke;
                CurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

         private void OpenChildForm(Form childForm)
    {
        //open only form
        if (currentChildForm != null)
        {
            currentChildForm.Close();
        }
        currentChildForm = childForm;
        //End
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        panelDesktop.Controls.Add(childForm);
        panelDesktop.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
        
        lbTitleChildForm.Text = childForm.Text;
    }

        //Przechowuje kolory RGB
        private struct RGBColors
        {

            public static Color color1 = Color.FromArgb(153, 50, 204); //w ten sposób jakie chcesz RGB

        }





        private void addTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm settingsForm = new AddTaskForm(this);

            // Show the settings form
            settingsForm.Show();
        }
        public void OpenUnfinishedTasks()
        {
            OpenChildForm(new UnfinishedTasksForm(this));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new UnfinishedTasksForm(this));
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            // OpenChildForm(new NAZWAFORMULARZA());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            // OpenChildForm(new NAZWAFORMULARZA());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            // OpenChildForm(new NAZWAFORMULARZA());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            // OpenChildForm(new NAZWAFORMULARZA());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            // OpenChildForm(new NAZWAFORMULARZA());
        }

        //Resetuje status przycisków do nieaktywnych
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lbTitleChildForm.Text = "Home";
        }
        //Events
        //Reset
        private void btnHome_Click(object sender, EventArgs e)
        {

            Reset();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Przesuwanie formularza za pomocą TitleBar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }





        //3 przyciski w kącie
        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Minimized;
        }

        private void iconButtonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
               WindowState = FormWindowState.Maximized;
            else
               WindowState = FormWindowState.Normal;
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        private void OnMouseEntericonButtonExit(object sender, EventArgs e)
        {
            iconButtonExit.BackColor = Color.Red;
        }
        private void OnMouseLeaveiconButtonExit(object sender, EventArgs e)
        {
            iconButtonExit.BackColor = Color.Transparent;
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
