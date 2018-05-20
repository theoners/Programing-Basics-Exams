using System;

namespace _06._Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= firsPlayer; i++)
            {
                for (int k = 1; k <= secondPlayer; k++)
                {
                    Console.Write($"({i} <-> {k}) ");
                    counter++;
                    if (counter==maxBattles)
                    {
                        return;
                    }
                }
            }
        }
    }
}
