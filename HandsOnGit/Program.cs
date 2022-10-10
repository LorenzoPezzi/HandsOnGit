using System.Text.Json;

namespace HandsOnGit;

internal class Program
{
    static void Main()
    {
        //Console.WriteLine(Helper.fileCount);
        //Console.WriteLine(Helper.FindSchoolFile());

        var student1 = new Student("Riccardo", "Stagni", 0);
        var student2 = new Student("Francesco", "Fera", 1);

        Student[] studentArray = { student1, student2 };

        string jsonString = JsonSerializer.Serialize(studentArray);

        Helper.WriteStudentFile(jsonString);
        
    }
}