using System;

namespace _02._Illidan
{
    class Program
    {
        static void Main(string[] args)
        {
            int peoples = int.Parse(Console.ReadLine());
            int peopleDamage = int.Parse(Console.ReadLine());
            int healtIllidan = int.Parse(Console.ReadLine());

            int totalDamage = peoples * peopleDamage;

            if (healtIllidan>totalDamage)
            {
                Console.WriteLine($"You are not prepared! You need {healtIllidan-totalDamage} more points.");
            }
            else
            {
                Console.WriteLine($"Illidan has been slain! You defeated him with {totalDamage-healtIllidan} points.");
            }

        }
    }
}
