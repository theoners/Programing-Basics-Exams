using System;

namespace _05._Sublime_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ',2*n-2-i*2));
                Console.Write(new string('*',2+i*2));
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write(new string('*', 2 * n - 2 - i * 2));
                Console.Write(new string(' ', 2 + i * 2));
                Console.WriteLine();
            }
            Console.Write(new string('*', 2 * n - 2 ));
            Console.Write(new string(' ', 2 ));
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(new string(' ', 2 * i));
                Console.Write(new string('*', 2 * n-i*2));
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write(new string(' ', 2 - i*2));
                Console.Write(new string('*', 2 * n-2 + i * 2));
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*', 2 * n - 2 - i * 2 ));
                Console.Write(new string(' ', 2 + i * 2));
                Console.WriteLine();
            }
        }
    }
}
