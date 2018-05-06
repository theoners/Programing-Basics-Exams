using System;

namespace _01._Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int wrappingPaper = int.Parse(Console.ReadLine());
            int textile = int.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            double discount =double.Parse(Console.ReadLine());

            double cost = wrappingPaper * 5.8 + textile * 7.2 + glue * 1.2;
            double costWithDiscount = cost * (1-discount/100);

            Console.WriteLine($"{costWithDiscount:F3}");

        }
    }
}
