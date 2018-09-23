using System;

namespace _05._Fan_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int itemCount = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < itemCount; i++)
            {
                string item = Console.ReadLine();

                switch (item)
                {
                    case "hoodie":
                        totalSum += 30;
                        break;
                    case "keychain":
                        totalSum += 4;
                        break;
                    case "T-shirt":
                        totalSum += 20;
                        break;
                    case "flag":
                        totalSum += 15;
                        break;
                    case "sticker":
                        totalSum += 1;
                        break;
                }
            }

            if (totalSum<=budget)
            {
                Console.WriteLine($"You bought {itemCount} items and left with {budget-totalSum} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalSum-budget} more lv.");
            }
        }
    }
}
