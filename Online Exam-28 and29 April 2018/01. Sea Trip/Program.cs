using System;

namespace _01._Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForGift = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());
            double moneyForFuel = 54.39;

            double moneyForFoodAndGift = (moneyForFood+moneyForGift)*3;
            double firstDayHotel = moneyForHotel * 0.9;
            double secondDayHotel = moneyForHotel * 0.85;
            double thirdDayHotel = moneyForHotel * 0.8;

            double totalSpend = moneyForFoodAndGift + moneyForFuel + firstDayHotel + secondDayHotel + thirdDayHotel;

            Console.WriteLine($"Money needed: {totalSpend:F2}");
        }
    }
}
