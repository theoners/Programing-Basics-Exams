using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            Console.WriteLine(new string('#',4*n+1));
            for (int i = 0; i < n*2; i++)
            {
                Console.Write(new string('.',1+i));
                if (i<n)
                {
                    Console.Write(new string('#', n * 2 - 1 - i * 2));
                }
                else
                {
                    Console.Write(new string('#', n * 2 - 1 -count*2));
                    count++;
                }
                if (i < n)
                {
                    if (i!=n/2)
                    {
                        Console.Write(new string(' ', i * 2 + 1));
                    }
                    else
                    {
                        Console.Write(new string(' ', ((i * 2 + 1)-3)/2));
                        Console.Write("(@)");
                        Console.Write(new string(' ', ((i * 2 + 1) - 3) / 2));
                    }
                    Console.Write(new string('#', n * 2 - 1 - i * 2));
                }
                Console.Write(new string('.', 1 + i));
                Console.WriteLine();
            }
        }
    }
}
