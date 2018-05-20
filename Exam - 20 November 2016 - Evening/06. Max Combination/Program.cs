using System;

namespace _06._Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int numberOfCombinations = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int k = start; k <=end; k++)
                {
                    Console.Write($"<{i}-{k}>");
                    counter++;
                    if (counter==numberOfCombinations)
                    {
                        return;
                    }
                }
            }
        }
    }
}
