using System;

namespace _01._Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine())/60;
            double secondtTime = double.Parse(Console.ReadLine())/60;
            double thirdTime = double.Parse(Console.ReadLine())/60;

            double firstDistance = speed * firstTime;
            speed *= 1.1;
            double secondDistance = speed * secondtTime;
            speed *= 0.95;
            double thirdDistance = speed * thirdTime;

            double totalDistance = firstDistance + secondDistance + thirdDistance;

            Console.WriteLine($"{ totalDistance:F2}");

        }
    }
}
