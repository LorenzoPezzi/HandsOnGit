namespace HandsOnGit
{
    public static class Helper
    {

        public static string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public static string fullPath = System.IO.Path.Combine(currentDirectory, @"..\..\..\Files");
        //public static string fullPathToSchool = Path.Combine(currentDirectory, @"..\..\..\Files\School.txt");
        public static int fileCount = Directory.GetFiles(fullPath).Length;

        public static bool FindSchoolFile()
        {
            var allFiles = Directory.GetFiles(fullPath);
            string schoolFile = System.IO.Path.Combine(currentDirectory, "..\\..\\..\\Files\\School.txt");
            if (allFiles.Contains(schoolFile))
            {
                return true;
            }
            return false;
        }

        public static void WriteStudentFile(string json)
        {
            string studentFilePath = System.IO.Path.Combine(currentDirectory, "..\\..\\..\\Files\\Student.txt");
            using (StreamWriter sw = new StreamWriter(studentFilePath))
            {
                sw.WriteLine(json);
            }

        }
    }
}