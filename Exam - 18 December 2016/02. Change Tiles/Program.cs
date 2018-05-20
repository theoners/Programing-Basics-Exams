using System;

namespace _02._Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double floorLeght = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double tileSide = double.Parse(Console.ReadLine());
            double tileHight = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double workmanPrice = double.Parse(Console.ReadLine());

            double floorArea = floorLeght * floorWidth;
            double tileArea = tileSide * tileHight / 2;
            double tilesNeed = Math.Ceiling(floorArea / tileArea) + 5;

            double cost = tilesNeed * tilePrice + workmanPrice;

            if (money>=cost)
            {
                Console.WriteLine($"{(money-cost):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {(cost-money):F2} lv more.");
            }
        }
    }
}
