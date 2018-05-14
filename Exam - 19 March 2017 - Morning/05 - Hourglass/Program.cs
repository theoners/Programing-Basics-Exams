using System;

namespace _05___Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*',2*n+1));

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.',i+1));
                Console.Write('*');
                if (i==0)
                {
                    Console.Write(new string(' ',2*n-3));
                    Console.Write('*');
                }
                else if(i!=n-1)
                {
                    Console.Write(new string('@', 2 * n - 3-i*2));
                    Console.Write('*');
                }
                
                Console.WriteLine(new string('.', i + 1));
            }

            for (int i = 0; i < n-1; i++)
            {
                if (i!=n-2)
                {
                    Console.Write(new string('.', n - 1 - i));
                    Console.Write('*');
                    Console.Write(new string(' ', i));
                    Console.Write('@');
                    Console.Write(new string(' ', i));
                    Console.Write('*');
                    Console.WriteLine(new string('.', n - 1 - i));
                }
                else
                {
                    Console.Write(new string('.', n - 1 - i));
                    Console.Write('*');
                    Console.Write(new string('@', i));
                    Console.Write('@');
                    Console.Write(new string('@', i));
                    Console.Write('*');
                    Console.WriteLine(new string('.', n - 1 - i));
                }
            }
            Console.WriteLine(new string('*', 2 * n + 1));
        }
    }
}
