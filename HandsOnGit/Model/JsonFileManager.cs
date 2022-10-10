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
        private static string FolderPath = AppDomain.CurrentDomain.BaseDirectory
                                       + "..\\..\\..\\Files\\";
        public static List<T> DeserializeObjects<T> (string filePath)
        {
            string content = File.ReadAllText (FolderPath + filePath);
            var newListJsonObj = JsonConvert.DeserializeObject<List<T>>(content);
            return newListJsonObj;
        }

        public static List<Teacher> RemoveTeachersWithoutSchoolId(List<Teacher> teachers)
        {
             
            var newTeachers = teachers.Where(teacher => teacher.SchoolId != 0);

            return newTeachers.ToList();


        }

        public static bool WriteOnTeacherFile(string filePath, List<Teacher> teachers)
        {
            if(File.Exists(FolderPath + filePath))
            {
                string newTeachers = JsonConvert.SerializeObject(teachers);
                File.WriteAllText(FolderPath + filePath, newTeachers);
                return true;
            }

            return false;
        }

        public static bool WriteStudentOnFile(Teacher student,string filePath)
        {
            if(File.Exists(FolderPath + filePath))
            {
                string jsonStudent = JsonConvert.SerializeObject(student);
                File.WriteAllText(FolderPath + filePath, jsonStudent);
                return true;

            }

            return false;
        }
       

    }
}
