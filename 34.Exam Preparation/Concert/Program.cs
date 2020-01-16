using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace Problem_1___Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bandNamesAndMembers = new Dictionary<string, List<string>>();

            Dictionary<string, int> bandNameAndTimes = new Dictionary<string, int>();

            int totalTime = 0;
            string input = Console.ReadLine();

            while (input != "start of concert")
            {
                string[] infoComandsAndBands = input.Split("; ", StringSplitOptions.RemoveEmptyEntries).ToArray(); 
                string comand = infoComandsAndBands[0];
                string bandName = infoComandsAndBands[1];

                if (comand == "Add")
                {
                    List<string> memberNames = infoComandsAndBands[2].Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

                    if (!bandNamesAndMembers.ContainsKey(bandName))
                    {
                        bandNamesAndMembers.Add(bandName, memberNames);
                    }
                    else 
                    {
                        foreach (var member in memberNames)
                        {
                            if (!bandNamesAndMembers[bandName].Contains(member))
                            {
                                bandNamesAndMembers[bandName].Add(member);
                            }
                        }
                    }
                }
                else if (comand == "Play")
                {
                    int bandTime = int.Parse(infoComandsAndBands[2]);
                    totalTime += bandTime;

                    if (!bandNameAndTimes.ContainsKey(bandName))
                    {
                        bandNameAndTimes.Add(bandName, bandTime);
                    }
                    else
                    {
                        bandNameAndTimes[bandName] += bandTime;
                    }
                }
               input = Console.ReadLine();
            }

            bandNameAndTimes = bandNameAndTimes
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            string selectedBand = Console.ReadLine();
            Console.WriteLine($"Total time: {totalTime}");

            foreach (var time in bandNameAndTimes)
            {
                Console.WriteLine($"{time.Key} -> {time.Value}");
            }
           
            if (bandNamesAndMembers.ContainsKey(selectedBand))
            {
               Console.WriteLine($"{selectedBand}");

               for (int i = 0; i < bandNamesAndMembers[selectedBand].Count; i++)
               {
                        Console.WriteLine($"=> {bandNamesAndMembers[selectedBand][i]}");
               }  
            }
        }
    }
}
