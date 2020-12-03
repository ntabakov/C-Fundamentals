using System;
using System.Collections.Generic;
using System.Text;
using CollectionHierarchy.Contracts;

namespace CollectionHierarchy.Models
{
    public class AddCollection : CollectionsBase, IAddable
    {
        public void Add(string element)
        {
            collection.Add(element);
        }

        public override void Print()
        {
            for (int i = 0; i < collection.Count; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
