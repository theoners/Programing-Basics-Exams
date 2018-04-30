using System;

namespace _02._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double ivoMoney = double.Parse(Console.ReadLine());
            int countChoclate = int.Parse(Console.ReadLine());
            double countMilk = double.Parse(Console.ReadLine());

            int countMandarine = (int)(countChoclate * 0.65);
            double priceChoclate =0.65 ;
            double priceMilk =2.70 ;
            double priceMandarine = 0.20;

            double totalPrice = countChoclate * priceChoclate + countMilk * priceMilk + countMandarine * priceMandarine;

            if (totalPrice>ivoMoney)
            {
                Console.WriteLine($"Not enough money, you need {(totalPrice-ivoMoney):F2} more!");
            }
            else
            {
                Console.WriteLine($"You got this, {(ivoMoney-totalPrice):F2} money left!");
            }
        }
    }
}
