namespace HandsOnGit
{
    public static class Helper
    {
        private static string _filePath = "./../../../files/School.txt";
        public static string GetFilePath()
        {
            return _filePath;
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
    }
}
