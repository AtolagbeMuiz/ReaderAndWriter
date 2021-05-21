using System;
using System.IO;

public class Reader : IReadable
{

    public void Read(string path)
    {
        try
        {
            string content = "";

            //This checks if the file exists
            if (File.Exists(path))
            {
                //This allows file content to be read
                content = File.ReadAllText(path);
            }

            //This prints the File content on the Console
            Console.WriteLine(content);
            
            //This prevent the app from closing
            Console.ReadKey();   
        }

         //catches any Exception
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}