using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Players_Handbook.NewFolder
{
    internal class prototype
    {
        public static void Run()
        {
            Console.WriteLine("User 1, enter a number between 1 and 100.");
            int user1Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("User 2, guess the number.");
            int user2Guess = Convert.ToInt32(Console.ReadLine());

            while (user1Number != user2Guess)
            {
                if (user2Guess < user1Number)
                {
                    Console.WriteLine("Too low, try again.");
                }
                else
                {
                    Console.WriteLine("Too high, try again.");
                }

                user2Guess = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Congratulations! You guessed the number!");
        }


            }

    }

