using System;

namespace _01._Ivanovi_s_Family
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double firstChild = double.Parse(Console.ReadLine());
            double secondChild = double.Parse(Console.ReadLine());
            double thirdChild = double.Parse(Console.ReadLine());

            double gifts = firstChild + secondChild + thirdChild;
            double restMoney = (budget - gifts)*0.90;

            Console.WriteLine($"{restMoney:F2}");
        }
    }
}
