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
    public partial class CategoriesWindow : Form
    {
        public CategoriesWindow()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public TaskLibrary.DB db = TaskLibrary.DB.Connect(
                   Properties.Settings.Default.adres,
                   Properties.Settings.Default.baza,
                   Properties.Settings.Default.login,
                   Properties.Settings.Default.haslo);

        private List<TaskLibrary.Models.TaskCategory> categories = new List<TaskLibrary.Models.TaskCategory>();

        private void CategoriesWindow_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            grid.DataSource = null;
            grid.Refresh();
            categories.Clear();
            categories.AddRange(
            db.categories.Select(s => new TaskLibrary.Models.TaskCategory()
            {
                Id = s.id,
                CategoryName = s.name,
                TaskCount = db.tasks.Where(q => q.category_id == s.id).Count()
            }));
            grid.DataSource = categories;
            grid.Refresh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (db.categories.Where(q => q.name == text.Text).Count() == 0)
            {
                var tmp = new TaskLibrary.categories();
                tmp.name = text.Text;
                db.categories.Add(tmp);
                db.SaveChanges();
                status.Text = "Kategoria została dodana";
                text.Clear();
                refresh();
            }
            else
            {
                status.Text = "Kategoria już istnieje";
            }
        }

        private void text_TextChanged(object sender, EventArgs e)
        {
            status.Text = db.categories.Where(q => q.name == text.Text).Count() > 0 ? "Kategoria już istnieje" : "";   
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            string cat = (string)grid.SelectedRows[0].Cells[0].Value;
            int id = db.categories.Where(q => q.name == cat).First().id;
            db.categories.Remove(db.categories.Where(q => q.name == cat).First());
            db.SaveChanges();
            foreach (var task in db.tasks.Where(q => q.category_id == id))
            {
                db.tasks.Remove(task);
            }
            db.SaveChanges();
            refresh();
        }
    }
}
