using System;

namespace _02._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tourPrice = double.Parse(Console.ReadLine());
            double puzzleCount = double.Parse(Console.ReadLine());
            double dollCount = double.Parse(Console.ReadLine());
            double bearCount = double.Parse(Console.ReadLine());
            double minionCount = double.Parse(Console.ReadLine());
            double truckCount = double.Parse(Console.ReadLine());

            double toysCount = puzzleCount + dollCount + bearCount + minionCount + truckCount;

            double totalPrice = puzzleCount*2.6 + dollCount*3 + bearCount*4.1 + minionCount*8.2 + truckCount*2;

            if (toysCount>=50)
            {
                totalPrice *= 0.75;
            }
            totalPrice *= 0.9;

            if (totalPrice<tourPrice)
            {
                Console.WriteLine($"Not enough money! {(tourPrice-totalPrice):F2} lv needed.");
            }
            else
            {
                Console.WriteLine($"Yes! {(totalPrice-tourPrice):F2} lv left.");
            }
        }
    }
}
