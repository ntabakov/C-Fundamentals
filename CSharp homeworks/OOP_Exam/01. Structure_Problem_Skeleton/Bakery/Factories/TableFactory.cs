using System;
using System.Collections.Generic;
using System.Text;
using Bakery.Models.Tables.Contracts;
using Bakery.Models.Tables.Models;

namespace Bakery.Factories
{
    public class TableFactory
    {
        public ITable CreateTable(string type, int tableNumber, int capacity)
        {
            ITable table = null;

            if (type == "InsideTable")
            {
                table = new InsideTable(tableNumber,capacity);
            }
            else if (type == "OutsideTable")
            {
                table = new OutsideTable(tableNumber,capacity);
            }
            else
            {
                throw new ArgumentException("InvalidType");
            }

            return table;
        }
    }
}
