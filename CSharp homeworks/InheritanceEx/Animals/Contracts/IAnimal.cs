using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Contracts
{
    public interface IAnimal
    {
        public string Name { get; }
        public int Age { get; }
        public string Gender { get; }

        public abstract string ProduceSound();
    }
}
