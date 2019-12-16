using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line != "end")
            {
                string word = line;
                string reversedWord = "";
                for (int i = word.Length - 1; i >=0; i--)
                {
                    reversedWord += word[i];
                }
                Console.Write($"{word} = {reversedWord}");
                Console.WriteLine();
                line = Console.ReadLine();
            }
        }
    }
}
