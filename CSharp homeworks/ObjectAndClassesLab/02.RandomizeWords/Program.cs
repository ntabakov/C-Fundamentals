using System;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            StringRandomizer random = new StringRandomizer();
            random.Input = Console.ReadLine().Split();
            random.Randomize();
            random.PrintWords();

        }

        public class StringRandomizer
        {
            public string[] Input;

            public void Randomize()
            {
                Random rand = new Random();
                for (int i = 0; i < this.Input.Length; i++)
                {
                    int randomNumber = rand.Next(0, this.Input.Length);

                    string temp = this.Input[i];
                    this.Input[i] = this.Input[randomNumber];
                    this.Input[randomNumber] = temp;
                }
            }
            public void PrintWords()
            {
                Console.WriteLine(String.Join(Environment.NewLine , this.Input));
            }

        }
    }
}
