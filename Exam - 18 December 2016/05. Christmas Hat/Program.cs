using System;

namespace _05._Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('.',(4*n-2)/2));
            Console.Write("/|\\");
            Console.WriteLine(new string('.',(4*n-2)/2));
            Console.Write(new string('.', (4 * n - 2) / 2));
            Console.Write("\\|/");
            Console.WriteLine(new string('.', (4 * n - 2) / 2));
            Console.Write(new string('.', (4 * n - 2) / 2));
            Console.Write("***");
            Console.WriteLine(new string('.', (4 * n - 2) / 2));

            for (int i = 0; i < n*2-1; i++)
            {
                Console.Write(new string('.', ((4 * n - 4) / 2)-i));
                Console.Write('*');
                Console.Write(new string('-',1+i));
                Console.Write('*');
                Console.Write(new string('-', 1 + i));
                Console.Write('*');
                Console.WriteLine(new string('.', ((4 * n - 4) / 2) - i));
            }

            Console.WriteLine(new string('*',4*n+1));
            for (int i = 0; i < (4 * n + 1)/2; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine('*');
            Console.WriteLine(new string('*', 4 * n + 1));

        }
    }
}
