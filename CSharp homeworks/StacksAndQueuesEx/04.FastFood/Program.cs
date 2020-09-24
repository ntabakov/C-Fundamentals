using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort totalQuantity = ushort.Parse(Console.ReadLine());

            ushort[] orders = Console.ReadLine().Split().Select(ushort.Parse).ToArray();
            ushort biggest = orders.Max();

            Queue<ushort> clientOrders = new Queue<ushort>(orders);

            while (clientOrders.Count > 0)
            {
                ushort currOrder = clientOrders.Peek();

                if (totalQuantity - currOrder >= 0)
                {
                    totalQuantity -= currOrder;
                    clientOrders.Dequeue();
                }
                else
                {
                    Console.WriteLine(biggest);
                    Console.WriteLine($"Orders left: " + String.Join(" ",clientOrders));
                    break;
                }
            }
            if (clientOrders.Count <= 0)
            {
                Console.WriteLine(biggest);
                Console.WriteLine("Orders complete");
            }
        }
    }
}
