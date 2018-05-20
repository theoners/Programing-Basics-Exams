using System;

namespace _01._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double palamudQuantity = double.Parse(Console.ReadLine());
            double scadQuantity = double.Parse(Console.ReadLine());
            double clamQuantity = double.Parse(Console.ReadLine());

            double palamudPrice = (mackerelPrice * 1.6)*palamudQuantity;
            double scadPrice = (spratPrice*1.8)*scadQuantity;
            double clamPrice = clamQuantity * 7.5;

            double cost = palamudPrice + scadPrice + clamPrice;

            //Console.WriteLine($"{Math.Round(cost,2,MidpointRounding.ToEven)}");
            Console.WriteLine($"{cost:F2}");
        }
    }
}
