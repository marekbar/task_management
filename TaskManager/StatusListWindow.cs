using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class StatusListWindow : Form
    {
        public StatusListWindow()
        {
            InitializeComponent();
        }
        public TaskLibrary.DB db = TaskLibrary.DB.Connect(
                    Properties.Settings.Default.adres,
                    Properties.Settings.Default.baza,
                    Properties.Settings.Default.login,
                    Properties.Settings.Default.haslo);
            
        
        private void StatusListWindow_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private List<TaskLibrary.Models.TaskStatus> list = new List<TaskLibrary.Models.TaskStatus>();

        private void refresh()
        {
            grid.Items.Clear();
            list.Clear();
            list.AddRange(TaskLibrary.Models.TaskStatus.GetAll(ref db));
            grid.Items.AddRange(list.Select(s => s.StatusName).ToArray());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (TaskLibrary.Models.TaskStatus.Create(ref db, text.Text))
            {
                refresh();
                status.Text = "Status został dodany.";
                text.Clear();
            }
            else
            {
                status.Text = "Nie dodano nowego statusu.";
            }
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                if (grid.SelectedIndex >= 0)
                {
                    int index = grid.SelectedIndex;
                    var id = list[index].Id;
                    if (TaskLibrary.Models.TaskStatus.Delete(ref db, id))
                    {
                        grid.Items.Clear();
                        list.RemoveAt(index);
                        grid.Items.AddRange(list.Select(s => s.StatusName).ToArray());
                    }
                    else
                    {
                        status.Text = "Nie usunięto";
                    }
                }
                else
                {
                    status.Text = "Zaznacz, aby móc usunąć.";
                }
            }
            else
            {
                status.Text = "Brak danych";
            }
        }
    }
}
