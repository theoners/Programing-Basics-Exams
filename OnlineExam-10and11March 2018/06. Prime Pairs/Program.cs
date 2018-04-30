using System;

namespace _06._Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPairMin = int.Parse(Console.ReadLine());
            int secondPairMin = int.Parse(Console.ReadLine());
            int firstPairMax = int.Parse(Console.ReadLine())+firstPairMin;
            int secondPairMax = int.Parse(Console.ReadLine())+secondPairMin;
            bool isPrime = true;
            int firstNumber = 0;
            int secondNumber = 0;

            for (int i = firstPairMin; i <= firstPairMax; i++)
            {
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i%k==0)
                    {
                        isPrime = false;
                       
                    }
                    
                }
                if (isPrime)
                {
                    firstNumber = i*100;
                    for (int j = secondPairMin; j <= secondPairMax; j++)
                    {
                        for (int k = 2; k <= Math.Sqrt(j); k++)
                        {
                            if (j % k == 0)
                            {
                                isPrime = false;
                                
                            }

                        }
                        if (isPrime)
                        {
                            secondNumber = j;
                            Console.WriteLine(firstNumber+secondNumber);
                        }
                        isPrime = true;
                    }
                }
                isPrime = true;
            }
            
        }
    }
}
