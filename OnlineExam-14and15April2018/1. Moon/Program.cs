using System;

namespace _1._Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            int consumation = int.Parse(Console.ReadLine());
            int distanceToMoon = 384400;

            double travelTime =distanceToMoon * 2 / speed;
            var totalTime = Math.Ceiling(travelTime) + 3;

            var totalConsumation = (distanceToMoon * 2 * consumation) / 100;

            Console.WriteLine(totalTime);
            Console.WriteLine(totalConsumation);
        }
    }
}
