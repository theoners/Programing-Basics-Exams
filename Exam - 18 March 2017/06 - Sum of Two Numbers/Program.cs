using System;

namespace _06___Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int k = start; k <= end; k++)
                {
                    counter++;
                    if (i+k==magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {k} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
