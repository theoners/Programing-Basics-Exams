using System;

namespace _01._House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double priceForMeter = double.Parse(Console.ReadLine());

            double bathroomArea = smallRoomArea / 2;
            double secondRoomArea = smallRoomArea * 1.1;
            double thirdRoomArea = secondRoomArea * 1.1;

            double houseArea = kitchenArea + bathroomArea + smallRoomArea + secondRoomArea + thirdRoomArea;
            houseArea *= 1.05;
            double housePrice = houseArea * priceForMeter;

            Console.WriteLine($"{housePrice:F2}");

        }
    }
}
