using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            DirectoryInfo d = new DirectoryInfo("C:\\Users\\hp\\Source\\Repos\\HandsOnGit\\HandsOnGit\\Files");
            FileInfo[] fileInfos = d.GetFiles();

            long size = 0;
            for (int i = 0; i < fileInfos.Length; i++)
                size+= fileInfos[i].Length;
            return size/fileInfos.Length;
            
        }
         
    }
}
