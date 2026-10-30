using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.NewFolder
{
    internal class sistersduckbear
    {
        public static void Run()
        {
            Console.WriteLine("How many chocolate eggs are there?");
            int eggs = int.Parse(Console.ReadLine());

            int sisters = eggs / 4;
            int duckbear = eggs % 4;

            Console.WriteLine($"Each sister gets {sisters} eggs and the duckbear gets {duckbear} eggs.");
        }

    }
}
