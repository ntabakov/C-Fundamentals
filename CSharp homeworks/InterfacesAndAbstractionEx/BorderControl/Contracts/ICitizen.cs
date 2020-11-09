using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Contracts
{
    public interface ICitizen
    {
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
    }
}
