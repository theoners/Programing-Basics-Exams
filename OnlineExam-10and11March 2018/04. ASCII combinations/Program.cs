using System;

namespace _04._ASCII_combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSymbol = int.Parse(Console.ReadLine());
            int sumNumbers = 0;
            int sumCapitalLetter = 0;
            int sumSmalLetter = 0;
            int sumOther = 0;
            string number = "";
            string capitalLetter = "";
            string smallLetter = "";
            string other = "";

            for (int i = 0; i < numberSymbol; i++)
            {
                char current = char.Parse(Console.ReadLine());

                if (current>=48 && current<=57)
                {
                    sumNumbers += current;
                    number += current;
                }
                else if (current >= 65 && current <= 90)
                {
                    sumCapitalLetter += current;
                    capitalLetter += current; 
                }
                else if (current >= 97 && current <= 122)
                {
                    sumSmalLetter += current;
                    smallLetter += current;
                }
                else
                {
                    sumOther += current;
                    other += current;
                }

                
            }
            var maxResult = Math.Max(sumSmalLetter, Math.Max(sumOther, Math.Max(sumNumbers, sumCapitalLetter)));

            if (maxResult == sumNumbers)
            {
                Console.WriteLine($"Biggest ASCII sum is:{sumNumbers}");
                Console.WriteLine($"Combination of characters is:{number}");
                
            }
            else if (maxResult == sumCapitalLetter)
            {
                Console.WriteLine($"Biggest ASCII sum is:{sumCapitalLetter}");
                Console.WriteLine($"Combination of characters is:{capitalLetter}");
                
            }
            else if (maxResult == sumSmalLetter)
            {
                Console.WriteLine($"Biggest ASCII sum is:{sumSmalLetter}");
                Console.WriteLine($"Combination of characters is:{smallLetter}");
            }
            else
            {
                Console.WriteLine($"Biggest ASCII sum is:{sumOther}");
                Console.WriteLine($"Combination of characters is:{other}");
            }
        }
    }
}
