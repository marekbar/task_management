using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class MainWindow : Form
    {
        private dynamic data;
        public TaskLibrary.DB db = TaskLibrary.DB.Connect(
                    Properties.Settings.Default.adres,
                    Properties.Settings.Default.baza,
                    Properties.Settings.Default.login,
                    Properties.Settings.Default.haslo);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuSettings_Click(object sender, EventArgs e)
        {
            try
            {
                var window = new SettingsWindow();
                window.FormClosing += (s, args) => { refresh(); };
                window.ShowDialog();
            }
            catch (Exception ex)
            {
                status.Text = ex.Message;
            }
        }

        private void menuEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listaStatusówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var window = new StatusListWindow();
                window.ShowDialog();
            }
            catch (Exception ex)
            {
                status.Text = ex.Message;
            }
        }

        private void menuCategories_Click(object sender, EventArgs e)
        {
            try
            {
                var window = new CategoriesWindow();
                window.ShowDialog();
            }
            catch (Exception ex)
            {
                status.Text = ex.Message;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private List<TaskLibrary.Models.SimpleTask> myTasks = new List<TaskLibrary.Models.SimpleTask>();

        private void refresh()
        {
            myTasks.Clear();
            grid.DataSource = null;
            grid.Refresh();

            if (db.users.Where(q => q.login == Properties.Settings.Default.login_uzytkownika).Count() == 0)
            {
                status.Text = "Nie można odnaleść użytkownika w bazie. Przejdź do ustawień i ustaw";
            }
            else
            {
                int userId = db.users.Where(q => q.login == Properties.Settings.Default.login_uzytkownika).First().id;

                data = db.tasks
                    .Where(q => q.assigned_to_user_id == userId)
                    .Join(db.categories,
                    left => left.category_id,
                    right => right.id,
                    (left, right) => new
                    {
                        tasks = left,
                        categories = right
                    })
                    .Join(db.status_list,
                    left => left.tasks.status,
                    right => right.id,
                    (left, right) => new
                    {
                        Id = left.tasks.id,
                        TaskName = left.tasks.task_name,
                        CategoryName = left.categories.name,
                        StatusName = right.status,
                        TimeSpent = left.tasks.time_spent
                    })
                    .ToList();

                grid.DataSource = data;
                grid.Refresh();

                grid.Columns[0].Visible = false;
                grid.Columns[1].HeaderText = "Zadanie";
                grid.Columns[2].HeaderText = "Kategoria";
                grid.Columns[3].HeaderText = "Status";
                grid.Columns[4].HeaderText = "Czas";
            }
        }

        private void menuAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                var window = new TaskAddWindow();
                window.ShowDialog();
            }
            catch (Exception ex)
            {
                status.Text = ex.Message;
            }
        }

        private void getAttachmentFiles()
        {
            if (grid.SelectedRows.Count > 0)
            {
                int taskId = grid.SelectedRows[0].Cells[0].Value is int ? ((int)grid.SelectedRows[0].Cells[0].Value) : 0;
                menuTaskAttachments.DropDownItems.Clear();
                foreach (var file in db.files.Where(q => q.task_id == taskId)
                    .Select(s => new
                    {
                        name = (s.name + "." + s.ext),
                        id = s.id
                    }))
                {
                    var item = new ToolStripMenuItem();
                    item.Text = file.name;
                    item.Tag = file.id;
                    item.Click += (a, b) =>
                    {
                        var position = (ToolStripMenuItem)a;
                        var tag = position.Tag;
                        var fileId = (int)tag;
                        var _file = db.files.Where(q => q.id == fileId)
                            .Select(s => new
                            {
                                data = s.file,
                                name = s.file,
                                ext = s.ext
                            }).First();
                        var tempPath = System.IO.Path.GetTempPath();

                        var tempFile = string.Format("{0}\\{1}.{2}",
                            tempPath.TrimEnd(new char[] { '\\' }), _file.name, _file.ext);

                        System.IO.File.WriteAllBytes(tempFile, _file.data);
                        System.Diagnostics.Process.Start(tempFile);

                    };
                    menuTaskAttachments.DropDownItems.Add(item);
                }

                var _item = new ToolStripMenuItem();
                _item.Text = "Dodaj kolejny załącznik";
                _item.Tag = taskId;
                _item.Click += (a, b) =>
                {
                    var position = (ToolStripMenuItem)a;
                    var tag = position.Tag;
                    var _taskId = (int)tag;
                    string filename = "";
                    var opener = new OpenFileDialog();
                    opener.CheckFileExists = true;
                    opener.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    opener.Title = "Wskaż plik, który chcesz załączyć";
                    if (opener.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        filename = opener.FileName;
                        TaskLibrary.Models.File.Save(ref db, filename, _taskId);
                    }

                };
                menuTaskAttachments.DropDownItems.Add(_item);
            }
        }
        private void contextMenu_Opened(object sender, EventArgs e)
        {
            getAttachmentFiles();
            getChecklist();
        }

        private void getChecklist()
        {
            if (grid.SelectedRows.Count > 0)
            {
                int taskId = grid.SelectedRows[0].Cells[0].Value is int ? ((int)grid.SelectedRows[0].Cells[0].Value) : 0;
                menuTaskcheckList.DropDownItems.Clear();
                var checks = TaskLibrary.Models.Check.GetAll(ref db, taskId);

                foreach (var item in checks)
                {
                    var pos = new ToolStripMenuItem();
                    pos.Text = item.Name;
                    pos.Checked = item.IsChecked;
                    pos.Tag = item.Id;
                    pos.Click += (a, b) => 
                    {
                        TaskLibrary.Models.Check.ToggleState(ref db, ((int)((ToolStripMenuItem)a).Tag));
                    };
                    menuTaskcheckList.DropDownItems.Add(pos);
                }

                var newCheckText = new ToolStripTextBox();
                newCheckText.Tag = taskId;
                newCheckText.KeyDown += (s, a) => 
                {
                    if (a.KeyCode == Keys.Enter)
                    {
                        TaskLibrary.Models.Check.Add(ref db, ((ToolStripTextBox)s).Text, (int)((ToolStripTextBox)s).Tag);
                        contextMenu.Close();                        
                    }
                };
                menuTaskcheckList.DropDownItems.Add(newCheckText);
            }
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (grid.SelectedRows.Count > 0)
                {
                    var window = new TaskPreviewWindow();
                    window.TaskId = ((dynamic)grid.SelectedRows[0].DataBoundItem).Id;
                    window.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                status.Text = ex.Message;
            }
        }
    }
}
