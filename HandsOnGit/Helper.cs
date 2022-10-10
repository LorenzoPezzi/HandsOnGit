namespace HandsOnGit;

internal static class Helper
{
    public static string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
    public static string FolderPath { get; private set; } = $"{currentDirectory}..\\..\\..\\Files";
    public static int FileCount { get; private set; } = Directory.GetFiles(FolderPath).Length;

    public static double GetAVGFileSize()
    {
        List<double> dimensions = new();
        DirectoryInfo dirInfo = new(FolderPath);



        dirInfo.GetFiles().ToList().ForEach(fileInfo => dimensions.Add(fileInfo.Length));
        return GetAverage(dimensions);
    }
    private static double GetAverage(List<double> values)
    {
        double somma = 0;

        foreach (var value in values)
        {
            somma += value;
        }
        return somma / values.Count;
    }

    public static string Read(string file)
    {
        String line;
        string text = String.Empty;
        try
        {
            using StreamReader sr = new StreamReader(file);
            line = sr.ReadLine();
            while (line != null)
            {
                text += line;
                line = sr.ReadLine();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        return text;
    }

    public static bool FindSchoolFile()
    {
        var allFiles = Directory.GetFiles(FolderPath);
        string schoolFile = Path.Combine(currentDirectory, "..\\..\\..\\Files\\School.txt");
        if (allFiles.Contains(schoolFile))
        {
            return true;
        }
        return false;
    }

    public static void WriteStudentFile(string json)
    {
        string studentFilePath = Path.Combine(currentDirectory, "..\\..\\..\\Files\\Student.txt");
        using (StreamWriter sw = new StreamWriter(studentFilePath))
        {
            sw.WriteLine(json);
        }
    }
}