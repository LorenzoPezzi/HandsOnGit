using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace HandsOnGit.Model
{
    public static class FileManager
    {
        private static string FolderPath = AppDomain.CurrentDomain.BaseDirectory
                                        + "..\\..\\..\\Files";
        /// <summary>
        ///     Get a file Name as parameter and return true if it is present in the folder
        ///     with path "AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\Files""
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>True or False</returns>
        public static bool FileNameCheck(string fileName)
        {
            DirectoryInfo Folder = new DirectoryInfo(FolderPath);
            FileInfo[] Files = Folder.GetFiles(); //Getting all files
            Console.WriteLine("Number of files in the folder: " + Files.Length);

            foreach (FileInfo File in Files)
                if (File.Name.Equals(fileName))
                    return true;

            return false;
        }

        public static double FileAverage()
        {
            DirectoryInfo d = new DirectoryInfo(FolderPath);
            FileInfo[] fileInfos = d.GetFiles();

            long size = 0;
            for (int i = 0; i < fileInfos.Length; i++)
                size+= fileInfos[i].Length;
            return size/fileInfos.Length;

        }

        public static bool ConvertJsonSchoolToListSchool()
        {
            string path = FolderPath + "\\School.txt";
            string listOfSchools = File.ReadAllText(path);
            var jsonSchool = JsonSerializer.Deserialize<List<School>>(listOfSchools);

            foreach (var school in jsonSchool)
            {
                Console.WriteLine($"Name: {school.name}, Address: {school.address}, Id: {school.id}");
            }

            return true;
        }
    }
}
