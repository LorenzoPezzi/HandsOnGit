using HandsOnGit.Model;
using System.Diagnostics;

public class Program
{ 
    static void Main()
    {

        var fileName = "School.txt";

        Console.WriteLine(FileManager.FileNameCheck( fileName));
        Console.WriteLine(FileManager.FileAverage());
        Console.WriteLine(FileManager.ConvertJsonSchoolToListSchool());
    }
}