namespace ToDoApp.view
{
    partial class AddTaskForm
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
            System.Windows.Forms.TextBox textBox2;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.isImportantCheckBox = new System.Windows.Forms.CheckBox();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.deadlineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isDeadlineCheckBox = new System.Windows.Forms.CheckBox();
            textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.HideSelection = false;
            textBox2.Location = new System.Drawing.Point(57, 136);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(100, 22);
            textBox2.TabIndex = 1;
            textBox2.Text = "Opis:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(57, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "zadanie:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(57, 90);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(174, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(57, 164);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(319, 60);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // isImportantCheckBox
            // 
            this.isImportantCheckBox.AutoSize = true;
            this.isImportantCheckBox.Location = new System.Drawing.Point(57, 240);
            this.isImportantCheckBox.Name = "isImportantCheckBox";
            this.isImportantCheckBox.Size = new System.Drawing.Size(74, 21);
            this.isImportantCheckBox.TabIndex = 4;
            this.isImportantCheckBox.Text = "Ważne";
            this.isImportantCheckBox.UseVisualStyleBackColor = true;
            this.isImportantCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(57, 388);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(144, 50);
            this.addTaskButton.TabIndex = 5;
            this.addTaskButton.Text = "dodaj";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // deadlineDateTimePicker
            // 
            this.deadlineDateTimePicker.Location = new System.Drawing.Point(176, 319);
            this.deadlineDateTimePicker.Name = "deadlineDateTimePicker";
            this.deadlineDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.deadlineDateTimePicker.TabIndex = 6;
            this.deadlineDateTimePicker.Visible = false;
            // 
            // isDeadlineCheckBox
            // 
            this.isDeadlineCheckBox.AutoSize = true;
            this.isDeadlineCheckBox.Location = new System.Drawing.Point(57, 319);
            this.isDeadlineCheckBox.Name = "isDeadlineCheckBox";
            this.isDeadlineCheckBox.Size = new System.Drawing.Size(84, 21);
            this.isDeadlineCheckBox.TabIndex = 7;
            this.isDeadlineCheckBox.Text = "deadline";
            this.isDeadlineCheckBox.UseVisualStyleBackColor = true;
            this.isDeadlineCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.isDeadlineCheckBox);
            this.Controls.Add(this.deadlineDateTimePicker);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.isImportantCheckBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.CheckBox isImportantCheckBox;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.DateTimePicker deadlineDateTimePicker;
        private System.Windows.Forms.CheckBox isDeadlineCheckBox;
    }
}