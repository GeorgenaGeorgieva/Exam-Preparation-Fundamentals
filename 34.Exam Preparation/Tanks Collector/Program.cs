using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;

namespace Problem_3._Tanks_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tanksOwnedByTom = Console.ReadLine().Split(", ").ToList();
            int countOfComands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfComands; i++)
            {
                string[] comands = Console.ReadLine().Split(", ").ToArray();
                string currentComand = comands[0];

                if (currentComand == "Add")
                {
                    string tankName = comands[1];

                    if (tanksOwnedByTom.Contains(tankName))
                    {
                        Console.WriteLine($"Tank is already bought");
                    }
                    else
                    {
                        Console.WriteLine($"Tank successfully bought");
                        tanksOwnedByTom.Add(tankName);
                    }
                }
                else if (currentComand == "Remove")
                {
                    string tankName = comands[1];

                    if (tanksOwnedByTom.Contains(tankName))
                    {
                        Console.WriteLine($"Tank successfully sold");
                        tanksOwnedByTom.Remove(tankName);
                    }
                    else
                    {
                        Console.WriteLine($"Tank not found");
                    }
                }
                else if (currentComand == "Remove At")
                {
                    int index = int.Parse(comands[1]);

                    if (index >= 0 && index < tanksOwnedByTom.Count)
                    {
                        Console.WriteLine($"Tank successfully sold");
                        tanksOwnedByTom.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                }
                else if (currentComand == "Insert")
                {
                    int index = int.Parse(comands[1]);
                    string tankName = comands[2];

                    if (index >= 0 && index < tanksOwnedByTom.Count)
                    {
                        if (tanksOwnedByTom.Contains(tankName))
                        {
                            Console.WriteLine($"Tank is already bought");
                        }
                        else
                        {
                            Console.WriteLine($"Tank successfully bought");
                            tanksOwnedByTom.Insert(index, tankName);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Index out of range");
                    }
                }
            }
            Console.WriteLine(string.Join(", ", tanksOwnedByTom));
        }
    }
}
