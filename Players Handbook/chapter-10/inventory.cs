using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Players_Handbook.NewFolder
{
    internal class inventory
    {
        public static void Run()
        {
            //List the shop's inventory
            Console.WriteLine("Here is the store's inventory: ");
            Console.WriteLine("1 - Rope ");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food");

            Console.WriteLine("What number do you want to see the price of?");
            int choice = Convert.ToInt32(Console.ReadLine());
            string response;

            response = choice switch
            {
                1 => "Rope is 10 gold.",
                2 => "Torches are 15 gold each.",
                3 => "Climbing Equipment is 25 gold.",
                4 => "Clean Water is 1 gold.",
                5 => "A Machete is 20 gold.",
                6 => "A Canoe is 200 gold.",
                7 => "Food is 1 gold."
            };

            Console.WriteLine(response);


        }

    }
}