using System;

namespace _04._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = "";
            double goalNumber = 0;
            string bestPlayerName = "";
            double maxGoal = 0;

            while (goalNumber<10)
            {
                playerName = Console.ReadLine();
                if (playerName == "END")
                {
                    break;
                }
                goalNumber = double.Parse(Console.ReadLine());
                if (maxGoal<goalNumber)
                {
                    maxGoal = goalNumber;
                    bestPlayerName = playerName;
                }
            }

            Console.WriteLine($"{bestPlayerName} is the best player!");
            if (maxGoal<3)
            {
                Console.WriteLine($"He has scored {maxGoal} goals.");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoal} goals and made a hat-trick !!!");
            }
           
        }
    }
}
