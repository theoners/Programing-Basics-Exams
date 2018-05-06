using System;

namespace _05._Christmas_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('-', n*2));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('-', n*2));

            for (int i = 0; i < n/2; i++)
            {
                    Console.Write(new string('-', n * 2 - 2 - 2 * i));
                    Console.Write(new string('*', i + 1));
                    Console.Write(new string('&', n + 2 + 2 * i));
                    Console.Write(new string('*', i + 1));
                    Console.WriteLine(new string('-', n * 2 - 2 - 2 * i));
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('-', n-1-i));
                Console.Write(new string('*', 2));
                Console.Write(new string('~', 3*n-2+2*i));
                Console.Write(new string('*',2));
                Console.WriteLine(new string('-', n - 1 - i));
            }

            Console.Write(new string('-',n/2));
            Console.Write('*');
            Console.Write(new string('|',4*n-2));
            Console.Write('*');
            Console.WriteLine(new string('-', n / 2));

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', n/2 + i));
                Console.Write(new string('*', 2));
                Console.Write(new string('~', 4 * n - 4-i*2));
                Console.Write(new string('*', 2));
                Console.WriteLine(new string('-', n / 2 + i));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', n+i*2));
                Console.Write(new string('*', n/2-i));
                Console.Write(new string('&', 2*n-i*2));
                Console.Write(new string('*', n / 2 - i));
                Console.WriteLine(new string('-', n + i * 2));
            }
            Console.Write(new string('-', n * 2));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
