using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary.Models
{
    public class Task : Table
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreationDate { get; set; }
        public int AssignedToUserId { get; set; }
        public DateTime AssignDate { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime StopDateTime { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public double TimeSpent { get; set; }
        public int TaskStatus { get; set; }

        public Task() { }
        public Task(int categoryId, string taskName, string taskDescription, int creatorId, int assignedToUserId, int taskStatus)
        {
            Id = 0;
            CategoryId = categoryId;
            TaskName = taskName;
            TaskDescription = taskDescription;
            CreatorId = creatorId;
            AssignedToUserId = assignedToUserId;
            CreationDate = AssignDate = StartDateTime = StopDateTime = ExpectedEndDate = DateTime.Now;
            TimeSpent = 0;
            TaskStatus = taskStatus;
        }

        public static Task Get(int id, ref DB db)
        {
            return db.tasks.Where(q => q.id == id).Select(s => new Task()
                {
                    Id = s.id,
                    CategoryId = s.category_id,
                    TaskName = s.task_name,
                    TaskDescription = s.task_description,
                    CreatorId = s.creator_id,
                    CreationDate = s.creation_date,
                    AssignedToUserId = s.assigned_to_user_id,
                    AssignDate = s.assign_date,
                    StartDateTime = s.start_date,
                    StopDateTime = s.stop_date,
                    ExpectedEndDate = s.expected_end_date,
                    TimeSpent = s.time_spent,
                    TaskStatus = s.status
                }).First();
        }

        public bool Save(ref DB db)
        {
            try
            {
                var t = new tasks();
                t.category_id = CategoryId;
                t.task_name = TaskName;
                t.task_description = TaskDescription;
                t.creator_id = CreatorId;
                t.creation_date = CreationDate;
                t.assign_date = AssignDate;
                t.assigned_to_user_id = AssignedToUserId;
                t.assign_date = AssignDate;
                t.start_date = StartDateTime;
                t.stop_date = StopDateTime;
                t.time_spent = TimeSpent;
                t.status = TaskStatus;
                t.expected_end_date = ExpectedEndDate;
                db.tasks.Add(t);                
                db.SaveChanges();
                Id = t.id;
                return Id != 0;
            }
            catch
            {
                return false;
            }
        }

        public static List<Task> GetAll(ref DB db)
        {
            var list = new List<Task>();

            list.AddRange(
                db.tasks.Select(s => new Task()
                {
                    Id = s.id,
                    CategoryId = s.category_id,
                    TaskName = s.task_name,
                    TaskDescription = s.task_description,
                    CreatorId = s.creator_id,
                    CreationDate = s.creation_date,
                    AssignedToUserId = s.assigned_to_user_id,
                    AssignDate = s.assign_date,
                    StartDateTime = s.start_date,
                    StopDateTime = s.stop_date,
                    ExpectedEndDate = s.expected_end_date,
                    TimeSpent = s.time_spent
                })
                );

            return list;
        }
    }

    public class SimpleTask
    {
        public int Id = 0;

        [DisplayName("Kategoria")]
        public string Category { get; set; }

        [DisplayName("Zadanie")]
        public string TaskName { get; set; }

        [DisplayName("Czas wykonania")]
        public string TimeSpent { get; set; }

        [DisplayName("Załączniki")]
        public int Attachements { get; set; }

        [DisplayName("Liczba punktów do sprawdzenia")]
        public int Checklist { get; set; }
    }
}
