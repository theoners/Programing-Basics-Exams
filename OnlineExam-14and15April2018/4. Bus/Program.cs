using System;

namespace _4._Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int stationnumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stationnumber; i++)
            {
                int down = int.Parse(Console.ReadLine());
                int up = int.Parse(Console.ReadLine());

                passengers = passengers - down + up;
            }

            if (stationnumber%2==1)
            {
                passengers += 2;
            }
            Console.WriteLine($"The final number of passengers is : {passengers}");
        }
    }
}
