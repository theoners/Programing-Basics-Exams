using System;

namespace _01._Hearthstone
{
    class Program
    {
        static void Main(string[] args)
        {
            var breakTime = int.Parse(Console.ReadLine());
            var priceCards = double.Parse(Console.ReadLine());
            var priceAdventure = double.Parse(Console.ReadLine());
            var priceCoffee = double.Parse(Console.ReadLine());

            var money = 3 * priceCards + 2 * priceAdventure + priceCoffee;
            var leftTime = breakTime - 15;

            Console.WriteLine($"{money:F2}");
            Console.WriteLine(leftTime);
  
        }
    }
}
