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
    public partial class UnfinishedTasksForm : Form
    {
        MainForm _masterForm;
        public UnfinishedTasksForm(MainForm sender)
        {
            InitializeComponent();
            _masterForm = sender;
            List<Task> tasks = TaskHandler.GetUnfinishedTasks();
            CreateMyList(tasks);
            panelmain.Paint += dropShadow;
        }
        private void dropShadow(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[6];
            shadow[0] = Color.FromArgb(0, 0, 0);
            shadow[1] = Color.FromArgb(10, 10, 10);
            shadow[2] = Color.FromArgb(20, 20, 20);
            shadow[4] = Color.FromArgb(30, 30, 30);
            shadow[5] = Color.FromArgb(40, 40, 40);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 4; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X + sp, pt.Y, pt.X + p.Width - 1 + sp, pt.Y);
                        e.Graphics.DrawLine(pen, p.Right + sp, p.Top + sp, p.Right + sp, p.Bottom + sp);
                        pt.Y++;
                    }
                }
            }
        }
        private void CreateMyList(List<Task> tasks)
        {
            int i = 0;
            Panel[] eventPanel = new Panel[tasks.Count];
            foreach (Task task in tasks)
            {
                ///////Console.WriteLine(artist.Name + " asdasd");

                eventPanel[i] = new Panel
                {
                    Location = new Point(20, 100 * i + 20),
                    Name = "eventPanel" + (int)task.Id,
                    Size = new System.Drawing.Size(940, 80)
                };

                eventPanel[i].Paint += dropShadow;
                eventPanel[i].SuspendLayout();

                TaskItemForm myForm = new TaskItemForm(task, _masterForm)
                {

                    TopLevel = false,
                    AutoScroll = true
                };

                eventPanel[i].Controls.Add(myForm);
                myForm.Show();
                panelmain.Controls.Add(eventPanel[i]);
                eventPanel[i].ResumeLayout(false);
                i++;
            }
        }
    }
}
