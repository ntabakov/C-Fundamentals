using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            bag = new List<Product>();
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(String.IsNullOrEmpty(value)|| String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public List<Product> Bag
        {
            get { return this.bag; }
            set { this.bag = value; }

        }

        public string BuyProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                throw new ArgumentException($"{this.Name} can't afford {product.Name}");
            }

            this.Money -= product.Cost;
            this.bag.Add(product);
            return $"{this.Name} bought {product.Name}";
        }

        public override string ToString()
        {
            string productsOutput = this.bag.Count > 0 ? String.Join(", ", this.bag) : "Nothing bought";
            return $"{this.Name} - {productsOutput}";
        }
    }
}
