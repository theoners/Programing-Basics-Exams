using System;

namespace _04._Group_Stage
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            double numberGame = double.Parse(Console.ReadLine());
            int scoredGoals = 0;
            int goalsConceded = 0;
            int points = 0;
            int totalScoredGoals = 0;
            int totalGoalsConceded = 0;

            for (int i = 0; i < numberGame; i++)
            {
                scoredGoals = int.Parse(Console.ReadLine());
                goalsConceded = int.Parse(Console.ReadLine());
                totalScoredGoals += scoredGoals;
                totalGoalsConceded += goalsConceded;
                if (scoredGoals>goalsConceded)
                {
                    points += 3;
                }
                else if (scoredGoals==goalsConceded)
                {
                    points++;
                }
                 
            }

            if (totalScoredGoals>=totalGoalsConceded)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {totalScoredGoals-totalGoalsConceded}.");
            }
            else
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {totalScoredGoals-totalGoalsConceded}.");
            }
        }
    }
}
