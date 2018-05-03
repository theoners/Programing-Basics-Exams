using System;

namespace _05._Christmas_Sock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("|");
            Console.Write(new string('-',n*2));
            Console.WriteLine('|');
            Console.Write("|");
            Console.Write(new string('*', n * 2));
            Console.WriteLine('|');
            Console.Write("|");
            Console.Write(new string('-', n * 2));
            Console.WriteLine('|');

            for (int i = 0; i < n-1; i++)
            {
                Console.Write("|");
                Console.Write(new string('-', (n * 2-2)/2-i));
                Console.Write(new string('~',i*2+2));
                Console.Write(new string('-', (n * 2 - 2) / 2 - i));
                Console.Write("|");
                Console.WriteLine();
            }
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("|");
                Console.Write(new string('-', 2+i));
                Console.Write(new string('~', n * 2-4 - 2*i));
                Console.Write(new string('-', 2 + i));
                Console.Write("|");
                Console.WriteLine();
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('-',i));
                Console.Write('\\');
                Console.Write(new string('.', n*2+1));
                Console.Write('\\');
                Console.WriteLine();

            }
            Console.Write(new string('-',n/2));
            Console.Write('\\');
            Console.Write(new string('.',(n*2-4)/2));
            Console.Write("MERRY");
            Console.Write(new string('.', (n * 2 - 4) / 2));
            Console.WriteLine('\\');

            Console.Write(new string('-', n/2+1));
            Console.Write('\\');
            Console.Write(new string('.', n * 2 + 1));
            Console.Write('\\');
            Console.WriteLine();

            Console.Write(new string('-', n / 2+2));
            Console.Write('\\');
            Console.Write(new string('.', (n * 2 - 4) / 2));
            Console.Write("X-MAS");
            Console.Write(new string('.', (n * 2 - 4) / 2));
            Console.WriteLine('\\');

            for (int i = 0; i < (n-1)/2; i++)
            {
                Console.Write(new string('-', n / 2 + 3+i));
                Console.Write('\\');
                Console.Write(new string('.', n * 2 + 1));
                Console.Write('\\');
                Console.WriteLine();
            }
            Console.Write(new string('-',n+2));
            Console.Write('\\');
            Console.Write(new string('_', n * 2 + 1));
            Console.WriteLine(')');
        }
    }
}
