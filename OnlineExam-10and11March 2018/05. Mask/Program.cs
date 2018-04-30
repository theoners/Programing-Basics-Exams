using System;

namespace _05._Mask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n-1; i++)
            {
                for (int k = i; k < n-2; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("/");
                for (int k = 0; k < i ; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("|  |");

                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\");
            }
            for (int i = 0; i < n*2+2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            Console.Write("|");
            for (int i = 0; i < (n - 3) / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("_");
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write(" ");
            }
            Console.Write("_");
            for (int i = 0; i < (n - 3) / 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
            Console.Write("|");
            for (int i = 0; i < (n-3)/2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("@");
            for (int i = 0; i < n +1; i++)
            {
                Console.Write(" ");
            }
            Console.Write("@");
            for (int i = 0; i < (n - 3) / 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");

            for (int i = 0; i < n/2; i++)
            {
                Console.Write("|");
                for (int k = 0; k < n*2; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            Console.Write("|");
            for (int i = 0; i < n-1; i++)
            {
                Console.Write(" ");
            }
            Console.Write("OO");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
            Console.Write("|");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("/");
            Console.Write("  ");
            Console.Write("\\");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
            Console.Write("|");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("||||");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");

            for (int i = 0; i < n+1; i++)
            {
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("\\");
                }
                for (int k = 0; k < n*2-2*i; k++)
                {
                    Console.Write("`");
                }
               
                for (int k = i; k >= 0; k--)
                {
                    Console.Write("/");
                }
                Console.WriteLine();
            }
        }
    }
}
