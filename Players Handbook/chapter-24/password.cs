using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.chapter_24
{
    internal class PasswordValidator
    {
        public bool IsValid(string password)
        {
            if (password.Length < 6 || password.Length > 12)
                return false;

            if (password.Contains('T') || password.Contains('&'))
                return false;

            return true;
        }
    }

    internal class Program
    {
        public static void Main()
        {
            PasswordValidator validator = new PasswordValidator();

            while (true)
            {
                Console.Write("Enter a password: ");
                string password = Console.ReadLine();

                if (validator.IsValid(password))
                    Console.WriteLine("Password is valid.");
                else
                    Console.WriteLine("Password is invalid.");
            }
        }
    }
}