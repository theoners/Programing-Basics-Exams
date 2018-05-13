using System;

namespace _04___Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            double water = 20 * month;
            double internet = 15 * month;
            double other = 0;
            double electricity = 0;

            for (int i = 0; i < month; i++)
            {
                double electricityPerMonth = double.Parse(Console.ReadLine());
                electricity += electricityPerMonth;
                other += (20 + 15 + electricityPerMonth)*1.2;
            }
            double avarage = (water + internet + electricity + other)/month;

            Console.WriteLine($"Electricity: {electricity:F2} lv");
            Console.WriteLine($"Water: {water:F2} lv"); 
            Console.WriteLine($"Internet: {internet:F2} lv"); 
            Console.WriteLine($"Other: {other:F2} lv"); 
            Console.WriteLine($"Average: {avarage:F2} lv");

            



        }
    }
}
