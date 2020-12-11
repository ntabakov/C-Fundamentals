using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common.Constants;
using OnlineShop.Factory;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Computers.Models;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private List<IComputer> computers;
        private List<IComponent> components;
        private List<IPeripheral> peripherals;

        private ComputerFactory computerFactory;
        private ComponentFactory componentFactory;
        private PeripheralFactory peripheralFactory;    
        public Controller()
        {
            computers = new List<IComputer>();
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();

            computerFactory = new ComputerFactory();
            componentFactory = new ComponentFactory();
            peripheralFactory = new PeripheralFactory();
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            if (computers.Any(x => x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComputerId);
            }
            IComputer comp = computerFactory.CreateComputer(computerType, id, manufacturer, model, price);
            computers.Add(comp);
            return String.Format(SuccessMessages.AddedComputer, id);
        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price,
            double overallPerformance, string connectionType)
        {
            CheckComputerExisting(computerId);
           
            if (this.peripherals.Any(x => x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingPeripheralId);
            }
            IPeripheral currPeripheral = peripheralFactory.CreatePeripheral(id, peripheralType, manufacturer, model,
                price, overallPerformance, connectionType);
            this.computers.First(x=>x.Id==computerId).AddPeripheral(currPeripheral);
            this.peripherals.Add(currPeripheral);
            return $"Peripheral {peripheralType} with id {id} added successfully in computer with id {computerId}.";

        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            CheckComputerExisting(computerId);
            this.computers.First(x => x.Id == computerId).RemovePeripheral(peripheralType);
            IPeripheral tempPeripheral = this.peripherals.First(x => x.GetType().Name == peripheralType);
            this.peripherals.Remove(tempPeripheral);
            return $"Successfully removed {peripheralType} with id {tempPeripheral.Id}.";


        }

        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price,
            double overallPerformance, int generation)
        {
            CheckComputerExisting(computerId);
            if (this.components.Any(x => x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
            }
            IComponent comp = componentFactory.CreateComponent(id, componentType, manufacturer, model, price,
                overallPerformance, generation);
            this.components.Add(comp);
            this.computers.First(x => x.Id == computerId).AddComponent(comp);
            return $"Component {componentType} with id {id} added successfully in computer with id {computerId}.";

        }

        public string RemoveComponent(string componentType, int computerId)
        {
            CheckComputerExisting(computerId);
            this.computers.First(x => x.Id == computerId).RemoveComponent(componentType);
            IComponent tempComponent = this.components.First(x => x.GetType().Name == componentType);
            this.components.Remove(tempComponent);
            return $"Successfully removed {componentType} with id {tempComponent.Id}.";
        }

        public string BuyComputer(int id)
        {
            CheckComputerExisting(id);
            IComputer comp = this.computers.First(x => x.Id == id);
            this.computers.Remove(comp);
            return comp.ToString();
        }

        public string BuyBest(decimal budget)
        {
            //TODO: If wrong test, remove ThenBy!!
            var orderedComputers = this.computers.OrderByDescending(x => x.OverallPerformance)/*.ThenByDescending(x=>x.Price)*/
                .Where(x => x.Price <= budget).ToList();
            if (orderedComputers.Count <= 0)
            {
                //TODO:  Outputs from Word and VS are different
                throw new ArgumentException($"Can't buy a computer with a budget of ${budget}.");
            }
            IComputer currComputer = orderedComputers[0];
            this.computers.Remove(currComputer);
            return currComputer.ToString();

        }

        public string GetComputerData(int id)
        {
            CheckComputerExisting(id);
            IComputer comp = this.computers.First(x => x.Id == id);

            return comp.ToString();
        }

        private void CheckComputerExisting(int computerId)
        {
            if (!(this.computers.Any(x => x.Id == computerId)))
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
            
        }
    }
}
