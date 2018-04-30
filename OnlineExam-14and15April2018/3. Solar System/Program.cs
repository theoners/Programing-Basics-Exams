using System;

namespace _3._Solar_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string planetName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            var distance = 0.0;


            switch (planetName)
            {
                case "Mercury":
                    if (days > 7)
                    {
                        Console.WriteLine("Invalid number of days!");
                    }
                    else
                    {
                        distance = 0.61;
                    }
                    break;
                    
                case "Venus":
                    if (days > 14)
                    {
                        Console.WriteLine("Invalid number of days!");
                    }
                    else
                    {
                        distance = 0.28;
                    }
                    break;
                    
                case "Mars":
                    if (days > 20)
                    {
                        Console.WriteLine("Invalid number of days!");
                    }
                    else
                    {
                        distance = 0.52;
                    }
                    break;
                case "Jupiter":
                    if (days > 5)
                    {
                        Console.WriteLine("Invalid number of days!");
                    }
                    else
                    {
                        distance = 4.2;
                    }
                    break;
                case "Saturn":
                    if (days > 3)
                    {
                        Console.WriteLine("Invalid number of days!");
                    }
                    else
                    {
                        distance = 8.52;
                    }
                    break;
                case "Uranus":
                    if (days > 3)
                    {
                        Console.WriteLine("Invalid number of days!");
                    }
                    else
                    {
                        distance = 18.21;
                    }
                    break;
                case "Neptune":
                    if (days > 2)
                    {
                        Console.WriteLine("Invalid number of days!");
                    }
                    else
                    {
                        distance = 29.09;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid planet name!");
                    break;
            }
            if (distance>0)
            {
                Console.WriteLine($"Distance: {(distance*2):F2}");
                var totalDays = (distance* 2 * 226)+days;
                Console.WriteLine($"Total number of days: {totalDays:F2}");
            }
        }
    }
}
