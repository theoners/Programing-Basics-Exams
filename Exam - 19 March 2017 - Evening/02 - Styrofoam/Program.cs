using System;

namespace _02___Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); 
            double houseArea = double.Parse(Console.ReadLine());
            double numberOfWindows = double.Parse(Console.ReadLine());
            double styrofoamInPacket = double.Parse(Console.ReadLine());
            double styrfoamPrice = double.Parse(Console.ReadLine());

            double areaWithoutWindows = houseArea - numberOfWindows * 2.4;
            areaWithoutWindows += areaWithoutWindows * 0.1;

            double styrofoamNeed = Math.Ceiling(areaWithoutWindows / styrofoamInPacket);
            double price = styrofoamNeed * styrfoamPrice;

            if (budget>=price)
            {
                Console.WriteLine($"Spent: {price:F2}");
                Console.WriteLine($"Left: {(budget- price):F2}");
            }
            else
            {
                Console.WriteLine($"Need more: {(price - budget):F2}");
            }
        }
    }
}
