using System;

namespace _6._Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            string carNumber = "";

            for (int firstDigit = firstNumber+1; firstDigit <= secondNumber; firstDigit++)
            {
                for (int secondDigit = firstNumber; secondDigit <= secondNumber; secondDigit++)
                {
                    for (int thirdDigit = firstNumber; thirdDigit <= secondNumber; thirdDigit++)
                    {
                        for (int fourthDigit = firstNumber; fourthDigit <= secondNumber; fourthDigit++)
                        {
                            if (firstDigit>fourthDigit && (secondDigit+thirdDigit)%2==0 &&((firstDigit%2==0 &&fourthDigit%2==1)|| (firstDigit % 2 == 1 && fourthDigit % 2 == 0)))
                            {
                                carNumber = "" + firstDigit + secondDigit + thirdDigit + fourthDigit+" ";
                                Console.Write(carNumber);
                            }
                        }
                    }
                }
            }

        }
    }
}
