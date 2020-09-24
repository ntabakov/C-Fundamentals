using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> handOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> handTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = Math.Max(handOne.Count, handTwo.Count);

            bool firstWin = false;
            bool secondWin = false;


            for (int i = 0; i < count; i++)
            {
                if (handOne[i] > handTwo[i])
                {
                    handOne.Add(handOne[i]);
                    handOne.Add(handTwo[i]);
                    handTwo.RemoveAt(i);
                    handOne.RemoveAt(i);
                    i--;
                }
                else if (handOne[i] < handTwo[i])
                {
                    handTwo.Add(handTwo[i]);
                    handTwo.Add(handOne[i]);
                    handOne.RemoveAt(i);
                    handTwo.RemoveAt(i);
                    i--;

                }
                else
                {
                    handOne.RemoveAt(i);
                    handTwo.RemoveAt(i);
                    i--;
                }

                if (handOne.Count == 0 )
                {
                    Console.WriteLine($"Second player wins! Sum: {handTwo.Sum()}");

                    break;
                }
                else if (handTwo.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {handOne.Sum()}");
                    break;
                }
                count = Math.Max(handOne.Count, handTwo.Count);
            }


        }
    }
}
