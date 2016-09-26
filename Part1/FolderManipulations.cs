using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Part1
{
    class FolderManipulations
    {
        public string CreateFolder()
        {
            const string pathString = @"C:\Users\Elena_Tcherniak\Documents\";
            string folderName;

            do
            {
                Console.WriteLine("Enter the folder name, please!");
                folderName = Console.ReadLine();
            } while (string.IsNullOrEmpty(folderName));

            string pathWithFolderName = Path.Combine(pathString, folderName);
            if (!Directory.Exists(pathWithFolderName))
            {
                Directory.CreateDirectory(pathWithFolderName);
            }
            else
            {
                Console.WriteLine("Folder is already exist! Choose another name, please");
                CreateFolder();
            }
            return pathWithFolderName;
        }

        public string CopyLinesIntoFile(string pathToFile)
        {
            string fileName = Path.GetRandomFileName() + ".txt";
            const string pathStringFileToCopy = @"C:\Users\Elena_Tcherniak\Documents\d.txt";
            string coryString = "";

            string pathWithFileName = Path.Combine(pathToFile, fileName);

            if (!File.Exists(pathToFile))
            {
                using (StreamReader reader = new StreamReader(pathStringFileToCopy))
                {
                    for (int i = 0; i < 20; i++)
                    {
                        coryString += reader.ReadLine() + "\r\n";
                    }
                    reader.Close();
                }
                File.AppendAllText(pathWithFileName, coryString);
            }
            else
            {
                Console.WriteLine("File is already exist!", fileName);
                CopyLinesIntoFile(pathToFile);
            }

            return pathWithFileName;
        }
        
        public void Start()
        {
            string pathToFile = CreateFolder();
            CopyLinesIntoFile(pathToFile);
        }
    }
}
