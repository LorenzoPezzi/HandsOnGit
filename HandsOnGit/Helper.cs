namespace HandsOnGit
{
    internal static class Helper
    {
        public static int fileCount = Directory.GetFiles("C:\\Users\\ilfer\\Desktop\\handson\\HandsOnGit\\Files\\").Length;

        public static bool FindSchoolFile()
        {
            var allFiles = Directory.GetFiles("C:\\Users\\ilfer\\Desktop\\handson\\HandsOnGit\\Files\\");
            string schoolFile = "C:\\Users\\ilfer\\Desktop\\handson\\HandsOnGit\\Files\\School.txt";
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

