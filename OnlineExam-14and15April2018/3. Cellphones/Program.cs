using System;

namespace _3._Cellphones
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double numberCellphone = double.Parse(Console.ReadLine());
            string brand = Console.ReadLine();
            double discount = 1;
            double price = 0;

            if (brand.Equals("Gsm4e"))
            {
                discount = 0.99;
                price = 20.50;
            }
            else if (brand.Equals("Mobifon4e"))
            {
                discount = 0.98;
                price = 50.75;
            }
            else
            {
                discount = 0.97;
                price = 115;
            }

            
            if (numberCellphone > 10 && numberCellphone <= 20)
            {
                discount = discount - 0.02;
            }
            else if (numberCellphone > 20 && numberCellphone <= 50)
            {
                discount = discount - 0.05;
            }
            else if (numberCellphone > 50)
            {
                discount = discount - 0.07;
            }

            var totalPrice = numberCellphone * price * discount;

            if (budjet>=totalPrice)
            {
                var diff = budjet - totalPrice;
                Console.WriteLine($"The company bought all mobile phones. {diff:F2} leva left.");
            }
            else
            {
                var diff = totalPrice - budjet;
                Console.WriteLine($"Not enough money for all mobiles. Company needs {diff:F2} more leva.");
            }
        }
    }
}
