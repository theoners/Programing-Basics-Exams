using System;

namespace _02___Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            double cupCount = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double workDays = double.Parse(Console.ReadLine());

            double totalHours = workers * workDays * 8;
            double cups =Math.Floor(totalHours / 5);

            if (cups<cupCount)
            {
                double losses = (cupCount-cups)*4.2;
                Console.WriteLine($"Losses: {losses:F2}");
            }
            else
            {
                double extraMoney = (cups - cupCount) * 4.2;
                Console.WriteLine($"{extraMoney:F2} extra money");
            }
        }
    }
}
