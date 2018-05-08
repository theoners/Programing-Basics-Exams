using System;

namespace _05.Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('.',(3*n-1)/2));
            Console.Write('x');
            Console.WriteLine(new string('.', (3 * n - 1) / 2));

            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("/x\\");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));

            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("x|x");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));

            for (int i = 0; i <= n/2; i++)
            {
                Console.Write(new string('.', (( n- 1) / 2)-i));
                Console.Write(new string('x', n +i));
                Console.Write('|');
                Console.Write(new string('x', n+i));
                Console.WriteLine(new string('.', ((n - 1) / 2) - i));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', 1 + i));
                Console.Write(new string('x', ((n*3-3)/2)-i));
                Console.Write('|');
                Console.Write(new string('x', ((n * 3 - 3) / 2) - i));
                Console.WriteLine(new string('.', 1 + i));
            }

                Console.Write(new string('.', (3 * n - 3) / 2));
                Console.Write("/x\\");
                Console.WriteLine(new string('.', (3 * n - 3) / 2));
                Console.Write(new string('.', (3 * n - 3) / 2));
                Console.Write("\\x/");
                Console.WriteLine(new string('.', (3 * n - 3) / 2));

            for (int i = 0; i <= n / 2; i++)
            {
                Console.Write(new string('.', ((n - 1) / 2) - i));
                Console.Write(new string('x', n + i));
                Console.Write('|');
                Console.Write(new string('x', n + i));
                Console.WriteLine(new string('.', ((n - 1) / 2) - i));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', 1 + i));
                Console.Write(new string('x', ((n * 3 - 3) / 2) - i));
                Console.Write('|');
                Console.Write(new string('x', ((n * 3 - 3) / 2) - i));
                Console.WriteLine(new string('.', 1 + i));
            }

            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("x|x");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));

            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("\\x/");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));

            Console.Write(new string('.', (3 * n - 1) / 2));
            Console.Write('x');
            Console.WriteLine(new string('.', (3 * n - 1) / 2));

            
        }
    }
}
