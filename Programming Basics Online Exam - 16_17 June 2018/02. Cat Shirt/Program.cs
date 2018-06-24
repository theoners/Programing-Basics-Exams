using System;

namespace _02._Cat_Shirt
{
    class Program
    {
        static void Main(string[] args)
        {
            double sleeve = double.Parse(Console.ReadLine());
            double front = double.Parse(Console.ReadLine());
            string fabricType = Console.ReadLine();
            string tie = Console.ReadLine();
            double fabricPrice = 0;

            double shirt = (sleeve+front)*2;
            shirt *= 1.1;
            shirt /= 100;

            if (fabricType== "Linen")
            {
                fabricPrice = 15;
            }
            else if (fabricType=="Cotton")
            {
                fabricPrice = 12;
            }
            else if (fabricType == "Denim")
            {
                fabricPrice = 20;
            }
            else if (fabricType == "Twill")
            {
                fabricPrice = 16;
            }
            else if (fabricType == "Flannel")
            {
                fabricPrice = 11;
            }

            double totalPrice = shirt * fabricPrice + 10;

            if (tie=="Yes")
            {
                totalPrice *= 1.2;
            }

            Console.WriteLine($"The price of the shirt is: {totalPrice:F2}lv.");
        }
    }
}
