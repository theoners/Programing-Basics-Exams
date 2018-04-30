using System;

namespace _2._AND_Processors
{
    class Program
    {
        static void Main(string[] args)
        {
            int countProcessor = int.Parse(Console.ReadLine());
            int countPeople = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            double totalWorkHours = countPeople * workDays * 8;
            var producedProcessor = totalWorkHours / 3;
            producedProcessor = Math.Floor(producedProcessor);

            if (producedProcessor<countProcessor)
            {
                var diff = (countProcessor - producedProcessor)*110.10;
                Console.WriteLine($"Losses: -> {diff:F2} BGN");
            }
            else
            {
                var diff = (producedProcessor - countProcessor) * 110.10;
                Console.WriteLine($"Profit: -> {diff:F2} BGN");
            }
        }
    }
}
