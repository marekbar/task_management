using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary.Models
{
    public class TaskCategory : Table
    {
        public int Id = 0;

        [DisplayName("Kategoria")]
        public string CategoryName { get; set; }

        [DisplayName("Liczba zadań")]
        public int TaskCount { get; set; }

        public static List<TaskCategory> GetAll(ref DB db)
        {
            return db.categories.Select(s => new TaskCategory() { Id = s.id, CategoryName = s.name }).ToList();
        }

        public static bool Delete(ref Database db, int id)
        {
            try
            {
                var cat = db.categories.Where(q => q.id == id).First();
                db.categories.Remove(cat);
                db.SaveChanges();

                foreach (var task in db.tasks.Where(q => q.category_id == id))
                {
                    db.tasks.Remove(task);
                }
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Create(ref Database db, string name)
        {
            try
            {
                if (db.categories.Where(q => q.name == name).Count() > 0) throw new Exception("Istnieje");
                categories cat = new categories();
                cat.name = name;
                db.categories.Add(cat);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(ref Database db, int id, string name)
        {
            try
            {
                db.categories.Where(q => q.id == id).First().name = name;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Read(ref Database db, int id, out TaskCategory status)
        {
            try
            {
                status = db.categories.Where(q => q.id == id).Select(s => new TaskCategory() { Id = s.id, CategoryName = s.name }).First();
                return true;
            }
            catch
            {
                status = null;
                return false;
            }
        }
    }
}
