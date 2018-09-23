using System;

namespace _01._Trip_To_World_Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            double ticketPriceDeparture = double.Parse(Console.ReadLine());
            double ticketPriceReturn = double.Parse(Console.ReadLine());
            double ticketPriceGame = double.Parse(Console.ReadLine());
            double gameNumber = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine())/100;

            double airplaneTicketPrice = (6 * (ticketPriceDeparture + ticketPriceReturn))*(1-discount);
            double ticketPriceAllGames = ticketPriceGame * gameNumber * 6;
            double totalSum = airplaneTicketPrice + ticketPriceAllGames;
            double priceForPerson = totalSum / 6;

            Console.WriteLine($"Total sum: {totalSum:F2} lv.");
            Console.WriteLine($"Each friend has to pay {priceForPerson:F2} lv.");

        }
    }
}
