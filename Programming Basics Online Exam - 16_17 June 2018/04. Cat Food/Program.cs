using System;

namespace _04._Cat_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int catNumber = int.Parse(Console.ReadLine());
            int FirstGroup = 0;
            int SecondGroup = 0;
            int thirdGroup = 0;
            double totalFood = 0;

            for (int i = 0; i < catNumber; i++)
            {
                double cat = double.Parse(Console.ReadLine());
                totalFood += cat;

                if (cat<200 && cat>=100)
                {
                    FirstGroup++;
                }
                else if (cat<300)
                {
                    SecondGroup++;
                }
                else if(cat<=400)
                {
                    thirdGroup++;
                }
            }

            double foodPrice = totalFood/1000 * 12.45;

            Console.WriteLine($"Group 1: {FirstGroup} cats.");
            Console.WriteLine($"Group 2: {SecondGroup} cats.");
            Console.WriteLine($"Group 3: {thirdGroup} cats.");
            Console.WriteLine($"Price for food per day: {Math.Round(foodPrice,2)} lv.");
            
        }
    }
}
