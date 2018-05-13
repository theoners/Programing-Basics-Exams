using System;

namespace _01___Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            double vineyardArea = double.Parse(Console.ReadLine());
            double grapesFromOneMeter = double.Parse(Console.ReadLine());
            double loss = double.Parse(Console.ReadLine());

            double totalGrapes = vineyardArea * grapesFromOneMeter-loss;
            double rakia = (totalGrapes * 0.45)/7.5;
            double incomeFromRakia = rakia * 9.8;

            double incomeForSale = totalGrapes * 0.55 * 1.5;

            Console.WriteLine($"{incomeFromRakia:F2}");
            Console.WriteLine($"{incomeForSale:F2}");

        }
    }
}
