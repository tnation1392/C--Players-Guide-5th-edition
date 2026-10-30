using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.NewFolder
{
    internal class watchtower
    {
        public static void Run()
        {
            //X value
            Console.WriteLine("X value?");
            string input = Console.ReadLine();
            int x = Convert.ToInt32(input);

            //Y value
            Console.WriteLine("Y value?");
            string input2 = Console.ReadLine();
            int y = Convert.ToInt32(input);

            if (x == 0)
            {
                if (y == 0)
                    Console.WriteLine("The enemy is here!");
                else if (y < 0)
                    Console.WriteLine("The enemy is south from here!");
                else if (y > 0)
                    Console.WriteLine("The enemy is north from here!");
            }

            else if (x < 0)
            {
                if (y == 0)
                    Console.WriteLine("The enemy is west from here!");
                else if (y < 0)
                    Console.WriteLine("The enemy is southwest from here!");
                else if (y > 0)
                    Console.WriteLine("The enemy is northwest from here!");
            }

            else if (x > 0)
            {
                if (y == 0)
                    Console.WriteLine("The enemy is east from here!");
                else if (y < 0)
                    Console.WriteLine("The enemy is southeast from here!");
                else if (y > 0)
                    Console.WriteLine("The enemy is northeast from here!");
            }
        }
    }
}

       