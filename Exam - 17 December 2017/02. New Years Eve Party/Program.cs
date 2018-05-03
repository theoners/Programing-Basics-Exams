using System;

namespace _02._New_Years_Eve_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double leftMoney = budget - (guests * 20);

            if (leftMoney>=0)
            {
                double moneyForDonation = leftMoney * 0.60;
                double moneyFOrPyrotehnics = leftMoney * 0.40;

                Console.WriteLine($"Yes! {Math.Round(moneyFOrPyrotehnics)} lv are for fireworks and {Math.Round(moneyForDonation)} lv are for donation.") ;
            }
            else
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(Math.Abs(leftMoney))} lv more.");
            }
        }
    }
}
