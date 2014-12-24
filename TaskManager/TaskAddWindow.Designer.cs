namespace TaskManager
{
    partial class TaskAddWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.taskName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.taskDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.taskCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.taskPerson = new System.Windows.Forms.ComboBox();
            this.taskFiles = new System.Windows.Forms.ListBox();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.taskRemoveAttachment = new System.Windows.Forms.Button();
            this.taskAddAttachment = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRemoveCheck = new System.Windows.Forms.Button();
            this.buttonAddCheck = new System.Windows.Forms.Button();
            this.taskCheckText = new System.Windows.Forms.TextBox();
            this.taskCheckList = new System.Windows.Forms.ListBox();
            this.taskSave = new System.Windows.Forms.Button();
            this.taskCancel = new System.Windows.Forms.Button();
            this.taskStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa zadania";
            // 
            // taskName
            // 
            this.taskName.BackColor = System.Drawing.Color.White;
            this.taskName.ForeColor = System.Drawing.Color.Black;
            this.taskName.Location = new System.Drawing.Point(15, 29);
            this.taskName.Multiline = true;
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(529, 76);
            this.taskName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis zadania";
            // 
            // taskDescription
            // 
            this.taskDescription.BackColor = System.Drawing.Color.White;
            this.taskDescription.ForeColor = System.Drawing.Color.Black;
            this.taskDescription.Location = new System.Drawing.Point(15, 128);
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(529, 346);
            this.taskDescription.TabIndex = 2;
            this.taskDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategoria";
            // 
            // taskCategory
            // 
            this.taskCategory.BackColor = System.Drawing.Color.White;
            this.taskCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskCategory.ForeColor = System.Drawing.Color.Black;
            this.taskCategory.FormattingEnabled = true;
            this.taskCategory.Location = new System.Drawing.Point(15, 497);
            this.taskCategory.Name = "taskCategory";
            this.taskCategory.Size = new System.Drawing.Size(255, 25);
            this.taskCategory.TabIndex = 3;
            this.taskCategory.DropDown += new System.EventHandler(this.taskCategory_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Przypisz do osoby";
            // 
            // taskPerson
            // 
            this.taskPerson.BackColor = System.Drawing.Color.White;
            this.taskPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskPerson.ForeColor = System.Drawing.Color.Black;
            this.taskPerson.FormattingEnabled = true;
            this.taskPerson.Location = new System.Drawing.Point(284, 497);
            this.taskPerson.Name = "taskPerson";
            this.taskPerson.Size = new System.Drawing.Size(255, 25);
            this.taskPerson.TabIndex = 4;
            this.taskPerson.DropDown += new System.EventHandler(this.taskPerson_DropDown);
            // 
            // taskFiles
            // 
            this.taskFiles.AllowDrop = true;
            this.taskFiles.BackColor = System.Drawing.Color.White;
            this.taskFiles.ForeColor = System.Drawing.Color.Black;
            this.taskFiles.FormattingEnabled = true;
            this.taskFiles.ItemHeight = 17;
            this.taskFiles.Location = new System.Drawing.Point(12, 24);
            this.taskFiles.Name = "taskFiles";
            this.taskFiles.Size = new System.Drawing.Size(372, 174);
            this.taskFiles.TabIndex = 6;
            // 
            // open
            // 
            this.open.FileName = "openFileDialog1";
            this.open.FileOk += new System.ComponentModel.CancelEventHandler(this.open_FileOk);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(950, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.taskFiles);
            this.groupBox1.Controls.Add(this.taskRemoveAttachment);
            this.groupBox1.Controls.Add(this.taskAddAttachment);
            this.groupBox1.Location = new System.Drawing.Point(550, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 249);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Załączniki";
            // 
            // taskRemoveAttachment
            // 
            this.taskRemoveAttachment.Image = global::TaskManager.Properties.Resources.delete32;
            this.taskRemoveAttachment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskRemoveAttachment.Location = new System.Drawing.Point(218, 204);
            this.taskRemoveAttachment.Name = "taskRemoveAttachment";
            this.taskRemoveAttachment.Size = new System.Drawing.Size(166, 39);
            this.taskRemoveAttachment.TabIndex = 8;
            this.taskRemoveAttachment.Text = "Usuń zaznaczony plik";
            this.taskRemoveAttachment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taskRemoveAttachment.UseVisualStyleBackColor = true;
            this.taskRemoveAttachment.Click += new System.EventHandler(this.taskRemoveAttachment_Click);
            // 
            // taskAddAttachment
            // 
            this.taskAddAttachment.Image = global::TaskManager.Properties.Resources.plus32;
            this.taskAddAttachment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskAddAttachment.Location = new System.Drawing.Point(12, 204);
            this.taskAddAttachment.Name = "taskAddAttachment";
            this.taskAddAttachment.Size = new System.Drawing.Size(109, 39);
            this.taskAddAttachment.TabIndex = 7;
            this.taskAddAttachment.Text = "Załącz plik";
            this.taskAddAttachment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taskAddAttachment.UseVisualStyleBackColor = true;
            this.taskAddAttachment.Click += new System.EventHandler(this.taskAddAttachment_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonRemoveCheck);
            this.groupBox2.Controls.Add(this.buttonAddCheck);
            this.groupBox2.Controls.Add(this.taskCheckText);
            this.groupBox2.Controls.Add(this.taskCheckList);
            this.groupBox2.Location = new System.Drawing.Point(550, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 258);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista podpunktów do zrobienia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nazwa:";
            // 
            // buttonRemoveCheck
            // 
            this.buttonRemoveCheck.Image = global::TaskManager.Properties.Resources.delete32;
            this.buttonRemoveCheck.Location = new System.Drawing.Point(344, 209);
            this.buttonRemoveCheck.Name = "buttonRemoveCheck";
            this.buttonRemoveCheck.Size = new System.Drawing.Size(40, 40);
            this.buttonRemoveCheck.TabIndex = 12;
            this.buttonRemoveCheck.UseVisualStyleBackColor = true;
            this.buttonRemoveCheck.Click += new System.EventHandler(this.buttonRemoveCheck_Click);
            // 
            // buttonAddCheck
            // 
            this.buttonAddCheck.Image = global::TaskManager.Properties.Resources.plus32;
            this.buttonAddCheck.Location = new System.Drawing.Point(302, 209);
            this.buttonAddCheck.Name = "buttonAddCheck";
            this.buttonAddCheck.Size = new System.Drawing.Size(40, 40);
            this.buttonAddCheck.TabIndex = 11;
            this.buttonAddCheck.UseVisualStyleBackColor = true;
            this.buttonAddCheck.Click += new System.EventHandler(this.buttonAddCheck_Click);
            // 
            // taskCheckText
            // 
            this.taskCheckText.BackColor = System.Drawing.Color.White;
            this.taskCheckText.ForeColor = System.Drawing.Color.Black;
            this.taskCheckText.Location = new System.Drawing.Point(6, 224);
            this.taskCheckText.Name = "taskCheckText";
            this.taskCheckText.Size = new System.Drawing.Size(290, 25);
            this.taskCheckText.TabIndex = 10;
            this.taskCheckText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taskCheckText_KeyDown);
            // 
            // taskCheckList
            // 
            this.taskCheckList.BackColor = System.Drawing.Color.White;
            this.taskCheckList.ForeColor = System.Drawing.Color.Black;
            this.taskCheckList.FormattingEnabled = true;
            this.taskCheckList.ItemHeight = 17;
            this.taskCheckList.Location = new System.Drawing.Point(6, 24);
            this.taskCheckList.Name = "taskCheckList";
            this.taskCheckList.Size = new System.Drawing.Size(378, 174);
            this.taskCheckList.TabIndex = 9;
            // 
            // taskSave
            // 
            this.taskSave.Image = global::TaskManager.Properties.Resources.save32;
            this.taskSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskSave.Location = new System.Drawing.Point(757, 528);
            this.taskSave.Name = "taskSave";
            this.taskSave.Size = new System.Drawing.Size(89, 39);
            this.taskSave.TabIndex = 13;
            this.taskSave.Text = "Zapisz";
            this.taskSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taskSave.UseVisualStyleBackColor = true;
            this.taskSave.Click += new System.EventHandler(this.taskSave_Click);
            // 
            // taskCancel
            // 
            this.taskCancel.Image = global::TaskManager.Properties.Resources.exit32;
            this.taskCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskCancel.Location = new System.Drawing.Point(852, 528);
            this.taskCancel.Name = "taskCancel";
            this.taskCancel.Size = new System.Drawing.Size(89, 39);
            this.taskCancel.TabIndex = 14;
            this.taskCancel.Text = "Zamknij";
            this.taskCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taskCancel.UseVisualStyleBackColor = true;
            this.taskCancel.Click += new System.EventHandler(this.taskCancel_Click);
            // 
            // taskStatus
            // 
            this.taskStatus.BackColor = System.Drawing.Color.White;
            this.taskStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskStatus.ForeColor = System.Drawing.Color.Black;
            this.taskStatus.FormattingEnabled = true;
            this.taskStatus.Location = new System.Drawing.Point(15, 548);
            this.taskStatus.Name = "taskStatus";
            this.taskStatus.Size = new System.Drawing.Size(255, 25);
            this.taskStatus.TabIndex = 5;
            this.taskStatus.DropDown += new System.EventHandler(this.taskStatus_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Status zadania";
            // 
            // TaskAddWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(950, 599);
            this.ControlBox = false;
            this.Controls.Add(this.taskStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.taskSave);
            this.Controls.Add(this.taskCancel);
            this.Controls.Add(this.taskPerson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taskCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskAddWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nowe zadanie";
            this.Load += new System.EventHandler(this.TaskAddWindow_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taskName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox taskDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox taskCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox taskPerson;
        private System.Windows.Forms.ListBox taskFiles;
        private System.Windows.Forms.Button taskCancel;
        private System.Windows.Forms.Button taskSave;
        private System.Windows.Forms.Button taskRemoveAttachment;
        private System.Windows.Forms.Button taskAddAttachment;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAddCheck;
        private System.Windows.Forms.TextBox taskCheckText;
        private System.Windows.Forms.ListBox taskCheckList;
        private System.Windows.Forms.Button buttonRemoveCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox taskStatus;
        private System.Windows.Forms.Label label6;
    }
}