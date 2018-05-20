using System;

namespace _05._Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*',i+1));
                Console.Write('\\');
                Console.Write(new string('-', (2*n-1)-i*2));
                Console.Write('/');
                Console.WriteLine(new string('*', i + 1));
            }

            for (int i = 0; i < n/3; i++)
            {
                Console.Write('|');
                Console.Write(new string('*',n/2+i));
                Console.Write('\\');
                Console.Write(new string('*', n -2* i));
                Console.Write('/');
                Console.Write(new string('*', n / 2 + i));
                Console.WriteLine('|');
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', i + 1));
                Console.Write('\\');
                Console.Write(new string('*', (2 * n - 1) - i * 2));
                Console.Write('/');
                Console.WriteLine(new string('-', i + 1));
            }
        }
    }
}
