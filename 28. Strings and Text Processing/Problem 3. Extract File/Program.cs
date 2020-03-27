namespace ExtractFile
{
    using System;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console
                .ReadLine()
                .Split("\\", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            string[] lastElement = inputLine
                .Last()
                .Split(".")
                .ToArray();
            
            string fileName = lastElement.First();
            string fileExtension = lastElement.Last();
            
            Console.WriteLine($"File name: {fileName} \nFile extension: {fileExtension}");
        }
    }
}
