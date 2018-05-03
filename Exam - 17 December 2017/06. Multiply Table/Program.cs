using System;

namespace _06._Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;

            for (int i = 1; i <=thirdDigit; i++)
            {
                for (int k = 1; k <= secondDigit; k++)
                {
                    for (int l = 1; l <= firstDigit; l++)
                    {
                        int result = i * k * l;

                        Console.WriteLine(""+ i+ " * " +k+ " * "+ l +" = "+result+";");
                    }
                }
            }
        }
    }
}
