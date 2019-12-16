using System;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace _5._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder characters = new StringBuilder();
            
            for (int i = 0; i < line.Length; i++)
            {
                var charText = line[i];
                if (char.IsDigit(charText))
                {
                    digits.Append(charText);
                }
                else if(char.IsLetter(charText))
                {
                    letters.Append(charText);
                }
                else
                {
                    characters.Append(charText);
                }
            }
            Console.WriteLine($"{digits}\n{letters}\n{characters}");
        }
    }
}
