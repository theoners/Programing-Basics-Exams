using System;

namespace _05._Cat_Food_Meow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string ('.',n-1)+'|');

            for (int i = 0; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('|'+ new string('.', n - 1));

            Console.Write(new string('.', n - 1) + '|');

            for (int i = 0; i < n; i++)
            {
                Console.Write("~~");
            }

            Console.WriteLine('|' + new string('.', n - 1));

            

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n - 1) + '|');
                Console.Write(new string(' ', i ));
                for (int k = i; k < n; k++)
                {

                    Console.Write("{}");
                }
                Console.Write(new string(' ', i));
                Console.WriteLine('|' + new string('.', n - 1));
            }

            Console.Write(new string('.', n - 1) + '|');
            Console.Write(new string(' ', (n*2-4)/2));
            Console.Write("MEOW");
            Console.Write(new string(' ', (n * 2 - 4) / 2));
            Console.WriteLine('|' + new string('.', n - 1));

            Console.Write(new string('.', n - 1) + '|');
            Console.Write(new string(' ', (n * 2 - 4) / 2));
            Console.Write("FOOD");
            Console.Write(new string(' ', (n * 2 - 4) / 2));
            Console.WriteLine('|' + new string('.', n - 1));

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n - 1) + '|');
                Console.Write(new string(' ', ((2*n-2)/2)-i));
                for (int k = 0; k < i+1; k++)
                {

                    Console.Write("{}");
                }
                Console.Write(new string(' ', ((2*n-2)/2)-i));
                Console.WriteLine('|' + new string('.', n - 1));
            }

            Console.Write(new string('.', n - 1) + '|');

            for (int i = 0; i < n; i++)
            {
                Console.Write("~~");
            }

            Console.WriteLine('|' + new string('.', n - 1));

            Console.Write(new string('.', n - 1) + '|');

            for (int i = 0; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('|' + new string('.', n - 1));
        }
    }
}
