using System;

namespace _03._Arena_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            string nameOfArena = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            string itemType = Console.ReadLine().ToLower();
            double discount = 0;
            double itemPrice = 0;

            if (nameOfArena== "nagrand" && dayOfWeek== "monday" || dayOfWeek == "wednesday")
            {
                    discount = 0.95;
            }
            else if (nameOfArena == "gurubashi" && dayOfWeek == "tuesday" || dayOfWeek == "thursday")
            {
                discount = 0.9;
            }
            else if (nameOfArena == "dire maul" && dayOfWeek == "friday" || dayOfWeek == "saturday")
            {
                discount = 0.93;
            }
            else
            {
                discount = 1;
            }

            if (itemType== "poor")
            {
                itemPrice = 7000 * discount;
            }
            else if (itemType == "normal")
            {
                itemPrice = 14000 * discount;
            }
            else
            {
                itemPrice = 21000 * discount;
            }
            var oneItemPrice = itemPrice / 5;

            if (itemPrice<=points)
            {
                Console.WriteLine("Items bought: 5");
                Console.WriteLine($"Arena points left: {points-itemPrice}");
                Console.WriteLine("Success!");
            }
            else
            {
                var totalItem = (int)(points / oneItemPrice);
                Console.WriteLine($"Items bought: {totalItem}");
                Console.WriteLine($"Arena points left: {points - oneItemPrice*totalItem}");
                Console.WriteLine("Failure!");
            }

        }
    }
}
