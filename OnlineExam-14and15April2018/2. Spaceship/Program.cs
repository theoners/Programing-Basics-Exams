using System;

namespace _2._Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double hightMans = double.Parse(Console.ReadLine());

            double volumeSpacecraft = width * lenght * hight;
            double volumeRoom = (hightMans + 0.40) * 2 * 2;

            var astronaunts = (volumeSpacecraft / volumeRoom);

            if (astronaunts>10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else if (astronaunts<3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {Math.Floor(astronaunts)} astronauts.");
            }


        }
    }
}
