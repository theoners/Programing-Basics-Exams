using System;

namespace _05._Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n-1; i++)
            {
                Console.Write(new string('.',i));
                Console.Write('*');
                Console.Write(new string('.',n-i));
                Console.Write('*');
                Console.Write(new string('.', n - i));
                Console.Write('*');
                Console.WriteLine(new string('.', i));
            }

            Console.Write(new string('.', n-1));
            Console.Write("*****");
            Console.WriteLine(new string('.', n - 1));

            Console.WriteLine(new string('*',2*n+3));

            Console.Write(new string('.', n - 1));
            Console.Write("*****");
            Console.WriteLine(new string('.', n - 1));

            for (int i = 0; i < n-1; i++)
            {
                Console.Write(new string('.',n-2-i));
                Console.Write('*');
                Console.Write(new string('.',2+i));
                Console.Write('*');
                Console.Write(new string('.',2 + i));
                Console.Write('*');
                Console.WriteLine(new string('.', n - 2 - i));
            }
        }
    }
}
