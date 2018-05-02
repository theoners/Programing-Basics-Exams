using System;

namespace _01._Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double priceSand = double.Parse(Console.ReadLine());
            double priceWood = double.Parse(Console.ReadLine());

            double area = height * width;
            double areaSand = (height - 0.4) * (width - 0.4);
            double areaWood = area - areaSand;
            double sandNeed = areaSand*20;
            sandNeed = Math.Ceiling(sandNeed);
            double woodNeed = areaWood / (2.2 * 0.2);
            woodNeed = Math.Ceiling(woodNeed);

            var result = woodNeed * priceWood + sandNeed * priceSand;
            Console.WriteLine($"{result:F2}");
        }
    }
}
