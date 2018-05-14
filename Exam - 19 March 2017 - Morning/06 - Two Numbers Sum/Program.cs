using System;

namespace _06___Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = startNumber; i >= endNumber; i--)
            {
                for (int k = startNumber; k >= endNumber; k--)
                {
                    counter++;
                    if (i+k==magicNumber)
                    {
                        Console.Write($"Combination N:{counter}");
                        Console.WriteLine($" ({i} + {k} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
