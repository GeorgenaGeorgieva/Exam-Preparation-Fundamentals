using System;
using System.Text;
using System.Linq;

namespace _4._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] specialWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var word in specialWords)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string ('*', word.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
