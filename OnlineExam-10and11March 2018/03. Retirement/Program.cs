using System;

namespace _03._Retirement
{
    class Program
    {
        static void Main(string[] args)
        {
            string gander = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int experiance = int.Parse(Console.ReadLine());

            if (gander.Equals("male"))
            {
                if (age>=64 && experiance>=38)
                {
                    Console.WriteLine($"Ready to retire at {age} and {experiance} years of experience!");
                }
                else if (age >= 64 && experiance < 38)
                {
                    Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {38-experiance}.");
                }
                else if (age < 64 && experiance >= 38)
                {
                    Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {64-age}.");
                }
                else
                {
                    Console.WriteLine($"Too early. Years left to retirement: {64-age}. Work experience left to retirement: {38-experiance}.");
                }
            }
            else if (gander.Equals("female"))
            {
                if (age >= 61 && experiance >= 35)
                {
                    Console.WriteLine($"Ready to retire at {age} and {experiance} years of experience!");
                }
                else if (age >= 61 && experiance < 35)
                {
                    Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {35 - experiance}.");
                }
                else if (age < 61 && experiance >= 35)
                {
                    Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {61 - age}.");
                }
                else
                {
                    Console.WriteLine($"Too early. Years left to retirement: {61 - age}. Work experience left to retirement: {35 - experiance}.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
