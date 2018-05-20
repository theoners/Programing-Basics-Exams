using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double adultPrice = 0;
            double studentPrice = 0;

            switch (transport)
            {
                case "train":
                    adultPrice = 24.99;
                    studentPrice = 14.99;
                    if (adults+students>=50)
                    {
                        adultPrice /= 2;
                        studentPrice /= 2;
                    }
                    break;
                case "bus":
                    adultPrice = 32.50;
                    studentPrice = 28.50;
                    break;
                case "boat":
                    adultPrice = 42.99;
                    studentPrice = 39.99;
                    break;
                case "airplane":
                    adultPrice = 70;
                    studentPrice = 50;
                    break;
            }

            double transportCost = (adults * adultPrice + students * studentPrice) * 2;
            double hotelCost = days * 82.99;
            double totalCost = transportCost + hotelCost;
            totalCost *= 1.1;

            Console.WriteLine($"{totalCost:F2}");
        }
    }
}
