using System;

namespace _01.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine())/100;

            double totalLitrs = length * width * height * 0.001;

            double litresNeed = totalLitrs * (1 - procent);

            Console.WriteLine($"{litresNeed:F3}");
        }
    }
}
