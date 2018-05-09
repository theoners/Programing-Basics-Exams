using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsForOneMeter = double.Parse(Console.ReadLine());

            double IvanchoTime = secondsForOneMeter * distance;
            double waterResistance = (int)(distance / 15) * 12.5;
            IvanchoTime += waterResistance;

            if (IvanchoTime<worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {IvanchoTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(IvanchoTime-worldRecord):F2} seconds slower.");
            }
        }
    }
}
