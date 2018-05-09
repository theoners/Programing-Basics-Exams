using System;

namespace _02._Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double stepsPerDay = Math.Ceiling(((steps / days) / steps)*100);

            if (stepsPerDay<=13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {(stepsPerDay/dancers):F2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {(stepsPerDay/dancers):F2}% steps to be learned per day.");
            }

        }
    }
}
