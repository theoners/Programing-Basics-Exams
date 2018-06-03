using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int firstPipe = int.Parse(Console.ReadLine());
            int secondPipe = int.Parse(Console.ReadLine());
            double hoursAbsence = double.Parse(Console.ReadLine());

            double totalDebit = (firstPipe + secondPipe) * hoursAbsence;

            if (totalDebit<=volume)
            {
                Console.WriteLine($"The pool is {(int)(totalDebit / volume * 100)}% full." +
                    $" Pipe 1: {(int)(firstPipe * hoursAbsence / totalDebit * 100)}%." +
                    $" Pipe 2: {(int)(secondPipe * hoursAbsence / totalDebit * 100)}%.");
            }
            else
            {
                Console.WriteLine($"For {hoursAbsence} hours the pool overflows with {totalDebit-volume} liters.");
            }
        }
    }
}
