using System;

namespace _03.Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double courierWeight = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine();
            double distance = double.Parse(Console.ReadLine());
            double priceForKm = 0;
            double overcharge = 0;

            
            if (courierWeight<=1)
            {
                priceForKm = 0.03;
            }
            else if (courierWeight<=10)
            {
                priceForKm = 0.05;
            }
            else if (courierWeight <= 40)
            {
                priceForKm = 0.10;
            }
            else if (courierWeight <= 90)
            {
                priceForKm = 0.15;
            }
            else if (courierWeight <= 150)
            {
                priceForKm = 0.2;
            }

            if (serviceType=="express")
            {

                if (courierWeight <= 1)
                {
                    overcharge= 0.03*0.80;
                }
                else if (courierWeight <= 10)
                {
                    overcharge = 0.05*0.40;
                }
                else if (courierWeight <= 40)
                {
                    overcharge = 0.10*0.05;
                }
                else if (courierWeight <= 90)
                {
                    overcharge = 0.15*0.02;
                }
                else if (courierWeight <= 150)
                {
                    overcharge = 0.2*0.01;
                }
            }

            double price = priceForKm * distance+overcharge*courierWeight*distance;
        
            Console.WriteLine($"The delivery of your shipment with weight of {(courierWeight):F3} kg. would cost {(price):F2} lv.");
        }
    }
}
