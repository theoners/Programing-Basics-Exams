using System;

namespace _05._Game_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int playedGames = int.Parse(Console.ReadLine());
            double totalTime = 0;
            int gamesWithPenalties = 0;
            int gamesWithAdditionalTime = 0;

            for (int i = 0; i < playedGames; i++)
            {
                int gameTime = int.Parse(Console.ReadLine());
                totalTime += gameTime;

                if (gameTime>120)
                {
                    gamesWithPenalties++;
                }
                else if (gameTime>90)
                {
                    gamesWithAdditionalTime++;
                }
            }

            Console.WriteLine($"{teamName} has played {totalTime} minutes." +
                $" Average minutes per game: {(totalTime/playedGames):F2}");
            Console.WriteLine($"Games with penalties: {gamesWithPenalties}");
            Console.WriteLine($"Games with additional time: {gamesWithAdditionalTime}");
        }
    }
}
