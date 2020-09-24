using System;

namespace Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double towel = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double umbrella = towel * 2 / 3;
            double flipFlops = umbrella * 0.75;

            double bag = (towel + flipFlops)*1 / 3 ;
            double sum =  towel + umbrella + flipFlops + bag;
            double sumDiscount = sum - sum * discount / 100;

            if (sumDiscount <= budget)
            {
                Console.WriteLine($"Annie's sum is {sumDiscount:f2} lv. She has {budget - sumDiscount:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {sumDiscount:f2} lv. She needs {sumDiscount - budget:f2} lv. more.");
            }
        }
    }
}
