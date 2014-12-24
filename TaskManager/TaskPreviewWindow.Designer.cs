namespace TaskManager
{
    partial class TaskPreviewWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskPreviewWindow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPerson = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.attachments = new System.Windows.Forms.ListBox();
            this.taskMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usuńZałączoneZałącznikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonRefresh = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbCheckItem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.todo = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.taskMenu.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(747, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dane podstawowe";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbCategory, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbStatus, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbPerson, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 442);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa zadania";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Location = new System.Drawing.Point(3, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(735, 23);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategoria zadania";
            // 
            // cbCategory
            // 
            this.cbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 66);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(735, 25);
            this.cbCategory.TabIndex = 3;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(735, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(3, 114);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(735, 25);
            this.cbStatus.TabIndex = 5;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(735, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Przydzielone do osoby";
            // 
            // cbPerson
            // 
            this.cbPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerson.FormattingEnabled = true;
            this.cbPerson.Location = new System.Drawing.Point(3, 162);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Size = new System.Drawing.Size(735, 25);
            this.cbPerson.TabIndex = 7;
            this.cbPerson.SelectedIndexChanged += new System.EventHandler(this.cbPerson_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.desc);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(747, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Opis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // desc
            // 
            this.desc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desc.Location = new System.Drawing.Point(3, 3);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(741, 442);
            this.desc.TabIndex = 0;
            this.desc.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.attachments);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(747, 448);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Załączniki";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // attachments
            // 
            this.attachments.AllowDrop = true;
            this.attachments.ContextMenuStrip = this.taskMenu;
            this.attachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attachments.FormattingEnabled = true;
            this.attachments.ItemHeight = 17;
            this.attachments.Location = new System.Drawing.Point(0, 0);
            this.attachments.Name = "attachments";
            this.attachments.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.attachments.Size = new System.Drawing.Size(747, 448);
            this.attachments.TabIndex = 0;
            // 
            // taskMenu
            // 
            this.taskMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuńZałączoneZałącznikiToolStripMenuItem});
            this.taskMenu.Name = "taskMenu";
            this.taskMenu.Size = new System.Drawing.Size(209, 26);
            // 
            // usuńZałączoneZałącznikiToolStripMenuItem
            // 
            this.usuńZałączoneZałącznikiToolStripMenuItem.Name = "usuńZałączoneZałącznikiToolStripMenuItem";
            this.usuńZałączoneZałącznikiToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.usuńZałączoneZałącznikiToolStripMenuItem.Text = "Usuń załączone załączniki";
            this.usuńZałączoneZałącznikiToolStripMenuItem.Click += new System.EventHandler(this.eventRemoveSelectedAttachments);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(747, 448);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Lista czynności";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(755, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(71, 22);
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status,
            this.progress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(755, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(100, 16);
            this.progress.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tbCheckItem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.todo, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(747, 448);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tbCheckItem
            // 
            this.tbCheckItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCheckItem.Location = new System.Drawing.Point(3, 3);
            this.tbCheckItem.Name = "tbCheckItem";
            this.tbCheckItem.Size = new System.Drawing.Size(741, 23);
            this.tbCheckItem.TabIndex = 0;
            this.tbCheckItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCheckItem_KeyDown);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(741, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // todo
            // 
            this.todo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todo.FormattingEnabled = true;
            this.todo.Location = new System.Drawing.Point(3, 61);
            this.todo.Name = "todo";
            this.todo.Size = new System.Drawing.Size(741, 384);
            this.todo.TabIndex = 2;
            this.todo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.todo_KeyDown);
            // 
            // TaskPreviewWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 525);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskPreviewWindow";
            this.Text = "Zadanie";
            this.Load += new System.EventHandler(this.TaskPreviewWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.taskMenu.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox desc;
        private System.Windows.Forms.ListBox attachments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPerson;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonRefresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripProgressBar progress;
        private System.Windows.Forms.ContextMenuStrip taskMenu;
        private System.Windows.Forms.ToolStripMenuItem usuńZałączoneZałącznikiToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbCheckItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox todo;
    }
}