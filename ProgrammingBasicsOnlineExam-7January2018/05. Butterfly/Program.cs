using System;

namespace _05._Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n-2; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write('*');
                    Console.Write('\\');
                }
                Console.Write(new string(' ',n*4-i*4-4));
                for (int k = 0; k < i; k++)
                {
                    Console.Write('/');
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            for (int i = 0; i < (4*n-4)/2; i++)
            {
                Console.Write("\\");
                Console.Write('/');
            }
            Console.WriteLine();
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('<',(4*n-10)/2));
                Console.Write("*|**|*");
                Console.Write(new string('>', (4 * n - 10) / 2));
                Console.WriteLine();
            }
            for (int i = 0; i < (4 * n - 4) / 2; i++)
            {
                Console.Write("/");
                Console.Write('\\');
            }
            Console.WriteLine();


            for (int i = 1; i <= n - 2; i++)
            {
                for (int k = 0; k < n-2-i+1; k++)
                {
                    Console.Write('*');
                    Console.Write('/');
                }
                Console.Write(new string(' ', i*4));
                for (int k = 0; k < n - 2 - i+1; k++)
                {
                    Console.Write('\\');
                    Console.Write('*');
                }
                Console.WriteLine();
            }


        }
    }
}
