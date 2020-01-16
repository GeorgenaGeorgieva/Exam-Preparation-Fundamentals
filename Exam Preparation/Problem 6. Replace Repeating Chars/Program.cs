using System;
using System.Linq;
using System.Text;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            
            StringBuilder builder = new StringBuilder();
            
            for (int i = 0; i < inputLine.Length - 1; i++)
            {
                string currentLetter = inputLine[i].ToString();
                string nextLetter = inputLine[i + 1].ToString();
                
                if (currentLetter != nextLetter)
                {
                    builder.Append(currentLetter);
                }
            }
            
            builder.Append(inputLine.Last());
            Console.WriteLine(builder);
        }
    }
}
