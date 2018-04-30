using System;

namespace _01._Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = double.Parse(Console.ReadLine());
            var speedTruck = double.Parse(Console.ReadLine());
            var speedCar = double.Parse(Console.ReadLine());

            speedCar = speedCar * 3.6 + speedTruck;

            Console.WriteLine($"The truck arrived after {Math.Ceiling(distance/speedTruck)} hours");
            Console.WriteLine($"The car arrived after {Math.Ceiling(distance/speedCar)} hours");

        
        }
    }
}
