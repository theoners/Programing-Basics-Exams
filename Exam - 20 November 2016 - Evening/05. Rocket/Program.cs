using System;

namespace _05._Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.',((3*n-2)/2)-i));
                Console.Write("/");
                Console.Write(new string(' ', i*2));
                Console.Write("\\");
                Console.WriteLine(new string('.', ((3 * n - 2) / 2)-i));
            }

            Console.Write(new string('.',n/2));
            Console.Write(new string('*',n*2));
            Console.WriteLine(new string('.', n / 2));

            for (int i = 0; i < n*2; i++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write('|');
                Console.Write(new string('\\',n*2-2));
                Console.Write('|');
                Console.WriteLine(new string('.', n / 2));
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('.', (n / 2)-i));
                Console.Write('/');
                Console.Write(new string('*', (n * 2 - 2)+i*2));
                Console.Write('\\');
                Console.WriteLine(new string('.', (n / 2)-i));
            }
        }
    }
}
