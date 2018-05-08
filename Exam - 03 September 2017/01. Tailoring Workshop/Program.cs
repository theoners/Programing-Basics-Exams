using System;

namespace _01._Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int table = int.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double coverArea = table*(tableLenght + 0.6) * (tableWidth + 0.6);
            double squareArea = table * (tableLenght / 2) * (tableLenght / 2);
            double priceInDolars = coverArea * 7 + squareArea * 9;
            double priceInLeva = priceInDolars * 1.85;

            Console.WriteLine($"{priceInDolars:F2} USD");
            Console.WriteLine($"{priceInLeva:F2} BGN");
        }
    }
}
