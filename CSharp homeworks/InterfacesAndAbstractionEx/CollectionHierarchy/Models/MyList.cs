using System;
using System.Collections.Generic;
using System.Text;
using CollectionHierarchy.Contracts;

namespace CollectionHierarchy.Models
{
    public class MyList : CollectionsBase,IRemovable,IAddable
    {
        private List<string> removed = new List<string>();
        public void Remove()
        {
            string element = collection[0];
            removed.Add(element);
            collection.RemoveAt(0);
        }

        public void Add(string element)
        {
            collection.Insert(0, element);
        }

        public override void Print()
        {
            for (int i = 0; i < collection.Count; i++)
            {
                Console.Write("0 ");
            }

            Console.WriteLine();
        }

        public void PrintRemoved()
        {
            Console.WriteLine(string.Join(" ", removed));
            Console.WriteLine();
        }
    }
}
