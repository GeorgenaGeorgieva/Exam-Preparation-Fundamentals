using System;
using System.Linq;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            StringBuilder bigNumber = new StringBuilder();
            int onMind = 0;

            for (int i = inputNumber.Length - 1; i >= 0 ; i--)
            {

                int lastDigit = int.Parse(inputNumber[i].ToString());
                int result = lastDigit * multiplier + onMind;
                bigNumber.Append(result % 10);
                onMind = result / 10;

            }
            if (onMind != 0)
            {
                bigNumber.Append(onMind);
            }
            string resultNumber = string.Join("", bigNumber.ToString().Reverse()).TrimStart('0');
            if (resultNumber == String.Empty)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(resultNumber);
            }
            
        }
    }
}
