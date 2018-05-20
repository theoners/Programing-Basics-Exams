using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfChrysanthemums = double.Parse(Console.ReadLine());
            double numberOfRoses = double.Parse(Console.ReadLine());
            double numberOfTulips = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string feast = Console.ReadLine();

            double chrysanthemumPrice = 0;
            double rosePrice = 0;
            double tulipPrice = 0;
            double discount = 1;

            if (season=="Summer" || season=="Spring")
            {
                chrysanthemumPrice = 2;
                rosePrice = 4.1;
                tulipPrice = 2.5;

                if (season=="Spring" && numberOfTulips>7)
                {
                    discount = 0.95;
                }
            }
            else
            {
                chrysanthemumPrice = 3.75;
                rosePrice = 4.5;
                tulipPrice = 4.15;

                if (season == "Winter" && numberOfRoses >= 10)
                {
                    discount = 0.90;
                }
            }

            double totalPrice = chrysanthemumPrice * numberOfChrysanthemums + 
                                rosePrice * numberOfRoses +
                                tulipPrice * numberOfTulips;

            totalPrice *= discount;

            if (feast == "Y")
            {
                totalPrice *= 1.15;
            }
            if (numberOfTulips+numberOfRoses+numberOfChrysanthemums>20)
            {
                totalPrice *= 0.8;
            }

            Console.WriteLine($"{(totalPrice+2):F2}");
        }
    }
}
