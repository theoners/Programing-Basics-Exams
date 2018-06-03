using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegatables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            double vegatablesQuantity = double.Parse(Console.ReadLine());
            double fruitsQuantity = double.Parse(Console.ReadLine());

            double totalPrice = (priceVegatables*vegatablesQuantity+priceFruits*fruitsQuantity)/ 1.94;

            Console.WriteLine(totalPrice);
        }
    }
}
