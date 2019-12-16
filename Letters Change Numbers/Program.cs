using System;
using System.Linq;
using System.Text;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitedInput = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;
            for (int i = 0; i < splitedInput.Length; i++)
            {
                string currentString = splitedInput[i];
                char firstLetter = currentString[0];
                char lastLetter = currentString[currentString.Length - 1];
                double digit = double.Parse(currentString.Substring(1, currentString.Length - 2));
                if (char.IsUpper(firstLetter))
                {
                    digit /= firstLetter - 'A' + 1;
                }
                else
                {
                    digit *= firstLetter - 'a' + 1;
                }

                if (char.IsUpper(lastLetter))
                {
                    digit -= lastLetter - 'A' + 1;
                }
                else
                {
                    digit += lastLetter - 'a' + 1;
                }
                totalSum += digit;
            }
            Console.WriteLine(totalSum.ToString("f2"));
        }
    }
}
