using System;

namespace _04._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            double cakeLenght = double.Parse(Console.ReadLine());
            double cakeWidth = double.Parse(Console.ReadLine());
           string input = Console.ReadLine();
            double cakeArea = cakeLenght * cakeWidth;

            while (input!="STOP")
            {
               int  piecesCake = int.Parse(input);

                cakeArea -= piecesCake;
                if (cakeArea<0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeArea)} pieces more.");
                   return;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{cakeArea} pieces are left.");
        }
    }
}
