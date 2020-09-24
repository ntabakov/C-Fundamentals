using System;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string command = Console.ReadLine();

            while (command!= "Decode")
            {
                var cList = command.Split('|');

                if (command.Contains("Move"))
                {
                    int numberOfLetters = int.Parse(cList[1]);
                    string cut = encryptedMessage.Substring(0,numberOfLetters);
                    encryptedMessage = encryptedMessage.Remove(0, numberOfLetters);
                    encryptedMessage = encryptedMessage.Insert(encryptedMessage.Length,cut);
                    //abvv
                }
                else if (command.Contains("Insert"))
                {
                    int index = int.Parse(cList[1]);
                    string value = cList[2];
                    if (index < 0)
                    {
                        index = 0;
                    }
                    encryptedMessage = encryptedMessage.Insert(index , value);
                }
                else
                {
                    string sub = cList[1];
                    string repl = cList[2];
                    encryptedMessage = encryptedMessage.Replace(sub, repl);
                }



                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
