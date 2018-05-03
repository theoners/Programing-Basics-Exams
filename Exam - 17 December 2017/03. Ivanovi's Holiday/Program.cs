using System;

namespace _03._Ivanovi_s_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNights = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string transport = Console.ReadLine();
            double priceAdults = 0;
            double priceChildren = 0;
            double priceTransportAdult = 0;
            double priceTransportChildren = 0;

            if (destination=="Miami")
            {
                if (numberOfNights<=10)
                {
                    priceAdults = 24.99;
                    priceChildren = 14.99;
                }
                else if (numberOfNights<=15)
                {
                    priceAdults = 22.99;
                    priceChildren = 11.99;
                }
                else
                {
                    priceAdults = 20;
                    priceChildren = 10;
                }
            }
            else if (destination== "Canary Islands")
            {
                if (numberOfNights <= 10)
                {
                    priceAdults = 32.50;
                    priceChildren = 28.50;
                }
                else if (numberOfNights <= 15)
                {
                    priceAdults = 30.50;
                    priceChildren = 25.60;
                }
                else
                {
                    priceAdults = 28;
                    priceChildren = 22;
                }
            }
            else
            {
                if (numberOfNights <= 10)
                {
                    priceAdults = 42.99;
                    priceChildren = 39.99;
                }
                else if (numberOfNights <= 15)
                {
                    priceAdults = 41;
                    priceChildren = 36;
                }
                else
                {
                    priceAdults = 38.50;
                    priceChildren = 32.40;
                }
            }
            switch (transport)
            {
                case "train":
                    priceTransportAdult = 22.30;
                    priceTransportChildren =12.50;
                    break;
                case "airplane":
                    priceTransportAdult = 90;
                    priceTransportChildren = 68.50;
                    break;
                case "bus":
                    priceTransportAdult = 45;
                    priceTransportChildren = 37;
                    break;
            }

            double costHoliday =numberOfNights* (priceAdults * 2 + priceChildren * 3) * 1.25;
            double costTransport = priceTransportAdult * 2 + priceTransportChildren * 3;

            double totalCost = costHoliday + costTransport;

            Console.WriteLine($"{totalCost:F3}");
        }
    }
}
