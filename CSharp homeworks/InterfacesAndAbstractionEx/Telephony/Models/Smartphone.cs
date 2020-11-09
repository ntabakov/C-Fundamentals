using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Contracts;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowseable
    {
        public Smartphone()
        {
            //this.Number = number;
            
        }
        //public int Number { get; }
        public void Browse(string url)
        {
            Console.WriteLine($"Browsing: {url}!");
        }

        public void Call(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
    }
}
