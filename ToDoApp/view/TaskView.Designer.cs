namespace ToDoApp.view
{
    partial class TaskView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.failButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.isImportatnLabel = new System.Windows.Forms.Label();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.decsriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.failButton);
            this.panel1.Controls.Add(this.finishButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.isImportatnLabel);
            this.panel1.Controls.Add(this.deadlineLabel);
            this.panel1.Controls.Add(this.decsriptionLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.categoryLabel);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 142);
            this.panel1.TabIndex = 0;
            // 
            // failButton
            // 
            this.failButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("failButton.BackgroundImage")));
            this.failButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.failButton.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.failButton.ForeColor = System.Drawing.Color.White;
            this.failButton.Location = new System.Drawing.Point(631, 60);
            this.failButton.Name = "failButton";
            this.failButton.Size = new System.Drawing.Size(91, 75);
            this.failButton.TabIndex = 8;
            this.failButton.Text = "NIE UDANE";
            this.failButton.UseVisualStyleBackColor = true;
            this.failButton.Click += new System.EventHandler(this.failButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finishButton.BackgroundImage")));
            this.finishButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finishButton.Font = new System.Drawing.Font("Microsoft JhengHei", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.ForeColor = System.Drawing.Color.White;
            this.finishButton.Location = new System.Drawing.Point(534, 60);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(91, 75);
            this.finishButton.TabIndex = 7;
            this.finishButton.Text = "ZROBIONE";
            this.finishButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.editButton.ForeColor = System.Drawing.Color.DimGray;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.Location = new System.Drawing.Point(633, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(91, 44);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "EDYTUJ";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(289, 32);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 15);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Ukończone";
            // 
            // isImportatnLabel
            // 
            this.isImportatnLabel.Location = new System.Drawing.Point(289, 4);
            this.isImportatnLabel.Name = "isImportatnLabel";
            this.isImportatnLabel.Size = new System.Drawing.Size(100, 22);
            this.isImportatnLabel.TabIndex = 4;
            this.isImportatnLabel.Text = "WAZNE";
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.Location = new System.Drawing.Point(395, 3);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(133, 22);
            this.deadlineLabel.TabIndex = 3;
            this.deadlineLabel.Text = "00-00-00-0000 00:00";
            // 
            // decsriptionLabel
            // 
            this.decsriptionLabel.BackColor = System.Drawing.Color.PowderBlue;
            this.decsriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decsriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.decsriptionLabel.Location = new System.Drawing.Point(3, 60);
            this.decsriptionLabel.Name = "decsriptionLabel";
            this.decsriptionLabel.Size = new System.Drawing.Size(525, 75);
            this.decsriptionLabel.TabIndex = 1;
            this.decsriptionLabel.Text = resources.GetString("decsriptionLabel.Text");
            this.decsriptionLabel.Click += new System.EventHandler(this.decsriptionLabel_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(17, 17);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(266, 43);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Lorem ipsum lorem Ipsum";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Location = new System.Drawing.Point(395, 32);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(133, 22);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Kategoria";
            // 
            // TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.panel1);
            this.Name = "TaskView";
            this.Text = "TaskView";
            this.Load += new System.EventHandler(this.TaskView_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button failButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label isImportatnLabel;
        private System.Windows.Forms.Label deadlineLabel;
        private System.Windows.Forms.Label decsriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label categoryLabel;
    }
}