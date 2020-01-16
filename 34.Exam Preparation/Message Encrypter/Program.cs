using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Globalization;

namespace Message_Encrypter_SecondSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string pattern = @"([*@]{1})(?<tag>[A-Z]{1}[a-z]{2,})(\1{1})(:{1}\s{1})(?<text>(\[{1}[A-Za-z]{1}\]{1}\|{1}){3}$)";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matchText = regex.Matches(input);

                if (regex.IsMatch(input))
                {
                    foreach (Match element in matchText)
                    {
                        string tagText = element.Groups["tag"].ToString();
                        string text = element.Groups["text"].ToString();

                        string secondPattern = @"(\[)(?<letter>\w)(\])(\|)";

                        Regex regSecond = new Regex(secondPattern);

                        MatchCollection matchSymbols = regSecond.Matches(text);

                        List<int> result = new List<int>();

                        foreach (Match symbol in matchSymbols)
                        {
                            string letterSymbol = symbol.Groups["letter"].ToString();
                            char[] symbolAcci = letterSymbol.ToCharArray();
                            
                            foreach (var item in symbolAcci)
                            {
                                int acci = (int)item;
                                result.Add(acci);
                            }
                        }
                        Console.WriteLine($"{tagText}: {string.Join(" ", result)}");
                    }
                }
                else
                {
                    Console.WriteLine($"Valid message not found!");
                }
            }
        }
    }
}

