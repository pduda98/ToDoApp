namespace ToDoApp
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.isOnlyImportantButton = new System.Windows.Forms.Button();
            this.finishedButton = new System.Windows.Forms.Button();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Location = new System.Drawing.Point(13, 74);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(954, 754);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTaskButton.BackgroundImage")));
            this.addTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTaskButton.CausesValidation = false;
            this.addTaskButton.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.addTaskButton.ForeColor = System.Drawing.Color.White;
            this.addTaskButton.Location = new System.Drawing.Point(25, 13);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(236, 55);
            this.addTaskButton.TabIndex = 1;
            this.addTaskButton.Text = "DODAJ ZADANIE";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // isOnlyImportantButton
            // 
            this.isOnlyImportantButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("isOnlyImportantButton.BackgroundImage")));
            this.isOnlyImportantButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.isOnlyImportantButton.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.isOnlyImportantButton.ForeColor = System.Drawing.Color.White;
            this.isOnlyImportantButton.Location = new System.Drawing.Point(254, 13);
            this.isOnlyImportantButton.Name = "isOnlyImportantButton";
            this.isOnlyImportantButton.Size = new System.Drawing.Size(236, 55);
            this.isOnlyImportantButton.TabIndex = 2;
            this.isOnlyImportantButton.Text = "WAZNE";
            this.isOnlyImportantButton.UseVisualStyleBackColor = true;
            // 
            // finishedButton
            // 
            this.finishedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finishedButton.BackgroundImage")));
            this.finishedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finishedButton.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.finishedButton.ForeColor = System.Drawing.Color.White;
            this.finishedButton.Location = new System.Drawing.Point(489, 13);
            this.finishedButton.Name = "finishedButton";
            this.finishedButton.Size = new System.Drawing.Size(236, 55);
            this.finishedButton.TabIndex = 3;
            this.finishedButton.Text = "UKONCZONE";
            this.finishedButton.UseVisualStyleBackColor = true;
            // 
            // categoriesButton
            // 
            this.categoriesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoriesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("categoriesButton.BackgroundImage")));
            this.categoriesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoriesButton.CausesValidation = false;
            this.categoriesButton.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesButton.ForeColor = System.Drawing.Color.White;
            this.categoriesButton.Location = new System.Drawing.Point(724, 13);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(236, 55);
            this.categoriesButton.TabIndex = 4;
            this.categoriesButton.Text = "KATEGORIE";
            this.categoriesButton.UseVisualStyleBackColor = false;
            this.categoriesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 840);
            this.Controls.Add(this.finishedButton);
            this.Controls.Add(this.categoriesButton);
            this.Controls.Add(this.isOnlyImportantButton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.addTaskButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "ToDo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button isOnlyImportantButton;
        private System.Windows.Forms.Button finishedButton;
        private System.Windows.Forms.Button categoriesButton;
    }
}

