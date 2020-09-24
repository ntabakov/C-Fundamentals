using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();
            //22 34 11 66
            while (command[0] != "end")
            {
                string action = command[0];
                

                if (action == "swap")
                {
                    int indexOne = int.Parse(command[1]);
                    int indexTwo = int.Parse(command[2]);
                    int temp = numbers[indexOne];
                    numbers[indexOne] = numbers[indexTwo];
                    numbers[indexTwo] = temp;
                }
                else if (action == "multiply")
                {
                    int indexOne = int.Parse(command[1]);
                    int indexTwo = int.Parse(command[2]);
                    numbers[indexOne] *= numbers[indexTwo];
                }
                else // decrease
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(", ",numbers));
        }
    }
}
