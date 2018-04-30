using System;

namespace _1._Mining_Rig
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVideoCard = double.Parse(Console.ReadLine());
            double priceAdapter = double.Parse(Console.ReadLine());
            double videoCardConsumation = double.Parse(Console.ReadLine());
            double profitOneVideoCard = double.Parse(Console.ReadLine());

            double costHardware = (priceVideoCard + priceAdapter) * 13+1000;
            double profitForDay = (profitOneVideoCard - videoCardConsumation)*13;
            double totalDays = costHardware / profitForDay;

            Console.WriteLine(costHardware);
            Console.WriteLine(Math.Ceiling(totalDays));
        }
    }
}
