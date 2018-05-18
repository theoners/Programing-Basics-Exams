using System;

namespace _01___Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double houseArea = (a * (a / 2) * 2)+((a/2*a/2)+ (a / 2 * (b - a / 2)) / 2)*2 - ((a / 5) * (a / 5));
            double roofArea = a * (a / 2) * 2;

            double greenPaint = houseArea / 3;
            double redPaint = roofArea / 5;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
