using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Players_Handbook.NewFolder
{
    internal class pirate
    {
        public static void Run()
        {
            Console.WriteLine("What is your choice captain?");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Ye rest and recover your health");
                    break;
                case 2:
                    Console.WriteLine("Raiding the port");
                    break;
                case 3:
                    Console.WriteLine("The wind is at your back");
                    break;
                case 4:
                    Console.WriteLine("'Tis but a baby kraken....");
                    break;
            }


        }

    }
}