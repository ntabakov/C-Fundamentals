using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.ParseState(state);
        }

        public string CodeName { get; private set; }

        public State State { get; private set; }

        State IMission.State => throw new NotImplementedException();

        private void ParseState(string stateAsString)
        {
            State state;

            bool parsed = Enum.TryParse<State>(stateAsString, out state);

            if (!parsed)
            {
                throw new ArgumentException("Invalid mission state!");
            }

            this.State = state;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
