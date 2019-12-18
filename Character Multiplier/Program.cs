using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.
                ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            string firstWord = input[0];
            string secondWord = input[1];

            if (firstWord.Length >= secondWord.Length)
            {
                Console.WriteLine(SummingLetters(firstWord, secondWord)); 
            }
            else
            {
                Console.WriteLine(SummingLetters(secondWord, firstWord)); 
            } 
        }
        
        static int SummingLetters(string biggerWord, string smallerWord)
        { 
                int sumCharacters = 0;
                int biggerString = biggerWord.Length - smallerWord.Length;
            
                for (int i = 0; i < smallerWord.Length; i++)
                {
                    sumCharacters += (biggerWord[i] * smallerWord[i]);
                }
                for (int i = 0; i < biggerString; i++)
                {
                    sumCharacters += biggerWord[biggerWord.Length - 1 - i];
                }
            
            return sumCharacters;
        }
    }
}
