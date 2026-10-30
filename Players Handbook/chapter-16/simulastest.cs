using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Players_Handbook.NewFolder
{
    internal class simulastest
    {
        enum status
        {
            unlocked,
            open,
            close,
            untouched
        }

        public static void Run()
        {
            status current = status.untouched;

            Console.WriteLine("The chest is locked. What do you want to do?");
            string change1 = Console.ReadLine();

            if (change1 == "unlock")
            {
                current = status.unlocked;
            }

            if (current == status.unlocked)
            {
                Console.WriteLine("The chest is unlocked. What do you want to do?");
                string change2 = Console.ReadLine();

                if (change2 == "open")
                {
                    current = status.open;
                }
            }

            if (current == status.open)
            {
                Console.WriteLine("The chest is open. What would you like to do?");
                string change3 = Console.ReadLine();

                if (change3 == "close")
                {
                    current = status.close;
                }

                Console.WriteLine($"Current state: {current}");



            }
        }
    }
}