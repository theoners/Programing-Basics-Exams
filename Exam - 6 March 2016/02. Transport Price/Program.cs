using System;

namespace _02._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double pricePerKm = 0;
            double totalPrice = 0;

            if (n < 20)
            {
                if (dayOrNight == "day")
                {
                    pricePerKm = 0.79;
                    totalPrice += 0.7;
                }
                else
                {
                    pricePerKm = 0.9;
                    totalPrice += 0.7;
                }

            }
            else if (n < 100)
            {
                pricePerKm = 0.09;
            }
            else
            {
                pricePerKm = 0.06;
            }

            totalPrice += n * pricePerKm;

            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
