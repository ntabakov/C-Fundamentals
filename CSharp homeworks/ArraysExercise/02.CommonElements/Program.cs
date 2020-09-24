using System;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split();
            string[] arrayTwo = Console.ReadLine().Split();

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                for (int k = 0; k < arrayOne.Length; k++)
                {
                    if (arrayTwo[i] == arrayOne[k])
                    {
                        Console.Write(arrayTwo[i] + " ");
                    }
                }
            }

        }
    }
}
