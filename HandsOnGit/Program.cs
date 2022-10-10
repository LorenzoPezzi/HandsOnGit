using HandsOnGit.Model;
using System.Diagnostics;
using System.Text.Json;

public class Program
{ 
    static void Main()
    {

        var fileName = "School.txt";

        Console.WriteLine(FileManager.FileNameCheck(fileName));

        string filePath = "Teacher.txt"; 
        var teachersList = JsonFileManager.DeserializeObjects<Teacher>(filePath);
        
        var teacherWithSchoolId = JsonFileManager.RemoveTeachersWithoutSchoolId(teachersList);

        string studentFile = "Student.txt";
        Teacher student = new Teacher("Pinco", "Pallino", 2);
        JsonFileManager.WriteStudentOnFile(student,studentFile);


    }
}