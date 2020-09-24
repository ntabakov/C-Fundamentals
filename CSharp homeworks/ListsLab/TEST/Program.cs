using System;
using System.Collections.Generic;
using System.Linq;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 ,6,54535,23,22};
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(String.Join(' ',numbers));
        }
    }
}
