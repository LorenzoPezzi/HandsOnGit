using HandsOnGit.Model;

public class Program
{ 
    static void Main()
    {
        var filePath = "Files\\";
  
        var fileName = "School.txt";

        DirectoryInfo folder = new DirectoryInfo(filePath);

        Console.WriteLine(FileManager.FileNameCheck(folder, fileName));
    }

}