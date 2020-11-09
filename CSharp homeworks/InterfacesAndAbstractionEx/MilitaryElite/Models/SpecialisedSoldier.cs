using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.ParseCorps(corps);
        }

        public Corps Corps { get; private set; }

        Corps ISpecialisedSoldier.Corps => throw new NotImplementedException();

        private void ParseCorps(string corpsAsString)
        {
            Corps corps;

            bool parsed = Enum.TryParse<Corps>(corpsAsString, out corps);

            if (!parsed)
            {
                throw new ArgumentException("Invalid corps!");
            }

            this.Corps = corps;
        }
    }
}
