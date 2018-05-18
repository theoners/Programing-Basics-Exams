using System;

namespace _03___Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string classType = "";
            string car = "Jeep";
            double carPrice = 0;

            if (budget<=100)
            {
                classType = "Economy class";
                if (season=="Winter")
                {
                    carPrice = budget * 0.65;
                }
                else
                {
                    carPrice = budget * 0.35;
                    car = "Cabrio";
                }
            }
            else if (budget<=500)
            {
                classType = "Compact class";
                if (season == "Winter")
                {
                    carPrice = budget * 0.80;
                }
                else
                {
                    carPrice = budget * 0.45;
                    car = "Cabrio";
                }
            }
            else
            {
                classType = "Luxury class";
                    carPrice = budget * 0.90;
            }

            Console.WriteLine(classType);
            Console.WriteLine($"{car} - {carPrice:F2}");
        }
    }
}
