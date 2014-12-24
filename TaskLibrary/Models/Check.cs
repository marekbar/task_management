using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary.Models
{
    public class Check
    {
        public int Id { get; set; }
        public bool IsChecked { get; set; }
        public string Name { get; set; }
        public int TaskId { get; set; }

        public Check()
        {
            Id = 0;
            IsChecked = false;
            Name = string.Empty;
            TaskId = 0;
        }

        public static List<Check> GetAll(ref DB db, int taskId = 0)
        {
            if (taskId > 0)
            {
                return db.checks.Where(q => q.task_id == taskId)
                        .Select(s => new Check()
                        {
                            IsChecked = s.is_checked,
                            Name = s.name,
                            Id = s.id,
                            TaskId = s.task_id
                        }).ToList();
            }
            else
            {
                return db.checks
                    .Select(s => new Check()
                    {
                        IsChecked = s.is_checked,
                        Name = s.name,
                        Id = s.id,
                        TaskId = s.task_id
                    }).ToList();
            }
        }

        public static bool ToggleState(ref DB db, int id)
        {
            try
            {
                var newFlag = !db.checks.Where(q => q.id == id).First().is_checked;
                db.checks.Where(q => q.id == id).First().is_checked = newFlag;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Check Add(ref DB db, string name, int taskId)
        {
            string sql = string.Format("INSERT INTO [zadania].[dbo].[checks]([task_id],[name],[is_checked])VALUES({0},'{1}',0)",
                              taskId, name);
            db.Database.ExecuteSqlCommand(sql);
            return db.checks
                .Where(q => q.task_id == taskId && q.name == name)
                .Select(s => new Check() 
                {
                    Id = s.id,
                    IsChecked = s.is_checked,
                    Name = s.name,
                    TaskId = s.task_id
                }).First();
        }

        public static void Delete(ref DB db, int id)
        {
            var toRemove = db.checks.Where(q => q.id == id).First();
            db.checks.Remove(toRemove);
            db.SaveChanges();
        }
    }
}
