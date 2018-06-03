﻿using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number<200)
                {
                    p1++;
                }
                else if (number<400)
                {
                    p2++;
                }
                else if (number<600)
                {
                    p3++;
                }
                else if (number<800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            Console.WriteLine($"{(p1/n*100):F2}");
            Console.WriteLine($"{(p2/n*100):F2}");
            Console.WriteLine($"{(p3/n*100):F2}");
            Console.WriteLine($"{(p4/n*100):F2}");
            Console.WriteLine($"{(p5/n*100):F2}");
        }
    }
}
