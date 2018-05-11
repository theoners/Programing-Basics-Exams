using System;

namespace _01._Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double vinQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double vinPrice = rakiaPrice*0.6;
            double beerPrice = rakiaPrice*0.2;

            double totalPrice = whiskeyPrice * whiskeyQuantity + rakiaPrice * rakiaQuantity + vinPrice * vinQuantity + beerPrice * beerQuantity;

            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
