using System;

namespace _03._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());
            double pricePerNight = 0;
            string sport = "";

            if (season=="Winter")
            {
                if (groupType=="mixed")
                {
                    sport = "Ski";
                    pricePerNight = 10;
                }
                else if (groupType=="boys")
                {
                    sport = "Judo";
                    pricePerNight = 9.6;
                }
                else
                {
                    sport = "Gymnastics";
                    pricePerNight = 9.6;
                }
            }
            else if (season=="Spring")
            {
                if (groupType == "mixed")
                {
                    sport = "Cycling";
                    pricePerNight = 9.5;
                }
                else if (groupType == "boys")
                {
                    sport = "Tennis";
                    pricePerNight = 7.2;
                }
                else
                {
                    sport = "Athletics";
                    pricePerNight = 7.2;
                }
            }
            else
            {
                if (groupType == "mixed")
                {
                    sport = "Swimming";
                    pricePerNight = 20;
                }
                else if (groupType == "boys")
                {
                    sport = "Football";
                    pricePerNight = 15;
                }
                else
                {
                    sport = "Volleyball";
                    pricePerNight = 15;
                }
            }

            double totalPrice = pricePerNight * numberOfNights*numberOfStudents;
            if (numberOfStudents >= 50)
            {
                totalPrice *= 0.5;
            }
            else if (numberOfStudents >= 20)
            {
                totalPrice *= 0.85;
            }
            else if (numberOfStudents >= 10)
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"{sport} {totalPrice:F2} lv.");
        }
    }
}
