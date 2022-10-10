using HandsOnGit.Model;
using System.Diagnostics;
using System.Text.Json;

public class Program
{ 
    static void Main()
    {

        //var fileName = "School.txt";

        //Console.WriteLine(FileManager.FileNameCheck(fileName));

        string filePath = "C:\\Users\\Alessandro\\source\\repos\\HandsOnGit\\HandsOnGit\\Files\\Teacher.txt";
        var teachersList = JsonFileManager.DeserializeObjects<Teacher>(filePath);
        
        var teacherWithScoolId = JsonFileManager.RemoveTeachersWithoutSchoolId(teachersList);
        foreach (var t in teacherWithScoolId) Console.WriteLine(t.lastName);

        JsonFileManager.WriteOnTeacherFile(filePath, teachersList);


    }
}