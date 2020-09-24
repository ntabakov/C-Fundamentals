using System;
using System.IO;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                var cList = command.Split(">>>");

                if (command.Contains("Contains"))
                {
                    string substring = cList[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command.Contains("Flip"))
                {
                    if (cList[1] == "Upper")
                    {
                        int startIndex = int.Parse(cList[2]);
                        int endIndex = int.Parse(cList[3]);
                        var cutText = activationKey.Substring(startIndex, endIndex - startIndex);
                        cutText = cutText.ToUpper();
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        activationKey = activationKey.Insert(startIndex, cutText);
                        Console.WriteLine(activationKey);
                    }
                    else
                    {
                        int startIndex = int.Parse(cList[2]);
                        int endIndex = int.Parse(cList[3]);
                        var cutText = activationKey.Substring(startIndex, endIndex - startIndex);
                        cutText = cutText.ToLower();
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        activationKey = activationKey.Insert(startIndex, cutText);
                        Console.WriteLine(activationKey);
                    }
                }
                else
                {
                    int startIndex = int.Parse(cList[1]);
                    int endIndex = int.Parse(cList[2]);
                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }






                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {activationKey}");


        }
    }
}
