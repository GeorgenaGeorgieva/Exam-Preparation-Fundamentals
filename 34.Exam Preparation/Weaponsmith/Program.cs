using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> particles = Console.ReadLine().Split("|").ToList();

            string comand = Console.ReadLine();

            while (comand != "Done")
            {
                string[] comands = comand.Split(" ").ToArray();
                string currentComand = comands[0];

                if (currentComand == "Move")
                {
                    string direction = comands[1];
                    int index = int.Parse(comands[2]);

                    if (direction == "Left" && index > 0 && index <= particles.Count)
                    {
                        particles.Insert(index + 1, particles[index - 1]);
                        particles.RemoveAt(index - 1);
                    }
                    else if (direction == "Right" && index >= 0 && index < particles.Count - 1)
                    {
                        particles.Insert(index, particles[index + 1]);
                        particles.RemoveAt(index + 2);
                    }
                }
                else if (currentComand == "Check")
                {
                    string type = comands[1];

                    if (type == "Even")
                    {
                        for (int i = 0; i < particles.Count; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write(particles[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (type == "Odd")
                    {
                        for (int i = 0; i < particles.Count; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write(particles[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                comand = Console.ReadLine();
            }

            StringBuilder buildWeapon = new StringBuilder();

            foreach (var pieces in particles)
            {
                buildWeapon.Append(pieces);
            }
            Console.Write($"You crafted {buildWeapon}!");
        }
    }
}
