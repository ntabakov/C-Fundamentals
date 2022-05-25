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
            bool valid = true;
            if (CheckNumberOfCharacters(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                valid = false;
            }

            if( CheckIfContainsOnlyDigitsAndLetters(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                valid = false;
            }

            if (CheckIfItHasAtleastTwoDigits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
                valid = false;
            }

            if (valid)
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
                return false;
            }
        }

        static bool CheckIfContainsOnlyDigitsAndLetters(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!(Char.IsDigit(password[i]) || Char.IsLetter(password[i])))
                {
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
                if (Char.IsDigit(password[i]))
                {
                    count++;
                }
            }
            if (count < 2)
            {
                return false;
            }
            return true;
        }
    }
}
