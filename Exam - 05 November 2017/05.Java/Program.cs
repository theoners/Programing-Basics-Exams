using System;

namespace _05.Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n));
                for (int k = 0; k < 3; k++)
                {
                    Console.Write("~");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('=',3*n+5));

            for (int i = 0; i < (n-3)/2; i++)
            {
                Console.Write('|');
                Console.Write(new string('~',n*2+4));
                Console.Write('|');
                Console.Write(new string(' ',n-1));
                Console.WriteLine('|');
            }

            if (n%2==0)
            {
                Console.Write('|');
                Console.Write(new string('~', n * 2 + 4));
                Console.Write('|');
                Console.Write(new string(' ', n - 1));
                Console.WriteLine('|');
            }

            Console.Write('|');
            Console.Write(new string('~',n));
            Console.Write("JAVA");
            Console.Write(new string('~', n));
            Console.Write('|');
            Console.Write(new string(' ', n - 1));
            Console.WriteLine('|');

            for (int i = 0; i < (n - 3) / 2; i++)
            {
                Console.Write('|');
                Console.Write(new string('~', n * 2 + 4));
                Console.Write('|');
                Console.Write(new string(' ', n - 1));
                Console.WriteLine('|');
            }

            Console.WriteLine(new string('=', 3 * n + 5));

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ',i));
                Console.Write('\\');
                Console.Write(new string('@',n*2+4-i*2));
                Console.WriteLine('/');

            }
            Console.WriteLine(new string('=',n*2+6));
        }
    }
}
