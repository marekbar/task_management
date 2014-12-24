using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary.Models
{
    public class TaskStatus
    {
        [DisplayName("Identyfikator")]
        public int Id { get; set; }

        [DisplayName("Status")]
        public string StatusName { get; set; }

        public static List<TaskStatus> GetAll(ref DB db)
        {
            return db.status_list.Select(s => new TaskStatus() { Id = s.id, StatusName = s.status }).ToList();
        }

        public static bool Delete(ref DB db, int id)
        {
            try
            {
                var status = db.status_list.Where(q => q.id == id).First();                
                db.status_list.Remove(status);
                db.SaveChanges();

                foreach (var task in db.tasks.Where(q => q.status == id))
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

        public static bool Create(ref DB db, string name)
        {
            try
            {
                if (db.status_list.Where(q => q.status == name).Count() > 0) throw new Exception("Istnieje");
                status_list st = new status_list();
                st.status = name;
                db.status_list.Add(st);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(ref DB db, int id, string name)
        {
            try
            {
                db.status_list.Where(q => q.id == id).First().status = name;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Read(ref DB db, int id, out TaskStatus status)
        {
            try
            {
                status = db.status_list.Where(q => q.id == id).Select(s => new TaskStatus() { Id = s.id, StatusName = s.status }).First();
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
