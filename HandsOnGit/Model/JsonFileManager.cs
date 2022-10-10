using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGit.Model
{
    public static class JsonFileManager
    {
        public static List<T> DeserializeObjects<T> (string filePath)
        {
            string content = File.ReadAllText (filePath);
            var newListJsonObj = JsonConvert.DeserializeObject<List<T>>(content);
            return newListJsonObj;
        }

        public static IEnumerable<Teacher> RemoveTeachersWithoutSchoolId(List<Teacher> teachers)
        {
             
            var newTeachers = teachers.Where(teacher => teacher.SchoolId != 0);

            return newTeachers;


        }

        public static bool WriteOnTeacherFile(string filePath, List<Teacher> teachers)
        {
            if(File.Exists(filePath))
            {
                string newTeachers = JsonConvert.SerializeObject(teachers);
                File.WriteAllText(filePath, newTeachers);
                return true;
            }

            return false;
        }

    }
}
