using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> firstLessonsSchedule = Console.ReadLine().Split(", ").ToList();
            
            string comand = Console.ReadLine();
            while (comand != "course start")
            {
                string[] currentComand = comand.Split(":");
                string operation = currentComand[0];
                string lessonTitle = currentComand[1];

                if (operation == "Add")
                {
                    if (!firstLessonsSchedule.Contains(lessonTitle))
                    {
                        firstLessonsSchedule.Add(lessonTitle);
                    }
                }
                else if (operation == "Insert")
                {
                    int indexCurrentLesson = int.Parse(currentComand[2]);
                    if (!firstLessonsSchedule.Contains(lessonTitle))
                    {
                        firstLessonsSchedule.Insert(indexCurrentLesson, lessonTitle);
                    }
                }
                else if (operation == "Remove")
                {
                    if (firstLessonsSchedule.Contains(lessonTitle))
                    {
                        firstLessonsSchedule.Remove(lessonTitle);
                    }
                    if (firstLessonsSchedule.Contains(lessonTitle + "-" + "Exercise"))
                    {
                        firstLessonsSchedule.Remove(lessonTitle + "-" + "Exercise");
                    }
                }
                else if (operation == "Swap")
                {
                    string secondLesson = currentComand[2];
                    
                    if (firstLessonsSchedule.Contains(lessonTitle) && firstLessonsSchedule.Contains(secondLesson))
                    {
                        int indexFirstElement = firstLessonsSchedule.IndexOf(lessonTitle);
                        int indexSecondElement = firstLessonsSchedule.IndexOf(secondLesson);
                        firstLessonsSchedule.Insert(indexFirstElement, secondLesson);
                        firstLessonsSchedule.Insert(indexSecondElement, lessonTitle);
                    }
                }
                else if (operation == "Exercise")
                {
                    if (firstLessonsSchedule.Contains(lessonTitle) && !firstLessonsSchedule.Contains($"{lessonTitle}-Exercise"))
                    {
                        int indexOfcurrentLesson = firstLessonsSchedule.IndexOf(lessonTitle);
                        firstLessonsSchedule[indexOfcurrentLesson] = lessonTitle + "-Exercise";
                    }
                    else
                    { 
                       
                        firstLessonsSchedule.Add(lessonTitle);
                    }
                }
                comand = Console.ReadLine();
            }
            
           for (int i = 1; i <= firstLessonsSchedule.Count; i++)
           {
              Console.WriteLine($"{i}.{firstLessonsSchedule[i - 1]}");
           }
            
        }
    }
}
