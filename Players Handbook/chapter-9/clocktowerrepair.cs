using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.NewFolder
{
    internal class clocktowerrepair
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number");
            
            //Convert to int
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);

            //Tick or tock conditions
            if (num % 2 == 0)
                {
                Console.WriteLine("Tick");
                }

            else
            {
                Console.WriteLine("Tock");
            }    

        }

    }
}