using System;

namespace _02._Football_Kit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double targetPrice = double.Parse(Console.ReadLine());

            double shortsPrice = tshirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.2;
            double bootsPrice = 2 * (shortsPrice + tshirtPrice);

            double totalPrice = (tshirtPrice+shortsPrice+socksPrice+bootsPrice)*0.85;

            if (totalPrice>=targetPrice)
            {
                Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalPrice:F2} lv.");
            }
            else
            {
                Console.WriteLine($"No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {(targetPrice-totalPrice):F2} lv. more.");
            }
        }
    }
}
