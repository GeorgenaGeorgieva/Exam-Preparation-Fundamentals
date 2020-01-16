using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int counter = 0;
            int[] checkList = numbers.ToArray();
          

            while (true)
            {
                string[] comand = Console.ReadLine().Split().ToArray();

                if (comand[0] == "Add")
                {
                    int number = int.Parse(comand[1]);
                    numbers.Add(number);
                    counter++;
                }
                else if (comand[0] == "Remove")
                {
                    int number = int.Parse(comand[1]);
                    numbers.Remove(number);
                    counter++;
                }
                else if (comand[0] == "RemoveAt")
                {
                    int index = int.Parse(comand[1]);
                    numbers.RemoveAt(index);
                    counter++;
                }
                else if (comand[0] == "Insert")
                {
                    int number = int.Parse(comand[1]);
                    int index = int.Parse(comand[2]);
                    numbers.Insert(index, number);
                    counter++;
                }
                else if (comand[0] == "Contains")
                {
                    int number = int.Parse(comand[1]);
                    if (numbers.Contains(number) == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (comand[0] == "PrintEven")
                {
                    numbers.RemoveAll(item => item % 2 != 0);
                    Console.WriteLine(string.Join(" ", numbers));
                    numbers = checkList.ToList();  //rewrite the sheet
                }
                else if (comand[0] == "PrintOdd")
                {
                    numbers.RemoveAll(item => item % 2 == 0);
                    Console.WriteLine(string.Join(" ", numbers));
                    numbers = checkList.ToList(); //rewrite the sheet
                }
                else if (comand[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (comand[0] == "Filter")
                {
                    int currentNumber = int.Parse(comand[2]);

                    if (comand[1] == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(item => item < currentNumber)));
                    }
                    else if (comand[1] == "<=")
                    {  
                        Console.WriteLine(string.Join(" ", numbers.FindAll(item => item <= currentNumber)));
                    }
                    else if (comand[1] == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(item => item > currentNumber)));
                    }
                    else if (comand[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(item => item >= currentNumber)));
                    }
                }
                else if (comand[0] == "end")
                { 
                    break;
                } 
            }
            if (counter > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
