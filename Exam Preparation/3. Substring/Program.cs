using System;
using System.Text;
using System.Linq;

namespace _3._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine().ToLower();
            string secondWord = Console.ReadLine();
            int index = secondWord.IndexOf(firstWord);

            while (index != -1)
            {
                secondWord = secondWord.Remove(index, firstWord.Length);
                index = secondWord.IndexOf(firstWord);
            }
            Console.WriteLine(secondWord);
        }
    }
}
