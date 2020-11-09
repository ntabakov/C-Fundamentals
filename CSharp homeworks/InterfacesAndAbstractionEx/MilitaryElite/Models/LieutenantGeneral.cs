using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<ISoldier> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            privates = new List<ISoldier>();
        }

        public IReadOnlyCollection<ISoldier> Privates => this.privates.AsReadOnly();

        public void AddPrivate(ISoldier privateToAdd)
        {
            this.privates.Add(privateToAdd);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            sb.AppendLine("Privates:");

            foreach (var currentPrivate in this.privates)
            {
                sb.AppendLine("  " + currentPrivate.ToString().TrimEnd());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
