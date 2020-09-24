using System;


namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double coins = 0;
            string start = "";
            string product = "";

            while (start != "Start")
            {
                start = Console.ReadLine();
                if (start == "Start")
                {
                    break;
                }
                if (start == "0.1" || start == "0.2" || start == "0.5" || start == "1" || start == "2")
                {
                    coins += double.Parse(start);

                }
                else
                {
                    Console.WriteLine($"Cannot accept {start}");
                }
            }
            while (product != "End")
            {
                product = Console.ReadLine();
                if (product == "End")
                {
                    break;
                }
                if (product == "Nuts")
                {
                    if (coins - 2 >= 0)
                    {
                        coins -= 2;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (coins - 0.7 >= 0)
                    {
                        coins -= 0.7;
                        Console.WriteLine($"Purchased water");

                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (coins - 1.5 >= 0)
                    {
                        coins -= 1.5;
                        Console.WriteLine($"Purchased crisps");

                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (coins - 0.8 >= 0)
                    {
                        coins -= 0.8;
                        Console.WriteLine($"Purchased soda");

                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (coins - 1 >= 0)
                    {
                        coins -= 1;
                        Console.WriteLine($"Purchased coke");

                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {coins:f2}");
        }
    }
}
