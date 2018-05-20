using System;

namespace _03._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorBiker = int.Parse(Console.ReadLine());
            int seniorBiker = int.Parse(Console.ReadLine());
            string trackType = Console.ReadLine();
            double juniorPrice = 0;
            double seniorPrice = 0;

            switch (trackType)
            {
                case "trail":
                    juniorPrice = 5.5;
                    seniorPrice = 7;
                    break;
                case "cross-country":
                    juniorPrice = 8;
                    seniorPrice = 9.5;
                    if (seniorBiker + juniorBiker > 49)
                    {
                        juniorPrice *= 0.75;
                        seniorPrice *= 0.75;
                    }
                    break;
                case "downhill":
                    juniorPrice = 12.25;
                    seniorPrice = 13.75;
                    break;
                case "road":
                    juniorPrice = 20;
                    seniorPrice = 21.5;
                    break;
            }

            double income = juniorBiker * juniorPrice + seniorBiker * seniorPrice;
            income *= 0.95;

            Console.WriteLine($"{income:F2}");
        }
    }
}
