using System;
using System.Text.RegularExpressions;
namespace _3._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>\d{2})(?<sep>[-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";
            string dates = Console.ReadLine();
            MatchCollection matchDates = Regex.Matches(dates, regex);
            foreach  (Match date in matchDates)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
