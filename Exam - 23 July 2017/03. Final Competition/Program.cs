using System;

namespace _03._Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancer = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double award = points*dancer;

            if (place == "Abroad")
            {
                award *= 1.5;
                if (season=="summer")
                {
                    award *= 0.9;
                }
                else
                {
                    award *= 0.85;
                }
            }
            else
            {
                if (season == "summer")
                {
                    award *= 0.95;
                }
                else
                {
                    award *= 0.92;
                }
            }

            double charity = award * 0.75;
            double moneyPerPerson = (award - charity) / dancer;

            Console.WriteLine($"Charity - {charity:F2}");
            Console.WriteLine($"Money per dancer - {moneyPerPerson:F2}");
        }
    }
}
