using System;
using System.IO;

 public class EnsureFolderOrFileExists
    {

        public static string EnsureFolderExists(string folderPath)
        {
            // ... Set to folder path we must ensure exists
            try
            {
                // ...If the diectory doesn't exist, create it
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);

                }
                else
                {
                    Console.WriteLine("Folder \"{0}\" already Exists.", folderPath);

                    Console.WriteLine("Enter Another Folder Name You wanted to Create:");
                    string nameOfFolder = Console.ReadLine();
                   
                    folderPath = @"C:\" + nameOfFolder;
                    EnsureFolderExists(folderPath);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return folderPath;
        }

        public static string EnsureFileExists(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }
                else
                {
                    Console.WriteLine("File Path \"{0}\" already exists.", filePath);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return filePath;
        }

    }