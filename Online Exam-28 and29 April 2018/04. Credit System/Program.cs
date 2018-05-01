using System;

namespace _04._Credit_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int coursCount = int.Parse(Console.ReadLine());
            double grade = 0;
            double credits = 0;

            for (int i = 0; i < coursCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                grade+= number % 10;
                if (number % 10==3)
                {
                    credits += (number / 10) * 0.5;
                }
                else if (number % 10 == 4)
                {
                    credits += (number / 10) * 0.7;
                }
                else if (number % 10 == 5)
                {
                    credits += (number / 10) * 0.85;
                }
                else if (number % 10 == 6)
                {
                    credits += (number / 10) * 1;
                }
            }
            Console.WriteLine($"{credits:F2}");
            Console.WriteLine($"{(grade/coursCount):F2}");
        }
    }
}
