using System;

namespace _06._Ticket_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            int prize = 0;

            for (char i = 'B'; i <= 'L'; i=(char)(i+2))
            {
                for (char k = 'f'; k >= 'a'; k--)
                {
                    for (char m = 'A'; m <= 'C'; m++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            for (int l = 10; l >= 1; l--)
                            {
                                counter++;
                                if (number == counter)
                                {
                                    Console.WriteLine($"Ticket combination: {i}{k}{m}{j}{l}");
                                    prize = l + j + m + k + i;
                                    Console.WriteLine($"Prize: {prize} lv.");
                                    break;
                                }
                            }
                        }
                    }
                    
                }
            }
        }
    }
}
