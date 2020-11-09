using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree.Core
{
    public class Engine
    {
        private readonly List<Person> people;
        private readonly List<Product> products;


        public Engine()
        {
            people = new List<Person>();
            products = new List<Product>();
        }

        public void Run()
        {
            try
            {
                PeopleInput();

                ProductInput();
                string command = Console.ReadLine();
                while (command != "END")
                {
                    var cE = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string personName = cE[0];
                    string productName = cE[1];
                    command = Console.ReadLine();

                    Person person = this.people.FirstOrDefault(p => p.Name == personName);
                    Product product = this.products.FirstOrDefault(p => p.Name == productName);

                    if (person != null && product != null)
                    {
                        string result = person.BuyProduct(product);
                        Console.WriteLine(result);
                    }
                }


            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            if (this.people.Count > 0)
            {
                foreach (Person person in this.people)
                {
                    Console.WriteLine(person);
                }

            }

        }

        public void PeopleInput()
        {
            string[] peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (string personStr in peopleInput)
            {
                string[] personArg = personStr
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string personName = personArg[0];
                decimal personMoney = decimal.Parse(personArg[1]);

                Person person = new Person(personName, personMoney);

                this.people.Add(person);
            }
        }

        public void ProductInput()
        {
            string[] productInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (string productStr in productInput)
            {
                string[] productArg = productStr
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string productName = productArg[0];
                decimal productCost = decimal.Parse(productArg[1]);

                Product product = new Product(productName, productCost);

                this.products.Add(product);
            }
        }
    }
}
