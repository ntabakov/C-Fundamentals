using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<Repair> repairs;

        public Engineer(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<Repair>();
        }

        public IReadOnlyCollection<Repair> Repairs => this.repairs.AsReadOnly();

        Corps ISpecialisedSoldier.Corps => throw new NotImplementedException();

        public void AddRepair(Repair repairToAdd)
        {
            this.repairs.Add(repairToAdd);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine("Repairs:");

            foreach (var currentRepair in this.repairs)
            {
                sb.AppendLine("  " + currentRepair.ToString().TrimEnd());
            }

            return sb.ToString().TrimEnd();

        }
    }
}
