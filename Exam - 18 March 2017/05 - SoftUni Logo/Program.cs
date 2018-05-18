using System;

namespace _05___SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n*2; i++)
            {
                Console.Write(new string('.',((12*n-6)/2)-i*3));
                Console.Write(new string('#',1+i*6));
                Console.WriteLine(new string('.', ((12 * n - 6) / 2) - i * 3));
            }

            for (int i = 0; i < n-2; i++)
            {
                Console.Write('|');
                Console.Write(new string('.',2+i*3));
                Console.Write(new string('#', 12*n-11-i*6));
                Console.WriteLine(new string('.', 3 + i * 3));
            }

            for (int i = 0; i < n; i++)
            {
                if (i<n-1)
                {
                    Console.Write('|');
                }
                else
                {
                    Console.Write('@');
                }
                Console.Write(new string('.', (6*n-7)/2));
                Console.Write(new string('#', (6*n+1)));
                Console.WriteLine(new string('.', (6 * n - 5) / 2));
            }
        }
    }
}
