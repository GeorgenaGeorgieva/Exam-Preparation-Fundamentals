using System;
using System.Linq;


namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split("\\").ToArray();
            string[] lastElement = inputLine.Last().Split(".");
            string fileName = lastElement.First();
            string fileExtension = lastElement.Last();
            Console.WriteLine($"File name: {fileName} \nFile extension: {fileExtension}");
        }
    }
}
