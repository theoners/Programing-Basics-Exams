using System;

namespace _02___Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursNeed = double.Parse(Console.ReadLine());
            double worker = double.Parse(Console.ReadLine());
            double workDays = double.Parse(Console.ReadLine());

            double totalHours = worker * workDays * 8;

            if (totalHours>=hoursNeed)
            {
                Console.WriteLine($"{totalHours-hoursNeed} hours left");
            }
            else
            {
                Console.WriteLine($"{hoursNeed - totalHours} overtime");
                Console.WriteLine($"Penalties: {(hoursNeed - totalHours)*workDays}");
            }
        }
    }
}
