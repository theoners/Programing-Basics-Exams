using System;
using System.Collections.Generic;

namespace _04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = int.Parse(Console.ReadLine());
            double points = 0;
            int countRed = 0;
            int countOrange = 0;
            int countYellow = 0;
            int countWhite = 0;
            int countOtherColor = 0;
            int countBlack = 0;



            for (int i = 0; i < numberOfBalls; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                { case "red":
                        countRed++;
                        points += 5; 
                        break;
                  case "orange":
                        countOrange++;
                        points += 10;
                        break;
                    case "yellow":
                        countYellow++;
                        points += 15;
                        break;
                    case "white":
                        countWhite++;
                        points += 20;
                        break;
                    case "black":
                        countBlack++;
                        points/= 2;
                        break;
                    default:
                        countOtherColor++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {(int)(points)}");
            Console.WriteLine($"Points from red balls: {countRed}");
            Console.WriteLine($"Points from orange balls: {countOrange}");
            Console.WriteLine($"Points from yellow balls: {countYellow}");
            Console.WriteLine($"Points from white balls: {countWhite}");
            Console.WriteLine($"Other colors picked: {countOtherColor}");
            Console.WriteLine($"Divides from black balls: {countBlack}");
        }
    }
}
