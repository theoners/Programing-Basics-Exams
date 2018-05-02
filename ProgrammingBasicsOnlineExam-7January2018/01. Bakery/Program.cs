using System;

namespace _01._Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double dought = double.Parse(Console.ReadLine());
            double netoBread = double.Parse(Console.ReadLine());
            double priceBread = double.Parse(Console.ReadLine());
            double countBread = double.Parse(Console.ReadLine());
            double countSweet = double.Parse(Console.ReadLine());
            var priceSweer = priceBread + (priceBread*0.25);
            var netoSweet = netoBread - (netoBread * 0.2);


            var dayincome = priceBread * countBread;
            var needDougtDay = countBread * netoBread;
            var totalDought = needDougtDay + dought;
            var needDoughtNight = netoSweet * countSweet;
            var nightIncome = priceSweer * countSweet;

            var priceDought = ((needDougtDay + dought)/1000)*4;

            var totalIncome = nightIncome + dayincome - priceDought;
            var totalDoughtUsed = needDougtDay + needDoughtNight;

            Console.WriteLine($"Pure income: {totalIncome:F2} lv.");
            Console.WriteLine($"Dough used: {totalDoughtUsed:F0} g.");

        }
    }
}
