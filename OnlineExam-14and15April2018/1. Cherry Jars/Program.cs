using System;

namespace _1._Cherry_Jars
{
    class Program
    {
        static void Main(string[] args)
        {
            int compoteJars = int.Parse(Console.ReadLine())+1;
            int jamJars = int.Parse(Console.ReadLine())+1;
            double priceCherry = 3.20;

            double cherryForCompote = compoteJars * 0.300 * 1.05;
            double cherryForJam = jamJars * 0.650 * 1.10;
            double totalCherries = cherryForCompote + cherryForJam;
            var totalPrice = totalCherries * priceCherry;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
