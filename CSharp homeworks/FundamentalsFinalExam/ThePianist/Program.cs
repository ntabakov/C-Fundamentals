using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                var cList = Console.ReadLine().Split("|");
                string piece = cList[0];
                string composer = cList[1];
                string key = cList[2];
                pieces.Add(piece, new List<string> { composer, key });
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                var cList = command.Split("|");
                string piece = cList[1];
                if (command.Contains("Add"))
                {
                    if (pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        string comp = cList[2];
                        string key = cList[3];
                        pieces.Add(piece, new List<string> { comp, key });
                        Console.WriteLine($"{piece} by {comp} in {key} added to the collection!");
                    }
                }
                else if (command.Contains("Remove"))
                {
                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else
                {
                    if (pieces.ContainsKey(piece))
                    {
                        string newKey = cList[2];
                        pieces[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }





                command = Console.ReadLine();
            }
            foreach (var item in pieces.OrderBy(x=>x.Key).ThenBy(x=>x.Value[0]))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
