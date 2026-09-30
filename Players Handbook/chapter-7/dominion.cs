using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.NewFolder
{
    internal class dominion
    {
        public static void Run()
        {
            Console.WriteLine("How many estates do you own?");
            int estate = int.Parse(Console.ReadLine());

            Console.WriteLine("How many duchies do you own?");
            int duchy = int.Parse(Console.ReadLine());
            int dpoints = duchy * 3;

            Console.WriteLine("How many provinces do you own?");
            int province = int.Parse(Console.ReadLine());
            int ppoints = province * 6;

            Console.WriteLine($"You get {estate} points for estates, {dpoints} points for duchies, and {ppoints} " +
                $"points for your provinces for a total of {estate + dpoints + ppoints} points!");
         
        }

    }
}
