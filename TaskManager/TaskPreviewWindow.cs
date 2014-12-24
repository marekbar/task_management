using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class TaskPreviewWindow : Form
    {
        public int TaskId { get; set; }
        private TaskLibrary.Models.Task task = null;
        private TaskLibrary.DB db = TaskLibrary.DB.Connect(
                    Properties.Settings.Default.adres,
                    Properties.Settings.Default.baza,
                    Properties.Settings.Default.login,
                    Properties.Settings.Default.haslo);
        private List<int> attachementsIds = new List<int>();
        private List<int> todoIds = new List<int>();
        private BackgroundWorker worker = new BackgroundWorker();
        public TaskPreviewWindow()
        {
            InitializeComponent();
        }

        private void TaskPreviewWindow_Load(object sender, EventArgs e)
        {
            loadTask();
            
            this.AllowDrop = true;
            attachments.AllowDrop = true;
            todo.AllowDrop = true;
            desc.AllowDrop = true;

            attachments.DragDrop += new System.Windows.Forms.DragEventHandler(this.files_DragDrop);
            attachments.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterEvent);
            
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.files_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterEvent);

            desc.DragDrop += new System.Windows.Forms.DragEventHandler(this.desc_DragDrop);
            desc.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterEvent);
        }


        private void desc_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                string text = (string)e.Data.GetData(DataFormats.Text, false);
                desc.Text += text;
            }
        }

        private void DragEnterEvent(object sender, System.Windows.Forms.DragEventArgs e)
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
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                worker.WorkerReportsProgress = true;
                worker.DoWork += (aa, bb) => 
                {
                    TaskLibrary.DB _db = TaskLibrary.DB.Connect(
                    Properties.Settings.Default.adres,
                    Properties.Settings.Default.baza,
                    Properties.Settings.Default.login,
                    Properties.Settings.Default.haslo);

                    var data = (string[])bb.Argument;
                    for (int i = 0; i < data.Length; i++)
                    {
                        TaskLibrary.Models.File.Save(ref _db, data[i], TaskId);
                        ((BackgroundWorker)aa).ReportProgress(i);
                    }
                };

                worker.ProgressChanged += (aa, bb) => 
                {
                    progress.Value = bb.ProgressPercentage;
                };
                worker.RunWorkerCompleted += (aa, bb) => 
                {
                    status.Text = "Pliki zostały dodane jako załączniki.";
                    progress.Visible = false;
                    loadTask();
                };

                progress.Visible = true;
                progress.Minimum = 0;
                progress.Maximum = files.Length;
                progress.Value = 0;
                status.Text = "Dodawanie załączników...";
                worker.RunWorkerAsync(files);             
            }
        }


        private void loadTask()
        {
            if (TaskId <= 0)
            {
                Close();
            }

            worker.DoWork += (aa, bb) => 
            {
                var taskId = (int)bb.Argument;
                var results = new List<object>();
                TaskLibrary.DB _db = TaskLibrary.DB.Connect(
                    Properties.Settings.Default.adres,
                    Properties.Settings.Default.baza,
                    Properties.Settings.Default.login,
                    Properties.Settings.Default.haslo);
                
                results.Add(TaskLibrary.Models.Task.Get(taskId, ref db));
                results.Add(TaskLibrary.Models.TaskCategory.GetAll(ref db).ToArray());
                results.Add(TaskLibrary.Models.TaskStatus.GetAll(ref db).ToArray());
                results.Add(TaskLibrary.Models.User.GetAll(ref db).ToArray());
                results.Add(TaskLibrary.Models.File.GetTaskFiles(ref db, taskId));
                results.Add(TaskLibrary.Models.Check.GetAll(ref db, taskId));
                bb.Result = results.ToArray();
            };

            worker.RunWorkerCompleted += (aa, bb) => 
            {
                var data = (object[])bb.Result;
                task = (TaskLibrary.Models.Task)data[0];

                tbName.Text = task.TaskName;
                var categories = (TaskLibrary.Models.TaskCategory[])data[1];
                cbCategory.Items.Clear();
                cbCategory.Items.AddRange(categories.Select(s => s.CategoryName).ToArray());
                for (int i = 0; i < categories.Length; i++)
                {
                    if (categories[i].Id == task.CategoryId)
                    {
                        cbCategory.SelectedIndex = i;
                        break;
                    }
                }

                var statuses = (TaskLibrary.Models.TaskStatus[])data[2];
                cbStatus.Items.Clear();
                cbStatus.Items.AddRange(statuses.Select(s => s.StatusName).ToArray());
                cbStatus.SelectedIndex = cbStatus.Items.IndexOf(statuses.Where(q => q.Id == task.TaskStatus).First().StatusName);

                var users = (TaskLibrary.Models.User[])data[3];
                cbPerson.Items.Clear();
                cbPerson.Items.AddRange(users.Select(s => s.Login).ToArray());
                for (int i = 0; i < users.Length; i++)
                {
                    if (users[i].Id == task.AssignedToUserId)
                    {
                        cbPerson.SelectedIndex = i;
                        break;
                    }
                }

                desc.Text = task.TaskDescription;

                var tmp = (List<TaskLibrary.Models.File>)data[4];
                attachementsIds.Clear();
                attachementsIds.AddRange(tmp.Select(s => s.Id));
                attachments.Items.Clear();
                attachments.Items.AddRange(tmp.Select(s => s.Name + "." + s.Extension).ToArray());

                var _tmp = (List<TaskLibrary.Models.Check>)data[5];
                todoIds.AddRange(_tmp.Select(s => s.Id));
                todo.Items.Clear();
                todo.Items.AddRange(_tmp.Select(s => s.Name).ToArray());

                for (int i = 0; i < _tmp.Count; i++)
                {
                    todo.SetItemChecked(i, _tmp[i].IsChecked);
                }

                status.Text = "Zadanie odczytane";
                progress.Visible = false;
                progress.Style = ProgressBarStyle.Continuous;
            };

            status.Text = "Pobieranie danych...";
            progress.Style = ProgressBarStyle.Marquee;
            progress.Visible = true;
            worker.RunWorkerAsync(TaskId);                
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            loadTask();
        }

        private void eventRemoveSelectedAttachments(object sender, EventArgs e)
        {
            var idsToRemove = new List<int>();
            foreach (var item in attachments.SelectedItems)
            {
                int index = attachments.Items.IndexOf(item);
                idsToRemove.Add(attachementsIds[index]);                
            }

            worker.WorkerReportsProgress = true;
            worker.DoWork += (aa, bb) =>
            {
                TaskLibrary.DB _db = TaskLibrary.DB.Connect(
                Properties.Settings.Default.adres,
                Properties.Settings.Default.baza,
                Properties.Settings.Default.login,
                Properties.Settings.Default.haslo);

                int i = 0;
                foreach (var fileId in (List<int>)bb.Argument)
                {
                    TaskLibrary.Models.File.Delete(ref db, fileId);
                    ((BackgroundWorker)aa).ReportProgress(++i);
                }
            };

            worker.ProgressChanged += (aa, bb) =>
            {
                progress.Value = bb.ProgressPercentage;
            };
            worker.RunWorkerCompleted += (aa, bb) =>
            {
                status.Text = "Załączniki zostały usununięte.";
                progress.Visible = false;
                loadTask();
            };

            progress.Visible = true;
            progress.Minimum = 0;
            progress.Maximum = idsToRemove.Count();
            progress.Value = 0;
            status.Text = "Usuwanie załączników...";
            worker.RunWorkerAsync(idsToRemove);             

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCheck();
        }

        private void addCheck()
        {
            var name = tbCheckItem.Text;
            tbCheckItem.Clear();

            if (name.Length > 0)
            {
                todo.Items.Add(name);
                todoIds.Add(TaskLibrary.Models.Check.Add(ref db, name, TaskId).Id);
            }
        }

        private void tbCheckItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addCheck();
            }
        }

        private void todo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && todo.SelectedIndex > 0)
            {
                var index = todo.SelectedIndex;
                var id = todoIds[index];
                todoIds.RemoveAt(index);
                todo.Items.RemoveAt(index);
                TaskLibrary.Models.Check.Delete(ref db, id);
            }

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            db.tasks.Where(q => q.id == TaskId).First().task_name = tbName.Text;
            db.SaveChanges();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string what = (string)cbCategory.SelectedItem;
            var tmp = db.categories.Where(q => q.name == what);
            if (tmp.Count() > 0)
            {
                var id = tmp.First().id;
                db.tasks.Where(q => q.id == TaskId).First().category_id = id;
                db.SaveChanges();
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string what = (string)cbStatus.SelectedItem;
            var tmp = db.status_list.Where(q => q.status == what);
            if (tmp.Count() > 0)
            {
                var id = tmp.First().id;
                db.tasks.Where(q => q.id == TaskId).First().status = id;
                db.SaveChanges();
            }
        }

        private void cbPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            string what = (string)cbPerson.SelectedItem;
            var tmp = db.users.Where(q => q.login == what);
            if (tmp.Count() > 0)
            {
                var id = tmp.First().id;
                db.tasks.Where(q => q.id == TaskId).First().assigned_to_user_id = id;
                db.SaveChanges();
            }
        }
    }
}
