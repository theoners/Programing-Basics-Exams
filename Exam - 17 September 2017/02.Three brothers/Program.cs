using System;

namespace _02.Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrotherTIme = double.Parse(Console.ReadLine());
            double secondBrotherTIme = double.Parse(Console.ReadLine());
            double thirdBrotherTIme = double.Parse(Console.ReadLine());
            double FatherTime = double.Parse(Console.ReadLine());

            double totalTime = (1 / (1 / firstBrotherTIme + 1 / secondBrotherTIme + 1 / thirdBrotherTIme))*1.15;

            Console.WriteLine($"Cleaning time: {totalTime:F2}");

            if (totalTime<=FatherTime)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(FatherTime-totalTime)} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(totalTime - FatherTime)} hours.");
            }
        }
    }
}
