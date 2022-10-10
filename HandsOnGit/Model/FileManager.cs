using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGit.Model
{
    public static class FileManager
    {
        public static int FileCounter(DirectoryInfo d)
        {


            return 0;
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
