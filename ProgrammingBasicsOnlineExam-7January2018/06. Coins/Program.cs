using System;

namespace _06._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine())*100;
            int cent = (int)money;
            int count = 0;

            while (cent!=0)
            {
                while (cent >= 200)
                {
                    count++;
                    cent -= 200;
                }
                while (cent >= 100)
                {
                    count++;
                    cent -= 100;
                }
                while (cent >= 50)
                {
                    count++;
                    cent -= 50;
                }
                while (cent >= 20)
                {
                    count++;
                    cent -= 20;
                }
                while (cent >= 10)
                {
                    count++;
                    cent -= 10;
                }
                while (cent >= 5)
                {
                    count++;
                    cent -= 5;
                }
                while (cent >= 2)
                {
                    count++;
                    cent -= 2;
                }
                while (cent >= 1)
                {
                    count++;
                    cent -= 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
