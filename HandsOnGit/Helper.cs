namespace HandsOnGit
{
    internal static class Helper
    {

        public static string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public static string fullPath = Path.Combine(currentDirectory, @"..\..\..\Files");
        public static int fileCount = Directory.GetFiles(fullPath).Length;

        public static bool FindSchoolFile()
        {
            var allFiles = Directory.GetFiles(fullPath);
            string schoolFile = Path.Combine(fullPath, @"\School.txt");
            if (allFiles.Contains(schoolFile))
            {
                return true;
            }
            return false;
        }

        public static void WriteStudentFile(string json)
        {
            string studentFilePath = "C:\\Users\\ilfer\\Desktop\\handson\\HandsOnGit\\Files\\Student.txt";
            using (StreamWriter sw = new StreamWriter(studentFilePath))
            {
                sw.WriteLine(json);
            }

        }
    }
}

