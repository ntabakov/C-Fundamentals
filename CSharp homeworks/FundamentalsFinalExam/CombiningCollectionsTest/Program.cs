using System;
using System.Collections.Generic;
using System.Linq;

namespace CombiningCollectionsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> c1 = new List<int>(){1,2,3,4,5,6};
            List<int> c2 = new List<int>() { 4,5,6,7,8,9,0,11 };
            List<string> c3 = new List<string>(){"opa","test"};

            var combined = c1.Concat(c2).Union(c1);

            foreach (var VARIABLE in combined)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}
