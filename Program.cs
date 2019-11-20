using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _2._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var regexDigits = @"\d";
            var regexLetters = @"[A-Za-z]";
            Dictionary<string, double> participantsAndDistance = new Dictionary<string, double>();
            string[] participantNames = Console.ReadLine().Split(", ").ToArray();
            foreach (string player in participantNames)
            {
                if (!participantsAndDistance.ContainsKey(player))
                {
                    participantsAndDistance[player] = 0;
                }
            }
            string input = Console.ReadLine();
            while (input != "end of race")
            {
                MatchCollection nameMatch = Regex.Matches(input, regexLetters);
                MatchCollection distanceMatch = Regex.Matches(input, regexDigits);
                string currentName = String.Empty;
                double distance = 0;
                foreach (Match letter in nameMatch)
                {
                    currentName += letter.Value;
                }
                foreach (Match digit in distanceMatch)
                {
                    distance += double.Parse(digit.Value);
                }
                if (participantsAndDistance.ContainsKey(currentName))
                {
                    participantsAndDistance[currentName] += distance;
                }
                input = Console.ReadLine();
            }
            participantsAndDistance = participantsAndDistance
                .OrderByDescending(x => x.Value)
                .ToDictionary(z => z.Key, x => x.Value);

            Console.WriteLine($"1st place: {participantsAndDistance.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {participantsAndDistance.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {participantsAndDistance.Keys.ElementAt(2)}");
        }
    }
}
