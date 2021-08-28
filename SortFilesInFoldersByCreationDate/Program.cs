using System;
using System.IO;

namespace SortFilesInFoldersByCreationDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"/Users/myUser/Pictures/myDirToSort";
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
