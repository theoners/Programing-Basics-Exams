using System;

namespace _05._Eiffel_Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-',n+2));
                Console.Write("**");
                Console.Write(new string('-', n + 2));
                Console.WriteLine();
            }
            for (int i = 0; i < n-3; i++)
            {
                Console.Write(new string('-', n +1));
                Console.Write("****");
                Console.Write(new string('-', n+1));
                Console.WriteLine();
            }
            Console.Write(new string('-',n));
            Console.Write(new string('*', 6));
            Console.Write(new string('-', n));
            Console.WriteLine();

            for (int i = 0; i < n-4; i++)
            {
                Console.Write(new string('-', n ));
                Console.Write(new string('*', 2));
                Console.Write(new string('-', 2));
                Console.Write(new string('*', 2));
                Console.Write(new string('-', n ));
                Console.WriteLine();
            }

            for (int i = 0; i < n - 3; i++)
            {
                Console.Write(new string('-', n-1));
                Console.Write(new string('*', 2));
                Console.Write(new string('-', 4));
                Console.Write(new string('*', 2));
                Console.Write(new string('-', n-1));
                Console.WriteLine();
            }
            Console.Write(new string('-', n - 2));
            Console.Write(new string('*', 10));
            Console.Write(new string('-', n-2));
            Console.WriteLine();

            for (int i = 0; i < n-2; i++)
            {
                Console.Write(new string('-', n - 3-i));
                if (i==n-3)
                {
                    Console.Write('*');
                }
                Console.Write(new string('*', 2));
                if (i != n - 3)
                {
                    Console.Write(new string('-', 8 + i * 2));
                }
                else
                {
                    Console.Write(new string('-', n*2));
                }
                
                Console.Write(new string('*', 2));
                Console.Write(new string('-', n - 3 - i));
                if (i == n - 3)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

        }
    }
}
