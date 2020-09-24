using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            CheckIfPasswordIsValid(password);
        }

        static void CheckIfPasswordIsValid(string password)
        {
            CheckNumberOfCharacters(password);
            CheckIfContainsOnlyDigitsAndLetters(password);
            CheckIfItHasAtleastTwoDigits(password);

            if (CheckNumberOfCharacters(password) == true &&
                CheckIfContainsOnlyDigitsAndLetters(password) == true &&
                CheckIfItHasAtleastTwoDigits(password) == true)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckNumberOfCharacters(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
        }

        static bool CheckIfContainsOnlyDigitsAndLetters(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!((password[i] >= 48 && password[i] <= 57) || (password[i] >= 65 && password[i] <= 90) || (password[i] >= 97 && password[i] <= 122)))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }
            }
            return true;
        }

        static bool CheckIfItHasAtleastTwoDigits(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    count++;
                }
            }
            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            return true;
        }
    }
}
