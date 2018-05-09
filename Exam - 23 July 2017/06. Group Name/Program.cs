using System;

namespace _06._Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            char fourthLetter = char.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int count = -1;

            for (char i = 'A'; i <= firstLetter; i++)
            {
                for (char k = 'a'; k <= secondLetter; k++)
                {
                    for (int j = 'a'; j <=thirdLetter; j++)
                    {
                        for (int l = 'a'; l <= fourthLetter; l++)
                        {
                            for (int m = 0; m <= number; m++)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
