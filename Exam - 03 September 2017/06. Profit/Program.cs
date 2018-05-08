using System;

namespace _06._Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLvCount = int.Parse(Console.ReadLine());
            int twoLvCount = int.Parse(Console.ReadLine());
            int fiveLvCount = int.Parse(Console.ReadLine());
            int money = int.Parse(Console.ReadLine());

            for (int one = 0; one <= oneLvCount; one++)
            {
                for (int two = 0; two <= twoLvCount; two++)
                {
                    for (int five = 0; five <= fiveLvCount; five++)
                    {
                        if (one*1+two*2+five*5==money)
                        {
                            Console.WriteLine($"{one} * 1 lv. + {two} * 2 lv. + {five} * 5 lv. = {money} lv.");
                        }
                    }
                }
            }
        }
    }
}
