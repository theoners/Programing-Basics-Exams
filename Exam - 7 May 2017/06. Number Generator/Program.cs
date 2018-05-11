using System;

namespace _06._Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            for (int first = m; first > 0; first--)
            {
                for (int second = n; second > 0; second--)
                {
                    for (int third = l; third > 0; third--)
                    {
                        int currentNumber = first * 100 + second * 10 + third;

                        if (currentNumber%3==0)
                        {
                            specialNumber += 5;
                        }
                        else if (currentNumber%10==5)
                        {
                            specialNumber -= 2;
                        }
                        else if (currentNumber%2==0)
                        {
                            specialNumber *= 2;
                        }

                        if (specialNumber>=controlNumber)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine($"No! {specialNumber} is the last reached special number.");
        }
    }
}
