namespace StringExplosion
{
    using System;
    using System.Text;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputLine = input.Split(">");
            string result = inputLine[0];
            int reminingPower = 0;
            
            for (int i = 1; i < inputLine.Length; i++)
            {
                result += ">";
                string currentString = inputLine[i];
                char digitSymbol = currentString[0];
                
                int power = int.Parse(digitSymbol.ToString()) + reminingPower;
                
                if (power > currentString.Length)
                {
                    reminingPower = power - currentString.Length;
                }
                else
                {
                    result += currentString.Substring(power);
                }     
            }
            
            Console.WriteLine(result);
        }
    }
}
