using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<Mission> missions;

        public Commando(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<Mission>();
        }

        public IReadOnlyCollection<Mission> Missions =>
            this.missions.AsReadOnly();

        Corps ISpecialisedSoldier.Corps => throw new NotImplementedException();

        public void AddMission(Mission missionToAdd)
        {
            this.missions.Add(missionToAdd);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine("Missions:");

            foreach (var currentMission in this.missions)
            {
                sb.AppendLine("  " + currentMission.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
