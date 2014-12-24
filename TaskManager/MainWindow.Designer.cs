namespace TaskManager
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.widokiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatuses = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.czynnościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddTask = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.taskCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.hoursCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.hoursWeekCount = new System.Windows.Forms.ToolStripLabel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuTaskAttachments = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaskcheckList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikacjaToolStripMenuItem,
            this.widokiToolStripMenuItem,
            this.czynnościToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(924, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikacjaToolStripMenuItem
            // 
            this.aplikacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettings,
            this.menuEnd});
            this.aplikacjaToolStripMenuItem.Name = "aplikacjaToolStripMenuItem";
            this.aplikacjaToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.aplikacjaToolStripMenuItem.Text = "Aplikacja";
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(131, 22);
            this.menuSettings.Text = "Ustawienia";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // menuEnd
            // 
            this.menuEnd.Name = "menuEnd";
            this.menuEnd.Size = new System.Drawing.Size(131, 22);
            this.menuEnd.Text = "Zakończ";
            this.menuEnd.Click += new System.EventHandler(this.menuEnd_Click);
            // 
            // widokiToolStripMenuItem
            // 
            this.widokiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStatuses,
            this.menuCategories});
            this.widokiToolStripMenuItem.Name = "widokiToolStripMenuItem";
            this.widokiToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.widokiToolStripMenuItem.Text = "Widoki";
            // 
            // menuStatuses
            // 
            this.menuStatuses.Name = "menuStatuses";
            this.menuStatuses.Size = new System.Drawing.Size(181, 22);
            this.menuStatuses.Text = "Lista statusów";
            this.menuStatuses.Click += new System.EventHandler(this.listaStatusówToolStripMenuItem_Click);
            // 
            // menuCategories
            // 
            this.menuCategories.Name = "menuCategories";
            this.menuCategories.Size = new System.Drawing.Size(181, 22);
            this.menuCategories.Text = "Lista kategorii zadań";
            this.menuCategories.Click += new System.EventHandler(this.menuCategories_Click);
            // 
            // czynnościToolStripMenuItem
            // 
            this.czynnościToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddTask});
            this.czynnościToolStripMenuItem.Name = "czynnościToolStripMenuItem";
            this.czynnościToolStripMenuItem.Size = new System.Drawing.Size(73, 19);
            this.czynnościToolStripMenuItem.Text = "Czynności";
            // 
            // menuAddTask
            // 
            this.menuAddTask.Name = "menuAddTask";
            this.menuAddTask.Size = new System.Drawing.Size(148, 22);
            this.menuAddTask.Text = "Dodaj zadanie";
            this.menuAddTask.Click += new System.EventHandler(this.menuAddTask_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 641);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(924, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.taskCount,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.hoursCount,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.hoursWeekCount});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(145, 22);
            this.toolStripLabel1.Text = "Liczba zadań do zrobienia:";
            // 
            // taskCount
            // 
            this.taskCount.Name = "taskCount";
            this.taskCount.Size = new System.Drawing.Size(13, 22);
            this.taskCount.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(170, 22);
            this.toolStripLabel2.Text = "Przepracowane godziny dzisiaj:";
            // 
            // hoursCount
            // 
            this.hoursCount.Name = "hoursCount";
            this.hoursCount.Size = new System.Drawing.Size(13, 22);
            this.hoursCount.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(222, 22);
            this.toolStripLabel3.Text = "Przepracowane godziny w tym tygodniu:";
            // 
            // hoursWeekCount
            // 
            this.hoursWeekCount.Name = "hoursWeekCount";
            this.hoursWeekCount.Size = new System.Drawing.Size(13, 22);
            this.hoursWeekCount.Text = "0";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ContextMenuStrip = this.contextMenu;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid.Location = new System.Drawing.Point(0, 50);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(924, 591);
            this.grid.TabIndex = 3;
            this.grid.DoubleClick += new System.EventHandler(this.grid_DoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTaskAttachments,
            this.menuTaskcheckList});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(289, 48);
            this.contextMenu.Opened += new System.EventHandler(this.contextMenu_Opened);
            // 
            // menuTaskAttachments
            // 
            this.menuTaskAttachments.Name = "menuTaskAttachments";
            this.menuTaskAttachments.Size = new System.Drawing.Size(288, 22);
            this.menuTaskAttachments.Text = "Załączniki";
            // 
            // menuTaskcheckList
            // 
            this.menuTaskcheckList.Name = "menuTaskcheckList";
            this.menuTaskcheckList.Size = new System.Drawing.Size(288, 22);
            this.menuTaskcheckList.Text = "Lista czynności / punktów do wykonania";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 663);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zadania";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikacjaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripMenuItem menuEnd;
        private System.Windows.Forms.ToolStripMenuItem widokiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStatuses;
        private System.Windows.Forms.ToolStripMenuItem menuCategories;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel taskCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel hoursCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel hoursWeekCount;
        private System.Windows.Forms.ToolStripMenuItem czynnościToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddTask;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuTaskAttachments;
        private System.Windows.Forms.ToolStripMenuItem menuTaskcheckList;
    }
}