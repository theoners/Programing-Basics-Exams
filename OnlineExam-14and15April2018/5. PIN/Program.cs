using System;

namespace _5._PIN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("/`");
            Console.Write(new string('P',n*2));
            Console.Write(new string(' ',n));
            Console.Write("/`I");
            Console.Write(new string(' ', n));
            Console.Write("/`N");
            Console.Write(new string(' ', n*2+1));
            Console.WriteLine("N");

            for (int i = 0; i <= n-1; i++)
            {
                Console.Write("| ");
                Console.Write('P');
                if (i==n-1)
                {
                    Console.Write(new string('P', n * 2 - 2));
                }
                else
                {
                    Console.Write(new string(' ', n * 2 - 2));
                }
                
                Console.Write('P');
                Console.Write(new string(' ', n));
                Console.Write("| I");
                Console.Write(new string(' ', n));
                Console.Write("| N");
                Console.Write(new string(' ',i));
                Console.Write("N");
                Console.Write(new string(' ', n * 2 -i));
                Console.WriteLine("N");
            }

            for (int i = 0; i < n+1; i++)
            {
                if (i==n)
                {
                    Console.Write("\\_");
                    Console.Write(new string('P', n / 2));
                    Console.Write(new string(' ', n * 2 - n / 2));
                    Console.Write(new string(' ', n));
                    Console.Write("\\_I");
                    Console.Write(new string(' ', n));
                    Console.Write("\\_N");
                    Console.Write(new string(' ', n + i));
                    Console.Write("N");
                    Console.Write(new string(' ', n * 2 - i - n));
                    Console.WriteLine("N");
                }
                else
                {
                    Console.Write("| ");
                    Console.Write(new string('P', n / 2));
                    Console.Write(new string(' ', n * 2 - n / 2));
                    Console.Write(new string(' ', n));
                    Console.Write("| I");
                    Console.Write(new string(' ', n));
                    Console.Write("| N");
                    Console.Write(new string(' ', n + i));
                    Console.Write("N");
                    Console.Write(new string(' ', n * 2 - i - n));
                    Console.WriteLine("N");
                }
                
                
            }
            

        }
    }
}
