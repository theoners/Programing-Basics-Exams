using System;

namespace _01._Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double hallArea = lenght * width * 10000;
            double wardrobeArea = wardrobeSide * wardrobeSide*10000;
            double bench = hallArea / 10;
            double freeSpace = hallArea - wardrobeArea - bench;

            double dancer = freeSpace / 7040;

            Console.WriteLine(Math.Floor(dancer));
        }
    }
}
