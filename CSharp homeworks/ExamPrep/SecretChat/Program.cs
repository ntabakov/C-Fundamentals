using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealMessage = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                var operations = command.Split(":|:");
                if (command.Contains("InsertSpace"))
                {
                    int index = int.Parse(operations[1]);
                    concealMessage = concealMessage.Insert(index, " ");
                    Console.WriteLine(concealMessage);

                }
                else if (command.Contains("Reverse"))
                {
                    string substring = operations[1];
                    if (concealMessage.Contains(substring))
                    {
                        int indexOfSub = concealMessage.IndexOf(substring);
                        string cut = concealMessage.Substring(indexOfSub, substring.Length);
                        concealMessage = concealMessage.Remove(indexOfSub, substring.Length);
                        cut = Reverse(cut);
                        concealMessage = concealMessage.Insert(concealMessage.Length, cut);
                        Console.WriteLine(concealMessage);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else
                {
                    string substring = operations[1];
                    string replacement = operations[2];

                    concealMessage = concealMessage.Replace(substring, replacement);
                    Console.WriteLine(concealMessage);
                }

                command = Console.ReadLine();

            }
            Console.WriteLine($"You have a new text message: {concealMessage}");
        }


        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}
