using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> people = Console.ReadLine().Split().ToList();

            Func<string,int> getAscii = x=> x.Select(c=>(int)c).Sum();
            string person = GetName(people, n, getAscii);
            Console.WriteLine(person);
        
        }

        static string GetName(List<string> list, int n , Func<string, int> func)
        {
            string res = null;
            foreach (var item in list)
            {
                if (func(item) >= n)
                {
                    res = item;
                    break;
                }
            }
            return res;

        }
    }
}
