namespace BiscuitsFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsOneWorker = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int competingFactoryBiscuits = int.Parse(Console.ReadLine());
            double biscuitsPerDay = biscuitsOneWorker * countOfWorkers;
            double sumBiscuits = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    sumBiscuits += (Math.Floor(biscuitsPerDay * 0.75));
                }
                else
                {
                    sumBiscuits += biscuitsPerDay;
                }
            }
            
            Console.WriteLine($"You have produced {sumBiscuits} biscuits for the past month.");

            if (sumBiscuits > competingFactoryBiscuits)
            {
                double differencePercent = ((sumBiscuits - competingFactoryBiscuits)/ competingFactoryBiscuits ) * 100;
                Console.WriteLine($"You produce {differencePercent:F2} percent more biscuits.");
            }
            else
            {
                double differencePercent = ((competingFactoryBiscuits - sumBiscuits) / competingFactoryBiscuits) * 100;
                Console.WriteLine($"You produce {differencePercent:F2} percent less biscuits.");
            }
        }
    }
}
