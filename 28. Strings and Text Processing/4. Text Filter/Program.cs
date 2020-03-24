namespace TextFilter
{
    using System;
    using System.Text;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] specialWords = Console
                .ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
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
