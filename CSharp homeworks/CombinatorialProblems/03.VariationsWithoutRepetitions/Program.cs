using System;

namespace _03.VariationsWithoutRepetitions
{
    class Program
    {
        private static string[] elements;
        private static string[] box;
        private static bool[] used;
        private static int k;
        static void Main(string[] args)
        {
            elements = new[] {"A", "B", "C"};/*Console.ReadLine().Split();*/
            k = 2;/*int.Parse(Console.ReadLine());*/
            box = new string[k];
            used = new bool[elements.Length];

            Variaton(0);
        }

        private static void Variaton(int index)
        {
            if (index >= box.Length)
            {
                Console.WriteLine(string.Join(" ",box));
                return;
            }

            for (int i = 0; i < elements.Length ; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    box[index] = elements[i];
                    Variaton(i+1);
                    used[i] = false;
                }
            }
        }


        //private static void Variaton(int index)
        //{
        //    if (index >= box.Length)
        //    {
        //        Console.WriteLine(string.Join(" ", box));
        //        return;
        //    }

        //    for (int i = 0; i < elements.Length; i++)
        //    {
        //        if (!used[i])
        //        {
        //            used[i] = true;
        //            box[index] = elements[i];
        //            Variaton(index+1);
        //            used[i] = false;
        //        }
        //    }
        //}
    }
}
