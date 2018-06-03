using System;

namespace _05._Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write('/');
            Console.Write(new string('^', n/2));
            Console.Write("\\");
            Console.Write(new string('_', n*2-4-(n/2)*2));
            Console.Write('/');
            Console.Write(new string('^', n / 2));
            Console.WriteLine('\\');

            for (int i = 0; i < n-3; i++)
            {
                Console.Write('|');
                Console.Write(new string(' ',2*n-2));
                Console.WriteLine('|');
            }

            Console.Write('|');
            Console.Write(new string(' ', (n / 2)+1));
            Console.Write(new string('_', n * 2 - 4 - (n / 2) * 2));
            Console.Write(new string(' ', (n / 2) + 1));
            Console.WriteLine('|');

            Console.Write('\\');
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            Console.Write(new string(' ', n * 2 - 4 - (n / 2) * 2));
            Console.Write('\\');
            Console.Write(new string('_', n / 2));
            Console.WriteLine('/');
        }
    }
}
