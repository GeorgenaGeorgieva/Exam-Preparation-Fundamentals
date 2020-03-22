namespace MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Collections.Generic;
    using System.Globalization;
    
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
            
            string phoneNumber = Console.ReadLine();
            
            MatchCollection matches = Regex.Matches(phoneNumber, regex);
            
            var matchedPhones = matches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            
            Console.Write(string.Join(", ", matchedPhones));
        }
    }
}
