using System;
using System.IO;

namespace TeamSaturnProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string folderFilePath = "";

            Console.WriteLine("Enter Folder Name You wanted to Create:");
            string nameOfFolder = Console.ReadLine();
            
            //Validates Folder Name to ensure empty values are not entered
            while (String.IsNullOrEmpty(nameOfFolder))
            {
                System.Console.WriteLine("Enter A Correct Folder Name...");
                nameOfFolder = Console.ReadLine();
            }
            string folderPath = @"C:\" + nameOfFolder;

            // call a Method
            var returnedFolderPath = EnsureFolderOrFileExists.EnsureFolderExists(folderPath);

            // Create a file name for the file you want to create.
            Console.WriteLine("Enter File Name You wanted to Create:");
            string fileName = Console.ReadLine();

            //Validates File Name to ensure empty values are not entered
            while (String.IsNullOrEmpty(fileName))
            {
                System.Console.WriteLine("Enter A Correct File Name...");
                fileName = Console.ReadLine();
            }
            string fileNameConvertTxtFile = fileName + ".txt";

            
            // Use Combine again to add the file name to the path.
            folderFilePath = Path.Combine(returnedFolderPath, fileNameConvertTxtFile);

            var returnedFilePath = EnsureFolderOrFileExists.EnsureFileExists(folderFilePath);
            Console.WriteLine("Path to my file: {0}\n", returnedFilePath);

            IWritable writer = new Writer();
            writer.Write(returnedFilePath);

            IReadable reader = new Reader();
            reader.Read(returnedFilePath);
        }
    }
}
