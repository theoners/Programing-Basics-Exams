using System;

namespace _02._Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int absentDays = int.Parse(Console.ReadLine());
            double foodLeft = double.Parse(Console.ReadLine());
            double firstDeer = double.Parse(Console.ReadLine());
            double secondtDeer = double.Parse(Console.ReadLine());
            double thirdDeer = double.Parse(Console.ReadLine());

            double totalDeerEat = (firstDeer + secondtDeer + thirdDeer)*absentDays;

            if (foodLeft>=totalDeerEat)
            {
                Console.WriteLine($"{Math.Floor(foodLeft-totalDeerEat)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalDeerEat-foodLeft)} more kilos of food are needed.");
            }

        }
    }
}
