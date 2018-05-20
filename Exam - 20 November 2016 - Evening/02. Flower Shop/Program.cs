using System;

namespace _02._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMagnolias = int.Parse(Console.ReadLine());
            int numberOfHyacinths = int.Parse(Console.ReadLine());
            int numberOfRoses = int.Parse(Console.ReadLine());
            int numberOfCactus = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double income = numberOfMagnolias * 3.25 + numberOfHyacinths * 4 + numberOfRoses * 3.5 + numberOfCactus * 8;
            income *= 0.95;

            if (income<giftPrice)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice-income)} leva.");
            }
            else
            {
                Console.WriteLine($"She is left with {Math.Floor(income-giftPrice)} leva.");
            }
        }
    }
}
