using System;

namespace _06.Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int firstDigit = 1; firstDigit <=9; firstDigit++)
            {
                for (int secondDigit = 1; secondDigit <=9; secondDigit++)
                {
                    for (int thirdDigit = 1; thirdDigit <=9; thirdDigit++)
                    {
                        for (int fourthDigit = 1; fourthDigit <=9; fourthDigit++)
                        {
                            if (firstDigit+secondDigit==thirdDigit+fourthDigit && n%(firstDigit+secondDigit)==0)
                            {
                                Console.Write(""+firstDigit+secondDigit+thirdDigit+fourthDigit+" ");
                            }
                        }
                    }
                }
            }
        }
    }
}
