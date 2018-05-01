using System;

namespace _01._Programming_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForPage = double.Parse(Console.ReadLine());
            double priceForCover = double.Parse(Console.ReadLine());
            double procentDiscountForPaper = double.Parse(Console.ReadLine());
            double moneyForDesigner = double.Parse(Console.ReadLine());
            double totalDiscount = double.Parse(Console.ReadLine());

            double priceWothoutDiscount = priceForPage * 899 + priceForCover * 2;
            double priceWithDiscount = priceWothoutDiscount * (1 - procentDiscountForPaper/100);
            double priceWithDesigner = priceWithDiscount + moneyForDesigner;
            double totalPrice = priceWithDesigner * (1 - totalDiscount/100);

            Console.WriteLine($"Avtonom should pay {totalPrice:F2} BGN.");
        }
    }
}
