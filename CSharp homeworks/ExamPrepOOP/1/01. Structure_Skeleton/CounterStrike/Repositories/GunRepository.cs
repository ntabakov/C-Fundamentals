using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;

namespace CounterStrike.Repositories
{
    public class GunRepository : IRepository<IGun>
    {

        private List<IGun> guns;
        public GunRepository()
        {
            guns = new List<IGun>();
        }



        public IReadOnlyCollection<IGun> Models => this.guns.AsReadOnly();


        public void Add(IGun model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunRepository);
            }

            guns.Add(model);
        }

        public bool Remove(IGun model)
        {
            if (guns.Contains(model))
            {
                guns.Remove(model);
                return true;
            }

            return false;
        }

        public IGun FindByName(string name)
        {
            return guns.FirstOrDefault(x => x.Name == name);
        }
    }
}
