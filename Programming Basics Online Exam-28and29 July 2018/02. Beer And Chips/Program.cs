using System;

namespace _02._Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string fanName = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double chips = double.Parse(Console.ReadLine());

            double beersPrice = beer * 1.2;
            double chipsPrice = Math.Ceiling((beersPrice * 0.45) * chips);
            double totalSum = beersPrice + chipsPrice;

            if (totalSum<=budget)
            {
                Console.WriteLine($"{fanName} bought a snack and has {(budget-totalSum):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{fanName} needs {(totalSum-budget):F2} more leva!");
            }
        }
    }
}
