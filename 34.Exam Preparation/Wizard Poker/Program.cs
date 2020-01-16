using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cardsInDeck = Console.ReadLine().Split(":").ToList();
            List<string> newDeck = new List<string>();
            string input = Console.ReadLine();

            while (input != "Ready")
            {
                string[] comandsInfo = input.Split(" ").ToArray();
                string currentComand = comandsInfo[0];

                if (currentComand == "Add")
                {
                    string cardName = comandsInfo[1];

                    if (cardsInDeck.Contains(cardName))
                    {
                        newDeck.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine($"Card not found.");
                    }
                }
                else if (currentComand == "Insert")
                {
                    string cardName = comandsInfo[1];
                    int index = int.Parse(comandsInfo[2]);

                    if (cardsInDeck.Contains(cardName) && index >= 0 && index < newDeck.Count)
                    {
                        newDeck.Insert(index, cardName);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (currentComand == "Remove")
                {
                    string cardName = comandsInfo[1];

                    if (newDeck.Contains(cardName))
                    {
                        newDeck.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");     
                    }
                }
                else if (currentComand == "Swap")
                {
                    string cardNameFirst = comandsInfo[1];
                    string cardNameSecond = comandsInfo[2];
                    int indexCardFirst = newDeck.IndexOf(cardNameFirst);
                    int indexCardSecond = newDeck.IndexOf(cardNameSecond);

                    if (newDeck.Contains(cardNameFirst) && newDeck.Contains(cardNameSecond))
                    {
                        newDeck.Insert(indexCardFirst, cardNameSecond);
                        newDeck.RemoveAt(indexCardSecond + 1);  
                    }
                }
                else if (currentComand == "Shuffle")
                {
                    newDeck.Reverse();
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", newDeck));
        }
    }
}
