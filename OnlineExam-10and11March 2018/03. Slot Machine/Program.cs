using System;

namespace _03._Slot_Machine
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstSymbol = char.Parse(Console.ReadLine())+ int.Parse(Console.ReadLine());
            int secondSymbol = char.Parse(Console.ReadLine())+ int.Parse(Console.ReadLine());
            int thirdSymbol = char.Parse(Console.ReadLine())+ int.Parse(Console.ReadLine());

            char first = (char)firstSymbol;
            char second = (char)secondSymbol;
            char third = (char)thirdSymbol;

            if (first=='@' && second == '@' && third == '@')
            {
                Console.WriteLine("@@@");
                Console.WriteLine("!!! YOU LOSE EVERYTHING !!!");
            }
            else if (first == '7' && second == '7' && third == '7')
            {
                Console.WriteLine("777");
                Console.WriteLine("*** JACKPOT ***");
            }
            else
            {
                Console.Write(first);
                Console.Write(second);
                Console.Write(third);
                Console.WriteLine();
            }

            

        }
    }
}
