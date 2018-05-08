using System;

namespace _03._Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictureCount = int.Parse(Console.ReadLine());
            string pictureFormat = Console.ReadLine();
            string typeOfOrder = Console.ReadLine();
            double price = 0;
            double discount = 1;

            switch (pictureFormat)
            {
                case "9X13":
                    price = 0.16;
                    if (pictureCount>=50)
                    {
                        discount = 0.95;                    }
                    break;
                case "10X15":
                    price = 0.16;
                    if (pictureCount>=80)
                    {
                        discount = 0.97;
                    }
                    break;
                case "13X18":
                    price = 0.38;
                    if (pictureCount >= 50 && pictureCount <=100)
                    {
                        discount = 0.97;
                    }
                    else if(pictureCount>100)
                    {
                        discount = 0.95;
                    }
                    break;
                case "20X30":
                    price = 2.90;
                    if (pictureCount >= 10 && pictureCount <= 50)
                    {
                        discount = 0.93;
                    }
                    else if (pictureCount > 50)
                    {
                        discount = 0.91;
                    }
                    break;
            }

            double totalPrice = pictureCount * price * discount;

            if (typeOfOrder=="online")
            {
                totalPrice *= 0.98;
            }

            Console.WriteLine($"{totalPrice:F2}BGN");

            
        }
    }
}
