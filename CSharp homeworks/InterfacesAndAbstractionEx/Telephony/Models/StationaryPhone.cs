using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Contracts;

namespace Telephony.Models
{
    class StationaryPhone : ICallable
    {
        public StationaryPhone()
        {
            //this.Number = number;
           
        }

        //public int Number { get; }
        

        public void Call(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }


    }
}
