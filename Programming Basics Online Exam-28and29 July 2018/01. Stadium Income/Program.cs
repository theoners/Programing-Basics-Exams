using System;

namespace _01._Stadium_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectorCount = int.Parse(Console.ReadLine());
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double incomeForSector = (stadiumCapacity*ticketPrice)/ sectorCount;
            double totalIncome = stadiumCapacity * ticketPrice;

            double moneyForCharity = (totalIncome - (incomeForSector * 0.75)) / 8;

            Console.WriteLine($"Total income - {totalIncome:F2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:F2} BGN");
        }
    }
}
