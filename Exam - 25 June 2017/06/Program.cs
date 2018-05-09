using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool yes = false;

            for (int a = 1; a < 31; a++)
            {
                for (int b = 1; b < 31; b++)
                {
                    for (int c = 1; c < 31; c++)
                    {
                        if (a+b+c==number && a<b && b<c )
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {number}");
                            yes = true;
                        }
                        if (a * b * c == number && a > b && b > c)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {number}");
                            yes = true;
                        }
                    }
                }
            }
            if (!yes)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
