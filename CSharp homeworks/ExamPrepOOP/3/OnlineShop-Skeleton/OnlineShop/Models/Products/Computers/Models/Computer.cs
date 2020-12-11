using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Models.Products.Computers.Models
{
    public abstract class Computer : Product, IComputer
    {
        private List<IComponent> components;
        private List<IPeripheral> peripherals;


        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();

        }

        public override double OverallPerformance
        {
            get
            {
                if (this.Components.Count <= 0)
                {
                    return base.OverallPerformance;
                }

                return base.OverallPerformance + this.Components.Average(x => x.OverallPerformance);

            }
        }

        public override decimal Price
        {
            get
            {
                //TODO: If wrong tests, add IF for checking if components and peripherals are empty!
                return base.Price + this.Components.Sum(x => x.Price) + this.Peripherals.Sum(x => x.Price);
            }
        }

        public IReadOnlyCollection<IComponent> Components
        {
            get
            {
                return this.components;
            }
        }

        public IReadOnlyCollection<IPeripheral> Peripherals
        {
            get
            {
                return this.peripherals;
            }
        }
        public void AddComponent(IComponent component)
        {
            if (components.Any(x => x.GetType().Name == component.GetType().Name))
            {
                //TODO: It is very possible this is not the correct ID !!!!
                throw new ArgumentException(String.Format(ExceptionMessages.ExistingComponent,component.GetType().Name,this.GetType().Name,this.Id));
            }

            this.components.Add(component);
        }

        public IComponent RemoveComponent(string componentType)
        {
            if (this.components.Count <= 0
                || !(this.components.Any(x => x.GetType().Name == componentType)))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.NotExistingComponent,componentType, this.GetType().Name, this.Id));
            }

            IComponent comp = this.components.FirstOrDefault(x => x.GetType().Name == componentType);
            this.components.Remove(comp);
            return comp;
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (peripherals.Any(x => x.GetType().Name == peripheral.GetType().Name))
            {
                //TODO: It is very possible this is not the correct ID !!!!
                throw new ArgumentException(String.Format(ExceptionMessages.ExistingPeripheral, peripheral.GetType().Name, this.GetType().Name, this.Id));
            }

            this.peripherals.Add(peripheral);
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (this.peripherals.Count <= 0
                || !(this.peripherals.Any(x => x.GetType().Name == peripheralType)))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.NotExistingPeripheral, peripheralType, this.GetType().Name, this.Id));
            }

            IPeripheral periph = this.peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);
            this.peripherals.Remove(periph);
            return periph;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            if (this.Components.Count > 0)
            {
                sb.AppendLine($" Components ({this.Components.Count}):");
                foreach (var component in this.Components)
                {
                    sb.AppendLine("  " + component.ToString());
                }
            }
            //else
            //{
            //    sb.AppendLine()
            //}
            
            //TODO: If wrongs tests, add :f2 into overallPerformance!
            if (this.Peripherals.Count > 0)
            {
                sb.AppendLine($" Peripherals ({this.Peripherals.Count}); Average Overall Performance ({this.Peripherals.Average(x => x.OverallPerformance):f2}):");
                foreach (var peripheral in Peripherals)
                {
                    sb.AppendLine("  " + peripheral.ToString());
                }
            }
            else
            {
                sb.AppendLine(" Peripherals (0); Average Overall Performance (0.00):");
            }
            


            return sb.ToString().TrimEnd();
        }
    }
}
