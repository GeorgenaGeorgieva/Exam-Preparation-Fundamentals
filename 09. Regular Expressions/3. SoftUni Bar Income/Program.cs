namespace SoftUniBarIncome
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Text;
    using System.Globalization;
    
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            
            double totalMoneyForDay = 0;
            string input = Console.ReadLine();
            
            while (input != "end of shift")
            {
                MatchCollection matchProfitInformation = Regex.Matches(input, pattern);
                double profitMoney = 0;    
                
                foreach  (Match data in matchProfitInformation)
                {
                    string customerName = data.Groups["customer"].Value;
                    string product = data.Groups["product"].Value;
                    int count = int.Parse(data.Groups["count"].Value);
                    double price = double.Parse(data.Groups["price"].Value);
                    
                    profitMoney = count * price;
                    
                    Console.WriteLine($"{customerName}: {product} - {profitMoney:F2}");
                    
                    totalMoneyForDay += profitMoney;
                }
                
                input = Console.ReadLine();
            }
            
            Console.WriteLine($"Total income: {totalMoneyForDay:F2}");
        }
    }
}
