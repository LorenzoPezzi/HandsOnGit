using System.Text.Json;

namespace HandsOnGit;

internal class Program
{
    static void Main()
    {
        List<School> schoolList = new List<School>();
        string fileSchool = "./../../../files/School.txt";
        string text=Helper.Read(fileSchool);
        text = text.Replace(",},","}*").Replace("[","").Replace(",}]", "}");
        string[] arr=text.Split('*');
        for (int i = 0; i < arr.Length; i++)
            schoolList.Add(JsonSerializer.Deserialize<School>(arr[i]));
        foreach (School school in schoolList)
            Console.WriteLine(school);

        
    }
}