using System;
using System.Collections.Generic;
using System.Text;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Utilities.Messages;

namespace Bakery.Models.BakedFoods.Models
{
    public abstract class Food : IBakedFood
    {
        private string name;
        private int portion;
        private decimal price;

        protected Food(string name,int portion,decimal price)
        {
            this.Name = name;
            this.Portion = portion;
            this.Price = price;
        }

        //TODO: If wrong tests, remove setters!
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                //TODO: If wrong tests, add IsNullOrEmpty
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidName);
                }

                this.name = value;
            }
        }

        public int Portion
        {
            get
            {
                return this.portion;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPortion);
                }

                this.portion = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPrice);
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            //TODO: If Wrong output, change to this.property
            return $"{this.Name}: {this.Portion}g - {this.Price:f2}";
        }
    }
}
