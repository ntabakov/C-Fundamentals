using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CollectionHierarchy.Contracts;

namespace CollectionHierarchy.Models
{
    class AddRemoveCollection : CollectionsBase, IAddable,IRemovable
    {
        private List<string> removed = new List<string>();


        public void Add(string element)
        {
            collection.Insert(0,element);
        }

        public void Remove()
        {
            string element = collection[collection.Count - 1];
            removed.Add(element);
            collection.RemoveAt(collection.Count - 1);
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
            Console.WriteLine(string.Join(" ",removed));
        }
    }
}
