using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.NewFolder
{
    internal class trianglefarm
    {
        public static void Run()
        {
            Console.WriteLine("What is the height of the triangle?");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the base of the triangle?");
            int floor = int.Parse(Console.ReadLine());

            int area = (height * floor) / 2;

            Console.WriteLine("The area of the triange is " + area + "!");
        }

    }
}
