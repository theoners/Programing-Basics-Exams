using System;

namespace _02._Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int flightTime = int.Parse(Console.ReadLine());

            minutes += flightTime;
            hours = hours + minutes / 60;
            minutes = minutes % 60;

            Console.WriteLine($"{hours%24}h {minutes}m");
        }
    }
}
