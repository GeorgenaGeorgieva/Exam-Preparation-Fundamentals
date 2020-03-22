using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _1._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(>{2})(?<furniture>.+)(<{2})((?<price>\d+\.?\d*)|(\d+))(!{1})(?<qunatity>\d+)";
            List<string> typeFurnitures = new List<string>();
            string input = Console.ReadLine();
            double sumPriceForAll = 0;
            while (input != "Purchase")
            {
                Match matchFurniture = Regex.Match(input, regex);
                if (matchFurniture.Success)
                {
                    var furniture = matchFurniture.Groups["furniture"].Value;
                    var exceptionalPrice = double.Parse(matchFurniture.Groups["price"].Value);
                    var quantity = int.Parse(matchFurniture.Groups["qunatity"].Value);
                    sumPriceForAll += exceptionalPrice* quantity;
                    typeFurnitures.Add(furniture);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Bought furniture:");
            foreach (var furniture in typeFurnitures)
            {
                Console.WriteLine(furniture);
            }
            Console.WriteLine($"Total money spend: {sumPriceForAll:F2}");
        }
    }
}
