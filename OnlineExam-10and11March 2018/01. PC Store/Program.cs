using System;

namespace _01._PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceProssecor = double.Parse(Console.ReadLine()) * 1.57;
            var priceVideoCard = double.Parse(Console.ReadLine()) * 1.57;
            var priceMemory = double.Parse(Console.ReadLine()) * 1.57;
            var countMemory = double.Parse(Console.ReadLine());
            var discount = double.Parse(Console.ReadLine());

            var moneyNeeded = priceProssecor * (1 - discount) + priceMemory * countMemory + priceVideoCard * (1 - discount);
            

            Console.WriteLine($"Money needed - {moneyNeeded:F2} leva.");
        }
    }
}
