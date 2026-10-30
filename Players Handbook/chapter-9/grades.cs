using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.NewFolder
{
    internal class grades
    {
        public static void Run()
        {
            Console.WriteLine("What is the grade on your test?");

            //Convert string to int grade
            string input = Console.ReadLine();
            int grade = Convert.ToInt32(input);

            //if else loop for returning grade letter
            if (grade == 100)
            {
                Console.WriteLine("A+!");
                Console.WriteLine("Perfect Score!");
            }

            else if (grade > 90 && grade < 100)
                {
                Console.WriteLine("A");
                }
            else if (grade > 80 && grade < 90)
            {
                Console.WriteLine("B");
            }
            else if (grade > 70 && grade < 80)
            {
                Console.WriteLine("C");
            }
            else if (grade > 60 && grade < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
            

        }

    }
}