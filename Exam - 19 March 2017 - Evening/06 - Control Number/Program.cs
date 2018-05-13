using System;

namespace _06___Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            int counter = 0;

            for (int i = 1; i <= firstNumber; i++)
            {
                for (int k =secondNumber; k > 0; k--)
                {
                    currentNumber += i * 2 + k * 3;
                    counter++;

                    if (currentNumber>=controlNumber)
                    {
                        Console.WriteLine($"{counter} moves");
                        Console.WriteLine($"Score: {currentNumber} >= {controlNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} moves");

        }
    }
}
