using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.NewFolder
{
    internal class defenseconsolas
    {
        public static void Run()
        {
            //Target row
            Console.WriteLine("Target Row?");
            int row = int.Parse(Console.ReadLine());

            //Target column
            Console.WriteLine("Target Column?");
            int column = int.Parse(Console.ReadLine());

            //Print resulting 4 positions
            Console.WriteLine("Deploy to: ");
            Console.WriteLine($"({row}, {column - 1})");
            Console.WriteLine($"({row - 1}, {column})");
            Console.WriteLine($"({row}, {column + 1})");
            Console.WriteLine($"({row + 1}, {column})");
        }

    }
}