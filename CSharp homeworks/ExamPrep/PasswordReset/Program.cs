using System;
using System.Text;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input = Console.ReadLine();
            StringBuilder newPassword = new StringBuilder();
            while (input != "Done")
            {
                if (input.Contains("TakeOdd"))
                {
                    string temp = "";
                    for (int i = 1; i < password.Length; i+=2)
                    {
                        temp += password[i];
                    }
                    password = temp;
                    Console.WriteLine(password);
                }
                else if (input.Contains("Cut"))
                {
                    var tempArr = input.Split();
                    int start = int.Parse(tempArr[1]);
                    int end = int.Parse(tempArr[2]);

                    password = password.Remove(start,end);
                    Console.WriteLine(password);
                }
                else
                {
                    var tempArr = input.Split();

                    if (password.Contains(tempArr[1]))
                    {
                        password = password.Replace(tempArr[1], tempArr[2]);
                        Console.WriteLine(password) ;
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
