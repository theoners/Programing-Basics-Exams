using System;

namespace _02._Picture_in_the_Wall
{
    class Program
    {
        static void Main(string[] args)
        {
            int holeWidth = int.Parse(Console.ReadLine());
            int holeHeight = int.Parse(Console.ReadLine());
            int sidePicture = int.Parse(Console.ReadLine());
            int countPicture = int.Parse(Console.ReadLine());

            int holeArea = holeHeight * holeWidth;
            int pictureArea = sidePicture * sidePicture * countPicture;

            if (holeArea<pictureArea)
            {
                Console.WriteLine($"The pictures don't fit in the hole. Picture area is {pictureArea-holeArea} bigger than hole area.");
            }
            else
            {
                Console.WriteLine($"The pictures fit in the hole. Hole area is {holeArea-pictureArea} bigger than pictures area.");
            }
        }
    }
}
