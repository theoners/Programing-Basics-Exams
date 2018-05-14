using System;

namespace _01___House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double heightRoof = double.Parse(Console.ReadLine());

            double houseArea = (height * height * 2 + lenght * height * 2) - 1.5 * 1.5 * 2 - 2 * 1.2;
            double roofArea = height * lenght * 2 + ((height * heightRoof)/2)*2;

            double housePaint = houseArea/ 3.4;
            double roofPaint = roofArea/ 4.3;

            Console.WriteLine($"{housePaint:F2}");
            Console.WriteLine($"{roofPaint:F2}");
        }
    }
}
