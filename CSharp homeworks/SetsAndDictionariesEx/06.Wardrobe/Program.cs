using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();


            for (int i = 0; i < n; i++)
            {
                var inputOne = Console.ReadLine().Split(" -> ", StringSplitOptions.
                    RemoveEmptyEntries).ToArray();
                string color = inputOne[0];
                string[] clothes = inputOne[1].Split(",", StringSplitOptions.
                    RemoveEmptyEntries).ToArray();

                //if (!wardrobe.ContainsKey(color))
                //{
                //    wardrobe.Add(color, new Dictionary<string, int>());
                //}
                //for (int k = 0; k < clothes.Length; k++)
                //{
                //    if (!wardrobe[color].ContainsKey(clothes[k]))
                //    {
                //        wardrobe[color].Add(clothes[k], 0);
                //    }
                //    wardrobe[color][clothes[k]]++;
                //}

                if (wardrobe.ContainsKey(color))
                {
                    for (int k = 0; k < clothes.Length; k++)
                    {
                        if (!wardrobe[color].ContainsKey(clothes[k]))
                        {
                            wardrobe[color].Add(clothes[k], 0);
                        }
                        wardrobe[color][clothes[k]]++;
                    }
                }
                else
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                    for (int k = 0; k < clothes.Length; k++)
                    {
                        if (!wardrobe[color].ContainsKey(clothes[k]))
                        {

                            wardrobe[color].Add(clothes[k], 0);
                        }
                        wardrobe[color][clothes[k]]++;
                    }
                }
            }

            var askedCloth = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var sorted = wardrobe.OrderBy(x => x.Key);
            foreach (var item in wardrobe)
            {
                Console.WriteLine(item.Key + " clothes:");

                foreach (var cloth in item.Value)
                {
                    Console.Write($"* {cloth.Key} - {cloth.Value}");
                    if (item.Key == askedCloth[0] && cloth.Key == askedCloth[1])
                    {
                        Console.Write($" (found!)");

                    }
                    Console.WriteLine();


                }


            }

        }
    }
}
