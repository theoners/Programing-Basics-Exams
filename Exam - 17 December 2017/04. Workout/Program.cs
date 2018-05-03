using System;

namespace _04._Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double firstDayKilometers = double.Parse(Console.ReadLine());
            double kilometeresPerDays = firstDayKilometers;
            double totalKilometeres = firstDayKilometers;

            for (int i = 0; i < days; i++)
            {
                double procentPlusKilometeres = double.Parse(Console.ReadLine());
                kilometeresPerDays = kilometeresPerDays * (1 + procentPlusKilometeres / 100);
                totalKilometeres += kilometeresPerDays;
            }

            if (totalKilometeres>=1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalKilometeres-1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000-totalKilometeres)} more kilometers");
            }
        }
    }
}
