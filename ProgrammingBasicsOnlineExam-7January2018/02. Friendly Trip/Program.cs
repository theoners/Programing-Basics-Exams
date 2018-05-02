using System;

namespace _02._Friendly_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int costFuel = int.Parse(Console.ReadLine());
            double priceFuel = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());

            double needFuel = distance * costFuel / 100.0;
            var totalPrice = needFuel * priceFuel;

            if (totalPrice>money)
            {
                double moneyforOne =Math.Round((money / 5), MidpointRounding.ToEven);
                Console.WriteLine($"Sorry, you cannot take a trip. Each will receive {Math.Round((money / 5), MidpointRounding.ToEven):F2} money.");
            }
            else
            {
                Console.WriteLine($"You can take a trip. {(money-totalPrice):F2} money left.");
            }
        }
    }
}
