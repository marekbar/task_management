using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary.Models
{
    public class File
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public byte[] Data { get; set; }

        public File()
        {
        }

        public static List<TaskLibrary.Models.File> GetTaskFiles(ref DB db, int taskId)
        {
            List<TaskLibrary.Models.File> _files = new List<TaskLibrary.Models.File>();

            _files.AddRange(db.files.Where(q => q.task_id == taskId)
                .Select(s => new TaskLibrary.Models.File() 
            { 
                Id = s.id,
                TaskId = s.task_id,
                Name = s.name,
                Extension = s.ext,
                Data = s.file
            }).ToArray());
            return _files;
        }

        public static TaskLibrary.Models.File GetTaskFile(ref DB db, int taskId, int fileId)
        {
            return db.files.Where(q => q.task_id == taskId && q.id == fileId)
                .Select(s => new TaskLibrary.Models.File()
                {
                    Id = s.id,
                    TaskId = s.task_id,
                    Name = s.name,
                    Extension = s.ext,
                    Data = s.file
                }).First();
        }


        public static File Save(ref DB db, string filename, int taskId)
        {
            try
            {
                File file = new File();
                file.TaskId = taskId;
                file.Extension = System.IO.Path.GetExtension(filename).TrimStart(new char[] { '.' });
                file.Name = System.IO.Path.GetFileNameWithoutExtension(filename);
                file.Data = getData(filename);

                var f = new files();
                f.task_id = file.TaskId;
                f.name = file.Name;
                f.ext = file.Extension;
                f.file = file.Data;
                db.files.Add(f);
                db.SaveChanges();

                file.Id = f.id;//yes, id is here

                return file;
            }
            catch
            {
                return null;
            }
        }

        public static bool Delete(ref DB db, int id)
        {
            try
            {
                var file = db.files.Where(q => q.id == id).First();
                db.files.Remove(file);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static byte[] getData(string fileName)
        {
            System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
            int numBytes = (int)new System.IO.FileInfo(fileName).Length;
            return br.ReadBytes(numBytes);            
        }
    }
}
