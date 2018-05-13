using System;

namespace _03___Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double distance = int.Parse(Console.ReadLine());
            double price = 0;

            if (distance<=5000)
            {
                if (season=="Summer")
                {
                    price = 0.90;
                }
                else if (season=="Winter")
                {
                    price = 1.05;
                }
                else
                {
                    price = 0.75;
                }
            }
            else if (distance<=10000)
            {
                if (season == "Summer")
                {
                    price = 1.10;
                }
                else if (season == "Winter")
                {
                    price = 1.25;
                }
                else
                {
                    price = 0.95;
                }
            }
            else
            {
                price = 1.45;
            }
            double salary = price * distance * 4;
            salary = salary * 0.9;
            Console.WriteLine($"{salary:F2}");
        }
    }
}
