using System;

namespace _05._Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < (number+5-1)/2; i++)
            {
                Console.Write('_');
            }
            Console.Write('^');
            for (int i = 0; i < (number + 5 - 1) / 2; i++)
            {
                Console.Write('_');
            }
            Console.WriteLine();
            for (int i = 0; i < (number + 5 - 3) / 2; i++)
            {
                Console.Write('_');
            }
            Console.Write("/|\\");
            for (int i = 0; i < (number + 5 - 3) / 2; i++)
            {
                Console.Write('_');
            }
            Console.WriteLine();

            for (int i = 0; i < number/2; i++)
            {
                for (int k = 0; k < (number/2)-i; k++)
                {
                    Console.Write("_");
                }
                Console.Write('/');
                for (int k = 0; k < i; k++)
                {
                    Console.Write('.');
                }
                Console.Write("|||");
                for (int k = 0; k < i; k++)
                {
                    Console.Write('.');
                }
                Console.Write('\\');
                for (int k = 0; k < (number / 2) - i; k++)
                {
                    Console.Write("_");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < (number + 5 - 9) / 2; i++)
            {
                Console.Write('_');
            }
            Console.Write("/..|||..\\");
            for (int i = 0; i < (number + 5 - 9) / 2; i++)
            {
                Console.Write('_');
            }
            Console.WriteLine();

            for (int i = 0; i < (number + 5 - 7)/2; i++)
            {
                Console.Write('_');
            }
            Console.Write("/.|||.\\");
            for (int i = 0; i < (number + 5 - 7) / 2; i++)
            {
                Console.Write('_');
            }
            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                for (int k = 0; k < (number+2)/2; k++)
                {
                    Console.Write('_');
                }
                Console.Write("|||");
                for (int k = 0; k < (number + 2)/2; k++)
                {
                    Console.Write('_');
                }
                Console.WriteLine();
            }
            for (int k = 0; k < (number + 2) / 2; k++)
            {
                Console.Write('_');
            }
            Console.Write("~~~");
            for (int k = 0; k < (number + 2) / 2; k++)
            {
                Console.Write('_');
            }
            Console.WriteLine();

            for (int i = 0; i < number/2; i++)
            {
                for (int k = 0; k < number/2-i; k++)
                {
                    Console.Write('_');
                }
                Console.Write("//");

                for (int k = 0; k <i; k++)
                {
                    Console.Write('.');
                }
                Console.Write("!");
                for (int k = 0; k < i; k++)
                {
                    Console.Write('.');
                }
                Console.Write("\\\\");
                for (int k = 0; k < number / 2 - i; k++)
                {
                    Console.Write('_');
                }
                Console.WriteLine();
            }

        }
    }
}
