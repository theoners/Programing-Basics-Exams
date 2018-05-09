using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string coctailSize = Console.ReadLine();
            double coctailCount = int.Parse(Console.ReadLine());
            double price = 0;

            if (coctailSize=="big")
            {
                switch (fruit)
                {
                    case "Watermelon":
                        price = 28.7 * 5;
                        break;
                    case "Mango":
                        price = 19.6 * 5;
                        break;
                    case "Pineapple":
                        price = 24.8 * 5;
                        break;
                    case "Raspberry":
                        price = 15.2 * 5;
                        break;
                }
            }
            else
            {
                switch (fruit)
                {
                    case "Watermelon":
                        price = 56 * 2;
                        break;
                    case "Mango":
                        price = 36.66 * 2;
                        break;
                    case "Pineapple":
                        price = 42.1 * 2;
                        break;
                    case "Raspberry":
                        price = 20 * 2;
                        break;
                }
            }

            double totalPrice = price * coctailCount;

            if (totalPrice>=400 && totalPrice<=1000)
            {
                totalPrice *= 0.85;
            }
            else if (totalPrice > 1000)
            {
                totalPrice /= 2;
            }

            Console.WriteLine($"{totalPrice:F2} lv.");
        }
    }
}
