using System;

namespace _05._Sword
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string ('#',((2*n)-2)/2));
            Console.Write("/^\\");
            Console.Write(new string('#', ((2 * n) - 2) / 2));
            Console.WriteLine();
            var soft = "SOFT".ToCharArray();
            var uni = "UNI".ToCharArray();

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('#', n-2-i));
                Console.Write('.');
                Console.Write(new string(' ',3+i*2));
                Console.Write('.');
                Console.Write(new string('#', n - 2 - i));
                Console.WriteLine();
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write(new string('#', (n - 1) / 2));
                Console.Write('|');
                Console.Write(new string(' ', (n) / 2));
                Console.Write(soft[i]);
                Console.Write(new string(' ', (n) / 2));
                Console.Write('|');
                Console.Write(new string('#', (n - 1) / 2));
                Console.WriteLine();
            }

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.Write(new string('#', (n - 1) / 2));
                Console.Write('|');
                Console.Write(new string(' ', (n ) / 2));
                Console.Write(' ');
                Console.Write(new string(' ', (n) / 2));
                Console.Write('|');
                Console.Write(new string('#', (n - 1) / 2));
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(new string('#', (n - 1) / 2));
                Console.Write('|');
                Console.Write(new string(' ', (n ) / 2));
                Console.Write(uni[i]);
                Console.Write(new string(' ', (n) / 2));
                Console.Write('|');
                Console.Write(new string('#', (n - 1) / 2));
                Console.WriteLine();
            }

            Console.Write('@');
            Console.Write(new string('=',2*n-1));
            Console.WriteLine('@');

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('#',(n - 1) / 2 + 2));
                Console.Write('|');
                Console.Write(new string(' ', 2 * n + 1 - (((n + 3) / 2) * 2 + 2)));
                Console.Write('|');
                Console.Write(new string('#',(n - 1) / 2 + 2));
                Console.WriteLine();
            }

            Console.Write(new string('#', (n - 1) / 2 + 2));
            Console.Write('\\');
            Console.Write(new string('.', 2 * n + 1 - (((n + 3) / 2) * 2 + 2)));
            Console.Write('/');
            Console.Write(new string('#', (n - 1) / 2 + 2));
            Console.WriteLine();
        }
    }
}
