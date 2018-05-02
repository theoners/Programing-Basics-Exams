using System;

namespace _05._Ladybird
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string(' ',n-2));
            Console.WriteLine("@   @");
            Console.Write(new string(' ', n - 1));
            Console.WriteLine("\\_/");
            Console.Write(new string(' ', n - 1));
            Console.WriteLine("/ \\");
            Console.Write(new string(' ', n - 1));
            Console.WriteLine("|_|");

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - 1-i));
                Console.Write('/');
                Console.Write(new string(' ',i));
                Console.Write('|');
                Console.Write(new string(' ', i));
                Console.Write('\\');
                Console.WriteLine();
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.Write('|');
                Console.Write(new string(' ', n/2-1));
                Console.Write('@');
                Console.Write(new string(' ', n / 2-1));
                if (n%2==1)
                {
                    Console.Write(' ');
                }
                Console.Write('|');
                if (n % 2 == 1)
                {
                    Console.Write(' ');
                }
                Console.Write(new string(' ', n / 2 - 1));
                Console.Write('@');
                Console.Write(new string(' ', n / 2 - 1));
                Console.Write('|');
                Console.WriteLine();
            }
            for (int i = 0; i < n/2; i++)
            {
                if (n!=2)
                {
                    Console.Write(new string(' ', i));
                    Console.Write('\\');
                    Console.Write(new string(' ', n - 1 - i));
                    Console.Write('|');
                    Console.Write(new string(' ', n - 1 - i));
                    Console.Write('/');
                    Console.WriteLine();
                }
                
            }
            Console.Write(new string(' ', n/2+1));
            Console.Write(new string('^',n/2));
            Console.Write('|');
            Console.Write(new string('^', n / 2));
            Console.WriteLine();


        }
    }
}
