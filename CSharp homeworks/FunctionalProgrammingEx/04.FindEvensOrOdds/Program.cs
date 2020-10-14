using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = input[0];
            int end = input[1];
            List<int> nums = new List<int>();
            Func<int, int, List<int>> getList = (a, b) =>
              {
                  List<int> list = new List<int>();
                  for (int i = a; i <= b; i++)
                  {
                      list.Add(i);
                  }
                  return list;
              };

            nums = getList(start, end);

            string command = Console.ReadLine();

            Predicate<int> predicate = n => n % 2 == 0;
            if(command == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            nums = MyWhere(nums, predicate);
            Console.WriteLine(string.Join(' ',nums));
        }

        static List<int> MyWhere (List<int> nums , Predicate<int> predicate)
        {
            List<int> res = new List<int>();
            foreach (var item in nums)
            {
                if (predicate(item))
                {
                    res.Add(item);
                }
            }
            return res;

        }

    }
}
