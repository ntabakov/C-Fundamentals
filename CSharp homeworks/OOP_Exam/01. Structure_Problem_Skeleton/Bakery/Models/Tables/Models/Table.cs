using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.BakedFoods.Models;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;

namespace Bakery.Models.Tables.Models
{
    public abstract class Table : ITable
    {
        private int capacity;
        private int numberOfPeople;

        private ICollection<IBakedFood> FoodOrders;
        private ICollection<IDrink> DrinkOrders;

        protected Table(int tableNumber,int capacity,decimal pricePerPerson)
        {
            this.TableNumber = tableNumber;
            this.Capacity = capacity;
            this.PricePerPerson = pricePerPerson;

            FoodOrders = new List<IBakedFood>();
            DrinkOrders = new List<IDrink>();
        }

        public int TableNumber { get; }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                //TODO: If wrong tests, Change to <= 0 !
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTableCapacity);
                }

                this.capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get
            {
                return this.numberOfPeople;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidNumberOfPeople);
                }

                this.numberOfPeople = value;
            }
        }
        public decimal PricePerPerson { get; }
        public bool IsReserved { get; private set; } = false;

        public decimal Price
        {
            get
            {
                return this.PricePerPerson * NumberOfPeople;
            }
        }
        public void Reserve(int numberOfPeople)
        {
            this.NumberOfPeople = numberOfPeople;

            if (this.Capacity >= NumberOfPeople)
            {
                this.IsReserved = true;
            }
            else
            {
                this.IsReserved = false;
            }
        }

        public void OrderFood(IBakedFood food)
        {
            if (food != null)
            {
                this.FoodOrders.Add(food);

            }
        }

        public void OrderDrink(IDrink drink)
        {
            if (drink != null)
            {
                this.DrinkOrders.Add(drink);

            }
        }

        public decimal GetBill()
        {
            decimal bill = 0m; 
            bill += DrinkOrders.Sum(drinks => drinks.Price);
            bill += FoodOrders.Sum(foods => foods.Price);

            //return DrinkOrders.Sum(drinks => drinks.Price)
            //       + FoodOrders.Sum(foods => foods.Price);
            return bill + this.Price;
        }

        public void Clear()
        {
            this.FoodOrders.Clear();
            this.DrinkOrders.Clear();
            this.IsReserved = false;
            this.numberOfPeople = 0;
        }

        public string GetFreeTableInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Table: {this.TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Capacity: {this.Capacity}");
            sb.AppendLine($"Price per Person: {this.PricePerPerson}");

            return sb.ToString().TrimEnd();
        }
    }
}
