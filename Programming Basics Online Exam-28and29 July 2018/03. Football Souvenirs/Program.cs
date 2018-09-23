using System;

namespace _03._Football_Souvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string giftType = Console.ReadLine();
            double giftNumber = double.Parse(Console.ReadLine());
            double giftPrice = 0;

            switch (team)
            {
                case "Brazil":
                    if (giftType=="flags")
                    {
                        giftPrice = 4.2;
                    }
                    else if (giftType=="caps")
                    {
                        giftPrice = 8.5;
                    }
                    else if (giftType == "posters")
                    {
                        giftPrice = 5.35;
                    }
                    else if (giftType == "stickers")
                    {
                        giftPrice = 1.2;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                    }
                    break;
                case "Argentina":
                    if (giftType == "flags")
                    {
                        giftPrice = 3.25;
                    }
                    else if (giftType == "caps")
                    {
                        giftPrice = 7.2;
                    }
                    else if (giftType == "posters")
                    {
                        giftPrice = 5.1;
                    }
                    else if (giftType == "stickers")
                    {
                        giftPrice = 1.25;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                    }
                    break;
                case "Croatia":
                    if (giftType == "flags")
                    {
                        giftPrice = 2.75;
                    }
                    else if (giftType == "caps")
                    {
                        giftPrice = 6.9;
                    }
                    else if (giftType == "posters")
                    {
                        giftPrice = 4.95;
                    }
                    else if (giftType == "stickers")
                    {
                        giftPrice = 1.1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                    }
                    break;
                case "Denmark":
                    if (giftType == "flags")
                    {
                        giftPrice = 3.1;
                    }
                    else if (giftType == "caps")
                    {
                        giftPrice = 6.5;
                    }
                    else if (giftType == "posters")
                    {
                        giftPrice = 4.8;
                    }
                    else if (giftType == "stickers")
                    {
                        giftPrice = 0.9;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid country!");
                    break;
            }
            if (giftPrice!=0)
            {
                Console.WriteLine($"Pepi bought {giftNumber} {giftType} of {team} for {(giftPrice*giftNumber):F2} lv.");
            }
        }
    }
}
