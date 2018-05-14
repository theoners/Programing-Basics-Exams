using System;

namespace _03___Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double costs = 0;
            string place = "";

            if (budget <= 1000)
            {
                place = "Camp";
                if (season == "Summer")
                {
                    costs = budget * 0.65;
                }
                else
                {
                    costs = budget * 0.45;
                }
            }
            else if (budget <= 3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    costs = budget * 0.8;
                }
                else
                {
                    costs = budget * 0.6;
                }
            }
            else
            {
                place = "Hotel";
                costs = budget * 0.9;
            }

            if (season=="Summer")
            {
                Console.WriteLine($"Alaska - {place} - {costs:F2}");
            }
            else
            {
                Console.WriteLine($"Morocco - {place} - {costs:F2}");
            }
        }
    }
}
