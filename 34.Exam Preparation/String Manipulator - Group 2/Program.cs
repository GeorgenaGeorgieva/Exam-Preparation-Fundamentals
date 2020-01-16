using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace String_Manipulator___Group_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] comandsInfo = input.Split(" ").ToArray();
                string comand = comandsInfo[0];

                if (comand == "Change")
                {
                    char currentChar = char.Parse(comandsInfo[1]);
                    char replacement = char.Parse(comandsInfo[2]); 
                    text = text.Replace(currentChar, replacement);
                    Console.WriteLine(text);
                }
                else if (comand == "Includes")
                {
                    string word = comandsInfo[1];

                    if (text.Contains(word))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (comand == "End")
                {
                    string word = comandsInfo[1];

                    if (text.EndsWith(word))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (comand == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (comand == "FindIndex")
                {
                    char symbol = char.Parse(comandsInfo[1]);
                    int index = text.IndexOf(symbol);

                    Console.WriteLine(index);
                }
                else if (comand == "Cut")
                {
                    int startIndex = int.Parse(comandsInfo[1]);
                    int length = int.Parse(comandsInfo[2]);
                    text = text.Substring(startIndex, length);

                    Console.WriteLine(text);
                }
               input = Console.ReadLine();
            }
        }
    }
}
