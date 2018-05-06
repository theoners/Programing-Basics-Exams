using System;

namespace _03._Santas_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string award = Console.ReadLine();
            double price = 0;
            double discount = 1;

            if (days<=10)
            {
                switch (typeOfRoom)
                {
                    case "room for one person":
                        price = 18;
                        break;
                    case "apartment":
                        price = 25;
                        discount = 0.7;
                        break;
                    case "president apartment":
                        price = 35;
                        discount = 0.9;
                        break;
                }
            }
            else if (days>10 && days<15)
            {
                switch (typeOfRoom)
                {
                    case "room for one person":
                        price = 18;
                        break;
                    case "apartment":
                        discount = 0.65;
                        price = 25;
                        break;
                    case "president apartment":
                        discount = 0.85;
                        price = 35;
                        break;
                }
            }
            else
            {
                switch (typeOfRoom)
                {
                    case "room for one person":
                        price = 18;
                        break;
                    case "apartment":
                        discount = 0.5;
                        price = 25;
                        break;
                    case "president apartment":
                        discount = 0.8;
                        price = 35;
                        break;
                }
            }

            double cost = ((days - 1) * price) * discount;

            if (award=="positive")
            {
                cost *= 1.25;
            }
            else
            {
                cost *= 0.90;
            }
            Console.WriteLine($"{cost:F2}");

        }
    }
}
