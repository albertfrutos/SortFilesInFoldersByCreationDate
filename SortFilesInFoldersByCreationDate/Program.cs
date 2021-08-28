using System;
using System.IO;

namespace SortFilesInFoldersByCreationDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"/Users/albert/Pictures/iPhone Albert 19032020 al 27082020/3 sort";
            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                string creationDate = File.GetCreationTime(file).ToString("yyyy_MM_dd");

                string targetDirectory = folderPath + "/" + creationDate;

                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }
                File.Move(file, targetDirectory + "/" + Path.GetFileName(file));
                
            }
        }
    }
}
