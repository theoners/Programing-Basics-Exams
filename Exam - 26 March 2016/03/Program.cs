using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string place = "";
            double cost = 0;


            if (budget<=100)
            {
                destination = "Bulgaria";
                if (season=="summer")
                {
                    cost = budget * 0.3;
                    place = "Camp";
                }
                else
                {
                    cost = budget * 0.7;
                    place = "Hotel";
                }
            }
            else if (budget<=1000)
            {
                destination = "Balkans";
                if (season=="summer")
                {
                    cost = budget * 0.4;
                    place = "Camp";
                }
                else
                {
                    cost = budget * 0.8;
                    place = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                cost = budget * 0.9;
                place = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {cost:F2}");
        }
    }
}
