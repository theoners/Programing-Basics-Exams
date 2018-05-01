using System;

namespace _04._Running_In_The_Park
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int totalMinutes = 0;
            double totalDistance = 0;
            double calories = 0;

            for (int i = 0; i < days; i++)
            {
                int minutes = int.Parse(Console.ReadLine());
                int distance = int.Parse(Console.ReadLine());
                string unit = Console.ReadLine();

                totalMinutes += minutes;

                if (unit=="km")
                {
                    totalDistance += distance;
                }
                else
                {
                    totalDistance += distance / 1000.0;
                }

            }

            calories = 20 * totalMinutes;
            Console.WriteLine($"He ran {totalDistance:F2}km for {totalMinutes} minutes and burned {calories} calories.");
        }
    }
}
