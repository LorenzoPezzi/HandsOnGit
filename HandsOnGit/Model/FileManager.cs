using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGit.Model
{
    public static class FileManager
    {
        
        public static bool FileNameCheck(DirectoryInfo folder, string fileName)
        {
            FileInfo[] Files = folder.GetFiles(); //Getting all files
            Console.WriteLine("Number of files in the folder: " + Files.Length);

            foreach (FileInfo File in Files)
                if (File.Name.Equals(fileName))
                    return true;

            return false;
        }
         
    }
}
