using System;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            AdMessage mess = new AdMessage();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mess.GetMessage());
            }
        }

        class AdMessage
        {
            string[] Phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            public string GetMessage()
            {
                Random rand = new Random();
                string currP = Phrases[rand.Next(0, Phrases.Length)];
                string currE = Events[rand.Next(0, Events.Length)];
                string currA = Authors[rand.Next(0, Authors.Length)];
                string currC = Cities[rand.Next(0, Cities.Length)];

                return $"{currP} {currE} {currA} - {currC}.";
            }
        }
    }
}
