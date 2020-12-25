using System;
using System.Collections.Generic;

namespace _01.PermutationsWithoutRepetitions
{
    class Program
    {
        private static string[] elements;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();


            Premut(0);
        }

        private static void Premut(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ",elements));
                return;
            }
            Premut(index + 1);
            var swapped = new HashSet<string>(){elements[index]};
           
            for (int i = index + 1; i < elements.Length; i++)
            {
                if (!swapped.Contains(elements[i]))
                {
                    Swap(index, i);
                    Premut(index + 1);
                    Swap(index, i);
                    swapped.Add(elements[i]);
                }
                

            }
        }

        private static void Swap(int first, int second)
        {
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }
    }
}
