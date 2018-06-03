using System;

namespace _01._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            int deskInRow = (int)((h * 100 - 100) / 70);
            int deskInCol = (int)((w * 100) / 120);

            int totalDesks = deskInCol * deskInRow - 3;

            Console.WriteLine(totalDesks);

        }
    }
}
