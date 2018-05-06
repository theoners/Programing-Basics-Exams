using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int startBarcode = int.Parse(Console.ReadLine());
            int endBarcode = int.Parse(Console.ReadLine());
            int firstDigitSTart = startBarcode / 1000;
            int secondDigitStart = (startBarcode / 100) % 10;
            int thirdDigitStart = (startBarcode / 10) % 10;
            int fourthDigitStart = startBarcode % 10;
            int firstDigitEnd = endBarcode / 1000;
            int secondDigitEnd = (endBarcode / 100) % 10;
            int thirdDigitEnd = (endBarcode / 10) % 10;
            int fourthDigitEnd = endBarcode % 10;



            for (int firsDigit =firstDigitSTart; firsDigit <= firstDigitEnd; firsDigit++)
            {
                for (int secondDigit = secondDigitStart; secondDigit <= secondDigitEnd; secondDigit++)
                {
                    for (int thirdDigit = thirdDigitStart; thirdDigit <= thirdDigitEnd; thirdDigit++)
                    {
                        for (int fourthDigit = fourthDigitStart; fourthDigit <= fourthDigitEnd; fourthDigit++)
                        {
                            if (firsDigit % 2 == 1 && secondDigit % 2 == 1 && thirdDigit % 2 == 1 && fourthDigit % 2 == 1)
                            {
                                Console.Write(""+firsDigit+secondDigit+thirdDigit+fourthDigit+" ");
                            }
                        }
                    }
                }
            }
        }
    }
}
