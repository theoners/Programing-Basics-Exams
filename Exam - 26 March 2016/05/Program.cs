using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n-2; i++)
            {
                if (i%2!=0)
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("\\ /");
                    Console.WriteLine(new string('-', n - 2));
                }
                else
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("\\ /");
                    Console.WriteLine(new string('*', n - 2));
                }
                
            }

            Console.Write(new string(' ', n-1));
            Console.Write('@');
            Console.WriteLine(new string(' ', n-1));

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("/ \\");
                    Console.WriteLine(new string('-', n - 2));
                }
                else
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("/ \\");
                    Console.WriteLine(new string('*', n - 2));
                }

            }

        }
    }
}
