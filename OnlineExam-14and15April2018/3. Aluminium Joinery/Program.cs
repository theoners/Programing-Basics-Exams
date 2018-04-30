using System;

namespace _3._Aluminium_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countWindow = int.Parse(Console.ReadLine());
            string size = Console.ReadLine();
            string delivery = Console.ReadLine();
            double discount = 1;
            double price = 0;

            if (countWindow<10)
            {
                Console.WriteLine("Invalid order");
                
            }
            else
            {
                switch (size)
                {
                    case "90X130":
                        if (countWindow>30 && countWindow<=60)
                        {
                            discount = 0.95;
                        }
                        else if (countWindow>60)
                        {
                            discount = 0.92;
                        }
                        price = 110;
                        break;
                    case "100X150":
                        if (countWindow > 40 && countWindow <= 80)
                        {
                            discount = 0.94;
                        }
                        else if (countWindow > 80)
                        {
                            discount = 0.90;
                        }
                        price = 140;
                        break;
                    case "130X180":
                        if (countWindow > 20 && countWindow <= 50)
                        {
                            discount = 0.93;
                        }
                        else if (countWindow > 50)
                        {
                            discount = 0.88;
                        }
                        price = 190;
                        break;
                    case "200X300":
                        if (countWindow > 25 && countWindow <= 50)
                        {
                            discount = 0.91;
                        }
                        else if (countWindow > 50)
                        {
                            discount = 0.86;
                        }
                        price = 250;
                        break;
                    
                }
                var totalPrice = countWindow * price*discount;
                if (delivery.Equals("With delivery"))
                {
                    totalPrice = totalPrice + 60;
                }
                if (countWindow>=100)
                {
                    totalPrice = totalPrice * 0.96;
                }
                Console.WriteLine($"{totalPrice:F2} BGN");
            }
           
        }
    }
}
