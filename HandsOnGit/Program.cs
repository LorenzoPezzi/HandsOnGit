using System.Text.Json;

namespace HandsOnGit;
internal class Program
{
    static void Main()
    {
        //T.a.
        var student1 = new Student("Riccardo", "Stagni", 0);
        var student2 = new Student("Francesco", "Fera", 1);



        Student[] studentArray = { student1, student2 };



        string jsonString = JsonSerializer.Serialize(studentArray);
        Helper.WriteStudentFile(jsonString);



        Console.WriteLine(Helper.FileCount);
        Console.WriteLine(Helper.FindSchoolFile());



        //T.b
        Console.WriteLine(Helper.GetAVGFileSize() + " Byte");



        //T.c
    }
}