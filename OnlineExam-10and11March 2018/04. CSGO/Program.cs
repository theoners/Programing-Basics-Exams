using System;

namespace _04._CSGO
{
    class Program
    {
        static void Main(string[] args)
        {
            int ak47 = 2700;
            int awp = 4750;
            int sg553 = 3500;
            int grenade = 300;
            int flash = 250;
            int glock = 500;
            int bazooka = 5600;
            int totalValue = 0;

            int itemNumber = int.Parse(Console.ReadLine());
            int nikiMoney = int.Parse(Console.ReadLine());

            if (itemNumber>7)
            {
                Console.WriteLine("Sorry, you can't carry so many things!");
                return;
            }

            for (int i = 0; i < itemNumber; i++)
            {
                string item = Console.ReadLine();

                switch (item)
                {
                    case "ak47":
                        totalValue += ak47;
                        break;
                    case "awp":
                        totalValue += awp;
                        break;
                    case "sg553":
                        totalValue += sg553;
                        break;
                    case "grenade":
                        totalValue += grenade;
                        break;
                    case "glock":
                        totalValue += glock;
                        break;
                    case "bazooka":
                        totalValue += bazooka;
                        break;
                    case "flash":
                        totalValue += flash;
                        break;
                }
            }
            if (nikiMoney>=totalValue)
            {
                Console.WriteLine($"You bought all {itemNumber} items! Get to work and defeat the bomb!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalValue-nikiMoney} more money.");
            }
        }
    }
}
