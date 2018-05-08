﻿using System;

namespace _03.Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine();
            string contractType = Console.ReadLine();
            string internet = Console.ReadLine();
            int totalMonth = int.Parse(Console.ReadLine());
            double price = 0;

            if (years=="one")
            {
                switch (contractType)
                {
                    case "Small":
                        price =9.98;
                        break;
                    case "Middle":
                        price = 18.99;
                        break;
                    case "Large":
                        price = 25.98;
                        break;
                    case "ExtraLarge":
                        price = 35.99;
                        break;
                }
            }
            else
            {
                switch (contractType)
                {
                    case "Small":
                        price = 8.58;
                        break;
                    case "Middle":
                        price = 17.09;
                        break;
                    case "Large":
                        price = 23.59;
                        break;
                    case "ExtraLarge":
                        price = 31.79;
                        break;
                }
            }
            if (internet=="yes")
            {
                if (price<=10)
                {
                    price += 5.50;
                }
                else if (price<=30)
                {
                    price += 4.35;
                }
                else
                {
                    price += 3.85;
                }
            }

            double totalPrice = price * totalMonth;

            if (years=="two")
            {
                totalPrice *= 0.9625;
            }
            Console.WriteLine($"{totalPrice:F2} lv.");
        }
    }
}
