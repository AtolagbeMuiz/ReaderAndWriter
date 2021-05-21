using System;
using System.IO;

public class Writer : IWritable
{
    public void Write(string path)
    {
        try
        {
           // string dataFile = @"C:\WorldCupWinners.txt";
            
            System.Console.WriteLine("How many Countries are you Adding?");
            string input = Console.ReadLine();

            int amountofCountriesTobeAdded;

            //checks and handles user error, if input is number or letter
            while(!Int32.TryParse(input, out amountofCountriesTobeAdded))
            {
                System.Console.WriteLine("Enter a Valid Number");
                input = Console.ReadLine();
            }
            
            //The number entered becomes the size of the array
            int[] addedCountries = new int[amountofCountriesTobeAdded];

            //loops through the number of countries to be added. so to add multiple countries
            for (int i = 0; i < addedCountries.Length; i++)
            {
                System.Console.WriteLine("Enter Countries and their WorldCup winning year");
                string content = Console.ReadLine();

                while (String.IsNullOrEmpty(content))
                {
                    System.Console.WriteLine("Enter a Valid Country Name and Year...");
                    content = Console.ReadLine();
                }

                //This checks if the file exists, if doesn't it creates the file
                if (File.Exists(path))
                {
                    //---> This allows the texts to be wrtten in an external file 
                    //---> without overwriting the texts in the file initially.
                    //---> The AppendAllText method takes in two arguments, the file that we want write to nd the content we want to write to the file
                    // ---> The Environment.NewLine allows a text to be written on the next line in the external file 
                    File.AppendAllText(path, content + Environment.NewLine);
                }   
            }
            Console.WriteLine();
        }
        catch (System.Exception ex)
        {
            
            System.Console.WriteLine(ex.Message);
        }
    }
}