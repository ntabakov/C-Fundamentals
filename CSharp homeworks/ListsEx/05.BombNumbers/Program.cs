using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            // 1 2 2 4 2 2 2 9
            // 0 1 2 3 4 5 6 7
            //4
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == bombAndPower[0])
                {
                    for (int j = 0; j < bombAndPower[1]; j++)
                    {
                        if(i - 1 - j < 0 || i - 1 - j >= numbers.Count)
                        {

                        }
                        else
                        {
                            numbers.RemoveAt(i - 1 - j);

                        }
                        if( i - j < 0 || i - j >= numbers.Count)
                        {

                        }
                        else
                        {
                            numbers.RemoveAt(i - j);

                        }

                    }
                    numbers.Remove(bombAndPower[0]);
                }
            }
            
            Console.WriteLine(numbers.Sum());
        }
    }
}
