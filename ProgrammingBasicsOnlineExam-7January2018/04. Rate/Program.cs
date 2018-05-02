using System;

namespace _04._Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            

            double simpleRate =money+ money * month * 0.03;

            for (int i = 0; i < month; i++)
            {
                money += money * 0.027;
            }

            Console.WriteLine($"Simple interest rate: {simpleRate:F2} lv.");
            Console.WriteLine($"Complex interest rate: {money:F2} lv.");
            if (simpleRate>money)
            {
                Console.WriteLine($"Choose a simple interest rate. You will win {(simpleRate-money):F2} lv.");
            }
            else
            {
                Console.WriteLine($"Choose a complex interest rate. You will win {(money-simpleRate):F2} lv.");
            }
        }
    }
}
