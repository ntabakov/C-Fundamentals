using PizzaCalories.Models;
using System;

namespace PizzaCalories
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var inputArr = input.Split();
           

            try
            {
                Pizza pizza = new Pizza(inputArr[1]);

                inputArr = Console.ReadLine().Split();

                string flour = inputArr[1];
                string bakingT = inputArr[2];
                double grams = double.Parse(inputArr[3]);
                pizza.Dough = new Dough(flour, bakingT, grams);

                input = Console.ReadLine();

                while (input != "END")
                {
                    var cE = input.Split();
                    string type = cE[1];
                    double weight = double.Parse(cE[2]);
                    pizza.AddTopping(new Toppings(type, weight));





                    //var cE = input.Split();
                    //if (cE[0] == "Topping")
                    //{
                    //    string toppingType = cE[1];
                    //    double grams = double.Parse(cE[2]);
                    //    Toppings toppings = new Toppings(toppingType, grams);
                    //    toppings.PrintCalories();
                    //}
                    //else if (cE[0] == "Dough")
                    //{
                    //    string flourType = cE[1];
                    //    string bakingTech = cE[2];
                    //    double weight = double.Parse(cE[3]);
                    //    Dough dough = new Dough(flourType, bakingTech, weight);
                    //    dough.CalculateCalories();
                    //}
                    input = Console.ReadLine();
                }
                Console.WriteLine(pizza);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
