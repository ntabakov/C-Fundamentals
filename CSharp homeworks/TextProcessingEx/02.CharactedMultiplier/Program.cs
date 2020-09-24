using System;

namespace _02.CharactedMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            TwoStringsSum(input);

        }

        static void TwoStringsSum(string[] twoStrings)
        {
            string first = twoStrings[0];
            string second = twoStrings[1];
            int sum = 0;

            if (first.Length < second.Length)
            {
                string temp = first;
                first = second;
                second = temp;
            }

            for (int i = 0; i < second.Length; i++)
            {
                sum += first[i] * second[i];
            }

            if (first.Length > second.Length)
            {
                for (int i = second.Length; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }
            Console.WriteLine(sum);

        }
    }
}
