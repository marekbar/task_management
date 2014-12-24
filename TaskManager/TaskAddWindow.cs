using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TaskLibrary;

namespace TaskManager
{
    public partial class TaskAddWindow : Form
    {
        #region STARTUP
        public TaskAddWindow()
        {
            InitializeComponent();
        }
        private void TaskAddWindow_Load(object sender, EventArgs e)
        {

            taskFiles.DragDrop += new
               System.Windows.Forms.DragEventHandler(this.files_DragDrop);
            taskFiles.DragEnter += new
               System.Windows.Forms.DragEventHandler(this.files_DragEnter);
        }
        #endregion

        #region DATA
        private int id = 0;
        public TaskLibrary.DB db = TaskLibrary.DB.Connect(
                    Properties.Settings.Default.adres,
                    Properties.Settings.Default.baza,
                    Properties.Settings.Default.login,
                    Properties.Settings.Default.haslo);


        string[] categories = null;
        string[] persons = null;
        private string[] statuses;
        List<string> files = new List<string>();
        private List<string> checklist = new List<string>();
        #endregion

        #region ACTIONS
        private void taskCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void open_FileOk(object sender, CancelEventArgs e)
        {
            files.Add(open.FileName);
            taskFiles.Items.Clear();
            taskFiles.Items.AddRange(files.ToArray());
        }

        private void taskAddAttachment_Click(object sender, EventArgs e)
        {
            open.ShowDialog();
        }

        private void taskRemoveAttachment_Click(object sender, EventArgs e)
        {
            int index = taskFiles.SelectedIndex;
            if (index != -1)
            {
                files.RemoveAt(index);
                taskFiles.Items.Clear();
                taskFiles.Items.AddRange(files.ToArray());
            }
        }

        private void clearForm()
        {
            taskName.Clear();
            taskDescription.Clear();
            taskFiles.Items.Clear();
            taskPerson.Items.Clear();
            taskCategory.Items.Clear();
            taskCheckList.Items.Clear();
            taskCheckText.Clear();
            taskStatus.Items.Clear();
            id = -1;
        }

        private void taskSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    string category = categories[taskCategory.SelectedIndex];
                    string login = persons[taskPerson.SelectedIndex];
                    string _status = statuses[taskStatus.SelectedIndex];
                    var me = Properties.Settings.Default.login_uzytkownika;

                    var task = new TaskLibrary.Models.Task
                        (
                            db.categories.Where(q => q.name == category).First().id,
                            taskName.Text,
                            taskDescription.Text,
                            db.users.Where(q => q.login == me).First().id,
                            db.users.Where(q => q.login == login).First().id,
                            db.status_list.Where(q => q.status == _status).First().id
                        );

          
                    if (task.Save(ref db))
                    {
                        id = task.Id;

                        foreach (var file in files)
                        {
                            TaskLibrary.Models.File.Save(ref db, file, id);
                        }

                        foreach (var check in checklist)
                        {
                            string sql = string.Format("INSERT INTO [zadania].[dbo].[checks]([task_id],[name],[is_checked])VALUES({0},'{1}',0)",
                                id, check);
                            db.Database.ExecuteSqlCommand(sql);                            
                        }


                        status.Text = "Zadanie zostało zapisane";
                        clearForm();
                    }
                    else
                    {
                        throw new Exception("Nie zapisano danych");
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                status.Text = ex.Message;
            }

        }


        private void buttonAddCheck_Click(object sender, EventArgs e)
        {
            checklist.Add(taskCheckText.Text);
            taskCheckList.Items.Clear();
            taskCheckText.Clear();
            taskCheckList.Items.AddRange(checklist.ToArray());
        }

        private void buttonRemoveCheck_Click(object sender, EventArgs e)
        {
            int index = taskCheckList.SelectedIndex;
            if (index != -1)
            {
                checklist.RemoveAt(index);
                taskCheckList.Items.Clear();
                taskCheckList.Items.AddRange(checklist.ToArray());
            }
        }
        #endregion

        #region DRAG_AND_DROP_FILES
        private void files_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else if (e.Data.GetDataPresent(typeof(TaskLibrary.Models.File)))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void files_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskLibrary.Models.File)))
            {

            }
            else
            {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                for (int i = 0; i < s.Length; i++)
                    files.Add(s[i]);

                taskFiles.Items.Clear();
                taskFiles.Items.AddRange(files.ToArray());
            }
        }

        private void files_DragLeave(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.StringFormat, false);
            for (int i = 0; i < s.Length; i++)
                files.Remove(s[i]);
            taskFiles.Items.Clear();
            taskFiles.Items.AddRange(files.ToArray());
        }

        #endregion

        #region DROP_AND_DOWN_DATA_LOAD
        private void taskStatus_DropDown(object sender, EventArgs e)
        {
            statuses = db.status_list.Select(s => s.status).ToArray();
            taskStatus.Items.Clear();
            taskStatus.Items.AddRange(statuses);
        }

        private void taskCheckText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddCheck.PerformClick();
            }
        }

        private void taskCategory_DropDown(object sender, EventArgs e)
        {
            categories = db.categories.Select(s => s.name).ToArray();
            taskCategory.Items.Clear();
            taskCategory.Items.AddRange(categories);
        }

        private void taskPerson_DropDown(object sender, EventArgs e)
        {
            persons = db.users.Select(s => s.login).ToArray();
            taskPerson.Items.Clear();
            taskPerson.Items.AddRange(persons);
        }

        #endregion

        #region CONTROLS
        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }

        private void EnableControls(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                EnableControls(con.Parent);
            }
        }
        #endregion
    }
}
