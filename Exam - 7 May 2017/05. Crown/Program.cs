using System;

namespace _05._Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write('@');
            Console.Write(new string(' ',(2*n-4)/2));
            Console.Write('@');
            Console.Write(new string(' ', (2 * n - 4) / 2));
            Console.WriteLine('@');

            Console.Write("**");
            Console.Write(new string(' ', (2 * n - 5) / 2));
            Console.Write('*');
            Console.Write(new string(' ', (2 * n - 5) / 2));
            Console.WriteLine("**");

            for (int i = 0; i < n/2-2; i++)
            {
                Console.Write("*");
                Console.Write(new string('.',i+1));
                Console.Write("*");
                Console.Write(new string(' ',n-5-i*2));
                Console.Write("*");
                Console.Write(new string('.', i*2 + 1));
                Console.Write("*");
                Console.Write(new string(' ', n - 5-i*2));
                Console.Write("*");
                Console.Write(new string('.', i + 1));
                Console.WriteLine("*");
            }

            Console.Write("*");
            Console.Write(new string('.', n/2-1));
            Console.Write("*");
            Console.Write(new string('.', n-3));
            Console.Write("*");
            Console.Write(new string('.', n / 2 - 1));
            Console.WriteLine("*");


            Console.Write("*");
            Console.Write(new string('.', n / 2 ));
            Console.Write(new string('*',n/2-2));
            Console.Write('.');
            Console.Write(new string('*', n / 2 - 2));
            Console.Write(new string('.', n / 2));
            Console.WriteLine("*");

            Console.WriteLine(new string('*',2*n-1));
            Console.WriteLine(new string('*',2*n-1));
        }
    }
}
