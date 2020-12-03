using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    public abstract class CollectionsBase
    {
        protected List<string> collection;

        public CollectionsBase()
        {
            collection = new List<string>();

        }

        public abstract void Print();
    }
}
