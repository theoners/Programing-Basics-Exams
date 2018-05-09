using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int person = int.Parse(Console.ReadLine());
            double cakesPrice = double.Parse(Console.ReadLine())*45;
            double gofretsPrice = double.Parse(Console.ReadLine())*5.8;
            double pancakesPrice = double.Parse(Console.ReadLine())*3.2;

            double totalprice = (cakesPrice+gofretsPrice+pancakesPrice)*person*days*0.875;

            Console.WriteLine($"{totalprice:F2}");
        }
    }
}
