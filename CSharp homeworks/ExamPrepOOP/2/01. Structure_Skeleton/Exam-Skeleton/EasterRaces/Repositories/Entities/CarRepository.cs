using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository : IRepository<ICar>
    {
        private List<ICar> models;

        public CarRepository()
        {
            models = new List<ICar>();
        }

        public ICar GetByName(string name)
        {
            return models.FirstOrDefault(x => x.Model == name);
        }

        public IReadOnlyCollection<ICar> GetAll()
        {
            return models.AsReadOnly();
        }

        public void Add(ICar model)
        {
            models.Add(model);
        }

        public bool Remove(ICar model)
        {
            if (models.Contains(model))
            {
                models.Remove(model);
                return true;
            }

            return false;
        }
    }
}
