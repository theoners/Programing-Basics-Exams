using System;

namespace _01.Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            double leghtCourt = double.Parse(Console.ReadLine());
            double widthCourt = double.Parse(Console.ReadLine());
            double heightNet = double.Parse(Console.ReadLine());
            double priceNet = double.Parse(Console.ReadLine());
            double weightNet = double.Parse(Console.ReadLine());

            double perimeterCourt = (leghtCourt + widthCourt)*2;
            double totalPriceNet = perimeterCourt * priceNet;
            double netArea = perimeterCourt * heightNet;
            double totalWeightNet = weightNet * netArea;
            Console.WriteLine(perimeterCourt);
            Console.WriteLine($"{totalPriceNet:F2}");
            Console.WriteLine($"{totalWeightNet:F3}");

        }
    }
}
