using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double moneyForPoint = double.Parse(Console.ReadLine());
            double totalPoints = 0;

            for (int i = 1; i <= parts; i++)
            {
                double points = double.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    totalPoints += points * 2;
                }
                else
                {
                    totalPoints += points;
                }

            }
            double award = totalPoints * moneyForPoint;

            Console.WriteLine($"The project prize was {award:F2} lv.");
        }
    }
}
