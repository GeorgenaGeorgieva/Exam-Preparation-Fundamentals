using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyListEmployee = new Dictionary<string, List<string>>();
            string comand = Console.ReadLine();
            
            while (comand != "End")
            {
                string[] information = comand
                    .Split("->")
                    .Select(x => x.Trim())
                    .ToArray();
                
                string companyName = information[0];
                string employeeId = information[1];

                if (!companyListEmployee.ContainsKey(companyName))
                {
                   companyListEmployee[companyName] = new List<string>();
                }
                if (!companyListEmployee[companyName].Contains(employeeId))
                {
                    companyListEmployee[companyName].Add(employeeId);
                }
                
                comand = Console.ReadLine();
            }
            
            companyListEmployee = companyListEmployee
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            
            foreach (var name in companyListEmployee)
            {
                Console.WriteLine(name.Key);
                
                foreach (var id in name.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
