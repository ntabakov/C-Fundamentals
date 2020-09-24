using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine(); //acer
            

            string password = "";
            int check = 1;

            for (int i = username.Length - 1; i >= 0 ; i--)
            {
                password += username[i];
            }

            string loginPass = Console.ReadLine();

            while (loginPass != password)
            {
                if(check == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                loginPass = Console.ReadLine();
                check++;
            }

            if (loginPass == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
