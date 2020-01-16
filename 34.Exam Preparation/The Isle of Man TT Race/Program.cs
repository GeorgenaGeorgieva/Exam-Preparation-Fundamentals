using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Text;

namespace Problem_1._The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(([#%$*&]))(?<name>[A-Za-z]+)(\2)([=])(?<length>\d+)([!]{2})(?<encrypted>\w+\S+)";

            while (true)
            {
                string input = Console.ReadLine();
                MatchCollection matchedInput = Regex.Matches(input, regex);

                if (matchedInput.Count == 0)
                {
                    Console.WriteLine($"Nothing found!");
                }
                else
                {
                    foreach (Match match in matchedInput)
                    {
                        string nameracer = match.Groups["name"].ToString();
                        int lengthgeohash = int.Parse(match.Groups["length"].ToString());
                        string encryptedtext = match.Groups["encrypted"].ToString();

                        if (encryptedtext.Length != lengthgeohash)
                        {
                            Console.WriteLine($"Nothing found!");
                            break;
                        }
                        else
                        {
                            StringBuilder buildText = new StringBuilder();  

                            for (int i = 0; i < encryptedtext.Length; i++)
                            {
                                char currentSymbol = encryptedtext[i];
                                char dectiptText = (char)(currentSymbol + lengthgeohash);
                                buildText.Append(dectiptText);
                            }
                            Console.WriteLine($"Coordinates found! {nameracer} -> {buildText}");
                            return;
                        }
                    }
                }
            }
        }
    }
}
