using System;
using System.Dynamic;
using CollectionHierarchy.Contracts;
using CollectionHierarchy.Models;

namespace CollectionHierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            AddCollection test = new AddCollection();
            AddRemoveCollection test2 = new AddRemoveCollection();
            MyList test3 = new MyList();

            var inpit = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < inpit.Length; i++)
            {
                test.Add(inpit[i]);
                test3.Add(inpit[i]);
                test2.Add(inpit[i]);
            }
            test.Print();
            test2.Print();
            test3.Print();
            for (int i = 0; i < n; i++)
            {
                test2.Remove();
                test3.Remove();
            }
           
            test2.PrintRemoved();
            test3.PrintRemoved();
        }
    }
}
