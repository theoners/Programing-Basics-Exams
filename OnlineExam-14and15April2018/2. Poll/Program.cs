using System;

namespace _2._Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = int.Parse(Console.ReadLine());
            var voteFirst = int.Parse(Console.ReadLine());

            var voteSecond =(voteFirst * 0.8);
            var voteThird =( voteSecond * 0.9);

            var totalvote = Math.Floor(voteFirst + voteSecond + voteThird);

            if (totalvote>=participants/2)
            {
                Console.WriteLine($"First three languages have {Math.Floor(totalvote - (participants / 2))} votes more");
            }
            else
            {
                Console.WriteLine($"First three languages have {Math.Floor((participants / 2)- totalvote)} votes less of half votes");
            }
        }
    }
}
