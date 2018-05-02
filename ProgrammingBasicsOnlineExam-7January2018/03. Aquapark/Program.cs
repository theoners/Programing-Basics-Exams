using System;

namespace _03._Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double time = double.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double price = 0;

            if (dayOrNight=="day")
            {
                if (month=="march"||month == "april"|| month == "may")
                {
                    price = 10.50;
                }
                else
                {
                    price = 12.60;
                }
            }
            else
            {
                if (month == "march" || month == "april" || month == "may")
                {
                    price = 8.40;
                }
                else
                {
                    price = 10.20;
                }
            }

            if (peopleCount>=4)
            {
                price *= 0.9;
            }
            if (time>=5)
            {
                price *= 0.5;
            }

            double totalCost = price * peopleCount * time;
            Console.WriteLine($"Price per person for one hour: {price:F2}");
            Console.WriteLine($"Total cost of the visit: {totalCost:F2}");

        }
    }
}
