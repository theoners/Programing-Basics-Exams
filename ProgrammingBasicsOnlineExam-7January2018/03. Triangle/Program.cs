using System;

namespace _03._Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a<b+c&&b<a+c&&c<a+b)
            {
                if (a==b && b==c)
                {
                    
                    Console.WriteLine($"Triangle with sides {a}, {b} and {c} is equilateral.");
                }
                else if (a==b ||a==c||c==b)
                {
                    Console.WriteLine($"Triangle with sides {a}, {b} and {c} is isosceles.");
                }
                else
                {
                    Console.WriteLine($"Triangle with sides {a}, {b} and {c} is scalene.");
                }

            }
            else
            {
                Console.WriteLine($"There is no triangle with sides {a}, {b} and {c}.");
            }
        }
    }
}
