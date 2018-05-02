using System;

namespace _06._Juice_Diet
{
    class Program
    {
        static void Main(string[] args)
        {
            int raspberries = int.Parse(Console.ReadLine());
            int strawberries = int.Parse(Console.ReadLine());
            int cherries = int.Parse(Console.ReadLine());
            int maxJuice = int.Parse(Console.ReadLine());

            int maxRaspberries = 0;
            int maxStrawberriess = 0;
            int maxCherries = 0;
            double totalJuice = 0;
            double maxTotalJuice = 0;

            for (int i = 0; i <= cherries; i++)
            {
                for (int k = 0; k <= strawberries; k++)
                {
                    for (int l = 0; l <= raspberries; l++)
                    {
                        totalJuice = i * 15 + k * 7.5 + l * 4.5;
                        if (totalJuice>=maxTotalJuice && totalJuice<=maxJuice)
                        {
                            maxTotalJuice = totalJuice;

                             maxRaspberries = l;
                             maxStrawberriess = k;
                             maxCherries = i;
                        }
                    }
                }
            }
            Console.WriteLine($"{maxRaspberries} Raspberries, {maxStrawberriess} Strawberries, {maxCherries} Cherries. Juice: {maxTotalJuice} ml.");
            
            
        }
    }
}
