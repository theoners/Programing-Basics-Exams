using System;

namespace _04._Dwarf_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDwarf = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double cost = 0;

            for (int i = 0; i < numberOfDwarf; i++)
            {
                string gift = Console.ReadLine();

                switch (gift)
                {
                    case "sand clock":
                        cost += 2.2;
                        break;
                    case "magnet":
                        cost += 1.5;
                        break;
                    case "cup":
                        cost += 5;
                        break;
                    case "t-shirt":
                        cost += 10;
                        break;
                    default:
                        break;
                }
            }

            if (cost<=money)
            {
                Console.WriteLine($"Santa Claus has {(money-cost):F2} more leva left!");
            }
            else
            {
                Console.WriteLine($"Santa Claus will need {(cost-money):F2} more leva.");
            }
        }
    }
}
