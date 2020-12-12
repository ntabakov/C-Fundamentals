using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bakery.Core.Contracts;
using Bakery.Factories;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;

namespace Bakery.Core
{
    public class Controller : IController
    {
        private ICollection<IBakedFood> bakedFoods;
        private ICollection<IDrink> drinks;
        private ICollection<ITable> tables;

        private FoodFactory foodFactory;
        private DrinkFactory drinkFactory;
        private TableFactory tableFactory;

        private decimal totalIncome;
        public Controller()
        {
            this.bakedFoods = new List<IBakedFood>();
            this.drinks = new List<IDrink>();
            this.tables = new List<ITable>();

            foodFactory = new FoodFactory();
            drinkFactory = new DrinkFactory();
            tableFactory = new TableFactory();
        }

        public string AddFood(string type, string name, decimal price)
        {
            IBakedFood food = foodFactory.CreateFood(type, name, price);

            bakedFoods.Add(food);
            return $"Added {food.Name} ({food.GetType().Name}) to the menu";

        }

        public string AddDrink(string type, string name, int portion, string brand)
        {
            IDrink drink = drinkFactory.CreateDrink(type, name, portion, brand);

            drinks.Add(drink);
            return $"Added {drink.Name} ({drink.Brand}) to the drink menu";

        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            ITable table = tableFactory.CreateTable(type, tableNumber, capacity);

            tables.Add(table);
            return $"Added table number {table.TableNumber} in the bakery";

        }

        public string ReserveTable(int numberOfPeople)
        {
            //if (tables.Count > 0)
            //{
            //    foreach (var table in tables)
            //    {
            //        if (table.IsReserved == false
            //            && table.Capacity >= numberOfPeople)
            //        {
            //            table.Reserve(numberOfPeople);
            //            return $"Table {table.TableNumber} has been reserved for {numberOfPeople} people";
            //        }
            //    }
            //}
            ITable table = tables.FirstOrDefault(x => x.IsReserved == false && x.Capacity >= numberOfPeople);
            table?.Reserve(numberOfPeople);
            if (table != null)
            {
                table.Reserve(numberOfPeople);
                return $"Table {table.TableNumber} has been reserved for {numberOfPeople} people";
            }
            return $"No available table for {numberOfPeople} people";
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            ITable table = tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            IBakedFood food = bakedFoods.FirstOrDefault(x => x.Name == foodName);
            StringBuilder sb = new StringBuilder();
            if (table != null && food != null)
            {
                table.OrderFood(food);
                sb.AppendLine($"Table {tableNumber} ordered {foodName}");
                
            }

            if (table == null)
            {
                sb.AppendLine($"Could not find table {tableNumber}");
                
            }

            if (food == null)
            {
                sb.AppendLine($"No {foodName} in the menu");
            }

            return sb.ToString().TrimEnd();
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            ITable table = tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            IDrink drink = drinks.FirstOrDefault(x => x.Name == drinkName && x.Brand == drinkBrand);
            StringBuilder sb = new StringBuilder();

            if (table != null && drink != null)
            {
                table.OrderDrink(drink);
                sb.AppendLine($"Table {tableNumber} ordered {drinkName} {drinkBrand}");
            }

            if (table == null)
            {
                sb.AppendLine($"Could not find table {tableNumber}");
            }

            if (drink == null)
            {
                sb.AppendLine($"There is no {drinkName} {drinkBrand} available");
            }

            return sb.ToString().TrimEnd();
        }

        public string LeaveTable(int tableNumber)
        {
            ITable table = tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            if (table == null)
            {
                return null;
            }

            decimal bill = table.GetBill();
            this.totalIncome += bill;
            table.Clear();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Table: {tableNumber}");
            sb.AppendLine($"Bill: {bill:f2}");


            return sb.ToString().TrimEnd();
        }

        public string GetFreeTablesInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var table in tables)
            {
                if (table.IsReserved == false)
                {
                    sb.AppendLine(table.GetFreeTableInfo());
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string GetTotalIncome()
        {
            foreach (var table in tables)
            {
                totalIncome += table.GetBill();
            }

            return $"Total income: {totalIncome:f2}lv";
        }
    }
}
