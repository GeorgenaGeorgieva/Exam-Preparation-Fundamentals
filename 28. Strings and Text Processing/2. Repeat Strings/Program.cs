namespace RepeatStrings
{
    using System;
    using System.Linq;
    using System.Text;
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            
            StringBuilder result = new StringBuilder();
            
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }
            }
            
            Console.WriteLine(result);
        }
    }
}
