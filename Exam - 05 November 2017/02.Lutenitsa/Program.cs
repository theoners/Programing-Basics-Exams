using System;

namespace _02.Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomato = double.Parse(Console.ReadLine());
            double boxes = double.Parse(Console.ReadLine());
            double jarCountInBox = double.Parse(Console.ReadLine());

            double lutenica =  tomato / 5;
            double jars = lutenica / 0.535;
            double boxesNeed = jars / jarCountInBox;

            Console.WriteLine($"Total lutenica: {Math.Floor( lutenica)} kilograms.");
            if (boxesNeed>=boxes)
            {
                Console.WriteLine($"{Math.Floor(boxesNeed-boxes)} boxes left.");
                Console.WriteLine($"{Math.Floor(jars-(boxes*jarCountInBox))} jars left.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(boxes-boxesNeed)} more boxes needed.");
                Console.WriteLine($"{Math.Floor(boxes * jarCountInBox - jars)} more jars needed.");
            }

            
        }
    }
}
